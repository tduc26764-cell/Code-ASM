namespace code_ko_keo_tha
{
    partial class OrderDetailForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDetailID;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblUnitPrice;

        private System.Windows.Forms.TextBox txtDetailID;
        private System.Windows.Forms.ComboBox cboOrder;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.TextBox txtUnitPrice;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.DataGridView dgvDetails;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDetailID = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();

            this.txtDetailID = new System.Windows.Forms.TextBox();
            this.cboOrder = new System.Windows.Forms.ComboBox();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.dgvDetails = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)
                (this.nudQuantity)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvDetails)).BeginInit();

            this.SuspendLayout();

            // TITLE
            this.lblTitle.Text = "ORDER DETAIL MANAGEMENT";
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                22F,
                System.Drawing.FontStyle.Bold);

            this.lblTitle.ForeColor =
                System.Drawing.Color.FromArgb(30, 60, 114);

            this.lblTitle.Location =
                new System.Drawing.Point(30, 20);

            this.lblTitle.Size =
                new System.Drawing.Size(600, 55);

            // DETAIL ID
            SetupLabel(
                lblDetailID,
                "Order Detail ID",
                35,
                110);

            SetupTextBox(
                txtDetailID,
                40,
                140);

            // ORDER
            SetupLabel(
                lblOrder,
                "Order",
                35,
                190);

            this.cboOrder.Location =
                new System.Drawing.Point(40, 220);

            this.cboOrder.Size =
                new System.Drawing.Size(280, 30);

            this.cboOrder.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.cboOrder.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            // PRODUCT
            SetupLabel(
                lblProduct,
                "Product",
                35,
                270);

            this.cboProduct.Location =
                new System.Drawing.Point(40, 300);

            this.cboProduct.Size =
                new System.Drawing.Size(280, 30);

            this.cboProduct.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.cboProduct.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            // QUANTITY
            SetupLabel(
                lblQuantity,
                "Quantity",
                35,
                350);

            this.nudQuantity.Location =
                new System.Drawing.Point(40, 380);

            this.nudQuantity.Size =
                new System.Drawing.Size(280, 30);

            this.nudQuantity.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.nudQuantity.Minimum = 1;
            this.nudQuantity.Maximum = 100;
            this.nudQuantity.Value = 1;

            // UNIT PRICE
            SetupLabel(
                lblUnitPrice,
                "Unit Price (VND)",
                35,
                430);

            SetupTextBox(
                txtUnitPrice,
                40,
                460);

            // BUTTONS
            SetupButton(
                btnAdd,
                "ADD",
                40,
                525,
                System.Drawing.Color.SeaGreen);

            SetupButton(
                btnUpdate,
                "UPDATE",
                165,
                525,
                System.Drawing.Color.FromArgb(30, 60, 114));

            SetupButton(
                btnDelete,
                "DELETE",
                290,
                525,
                System.Drawing.Color.Firebrick);

            SetupButton(
                btnClear,
                "CLEAR",
                415,
                525,
                System.Drawing.Color.DimGray);

            // DATAGRIDVIEW
            this.dgvDetails.Location =
                new System.Drawing.Point(370, 110);

            this.dgvDetails.Size =
                new System.Drawing.Size(820, 380);

            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.MultiSelect = false;

            this.dgvDetails.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvDetails.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvDetails.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvDetails.RowHeadersVisible = false;

            // FORM
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(245, 246, 250);

            this.ClientSize =
                new System.Drawing.Size(1230, 620);

            this.Controls.Add(lblTitle);

            this.Controls.Add(lblDetailID);
            this.Controls.Add(txtDetailID);

            this.Controls.Add(lblOrder);
            this.Controls.Add(cboOrder);

            this.Controls.Add(lblProduct);
            this.Controls.Add(cboProduct);

            this.Controls.Add(lblQuantity);
            this.Controls.Add(nudQuantity);

            this.Controls.Add(lblUnitPrice);
            this.Controls.Add(txtUnitPrice);

            this.Controls.Add(btnAdd);
            this.Controls.Add(btnUpdate);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnClear);

            this.Controls.Add(dgvDetails);

            this.Name = "OrderDetailForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Order Detail Management";

            ((System.ComponentModel.ISupportInitialize)
                (this.nudQuantity)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvDetails)).EndInit();

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
                new System.Drawing.Size(280, 30);

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

            button.Size =
                new System.Drawing.Size(110, 42);

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