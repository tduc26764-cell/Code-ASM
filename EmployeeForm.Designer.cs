namespace code_ko_keo_tha
{
    partial class EmployeeForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblSearch;

        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtEmployeeCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.DataGridView dgvEmployees;

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
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();

            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtEmployeeCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();

            this.dgvEmployees = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvEmployees)).BeginInit();

            this.SuspendLayout();

            // TITLE
            this.lblTitle.Text = "EMPLOYEE MANAGEMENT";

            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                22F,
                System.Drawing.FontStyle.Bold);

            this.lblTitle.ForeColor =
                System.Drawing.Color.FromArgb(30, 60, 114);

            this.lblTitle.Location =
                new System.Drawing.Point(30, 20);

            this.lblTitle.Size =
                new System.Drawing.Size(520, 55);

            // INPUTS
            SetupLabel(lblID, "Employee ID", 35, 90);
            SetupTextBox(txtEmployeeID, 40, 118);

            SetupLabel(lblCode, "Employee Code", 35, 160);
            SetupTextBox(txtEmployeeCode, 40, 188);

            SetupLabel(lblName, "Employee Name", 35, 230);
            SetupTextBox(txtName, 40, 258);

            SetupLabel(lblEmail, "Email", 35, 300);
            SetupTextBox(txtEmail, 40, 328);

            SetupLabel(lblPhone, "Phone Number", 35, 370);
            SetupTextBox(txtPhone, 40, 398);

            // POSITION
            SetupLabel(lblPosition, "Position", 35, 440);

            this.cboPosition.Location =
                new System.Drawing.Point(40, 468);

            this.cboPosition.Size =
                new System.Drawing.Size(270, 30);

            this.cboPosition.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.cboPosition.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboPosition.Items.AddRange(
                new object[]
                {
                    "Manager",
                    "Sales Staff",
                    "Cashier",
                    "Warehouse Staff"
                });

            // SALARY
            SetupLabel(lblSalary, "Salary (VND)", 35, 510);
            SetupTextBox(txtSalary, 40, 538);

            // BUTTONS
            SetupButton(
                btnAdd,
                "ADD",
                40,
                595,
                System.Drawing.Color.SeaGreen);

            SetupButton(
                btnUpdate,
                "UPDATE",
                165,
                595,
                System.Drawing.Color.FromArgb(30, 60, 114));

            SetupButton(
                btnDelete,
                "DELETE",
                290,
                595,
                System.Drawing.Color.Firebrick);

            SetupButton(
                btnClear,
                "CLEAR",
                415,
                595,
                System.Drawing.Color.DimGray);

            // SEARCH
            this.lblSearch.Text = "Search Employee";

            this.lblSearch.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.lblSearch.Location =
                new System.Drawing.Point(355, 85);

            this.lblSearch.Size =
                new System.Drawing.Size(180, 25);

            this.txtSearch.Location =
                new System.Drawing.Point(360, 115);

            this.txtSearch.Size =
                new System.Drawing.Size(430, 30);

            this.txtSearch.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            SetupButton(
                btnSearch,
                "SEARCH",
                805,
                111,
                System.Drawing.Color.FromArgb(30, 60, 114));

            // DATAGRIDVIEW
            this.dgvEmployees.Location =
                new System.Drawing.Point(360, 165);

            this.dgvEmployees.Size =
                new System.Drawing.Size(800, 390);

            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.MultiSelect = false;

            this.dgvEmployees.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvEmployees.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvEmployees.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvEmployees.RowHeadersVisible = false;

            // FORM
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(245, 246, 250);

            this.ClientSize =
                new System.Drawing.Size(1200, 680);

            this.Controls.Add(lblTitle);

            this.Controls.Add(lblID);
            this.Controls.Add(txtEmployeeID);

            this.Controls.Add(lblCode);
            this.Controls.Add(txtEmployeeCode);

            this.Controls.Add(lblName);
            this.Controls.Add(txtName);

            this.Controls.Add(lblEmail);
            this.Controls.Add(txtEmail);

            this.Controls.Add(lblPhone);
            this.Controls.Add(txtPhone);

            this.Controls.Add(lblPosition);
            this.Controls.Add(cboPosition);

            this.Controls.Add(lblSalary);
            this.Controls.Add(txtSalary);

            this.Controls.Add(btnAdd);
            this.Controls.Add(btnUpdate);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnClear);

            this.Controls.Add(lblSearch);
            this.Controls.Add(txtSearch);
            this.Controls.Add(btnSearch);

            this.Controls.Add(dgvEmployees);

            this.Name = "EmployeeForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Employee Management";

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvEmployees)).EndInit();

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