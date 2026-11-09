namespace code_ko_keo_tha
{
    partial class PaymentForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPaymentID;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblStatus;

        private System.Windows.Forms.TextBox txtPaymentID;
        private System.Windows.Forms.ComboBox cboOrder;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.ComboBox cboMethod;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cboStatus;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.DataGridView dgvPayments;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPaymentID = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();

            this.txtPaymentID = new System.Windows.Forms.TextBox();
            this.cboOrder = new System.Windows.Forms.ComboBox();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.cboMethod = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.dgvPayments = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvPayments)).BeginInit();

            this.SuspendLayout();

            // TITLE
            this.lblTitle.Text = "PAYMENT MANAGEMENT";

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
                new System.Drawing.Size(550, 55);

            // PAYMENT ID
            SetupLabel(
                lblPaymentID,
                "Payment ID",
                35,
                100);

            SetupTextBox(
                txtPaymentID,
                40,
                130);

            // ORDER
            SetupLabel(
                lblOrder,
                "Order",
                35,
                180);

            this.cboOrder.Location =
                new System.Drawing.Point(40, 210);

            this.cboOrder.Size =
                new System.Drawing.Size(280, 30);

            this.cboOrder.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.cboOrder.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            // PAYMENT DATE
            SetupLabel(
                lblPaymentDate,
                "Payment Date",
                35,
                260);

            this.dtpPaymentDate.Location =
                new System.Drawing.Point(40, 290);

            this.dtpPaymentDate.Size =
                new System.Drawing.Size(280, 30);

            this.dtpPaymentDate.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.dtpPaymentDate.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            // METHOD
            SetupLabel(
                lblMethod,
                "Payment Method",
                35,
                340);

            this.cboMethod.Location =
                new System.Drawing.Point(40, 370);

            this.cboMethod.Size =
                new System.Drawing.Size(280, 30);

            this.cboMethod.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.cboMethod.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboMethod.Items.AddRange(
                new object[]
                {
                    "Cash",
                    "Bank Transfer",
                    "Credit Card"
                });

            // AMOUNT
            SetupLabel(
                lblAmount,
                "Amount (VND)",
                35,
                420);

            SetupTextBox(
                txtAmount,
                40,
                450);

            // STATUS
            SetupLabel(
                lblStatus,
                "Payment Status",
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
                    "Paid",
                    "Pending",
                    "Failed"
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
            this.dgvPayments.Location =
                new System.Drawing.Point(370, 100);

            this.dgvPayments.Size =
                new System.Drawing.Size(820, 460);

            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.MultiSelect = false;

            this.dgvPayments.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvPayments.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvPayments.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvPayments.RowHeadersVisible = false;

            // FORM
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(245, 246, 250);

            this.ClientSize =
                new System.Drawing.Size(1230, 680);

            this.Controls.Add(lblTitle);

            this.Controls.Add(lblPaymentID);
            this.Controls.Add(txtPaymentID);

            this.Controls.Add(lblOrder);
            this.Controls.Add(cboOrder);

            this.Controls.Add(lblPaymentDate);
            this.Controls.Add(dtpPaymentDate);

            this.Controls.Add(lblMethod);
            this.Controls.Add(cboMethod);

            this.Controls.Add(lblAmount);
            this.Controls.Add(txtAmount);

            this.Controls.Add(lblStatus);
            this.Controls.Add(cboStatus);

            this.Controls.Add(btnAdd);
            this.Controls.Add(btnUpdate);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnClear);

            this.Controls.Add(dgvPayments);

            this.Name = "PaymentForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Payment Management";

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvPayments)).EndInit();

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