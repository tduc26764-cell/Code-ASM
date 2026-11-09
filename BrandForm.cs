using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace code_ko_keo_tha
{
    public partial class BrandForm : Form
    {
        public BrandForm()
        {
            InitializeComponent();

            this.Load += BrandForm_Load;

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            btnSearch.Click += btnSearch_Click;

            dgvBrands.CellClick += dgvBrands_CellClick;
        }

        // ==============================
        // FORM LOAD
        // ==============================

        private void BrandForm_Load(
            object sender,
            EventArgs e)
        {
            LoadBrands();
        }

        // ==============================
        // LOAD DATA
        // ==============================

        private void LoadBrands()
        {
            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql =
                        @"SELECT
                            Brand_ID,
                            Brand_Name,
                            Country
                          FROM Brand
                          ORDER BY Brand_ID";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, con);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dgvBrands.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database error:\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==============================
        // ADD
        // ==============================

        private void btnAdd_Click(
            object sender,
            EventArgs e)
        {
            if (txtBrandID.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Please enter Brand ID.");

                txtBrandID.Focus();
                return;
            }

            if (txtBrandName.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Please enter Brand Name.");

                txtBrandName.Focus();
                return;
            }

            int brandID;

            if (!int.TryParse(
                txtBrandID.Text.Trim(),
                out brandID))
            {
                MessageBox.Show(
                    "Brand ID must be a number.");

                txtBrandID.Focus();
                return;
            }

            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        INSERT INTO Brand
                        (
                            Brand_ID,
                            Brand_Name,
                            Country
                        )
                        VALUES
                        (
                            @Brand_ID,
                            @Brand_Name,
                            @Country
                        )";

                    SqlCommand cmd =
                        new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue(
                        "@Brand_ID",
                        brandID);

                    cmd.Parameters.AddWithValue(
                        "@Brand_Name",
                        txtBrandName.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Country",
                        txtCountry.Text.Trim());

                    con.Open();

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Brand added successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadBrands();

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cannot add brand.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==============================
        // UPDATE
        // ==============================

        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            int brandID;

            if (!int.TryParse(
                txtBrandID.Text.Trim(),
                out brandID))
            {
                MessageBox.Show(
                    "Please select a brand first.");

                return;
            }

            if (txtBrandName.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Brand Name cannot be empty.");

                return;
            }

            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        UPDATE Brand
                        SET
                            Brand_Name = @Brand_Name,
                            Country = @Country
                        WHERE Brand_ID = @Brand_ID";

                    SqlCommand cmd =
                        new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue(
                        "@Brand_ID",
                        brandID);

                    cmd.Parameters.AddWithValue(
                        "@Brand_Name",
                        txtBrandName.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Country",
                        txtCountry.Text.Trim());

                    con.Open();

                    int result =
                        cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show(
                            "Brand updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show(
                            "Brand not found.");
                    }
                }

                LoadBrands();

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==============================
        // DELETE
        // ==============================

        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            int brandID;

            if (!int.TryParse(
                txtBrandID.Text.Trim(),
                out brandID))
            {
                MessageBox.Show(
                    "Please select a brand first.");

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Do you want to delete this brand?",
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
                    string sql =
                        @"DELETE FROM Brand
                          WHERE Brand_ID = @Brand_ID";

                    SqlCommand cmd =
                        new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue(
                        "@Brand_ID",
                        brandID);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Brand deleted successfully.");

                LoadBrands();

                ClearFields();
            }
            catch (SqlException)
            {
                MessageBox.Show(
                    "Cannot delete this brand because " +
                    "it is currently used by a product.",
                    "Delete Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // ==============================
        // SEARCH
        // ==============================

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
                            Brand_ID,
                            Brand_Name,
                            Country
                        FROM Brand
                        WHERE
                            Brand_Name LIKE @Search
                            OR Country LIKE @Search
                        ORDER BY Brand_ID";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, con);

                    da.SelectCommand.Parameters
                        .AddWithValue(
                            "@Search",
                            "%" +
                            txtSearch.Text.Trim() +
                            "%");

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dgvBrands.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
            }
        }

        // ==============================
        // CLICK DATAGRIDVIEW
        // ==============================

        private void dgvBrands_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dgvBrands.Rows[e.RowIndex];

            txtBrandID.Text =
                row.Cells["Brand_ID"]
                   .Value
                   .ToString();

            txtBrandName.Text =
                row.Cells["Brand_Name"]
                   .Value
                   .ToString();

            txtCountry.Text =
                row.Cells["Country"]
                   .Value
                   .ToString();

            // Không cho sửa Primary Key
            txtBrandID.ReadOnly = true;
        }

        // ==============================
        // CLEAR
        // ==============================

        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            ClearFields();

            txtSearch.Clear();

            LoadBrands();
        }

        private void ClearFields()
        {
            txtBrandID.Clear();
            txtBrandName.Clear();
            txtCountry.Clear();

            txtBrandID.ReadOnly = false;

            txtBrandID.Focus();
        }
    }
}