namespace code_ko_keo_tha
{
    partial class InventoryForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInventoryID;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblLastUpdated;
        private System.Windows.Forms.Label lblSearch;

        private System.Windows.Forms.TextBox txtInventoryID;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.DateTimePicker dtpLastUpdated;
        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.DataGridView dgvInventory;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInventoryID = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();

            this.txtInventoryID = new System.Windows.Forms.TextBox();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.dtpLastUpdated = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();

            this.dgvInventory = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvInventory)).BeginInit();

            this.SuspendLayout();

            // TITLE
            this.lblTitle.Text = "INVENTORY MANAGEMENT";

            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    22F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitle.ForeColor =
                System.Drawing.Color.FromArgb(30, 60, 114);

            this.lblTitle.Location =
                new System.Drawing.Point(30, 20);

            this.lblTitle.Size =
                new System.Drawing.Size(600, 55);

            // INVENTORY ID
            SetupLabel(
                lblInventoryID,
                "Inventory ID",
                35,
                110);

            SetupTextBox(
                txtInventoryID,
                40,
                140);

            // PRODUCT
            SetupLabel(
                lblProduct,
                "Product",
                35,
                200);

            this.cboProduct.Location =
                new System.Drawing.Point(40, 230);

            this.cboProduct.Size =
                new System.Drawing.Size(280, 30);

            this.cboProduct.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.cboProduct.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            // STOCK
            SetupLabel(
                lblStock,
                "Stock Quantity",
                35,
                290);

            SetupTextBox(
                txtStock,
                40,
                320);

            // LAST UPDATED
            SetupLabel(
                lblLastUpdated,
                "Last Updated",
                35,
                380);

            this.dtpLastUpdated.Location =
                new System.Drawing.Point(40, 410);

            this.dtpLastUpdated.Size =
                new System.Drawing.Size(280, 30);

            this.dtpLastUpdated.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.dtpLastUpdated.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            // BUTTONS
            SetupButton(
                btnAdd,
                "ADD",
                40,
                480,
                System.Drawing.Color.SeaGreen);

            SetupButton(
                btnUpdate,
                "UPDATE",
                165,
                480,
                System.Drawing.Color.FromArgb(30, 60, 114));

            SetupButton(
                btnDelete,
                "DELETE",
                290,
                480,
                System.Drawing.Color.Firebrick);

            SetupButton(
                btnClear,
                "CLEAR",
                415,
                480,
                System.Drawing.Color.DimGray);

            // SEARCH
            this.lblSearch.Text = "Search Product";

            this.lblSearch.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.lblSearch.Location =
                new System.Drawing.Point(370, 85);

            this.lblSearch.Size =
                new System.Drawing.Size(180, 25);

            this.txtSearch.Location =
                new System.Drawing.Point(375, 115);

            this.txtSearch.Size =
                new System.Drawing.Size(400, 30);

            this.txtSearch.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            SetupButton(
                btnSearch,
                "SEARCH",
                790,
                111,
                System.Drawing.Color.FromArgb(30, 60, 114));

            // DATAGRIDVIEW
            this.dgvInventory.Location =
                new System.Drawing.Point(375, 165);

            this.dgvInventory.Size =
                new System.Drawing.Size(750, 280);

            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.MultiSelect = false;

            this.dgvInventory.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvInventory.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvInventory.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvInventory.RowHeadersVisible = false;

            // FORM
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(245, 246, 250);

            this.ClientSize =
                new System.Drawing.Size(1170, 580);

            this.Controls.Add(lblTitle);

            this.Controls.Add(lblInventoryID);
            this.Controls.Add(txtInventoryID);

            this.Controls.Add(lblProduct);
            this.Controls.Add(cboProduct);

            this.Controls.Add(lblStock);
            this.Controls.Add(txtStock);

            this.Controls.Add(lblLastUpdated);
            this.Controls.Add(dtpLastUpdated);

            this.Controls.Add(btnAdd);
            this.Controls.Add(btnUpdate);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnClear);

            this.Controls.Add(lblSearch);
            this.Controls.Add(txtSearch);
            this.Controls.Add(btnSearch);

            this.Controls.Add(dgvInventory);

            this.Name = "InventoryForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Inventory Management";

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvInventory)).EndInit();

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
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

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
                new System.Drawing.Size(280, 30);

            textBox.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);
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

            button.Size =
                new System.Drawing.Size(110, 42);

            button.BackColor = color;

            button.ForeColor =
                System.Drawing.Color.White;

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