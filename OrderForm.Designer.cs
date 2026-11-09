namespace code_ko_keo_tha
{
    partial class OrderForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblStatus;

        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.ComboBox cboEmployee;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.ComboBox cboStatus;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.DataGridView dgvOrders;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();

            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.cboEmployee = new System.Windows.Forms.ComboBox();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.dgvOrders = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvOrders)).BeginInit();

            this.SuspendLayout();

            // TITLE
            this.lblTitle.Text = "ORDER MANAGEMENT";

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
                new System.Drawing.Size(500, 55);

            // ORDER ID
            SetupLabel(
                lblOrderID,
                "Order ID",
                35,
                100);

            SetupTextBox(
                txtOrderID,
                40,
                130);

            // CUSTOMER
            SetupLabel(
                lblCustomer,
                "Customer",
                35,
                180);

            this.cboCustomer.Location =
                new System.Drawing.Point(40, 210);

            this.cboCustomer.Size =
                new System.Drawing.Size(280, 30);

            this.cboCustomer.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.cboCustomer.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            // EMPLOYEE
            SetupLabel(
                lblEmployee,
                "Employee",
                35,
                260);

            this.cboEmployee.Location =
                new System.Drawing.Point(40, 290);

            this.cboEmployee.Size =
                new System.Drawing.Size(280, 30);

            this.cboEmployee.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.cboEmployee.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            // ORDER DATE
            SetupLabel(
                lblOrderDate,
                "Order Date",
                35,
                340);

            this.dtpOrderDate.Location =
                new System.Drawing.Point(40, 370);

            this.dtpOrderDate.Size =
                new System.Drawing.Size(280, 30);

            this.dtpOrderDate.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.dtpOrderDate.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            // TOTAL AMOUNT
            SetupLabel(
                lblTotalAmount,
                "Total Amount (VND)",
                35,
                420);

            SetupTextBox(
                txtTotalAmount,
                40,
                450);

            // STATUS
            SetupLabel(
                lblStatus,
                "Order Status",
                35,
                500);

            this.cboStatus.Location =
                new System.Drawing.Point(40, 530);

            this.cboStatus.Size =
                new System.Drawing.Size(280, 30);

            this.cboStatus.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.cboStatus.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboStatus.Items.AddRange(
                new object[]
                {
                    "Pending",
                    "Completed",
                    "Cancelled"
                });

            // BUTTONS
            SetupButton(
                btnAdd,
                "ADD",
                40,
                590,
                System.Drawing.Color.SeaGreen);

            SetupButton(
                btnUpdate,
                "UPDATE",
                165,
                590,
                System.Drawing.Color.FromArgb(30, 60, 114));

            SetupButton(
                btnDelete,
                "DELETE",
                290,
                590,
                System.Drawing.Color.Firebrick);

            SetupButton(
                btnClear,
                "CLEAR",
                415,
                590,
                System.Drawing.Color.DimGray);

            // DATAGRIDVIEW
            this.dgvOrders.Location =
                new System.Drawing.Point(370, 100);

            this.dgvOrders.Size =
                new System.Drawing.Size(830, 460);

            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;

            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.MultiSelect = false;

            this.dgvOrders.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvOrders.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvOrders.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvOrders.RowHeadersVisible = false;

            // FORM
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(245, 246, 250);

            this.ClientSize =
                new System.Drawing.Size(1240, 680);

            this.Controls.Add(lblTitle);

            this.Controls.Add(lblOrderID);
            this.Controls.Add(txtOrderID);

            this.Controls.Add(lblCustomer);
            this.Controls.Add(cboCustomer);

            this.Controls.Add(lblEmployee);
            this.Controls.Add(cboEmployee);

            this.Controls.Add(lblOrderDate);
            this.Controls.Add(dtpOrderDate);

            this.Controls.Add(lblTotalAmount);
            this.Controls.Add(txtTotalAmount);

            this.Controls.Add(lblStatus);
            this.Controls.Add(cboStatus);

            this.Controls.Add(btnAdd);
            this.Controls.Add(btnUpdate);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnClear);

            this.Controls.Add(dgvOrders);

            this.Name = "OrderForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Order Management";

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvOrders)).EndInit();

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