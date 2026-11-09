namespace code_ko_keo_tha
{
    partial class BrandForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBrandID;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblSearch;

        private System.Windows.Forms.TextBox txtBrandID;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.DataGridView dgvBrands;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBrandID = new System.Windows.Forms.Label();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();

            this.txtBrandID = new System.Windows.Forms.TextBox();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();

            this.dgvBrands = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvBrands)).BeginInit();

            this.SuspendLayout();

            // ==============================
            // TITLE
            // ==============================

            this.lblTitle.Text = "BRAND MANAGEMENT";

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
                new System.Drawing.Size(450, 55);

            // ==============================
            // BRAND ID
            // ==============================

            this.lblBrandID.Text = "Brand ID";

            this.lblBrandID.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.lblBrandID.Location =
                new System.Drawing.Point(35, 105);

            this.lblBrandID.Size =
                new System.Drawing.Size(150, 25);

            this.txtBrandID.Location =
                new System.Drawing.Point(40, 135);

            this.txtBrandID.Size =
                new System.Drawing.Size(250, 27);

            this.txtBrandID.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            // ==============================
            // BRAND NAME
            // ==============================

            this.lblBrandName.Text = "Brand Name";

            this.lblBrandName.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.lblBrandName.Location =
                new System.Drawing.Point(35, 185);

            this.lblBrandName.Size =
                new System.Drawing.Size(150, 25);

            this.txtBrandName.Location =
                new System.Drawing.Point(40, 215);

            this.txtBrandName.Size =
                new System.Drawing.Size(250, 27);

            this.txtBrandName.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            // ==============================
            // COUNTRY
            // ==============================

            this.lblCountry.Text = "Country";

            this.lblCountry.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.lblCountry.Location =
                new System.Drawing.Point(35, 265);

            this.lblCountry.Size =
                new System.Drawing.Size(150, 25);

            this.txtCountry.Location =
                new System.Drawing.Point(40, 295);

            this.txtCountry.Size =
                new System.Drawing.Size(250, 27);

            this.txtCountry.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            // ==============================
            // BUTTON ADD
            // ==============================

            SetupButton(
                this.btnAdd,
                "ADD",
                40,
                365,
                System.Drawing.Color.SeaGreen);

            // ==============================
            // BUTTON UPDATE
            // ==============================

            SetupButton(
                this.btnUpdate,
                "UPDATE",
                165,
                365,
                System.Drawing.Color.FromArgb(30, 60, 114));

            // ==============================
            // BUTTON DELETE
            // ==============================

            SetupButton(
                this.btnDelete,
                "DELETE",
                40,
                420,
                System.Drawing.Color.Firebrick);

            // ==============================
            // BUTTON CLEAR
            // ==============================

            SetupButton(
                this.btnClear,
                "CLEAR",
                165,
                420,
                System.Drawing.Color.DimGray);

            // ==============================
            // SEARCH
            // ==============================

            this.lblSearch.Text = "Search Brand";

            this.lblSearch.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.lblSearch.Location =
                new System.Drawing.Point(350, 68);

            this.lblSearch.Size =
                new System.Drawing.Size(150, 25);

            this.txtSearch.Location =
                new System.Drawing.Point(350, 95);

            this.txtSearch.Size =
                new System.Drawing.Size(360, 30);

            this.txtSearch.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            SetupButton(
                this.btnSearch,
                "SEARCH",
                725,
                91,
                System.Drawing.Color.FromArgb(30, 60, 114));

            // ==============================
            // DATAGRIDVIEW
            // ==============================

            this.dgvBrands.Location =
                new System.Drawing.Point(350, 145);

            this.dgvBrands.Size =
                new System.Drawing.Size(600, 380);

            this.dgvBrands.AllowUserToAddRows = false;
            this.dgvBrands.AllowUserToDeleteRows = false;

            this.dgvBrands.ReadOnly = true;
            this.dgvBrands.MultiSelect = false;

            this.dgvBrands.SelectionMode =
                System.Windows.Forms
                    .DataGridViewSelectionMode.FullRowSelect;

            this.dgvBrands.AutoSizeColumnsMode =
                System.Windows.Forms
                    .DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvBrands.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvBrands.BorderStyle =
                System.Windows.Forms.BorderStyle.Fixed3D;

            this.dgvBrands.RowHeadersVisible = false;

            // ==============================
            // FORM
            // ==============================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(245, 246, 250);

            this.ClientSize =
                new System.Drawing.Size(1000, 580);

            this.Controls.Add(this.lblTitle);

            this.Controls.Add(this.lblBrandID);
            this.Controls.Add(this.txtBrandID);

            this.Controls.Add(this.lblBrandName);
            this.Controls.Add(this.txtBrandName);

            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtCountry);

            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);

            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);

            this.Controls.Add(this.dgvBrands);

            this.Name = "BrandForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Brand Management";

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvBrands)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // ==============================
        // BUTTON DESIGN
        // ==============================

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