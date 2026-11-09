using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace code_ko_keo_tha
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();

            this.Load += EmployeeForm_Load;

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            btnSearch.Click += btnSearch_Click;

            dgvEmployees.CellClick += dgvEmployees_CellClick;
        }

        private void EmployeeForm_Load(
            object sender,
            EventArgs e)
        {
            LoadEmployees();
        }

        // LOAD EMPLOYEES
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
                            Employee_Code,
                            E_Name,
                            E_Email,
                            E_Phone,
                            Position,
                            Salary
                        FROM Employee
                        ORDER BY Employee_ID";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, con);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvEmployees.DataSource = dt;
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
            int employeeID;
            decimal salary;

            if (!int.TryParse(
                txtEmployeeID.Text.Trim(),
                out employeeID))
            {
                MessageBox.Show(
                    "Employee ID must be a number.");

                return;
            }

            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Employee Name is required.");

                return;
            }

            if (cboPosition.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a Position.");

                return;
            }

            if (!decimal.TryParse(
                txtSalary.Text.Trim(),
                out salary))
            {
                MessageBox.Show(
                    "Salary must be a number.");

                return;
            }

            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        INSERT INTO Employee
                        (
                            Employee_ID,
                            Employee_Code,
                            E_Name,
                            E_Email,
                            E_Phone,
                            Position,
                            Salary
                        )
                        VALUES
                        (
                            @ID,
                            @Code,
                            @Name,
                            @Email,
                            @Phone,
                            @Position,
                            @Salary
                        )";

                    SqlCommand cmd =
                        new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue(
                        "@ID",
                        employeeID);

                    cmd.Parameters.AddWithValue(
                        "@Code",
                        txtEmployeeCode.Text.Trim());

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
                        "@Position",
                        cboPosition.Text);

                    cmd.Parameters.AddWithValue(
                        "@Salary",
                        salary);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Employee added successfully.");

                LoadEmployees();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cannot add employee.\n\n" +
                    ex.Message);
            }
        }

        // UPDATE
        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            int employeeID;
            decimal salary;

            if (!int.TryParse(
                txtEmployeeID.Text.Trim(),
                out employeeID))
            {
                MessageBox.Show(
                    "Please select an employee.");

                return;
            }

            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Employee Name is required.");

                return;
            }

            if (cboPosition.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a Position.");

                return;
            }

            if (!decimal.TryParse(
                txtSalary.Text.Trim(),
                out salary))
            {
                MessageBox.Show(
                    "Salary must be a number.");

                return;
            }

            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        UPDATE Employee
                        SET
                            Employee_Code = @Code,
                            E_Name = @Name,
                            E_Email = @Email,
                            E_Phone = @Phone,
                            Position = @Position,
                            Salary = @Salary
                        WHERE Employee_ID = @ID";

                    SqlCommand cmd =
                        new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue(
                        "@ID",
                        employeeID);

                    cmd.Parameters.AddWithValue(
                        "@Code",
                        txtEmployeeCode.Text.Trim());

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
                        "@Position",
                        cboPosition.Text);

                    cmd.Parameters.AddWithValue(
                        "@Salary",
                        salary);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Employee updated successfully.");

                LoadEmployees();
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
            int employeeID;

            if (!int.TryParse(
                txtEmployeeID.Text.Trim(),
                out employeeID))
            {
                MessageBox.Show(
                    "Please select an employee.");

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Do you want to delete this employee?",
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
                    string sql = @"
                        DELETE FROM Employee
                        WHERE Employee_ID = @ID";

                    SqlCommand cmd =
                        new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue(
                        "@ID",
                        employeeID);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Employee deleted successfully.");

                LoadEmployees();
                ClearFields();
            }
            catch (SqlException)
            {
                MessageBox.Show(
                    "Cannot delete this employee because " +
                    "the employee is linked to an order.",
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
                            Employee_ID,
                            Employee_Code,
                            E_Name,
                            E_Email,
                            E_Phone,
                            Position,
                            Salary
                        FROM Employee
                        WHERE
                            Employee_Code LIKE @Search
                            OR E_Name LIKE @Search
                            OR E_Email LIKE @Search
                            OR E_Phone LIKE @Search
                            OR Position LIKE @Search
                        ORDER BY Employee_ID";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, con);

                    da.SelectCommand.Parameters.AddWithValue(
                        "@Search",
                        "%" +
                        txtSearch.Text.Trim() +
                        "%");

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dgvEmployees.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // CLICK ROW
        private void dgvEmployees_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvEmployees.Rows[e.RowIndex];

            txtEmployeeID.Text =
                row.Cells["Employee_ID"]
                    .Value.ToString();

            txtEmployeeCode.Text =
                row.Cells["Employee_Code"]
                    .Value.ToString();

            txtName.Text =
                row.Cells["E_Name"]
                    .Value.ToString();

            txtEmail.Text =
                row.Cells["E_Email"]
                    .Value.ToString();

            txtPhone.Text =
                row.Cells["E_Phone"]
                    .Value.ToString();

            cboPosition.Text =
                row.Cells["Position"]
                    .Value.ToString();

            txtSalary.Text =
                row.Cells["Salary"]
                    .Value.ToString();

            txtEmployeeID.ReadOnly = true;
        }

        // CLEAR
        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            ClearFields();

            txtSearch.Clear();

            LoadEmployees();
        }

        private void ClearFields()
        {
            txtEmployeeID.Clear();
            txtEmployeeCode.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtSalary.Clear();

            cboPosition.SelectedIndex = -1;

            txtEmployeeID.ReadOnly = false;

            txtEmployeeID.Focus();
        }
    }
}