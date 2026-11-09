using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace code_ko_keo_tha
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();

            this.Load += ProductForm_Load;

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            btnSearch.Click += btnSearch_Click;

            dgvProducts.CellClick += dgvProducts_CellClick;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadBrands();
            LoadProducts();
        }

        // Parse decimal consistently for both 6.10 and 6,10,
        // regardless of Windows regional settings.
        private static bool TryParseDecimalInput(string text, out decimal value)
        {
            string normalized = text.Trim().Replace(',', '.');
            return decimal.TryParse(
                normalized,
                NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture,
                out value);
        }

        private static void AddDecimalParameters(SqlCommand cmd, decimal screenSize, decimal price)
        {
            SqlParameter screenParam = cmd.Parameters.Add("@Screen_Size", SqlDbType.Decimal);
            screenParam.Precision = 4;
            screenParam.Scale = 2;
            screenParam.Value = screenSize;

            SqlParameter priceParam = cmd.Parameters.Add("@Price", SqlDbType.Decimal);
            priceParam.Precision = 18;
            priceParam.Scale = 2;
            priceParam.Value = price;
        }

        // LOAD BRAND INTO COMBOBOX
        private void LoadBrands()
        {
            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    SqlDataAdapter da =
                        new SqlDataAdapter(
                            @"SELECT Brand_ID, Brand_Name
                              FROM Brand
                              ORDER BY Brand_Name",
                            con);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    cboBrand.DataSource = dt;
                    cboBrand.DisplayMember = "Brand_Name";
                    cboBrand.ValueMember = "Brand_ID";

                    cboBrand.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cannot load brands.\n" +
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
                            p.Product_ID,
                            p.Product_Name,
                            p.Brand_ID,
                            b.Brand_Name,
                            p.Chipset,
                            p.RAM,
                            p.Storage,
                            p.Screen_Size,
                            p.Battery_Capacity,
                            p.Operating_System,
                            p.Color,
                            p.Selling_Price,
                            p.Warranty_Months
                        FROM Product p
                        INNER JOIN Brand b
                            ON p.Brand_ID = b.Brand_ID
                        ORDER BY p.Product_ID";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, con);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dgvProducts.DataSource = dt;

                    if (dgvProducts.Columns["Brand_ID"] != null)
                    {
                        dgvProducts.Columns["Brand_ID"].Visible = false;
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int productID;
            int ram;
            int storage;
            int battery;
            int warranty;

            decimal screenSize;
            decimal price;

            if (!int.TryParse(
                txtProductID.Text.Trim(),
                out productID))
            {
                MessageBox.Show(
                    "Product ID must be a number.");

                return;
            }

            if (txtProductName.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Please enter Product Name.");

                return;
            }

            if (cboBrand.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a Brand.");

                return;
            }

            if (!int.TryParse(txtRAM.Text.Trim(), out ram))
            {
                MessageBox.Show("RAM must be a number.");
                return;
            }

            if (!int.TryParse(
                txtStorage.Text.Trim(),
                out storage))
            {
                MessageBox.Show(
                    "Storage must be a number.");

                return;
            }

            if (!TryParseDecimalInput(
                txtScreenSize.Text.Trim(),
                out screenSize))
            {
                MessageBox.Show(
                    "Screen Size must be a number.");

                return;
            }

            if (!int.TryParse(
                txtBattery.Text.Trim(),
                out battery))
            {
                MessageBox.Show(
                    "Battery Capacity must be a number.");

                return;
            }

            if (!TryParseDecimalInput(
                txtPrice.Text.Trim(),
                out price))
            {
                MessageBox.Show(
                    "Selling Price must be a number.");

                return;
            }

            if (!int.TryParse(
                txtWarranty.Text.Trim(),
                out warranty))
            {
                MessageBox.Show(
                    "Warranty must be a number.");

                return;
            }

            if (screenSize <= 0 || screenSize >= 100)
            {
                MessageBox.Show("Screen Size must be greater than 0 and less than 100.");
                return;
            }
            if (price <= 0)
            {
                MessageBox.Show("Selling Price must be greater than 0.");
                return;
            }

            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        INSERT INTO Product
                        (
                            Product_ID,
                            Product_Name,
                            Brand_ID,
                            Chipset,
                            RAM,
                            Storage,
                            Screen_Size,
                            Battery_Capacity,
                            Operating_System,
                            Color,
                            Selling_Price,
                            Warranty_Months
                        )
                        VALUES
                        (
                            @Product_ID,
                            @Product_Name,
                            @Brand_ID,
                            @Chipset,
                            @RAM,
                            @Storage,
                            @Screen_Size,
                            @Battery,
                            @OS,
                            @Color,
                            @Price,
                            @Warranty
                        )";

                    SqlCommand cmd =
                        new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue(
                        "@Product_ID",
                        productID);

                    cmd.Parameters.AddWithValue(
                        "@Product_Name",
                        txtProductName.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Brand_ID",
                        cboBrand.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@Chipset",
                        txtChipset.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@RAM",
                        ram);

                    cmd.Parameters.AddWithValue(
                        "@Storage",
                        storage);

                    cmd.Parameters.AddWithValue(
                        "@Battery",
                        battery);

                    cmd.Parameters.AddWithValue(
                        "@OS",
                        txtOS.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Color",
                        txtColor.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Warranty",
                        warranty);

                    AddDecimalParameters(cmd, screenSize, price);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Product added successfully.");

                LoadProducts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cannot add product.\n\n" +
                    ex.Message);
            }
        }

        // UPDATE
        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            int productID;
            int ram;
            int storage;
            int battery;
            int warranty;

            decimal screenSize;
            decimal price;

            if (!int.TryParse(
                txtProductID.Text.Trim(),
                out productID))
            {
                MessageBox.Show(
                    "Please select a product.");

                return;
            }

            if (cboBrand.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a brand.");

                return;
            }

            if (!int.TryParse(txtRAM.Text, out ram) ||
                !int.TryParse(txtStorage.Text, out storage) ||
                !TryParseDecimalInput(txtScreenSize.Text, out screenSize) ||
                !int.TryParse(txtBattery.Text, out battery) ||
                !TryParseDecimalInput(txtPrice.Text, out price) ||
                !int.TryParse(txtWarranty.Text, out warranty))
            {
                MessageBox.Show(
                    "Please check numeric fields.");

                return;
            }

            if (screenSize <= 0 || screenSize >= 100 || price <= 0)
            {
                MessageBox.Show("Screen Size must be between 0 and 100; Selling Price must be positive.");
                return;
            }

            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        UPDATE Product
                        SET
                            Product_Name = @Product_Name,
                            Brand_ID = @Brand_ID,
                            Chipset = @Chipset,
                            RAM = @RAM,
                            Storage = @Storage,
                            Screen_Size = @Screen_Size,
                            Battery_Capacity = @Battery,
                            Operating_System = @OS,
                            Color = @Color,
                            Selling_Price = @Price,
                            Warranty_Months = @Warranty
                        WHERE Product_ID = @Product_ID";

                    SqlCommand cmd =
                        new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue(
                        "@Product_ID",
                        productID);

                    cmd.Parameters.AddWithValue(
                        "@Product_Name",
                        txtProductName.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Brand_ID",
                        cboBrand.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@Chipset",
                        txtChipset.Text.Trim());

                    cmd.Parameters.AddWithValue("@RAM", ram);
                    cmd.Parameters.AddWithValue("@Storage", storage);

                    cmd.Parameters.AddWithValue(
                        "@Battery",
                        battery);

                    cmd.Parameters.AddWithValue(
                        "@OS",
                        txtOS.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Color",
                        txtColor.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Warranty",
                        warranty);

                    AddDecimalParameters(cmd, screenSize, price);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Product updated successfully.");

                LoadProducts();
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
            int productID;

            if (!int.TryParse(
                txtProductID.Text,
                out productID))
            {
                MessageBox.Show(
                    "Please select a product.");

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Do you want to delete this product?",
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
                            @"DELETE FROM Product
                              WHERE Product_ID = @ID",
                            con);

                    cmd.Parameters.AddWithValue(
                        "@ID",
                        productID);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Product deleted successfully.");

                LoadProducts();
                ClearFields();
            }
            catch (SqlException)
            {
                MessageBox.Show(
                    "Cannot delete this product because it is " +
                    "being used in an order or inventory record.",
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
                            p.Product_ID,
                            p.Product_Name,
                            p.Brand_ID,
                            b.Brand_Name,
                            p.Chipset,
                            p.RAM,
                            p.Storage,
                            p.Screen_Size,
                            p.Battery_Capacity,
                            p.Operating_System,
                            p.Color,
                            p.Selling_Price,
                            p.Warranty_Months
                        FROM Product p
                        INNER JOIN Brand b
                            ON p.Brand_ID = b.Brand_ID
                        WHERE
                            p.Product_Name LIKE @Search
                            OR b.Brand_Name LIKE @Search
                            OR p.Chipset LIKE @Search
                            OR p.Operating_System LIKE @Search
                            OR p.Color LIKE @Search
                        ORDER BY p.Product_ID";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, con);

                    da.SelectCommand.Parameters.AddWithValue(
                        "@Search",
                        "%" + txtSearch.Text.Trim() + "%");

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvProducts.DataSource = dt;

                    if (dgvProducts.Columns["Brand_ID"] != null)
                    {
                        dgvProducts.Columns["Brand_ID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // CLICK ROW
        private void dgvProducts_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvProducts.Rows[e.RowIndex];

            txtProductID.Text =
                row.Cells["Product_ID"].Value.ToString();

            txtProductName.Text =
                row.Cells["Product_Name"].Value.ToString();

            cboBrand.SelectedValue =
                row.Cells["Brand_ID"].Value;

            txtChipset.Text =
                row.Cells["Chipset"].Value.ToString();

            txtRAM.Text =
                row.Cells["RAM"].Value.ToString();

            txtStorage.Text =
                row.Cells["Storage"].Value.ToString();

            txtScreenSize.Text =
                row.Cells["Screen_Size"].Value.ToString();

            txtBattery.Text =
                row.Cells["Battery_Capacity"].Value.ToString();

            txtOS.Text =
                row.Cells["Operating_System"].Value.ToString();

            txtColor.Text =
                row.Cells["Color"].Value.ToString();

            txtPrice.Text =
                row.Cells["Selling_Price"].Value.ToString();

            txtWarranty.Text =
                row.Cells["Warranty_Months"].Value.ToString();

            txtProductID.ReadOnly = true;
        }

        // CLEAR
        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            ClearFields();

            txtSearch.Clear();

            LoadProducts();
        }

        private void ClearFields()
        {
            txtProductID.Clear();
            txtProductName.Clear();

            cboBrand.SelectedIndex = -1;

            txtChipset.Clear();
            txtRAM.Clear();
            txtStorage.Clear();
            txtScreenSize.Clear();
            txtBattery.Clear();
            txtOS.Clear();
            txtColor.Clear();
            txtPrice.Clear();
            txtWarranty.Clear();

            txtProductID.ReadOnly = false;
            txtProductID.Focus();
        }
    }
}