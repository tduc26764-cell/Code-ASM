using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace code_ko_keo_tha
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();

            this.Load += InventoryForm_Load;

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            btnSearch.Click += btnSearch_Click;

            dgvInventory.CellClick += dgvInventory_CellClick;
        }

        // FORM LOAD
        private void InventoryForm_Load(
            object sender,
            EventArgs e)
        {
            LoadProducts();
            LoadInventory();

            cboProduct.SelectedIndex = -1;
        }

        // LOAD PRODUCTS
        private void LoadProducts()
        {
            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        SELECT
                            Product_ID,
                            Product_Name
                        FROM Product
                        ORDER BY Product_Name";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, con);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    cboProduct.DataSource = dt;

                    cboProduct.DisplayMember =
                        "Product_Name";

                    cboProduct.ValueMember =
                        "Product_ID";

                    cboProduct.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cannot load products.\n" +
                    ex.Message);
            }
        }

        // LOAD INVENTORY
        private void LoadInventory()
        {
            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        SELECT
                            i.Inventory_ID,
                            i.Product_ID,
                            p.Product_Name,
                            i.Stock_Quantity,
                            i.Last_Updated
                        FROM Inventory i
                        INNER JOIN Product p
                            ON i.Product_ID = p.Product_ID
                        ORDER BY i.Inventory_ID";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, con);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dgvInventory.DataSource = dt;

                    if (dgvInventory.Columns["Product_ID"] != null)
                    {
                        dgvInventory.Columns["Product_ID"].Visible = false;
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

        // ADD
        private void btnAdd_Click(
            object sender,
            EventArgs e)
        {
            int inventoryID;
            int stock;

            if (!int.TryParse(
                txtInventoryID.Text.Trim(),
                out inventoryID))
            {
                MessageBox.Show(
                    "Inventory ID must be a number.");

                return;
            }

            if (cboProduct.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a Product.");

                return;
            }

            if (!int.TryParse(
                txtStock.Text.Trim(),
                out stock))
            {
                MessageBox.Show(
                    "Stock Quantity must be a number.");

                return;
            }

            if (stock < 0)
            {
                MessageBox.Show(
                    "Stock Quantity cannot be negative.");

                return;
            }

            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        INSERT INTO Inventory
                        (
                            Inventory_ID,
                            Product_ID,
                            Stock_Quantity,
                            Last_Updated
                        )
                        VALUES
                        (
                            @Inventory_ID,
                            @Product_ID,
                            @Stock,
                            @LastUpdated
                        )";

                    SqlCommand cmd =
                        new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue(
                        "@Inventory_ID",
                        inventoryID);

                    cmd.Parameters.AddWithValue(
                        "@Product_ID",
                        cboProduct.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@Stock",
                        stock);

                    cmd.Parameters.AddWithValue(
                        "@LastUpdated",
                        dtpLastUpdated.Value.Date);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Inventory added successfully.");

                LoadInventory();
                ClearFields();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 ||
                    ex.Number == 2601)
                {
                    MessageBox.Show(
                        "This Inventory ID already exists, " +
                        "or this Product already has an inventory record.",
                        "Duplicate Inventory",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(
                        "Cannot add inventory.\n\n" +
                        ex.Message);
                }
            }
        }

        // UPDATE
        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            int inventoryID;
            int stock;

            if (!int.TryParse(
                txtInventoryID.Text.Trim(),
                out inventoryID))
            {
                MessageBox.Show(
                    "Please select an Inventory record.");

                return;
            }

            if (cboProduct.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a Product.");

                return;
            }

            if (!int.TryParse(
                txtStock.Text.Trim(),
                out stock))
            {
                MessageBox.Show(
                    "Stock Quantity must be a number.");

                return;
            }

            if (stock < 0)
            {
                MessageBox.Show(
                    "Stock Quantity cannot be negative.");

                return;
            }

            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        UPDATE Inventory
                        SET
                            Product_ID = @Product_ID,
                            Stock_Quantity = @Stock,
                            Last_Updated = @LastUpdated
                        WHERE Inventory_ID = @Inventory_ID";

                    SqlCommand cmd =
                        new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue(
                        "@Inventory_ID",
                        inventoryID);

                    cmd.Parameters.AddWithValue(
                        "@Product_ID",
                        cboProduct.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@Stock",
                        stock);

                    cmd.Parameters.AddWithValue(
                        "@LastUpdated",
                        dtpLastUpdated.Value.Date);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Inventory updated successfully.");

                LoadInventory();
                ClearFields();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 ||
                    ex.Number == 2601)
                {
                    MessageBox.Show(
                        "The selected Product already has " +
                        "another inventory record.",
                        "Duplicate Product",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // DELETE
        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            int inventoryID;

            if (!int.TryParse(
                txtInventoryID.Text.Trim(),
                out inventoryID))
            {
                MessageBox.Show(
                    "Please select an Inventory record.");

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Do you want to delete this inventory record?",
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
                        DELETE FROM Inventory
                        WHERE Inventory_ID = @Inventory_ID";

                    SqlCommand cmd =
                        new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue(
                        "@Inventory_ID",
                        inventoryID);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Inventory deleted successfully.");

                LoadInventory();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cannot delete inventory.\n\n" +
                    ex.Message);
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
                            i.Inventory_ID,
                            i.Product_ID,
                            p.Product_Name,
                            i.Stock_Quantity,
                            i.Last_Updated
                        FROM Inventory i
                        INNER JOIN Product p
                            ON i.Product_ID = p.Product_ID
                        WHERE
                            p.Product_Name LIKE @Search
                        ORDER BY i.Inventory_ID";

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

                    dgvInventory.DataSource = dt;

                    if (dgvInventory.Columns["Product_ID"] != null)
                    {
                        dgvInventory.Columns["Product_ID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // CLICK ROW
        private void dgvInventory_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvInventory.Rows[e.RowIndex];

            txtInventoryID.Text =
                row.Cells["Inventory_ID"]
                    .Value.ToString();

            cboProduct.SelectedValue =
                row.Cells["Product_ID"].Value;

            txtStock.Text =
                row.Cells["Stock_Quantity"]
                    .Value.ToString();

            if (row.Cells["Last_Updated"].Value != DBNull.Value)
            {
                dtpLastUpdated.Value =
                    Convert.ToDateTime(
                        row.Cells["Last_Updated"].Value);
            }

            txtInventoryID.ReadOnly = true;
        }

        // CLEAR
        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            ClearFields();

            txtSearch.Clear();

            LoadInventory();
        }

        private void ClearFields()
        {
            txtInventoryID.Clear();

            cboProduct.SelectedIndex = -1;

            txtStock.Clear();

            dtpLastUpdated.Value =
                DateTime.Today;

            txtInventoryID.ReadOnly = false;

            txtInventoryID.Focus();
        }
    }
}