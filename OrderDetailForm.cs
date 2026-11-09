using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace code_ko_keo_tha
{
    public partial class OrderDetailForm : Form
    {
        private bool isLoading = false;

        public OrderDetailForm()
        {
            InitializeComponent();

            this.Load += OrderDetailForm_Load;

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;

            dgvDetails.CellClick += dgvDetails_CellClick;

            cboProduct.SelectedIndexChanged +=
                cboProduct_SelectedIndexChanged;
        }

        private void OrderDetailForm_Load(
            object sender,
            EventArgs e)
        {
            isLoading = true;

            LoadOrders();
            LoadProducts();
            LoadDetails();

            cboOrder.SelectedIndex = -1;
            cboProduct.SelectedIndex = -1;

            isLoading = false;
        }

        // LOAD ORDERS
        private void LoadOrders()
        {
            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        SELECT
                            Order_ID,
                            'Order #' + CAST(Order_ID AS VARCHAR(20))
                            AS Order_Display
                        FROM Sale_Order
                        ORDER BY Order_ID";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, con);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    cboOrder.DataSource = dt;
                    cboOrder.DisplayMember = "Order_Display";
                    cboOrder.ValueMember = "Order_ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cannot load orders.\n" +
                    ex.Message);
            }
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
                            Product_Name,
                            Selling_Price
                        FROM Product
                        ORDER BY Product_Name";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, con);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    cboProduct.DataSource = dt;
                    cboProduct.DisplayMember = "Product_Name";
                    cboProduct.ValueMember = "Product_ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cannot load products.\n" +
                    ex.Message);
            }
        }

        // LOAD DETAILS
        private void LoadDetails()
        {
            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        SELECT
                            od.Order_Detail_ID,
                            od.Order_ID,
                            od.Product_ID,
                            p.Product_Name,
                            od.Quantity,
                            od.Unit_Price
                        FROM Order_Detail od
                        INNER JOIN Product p
                            ON od.Product_ID = p.Product_ID
                        ORDER BY od.Order_Detail_ID";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, con);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvDetails.DataSource = dt;

                    if (dgvDetails.Columns["Product_ID"] != null)
                    {
                        dgvDetails.Columns["Product_ID"].Visible = false;
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

        // AUTO GET PRODUCT PRICE
        private void cboProduct_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (isLoading)
                return;

            if (cboProduct.SelectedIndex == -1)
                return;

            DataRowView row =
                cboProduct.SelectedItem as DataRowView;

            if (row != null)
            {
                txtUnitPrice.Text =
                    Convert.ToDecimal(
                        row["Selling_Price"])
                    .ToString("0.##");
            }
        }

        // ADD
        private void btnAdd_Click(
            object sender,
            EventArgs e)
        {
            int detailID;
            decimal unitPrice;

            if (!int.TryParse(
                txtDetailID.Text.Trim(),
                out detailID))
            {
                MessageBox.Show(
                    "Order Detail ID must be a number.");

                return;
            }

            if (cboOrder.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select an Order.");

                return;
            }

            if (cboProduct.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a Product.");

                return;
            }

            if (!decimal.TryParse(
                txtUnitPrice.Text.Trim(),
                out unitPrice))
            {
                MessageBox.Show(
                    "Unit Price must be a number.");

                return;
            }

            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        INSERT INTO Order_Detail
                        (
                            Order_Detail_ID,
                            Order_ID,
                            Product_ID,
                            Quantity,
                            Unit_Price
                        )
                        VALUES
                        (
                            @Detail_ID,
                            @Order_ID,
                            @Product_ID,
                            @Quantity,
                            @Unit_Price
                        )";

                    SqlCommand cmd =
                        new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue(
                        "@Detail_ID",
                        detailID);

                    cmd.Parameters.AddWithValue(
                        "@Order_ID",
                        cboOrder.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@Product_ID",
                        cboProduct.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@Quantity",
                        (int)nudQuantity.Value);

                    cmd.Parameters.AddWithValue(
                        "@Unit_Price",
                        unitPrice);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Order detail added successfully.");

                LoadDetails();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cannot add order detail.\n\n" +
                    ex.Message);
            }
        }

        // UPDATE
        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            int detailID;
            decimal unitPrice;

            if (!int.TryParse(
                txtDetailID.Text.Trim(),
                out detailID))
            {
                MessageBox.Show(
                    "Please select an Order Detail.");

                return;
            }

            if (cboOrder.SelectedIndex == -1 ||
                cboProduct.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select Order and Product.");

                return;
            }

            if (!decimal.TryParse(
                txtUnitPrice.Text.Trim(),
                out unitPrice))
            {
                MessageBox.Show(
                    "Unit Price must be a number.");

                return;
            }

            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        UPDATE Order_Detail
                        SET
                            Order_ID = @Order_ID,
                            Product_ID = @Product_ID,
                            Quantity = @Quantity,
                            Unit_Price = @Unit_Price
                        WHERE Order_Detail_ID = @Detail_ID";

                    SqlCommand cmd =
                        new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue(
                        "@Detail_ID",
                        detailID);

                    cmd.Parameters.AddWithValue(
                        "@Order_ID",
                        cboOrder.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@Product_ID",
                        cboProduct.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@Quantity",
                        (int)nudQuantity.Value);

                    cmd.Parameters.AddWithValue(
                        "@Unit_Price",
                        unitPrice);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Order detail updated successfully.");

                LoadDetails();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cannot update order detail.\n\n" +
                    ex.Message);
            }
        }

        // DELETE
        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            int detailID;

            if (!int.TryParse(
                txtDetailID.Text.Trim(),
                out detailID))
            {
                MessageBox.Show(
                    "Please select an Order Detail.");

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Do you want to delete this order detail?",
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
                        DELETE FROM Order_Detail
                        WHERE Order_Detail_ID = @Detail_ID";

                    SqlCommand cmd =
                        new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue(
                        "@Detail_ID",
                        detailID);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Order detail deleted successfully.");

                LoadDetails();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cannot delete order detail.\n\n" +
                    ex.Message);
            }
        }

        // CLICK ROW
        private void dgvDetails_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            isLoading = true;

            DataGridViewRow row =
                dgvDetails.Rows[e.RowIndex];

            txtDetailID.Text =
                row.Cells["Order_Detail_ID"]
                    .Value.ToString();

            cboOrder.SelectedValue =
                row.Cells["Order_ID"].Value;

            cboProduct.SelectedValue =
                row.Cells["Product_ID"].Value;

            nudQuantity.Value =
                Convert.ToDecimal(
                    row.Cells["Quantity"].Value);

            txtUnitPrice.Text =
                row.Cells["Unit_Price"]
                    .Value.ToString();

            txtDetailID.ReadOnly = true;

            isLoading = false;
        }

        // CLEAR
        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            isLoading = true;

            txtDetailID.Clear();

            cboOrder.SelectedIndex = -1;
            cboProduct.SelectedIndex = -1;

            nudQuantity.Value = 1;

            txtUnitPrice.Clear();

            txtDetailID.ReadOnly = false;

            isLoading = false;

            txtDetailID.Focus();
        }
    }
}