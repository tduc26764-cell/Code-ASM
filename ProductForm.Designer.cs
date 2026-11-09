namespace code_ko_keo_tha
{
    partial class ProductForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblChipset;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblStorage;
        private System.Windows.Forms.Label lblScreenSize;
        private System.Windows.Forms.Label lblBattery;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblWarranty;
        private System.Windows.Forms.Label lblSearch;

        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.TextBox txtChipset;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.TextBox txtStorage;
        private System.Windows.Forms.TextBox txtScreenSize;
        private System.Windows.Forms.TextBox txtBattery;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtWarranty;
        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.DataGridView dgvProducts;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblChipset = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblStorage = new System.Windows.Forms.Label();
            this.lblScreenSize = new System.Windows.Forms.Label();
            this.lblBattery = new System.Windows.Forms.Label();
            this.lblOS = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblWarranty = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();

            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.txtChipset = new System.Windows.Forms.TextBox();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.txtStorage = new System.Windows.Forms.TextBox();
            this.txtScreenSize = new System.Windows.Forms.TextBox();
            this.txtBattery = new System.Windows.Forms.TextBox();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtWarranty = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();

            this.dgvProducts = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvProducts)).BeginInit();

            this.SuspendLayout();

            // TITLE
            this.lblTitle.Text = "PRODUCT MANAGEMENT";
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 22F,
                System.Drawing.FontStyle.Bold);

            this.lblTitle.ForeColor =
                System.Drawing.Color.FromArgb(30, 60, 114);

            this.lblTitle.Location =
                new System.Drawing.Point(30, 15);

            this.lblTitle.Size =
                new System.Drawing.Size(500, 55);

            // LEFT COLUMN
            SetupLabel(this.lblProductID, "Product ID", 35, 90);
            SetupTextBox(this.txtProductID, 40, 118);

            SetupLabel(this.lblProductName, "Product Name", 35, 165);
            SetupTextBox(this.txtProductName, 40, 193);

            SetupLabel(this.lblBrand, "Brand", 35, 240);

            this.cboBrand.Location =
                new System.Drawing.Point(40, 268);

            this.cboBrand.Size =
                new System.Drawing.Size(250, 28);

            this.cboBrand.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.cboBrand.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            SetupLabel(this.lblChipset, "Chipset", 35, 315);
            SetupTextBox(this.txtChipset, 40, 343);

            SetupLabel(this.lblRAM, "RAM (GB)", 35, 390);
            SetupTextBox(this.txtRAM, 40, 418);

            SetupLabel(this.lblStorage, "Storage (GB)", 35, 465);
            SetupTextBox(this.txtStorage, 40, 493);

            // MIDDLE COLUMN
            SetupLabel(this.lblScreenSize, "Screen Size (inch)", 325, 90);
            SetupTextBox(this.txtScreenSize, 330, 118);

            SetupLabel(this.lblBattery, "Battery Capacity (mAh)", 325, 165);
            SetupTextBox(this.txtBattery, 330, 193);

            SetupLabel(this.lblOS, "Operating System", 325, 240);
            SetupTextBox(this.txtOS, 330, 268);

            SetupLabel(this.lblColor, "Color", 325, 315);
            SetupTextBox(this.txtColor, 330, 343);

            SetupLabel(this.lblPrice, "Selling Price", 325, 390);
            SetupTextBox(this.txtPrice, 330, 418);

            SetupLabel(this.lblWarranty, "Warranty (Months)", 325, 465);
            SetupTextBox(this.txtWarranty, 330, 493);

            // BUTTONS
            SetupButton(
                this.btnAdd,
                "ADD",
                40,
                555,
                System.Drawing.Color.SeaGreen);

            SetupButton(
                this.btnUpdate,
                "UPDATE",
                165,
                555,
                System.Drawing.Color.FromArgb(30, 60, 114));

            SetupButton(
                this.btnDelete,
                "DELETE",
                290,
                555,
                System.Drawing.Color.Firebrick);

            SetupButton(
                this.btnClear,
                "CLEAR",
                415,
                555,
                System.Drawing.Color.DimGray);

            // SEARCH
            this.lblSearch.Text = "Search Product";

            this.lblSearch.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.lblSearch.Location =
                new System.Drawing.Point(620, 70);

            this.lblSearch.Size =
                new System.Drawing.Size(160, 25);

            this.txtSearch.Location =
                new System.Drawing.Point(625, 100);

            this.txtSearch.Size =
                new System.Drawing.Size(370, 30);

            this.txtSearch.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            SetupButton(
                this.btnSearch,
                "SEARCH",
                1010,
                96,
                System.Drawing.Color.FromArgb(30, 60, 114));

            // DATAGRIDVIEW
            this.dgvProducts.Location =
                new System.Drawing.Point(625, 150);

            this.dgvProducts.Size =
                new System.Drawing.Size(620, 440);

            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.MultiSelect = false;

            this.dgvProducts.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvProducts.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;

            this.dgvProducts.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvProducts.RowHeadersVisible = false;

            // FORM
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(245, 246, 250);

            this.ClientSize =
                new System.Drawing.Size(1280, 640);

            this.Controls.Add(this.lblTitle);

            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.txtProductID);

            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtProductName);

            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.cboBrand);

            this.Controls.Add(this.lblChipset);
            this.Controls.Add(this.txtChipset);

            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.txtRAM);

            this.Controls.Add(this.lblStorage);
            this.Controls.Add(this.txtStorage);

            this.Controls.Add(this.lblScreenSize);
            this.Controls.Add(this.txtScreenSize);

            this.Controls.Add(this.lblBattery);
            this.Controls.Add(this.txtBattery);

            this.Controls.Add(this.lblOS);
            this.Controls.Add(this.txtOS);

            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtColor);

            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);

            this.Controls.Add(this.lblWarranty);
            this.Controls.Add(this.txtWarranty);

            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);

            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);

            this.Controls.Add(this.dgvProducts);

            this.Name = "ProductForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Product Management";

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvProducts)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void SetupLabel(
            System.Windows.Forms.Label label,
            string text,
            int x,
            int y)
        {
            label.Text = text;

            label.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            label.Location =
                new System.Drawing.Point(x, y);

            label.Size =
                new System.Drawing.Size(250, 25);
        }

        private void SetupTextBox(
            System.Windows.Forms.TextBox textBox,
            int x,
            int y)
        {
            textBox.Location =
                new System.Drawing.Point(x, y);

            textBox.Size =
                new System.Drawing.Size(250, 30);

            textBox.Font =
                new System.Drawing.Font("Segoe UI", 10F);
        }

        private void SetupButton(
            System.Windows.Forms.Button button,
            string text,
            int x,
            int y,
            System.Drawing.Color color)
        {
            button.Text = text;

            button.Location =
                new System.Drawing.Point(x, y);

            button.Size = new System.Drawing.Size(110, 42);

            button.BackColor = color;
            button.ForeColor = System.Drawing.Color.White;

            button.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            button.FlatAppearance.BorderSize = 0;

            button.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            button.Cursor =
                System.Windows.Forms.Cursors.Hand;
        }
    }
}