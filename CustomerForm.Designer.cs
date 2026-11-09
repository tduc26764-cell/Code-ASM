namespace code_ko_keo_tha
{
    partial class CustomerForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSearch;

        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtCustomerCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.DataGridView dgvCustomers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();

            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();

            this.dgvCustomers = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvCustomers)).BeginInit();

            this.SuspendLayout();

            // TITLE
            this.lblTitle.Text = "CUSTOMER MANAGEMENT";

            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 22F,
                System.Drawing.FontStyle.Bold);

            this.lblTitle.ForeColor =
                System.Drawing.Color.FromArgb(30, 60, 114);

            this.lblTitle.Location =
                new System.Drawing.Point(30, 20);

            this.lblTitle.Size =
                new System.Drawing.Size(500, 55);

            // INPUTS
            SetupLabel(lblID, "Customer ID", 35, 100);
            SetupTextBox(txtCustomerID, 40, 130);

            SetupLabel(lblCode, "Customer Code", 35, 175);
            SetupTextBox(txtCustomerCode, 40, 205);

            SetupLabel(lblName, "Customer Name", 35, 250);
            SetupTextBox(txtName, 40, 280);

            SetupLabel(lblEmail, "Email", 35, 325);
            SetupTextBox(txtEmail, 40, 355);

            SetupLabel(lblPhone, "Phone Number", 35, 400);
            SetupTextBox(txtPhone, 40, 430);

            SetupLabel(lblAddress, "Address", 35, 475);
            SetupTextBox(txtAddress, 40, 505);

            // BUTTONS
            SetupButton(
                btnAdd, "ADD", 40, 565,
                System.Drawing.Color.SeaGreen);

            SetupButton(
                btnUpdate, "UPDATE", 165, 565,
                System.Drawing.Color.FromArgb(30, 60, 114));

            SetupButton(
                btnDelete, "DELETE", 290, 565,
                System.Drawing.Color.Firebrick);

            SetupButton(
                btnClear, "CLEAR", 415, 565,
                System.Drawing.Color.DimGray);

            // SEARCH
            this.lblSearch.Text = "Search Customer";

            this.lblSearch.Font =
                new System.Drawing.Font(
                    "Segoe UI", 10F,
                    System.Drawing.FontStyle.Bold);

            this.lblSearch.Location =
                new System.Drawing.Point(350, 85);

            this.lblSearch.Size =
                new System.Drawing.Size(180, 25);

            this.txtSearch.Location =
                new System.Drawing.Point(355, 115);

            this.txtSearch.Size =
                new System.Drawing.Size(430, 30);

            this.txtSearch.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            SetupButton(
                btnSearch, "SEARCH", 800, 111,
                System.Drawing.Color.FromArgb(30, 60, 114));

            // DATAGRIDVIEW
            this.dgvCustomers.Location =
                new System.Drawing.Point(355, 165);

            this.dgvCustomers.Size =
                new System.Drawing.Size(750, 370);

            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.MultiSelect = false;

            this.dgvCustomers.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvCustomers.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvCustomers.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvCustomers.RowHeadersVisible = false;

            // FORM
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(245, 246, 250);

            this.ClientSize =
                new System.Drawing.Size(1150, 650);

            this.Controls.Add(lblTitle);

            this.Controls.Add(lblID);
            this.Controls.Add(txtCustomerID);

            this.Controls.Add(lblCode);
            this.Controls.Add(txtCustomerCode);

            this.Controls.Add(lblName);
            this.Controls.Add(txtName);

            this.Controls.Add(lblEmail);
            this.Controls.Add(txtEmail);

            this.Controls.Add(lblPhone);
            this.Controls.Add(txtPhone);

            this.Controls.Add(lblAddress);
            this.Controls.Add(txtAddress);

            this.Controls.Add(btnAdd);
            this.Controls.Add(btnUpdate);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnClear);

            this.Controls.Add(lblSearch);
            this.Controls.Add(txtSearch);
            this.Controls.Add(btnSearch);

            this.Controls.Add(dgvCustomers);

            this.Name = "CustomerForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Customer Management";

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvCustomers)).EndInit();

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
                new System.Drawing.Size(270, 30);

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

            button.ForeColor =
                System.Drawing.Color.White;

            button.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            button.FlatAppearance.BorderSize = 0;

            button.Font =
                new System.Drawing.Font(
                    "Segoe UI", 9F,
                    System.Drawing.FontStyle.Bold);

            button.Cursor =
                System.Windows.Forms.Cursors.Hand;
        }
    }
}