using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace code_ko_keo_tha
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();

            this.Load += OrderForm_Load;

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;

            dgvOrders.CellClick += dgvOrders_CellClick;
        }

        // ==========================
        // FORM LOAD
        // ==========================
        private void OrderForm_Load(
            object sender,
            EventArgs e)
        {
            LoadCustomers();
            LoadEmployees();
            LoadOrders();

            cboCustomer.SelectedIndex = -1;
            cboEmployee.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;
        }

        // ==========================
        // LOAD CUSTOMERS
        // ==========================
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
                            C_Name
                        FROM Customer
                        ORDER BY C_Name";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, con);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    cboCustomer.DataSource = dt;

                    cboCustomer.DisplayMember =
                        "C_Name";

                    cboCustomer.ValueMember =
                        "Customer_ID";

                    cboCustomer.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cannot load customers.\n" +
                    ex.Message);
            }
        }

        // ==========================
        // LOAD EMPLOYEES
        // ==========================
        private void LoadEmployees()
        {
            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        SELECT
                            Employee_ID,
                            E_Name
                        FROM Employee
                        ORDER BY E_Name";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, con);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    cboEmployee.DataSource = dt;

                    cboEmployee.DisplayMember =
                        "E_Name";

                    cboEmployee.ValueMember =
                        "Employee_ID";

                    cboEmployee.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cannot load employees.\n" +
                    ex.Message);
            }
        }

        // ==========================
        // LOAD ORDERS
        // ==========================
        private void LoadOrders()
        {
            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        SELECT
                            o.Order_ID,
                            o.Customer_ID,
                            c.C_Name AS Customer_Name,
                            o.Employee_ID,
                            e.E_Name AS Employee_Name,
                            o.Order_Date,
                            o.Total_Amount,
                            o.Order_Status
                        FROM Sale_Order o
                        INNER JOIN Customer c
                            ON o.Customer_ID = c.Customer_ID
                        INNER JOIN Employee e
                            ON o.Employee_ID = e.Employee_ID
                        ORDER BY o.Order_ID";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, con);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dgvOrders.DataSource = dt;

                    // Hide IDs because names are easier to read
                    if (dgvOrders.Columns["Customer_ID"] != null)
                    {
                        dgvOrders.Columns["Customer_ID"].Visible = false;
                    }

                    if (dgvOrders.Columns["Employee_ID"] != null)
                    {
                        dgvOrders.Columns["Employee_ID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database error:\n" +
                    ex.Message);
            }
        }

        // ==========================
        // ADD
        // ==========================
        private void btnAdd_Click(
            object sender,
            EventArgs e)
        {
            int orderID;
            decimal totalAmount;

            if (!int.TryParse(
                txtOrderID.Text.Trim(),
                out orderID))
            {
                MessageBox.Show(
                    "Order ID must be a number.");

                txtOrderID.Focus();

                return;
            }

            if (cboCustomer.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a customer.");

                return;
            }

            if (cboEmployee.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select an employee.");

                return;
            }

            if (!decimal.TryParse(
                txtTotalAmount.Text.Trim(),
                out totalAmount))
            {
                MessageBox.Show(
                    "Total Amount must be a number.");

                return;
            }

            if (cboStatus.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select Order Status.");

                return;
            }

            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        INSERT INTO Sale_Order
                        (
                            Order_ID,
                            Customer_ID,
                            Employee_ID,
                            Order_Date,
                            Total_Amount,
                            Order_Status
                        )
                        VALUES
                        (
                            @Order_ID,
                            @Customer_ID,
                            @Employee_ID,
                            @Order_Date,
                            @Total_Amount,
                            @Order_Status
                        )";

                    SqlCommand cmd =
                        new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue(
                        "@Order_ID",
                        orderID);

                    cmd.Parameters.AddWithValue(
                        "@Customer_ID",
                        cboCustomer.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@Employee_ID",
                        cboEmployee.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@Order_Date",
                        dtpOrderDate.Value.Date);

                    cmd.Parameters.AddWithValue(
                        "@Total_Amount",
                        totalAmount);

                    cmd.Parameters.AddWithValue(
                        "@Order_Status",
                        cboStatus.Text);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Order added successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadOrders();

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cannot add order.\n\n" +
                    ex.Message);
            }
        }

        // ==========================
        // UPDATE
        // ==========================
        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            int orderID;
            decimal totalAmount;

            if (!int.TryParse(
                txtOrderID.Text.Trim(),
                out orderID))
            {
                MessageBox.Show(
                    "Please select an order.");

                return;
            }

            if (cboCustomer.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a customer.");

                return;
            }

            if (cboEmployee.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select an employee.");

                return;
            }

            if (!decimal.TryParse(
                txtTotalAmount.Text.Trim(),
                out totalAmount))
            {
                MessageBox.Show(
                    "Total Amount must be a number.");

                return;
            }

            if (cboStatus.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select Order Status.");

                return;
            }

            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        UPDATE Sale_Order
                        SET
                            Customer_ID = @Customer_ID,
                            Employee_ID = @Employee_ID,
                            Order_Date = @Order_Date,
                            Total_Amount = @Total_Amount,
                            Order_Status = @Order_Status
                        WHERE Order_ID = @Order_ID";

                    SqlCommand cmd =
                        new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue(
                        "@Order_ID",
                        orderID);

                    cmd.Parameters.AddWithValue(
                        "@Customer_ID",
                        cboCustomer.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@Employee_ID",
                        cboEmployee.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@Order_Date",
                        dtpOrderDate.Value.Date);

                    cmd.Parameters.AddWithValue(
                        "@Total_Amount",
                        totalAmount);

                    cmd.Parameters.AddWithValue(
                        "@Order_Status",
                        cboStatus.Text);

                    con.Open();

                    int result =
                        cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show(
                            "Order updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show(
                            "Order not found.");
                    }
                }

                LoadOrders();

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cannot update order.\n\n" +
                    ex.Message);
            }
        }

        // ==========================
        // DELETE
        // ==========================
        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            int orderID;

            if (!int.TryParse(
                txtOrderID.Text.Trim(),
                out orderID))
            {
                MessageBox.Show(
                    "Please select an order.");

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Do you want to delete this order?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        DELETE FROM Sale_Order
                        WHERE Order_ID = @Order_ID";

                    SqlCommand cmd =
                        new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue(
                        "@Order_ID",
                        orderID);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Order deleted successfully.");

                LoadOrders();

                ClearFields();
            }
            catch (SqlException)
            {
                MessageBox.Show(
                    "Cannot delete this order because it " +
                    "already has Order Detail or Payment data.",
                    "Delete Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // ==========================
        // CLICK ROW
        // ==========================
        private void dgvOrders_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dgvOrders.Rows[e.RowIndex];

            txtOrderID.Text =
                row.Cells["Order_ID"]
                    .Value.ToString();

            cboCustomer.SelectedValue =
                row.Cells["Customer_ID"].Value;

            cboEmployee.SelectedValue =
                row.Cells["Employee_ID"].Value;

            if (row.Cells["Order_Date"].Value != null)
            {
                dtpOrderDate.Value =
                    Convert.ToDateTime(
                        row.Cells["Order_Date"].Value);
            }

            txtTotalAmount.Text =
                row.Cells["Total_Amount"]
                    .Value.ToString();

            cboStatus.Text =
                row.Cells["Order_Status"]
                    .Value.ToString();

            txtOrderID.ReadOnly = true;
        }

        // ==========================
        // CLEAR
        // ==========================
        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtOrderID.Clear();

            cboCustomer.SelectedIndex = -1;

            cboEmployee.SelectedIndex = -1;

            dtpOrderDate.Value =
                DateTime.Today;

            txtTotalAmount.Clear();

            cboStatus.SelectedIndex = -1;

            txtOrderID.ReadOnly = false;

            txtOrderID.Focus();
        }
    }
}