using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace code_ko_keo_tha
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();

            this.Load += CustomerForm_Load;

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            btnSearch.Click += btnSearch_Click;

            dgvCustomers.CellClick += dgvCustomers_CellClick;
        }

        private void CustomerForm_Load(
            object sender,
            EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        SELECT
                            Customer_ID,
                            Customer_Code,
                            C_Name,
                            C_Email,
                            C_Number,
                            C_Address
                        FROM Customer
                        ORDER BY Customer_ID";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, con);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvCustomers.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database error:\n" +
                    ex.Message);
            }
        }

        // ADD
        private void btnAdd_Click(
            object sender,
            EventArgs e)
        {
            int customerID;

            if (!int.TryParse(
                txtCustomerID.Text.Trim(),
                out customerID))
            {
                MessageBox.Show(
                    "Customer ID must be a number.");

                return;
            }

            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Customer Name is required.");

                return;
            }

            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        INSERT INTO Customer
                        (
                            Customer_ID,
                            Customer_Code,
                            C_Name,
                            C_Email,
                            C_Number,
                            C_Address
                        )
                        VALUES
                        (
                            @ID,
                            @Code,
                            @Name,
                            @Email,
                            @Phone,
                            @Address
                        )";

                    SqlCommand cmd =
                        new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue(
                        "@ID", customerID);

                    cmd.Parameters.AddWithValue(
                        "@Code",
                        txtCustomerCode.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Name",
                        txtName.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Email",
                        txtEmail.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Phone",
                        txtPhone.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Address",
                        txtAddress.Text.Trim());

                    con.Open();

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Customer added successfully.");

                LoadCustomers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cannot add customer.\n\n" +
                    ex.Message);
            }
        }

        // UPDATE
        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            int customerID;

            if (!int.TryParse(
                txtCustomerID.Text.Trim(),
                out customerID))
            {
                MessageBox.Show(
                    "Please select a customer.");

                return;
            }

            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Customer Name is required.");

                return;
            }

            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        UPDATE Customer
                        SET
                            Customer_Code = @Code,
                            C_Name = @Name,
                            C_Email = @Email,
                            C_Number = @Phone,
                            C_Address = @Address
                        WHERE Customer_ID = @ID";

                    SqlCommand cmd =
                        new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue(
                        "@ID", customerID);

                    cmd.Parameters.AddWithValue(
                        "@Code",
                        txtCustomerCode.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Name",
                        txtName.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Email",
                        txtEmail.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Phone",
                        txtPhone.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Address",
                        txtAddress.Text.Trim());

                    con.Open();

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Customer updated successfully.");

                LoadCustomers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // DELETE
        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            int customerID;

            if (!int.TryParse(
                txtCustomerID.Text,
                out customerID))
            {
                MessageBox.Show(
                    "Please select a customer.");

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Do you want to delete this customer?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    SqlCommand cmd =
                        new SqlCommand(
                            @"DELETE FROM Customer
                              WHERE Customer_ID = @ID",
                            con);

                    cmd.Parameters.AddWithValue(
                        "@ID", customerID);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Customer deleted successfully.");

                LoadCustomers();
                ClearFields();
            }
            catch (SqlException)
            {
                MessageBox.Show(
                    "Cannot delete this customer because " +
                    "the customer already has an order.",
                    "Delete Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // SEARCH
        private void btnSearch_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        SELECT
                            Customer_ID,
                            Customer_Code,
                            C_Name,
                            C_Email,
                            C_Number,
                            C_Address
                        FROM Customer
                        WHERE
                            Customer_Code LIKE @Search
                            OR C_Name LIKE @Search
                            OR C_Email LIKE @Search
                            OR C_Number LIKE @Search
                            OR C_Address LIKE @Search
                        ORDER BY Customer_ID";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, con);

                    da.SelectCommand.Parameters.AddWithValue(
                        "@Search",
                        "%" +
                        txtSearch.Text.Trim() +
                        "%");

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvCustomers.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // CLICK ROW
        private void dgvCustomers_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvCustomers.Rows[e.RowIndex];

            txtCustomerID.Text =
                row.Cells["Customer_ID"]
                   .Value.ToString();

            txtCustomerCode.Text =
                row.Cells["Customer_Code"]
                   .Value.ToString();

            txtName.Text =
                row.Cells["C_Name"]
                   .Value.ToString();

            txtEmail.Text =
                row.Cells["C_Email"]
                   .Value.ToString();

            txtPhone.Text =
                row.Cells["C_Number"]
                   .Value.ToString();

            txtAddress.Text =
                row.Cells["C_Address"]
                   .Value.ToString();

            txtCustomerID.ReadOnly = true;
        }

        // CLEAR
        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            ClearFields();

            txtSearch.Clear();

            LoadCustomers();
        }

        private void ClearFields()
        {
            txtCustomerID.Clear();
            txtCustomerCode.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();

            txtCustomerID.ReadOnly = false;

            txtCustomerID.Focus();
        }
    }
}