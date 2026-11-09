namespace code_ko_keo_tha
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblUser;

        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnBrands;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnOrderDetails;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Label lblDashboard;

        private System.Windows.Forms.Panel pnlProductCard;
        private System.Windows.Forms.Panel pnlCustomerCard;
        private System.Windows.Forms.Panel pnlOrderCard;
        private System.Windows.Forms.Panel pnlEmployeeCard;

        private System.Windows.Forms.Label lblProductTitle;
        private System.Windows.Forms.Label lblProductCount;

        private System.Windows.Forms.Label lblCustomerTitle;
        private System.Windows.Forms.Label lblCustomerCount;

        private System.Windows.Forms.Label lblOrderTitle;
        private System.Windows.Forms.Label lblOrderCount;

        private System.Windows.Forms.Label lblEmployeeTitle;
        private System.Windows.Forms.Label lblEmployeeCount;

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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();

            this.lblLogo = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();

            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnBrands = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnOrderDetails = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();

            this.lblDashboard = new System.Windows.Forms.Label();

            this.pnlProductCard = new System.Windows.Forms.Panel();
            this.pnlCustomerCard = new System.Windows.Forms.Panel();
            this.pnlOrderCard = new System.Windows.Forms.Panel();
            this.pnlEmployeeCard = new System.Windows.Forms.Panel();

            this.lblProductTitle = new System.Windows.Forms.Label();
            this.lblProductCount = new System.Windows.Forms.Label();

            this.lblCustomerTitle = new System.Windows.Forms.Label();
            this.lblCustomerCount = new System.Windows.Forms.Label();

            this.lblOrderTitle = new System.Windows.Forms.Label();
            this.lblOrderCount = new System.Windows.Forms.Label();

            this.lblEmployeeTitle = new System.Windows.Forms.Label();
            this.lblEmployeeCount = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // SIDEBAR
            this.pnlSidebar.BackColor =
                System.Drawing.Color.FromArgb(30, 60, 114);

            this.pnlSidebar.Dock =
                System.Windows.Forms.DockStyle.Left;

            this.pnlSidebar.Size =
                new System.Drawing.Size(220, 700);

            // LOGO
            this.lblLogo.Text = "PHONE SHOP";
            this.lblLogo.ForeColor = System.Drawing.Color.White;

            this.lblLogo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    17F,
                    System.Drawing.FontStyle.Bold);

            this.lblLogo.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            this.lblLogo.Location =
                new System.Drawing.Point(0, 20);

            this.lblLogo.Size =
                new System.Drawing.Size(220, 60);

            this.pnlSidebar.Controls.Add(this.lblLogo);

            // DASHBOARD BUTTON
            SetupMenuButton(
                this.btnDashboard,
                "Dashboard",
                100);

            // PRODUCTS
            SetupMenuButton(
                this.btnProducts,
                "Products",
                150);

            // BRANDS
            SetupMenuButton(
                this.btnBrands,
                "Brands",
                200);

            // CUSTOMERS
            SetupMenuButton(
                this.btnCustomers,
                "Customers",
                250);

            // EMPLOYEES
            SetupMenuButton(
                this.btnEmployees,
                "Employees",
                300);

            // ORDERS
            SetupMenuButton(
                this.btnOrders,
                "Orders",
                350);

            // ORDER DETAILS
            SetupMenuButton(
                this.btnOrderDetails,
                "Order Details",
                400);

            // PAYMENTS
            SetupMenuButton(
                this.btnPayments,
                "Payments",
                450);

            // INVENTORY
            SetupMenuButton(
                this.btnInventory,
                "Inventory",
                500);

            // LOGOUT
            SetupMenuButton(
                this.btnLogout,
                "Logout",
                610);

            this.btnLogout.BackColor =
                System.Drawing.Color.FromArgb(192, 57, 43);

            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.btnProducts);
            this.pnlSidebar.Controls.Add(this.btnBrands);
            this.pnlSidebar.Controls.Add(this.btnCustomers);
            this.pnlSidebar.Controls.Add(this.btnEmployees);
            this.pnlSidebar.Controls.Add(this.btnOrders);
            this.pnlSidebar.Controls.Add(this.btnOrderDetails);
            this.pnlSidebar.Controls.Add(this.btnPayments);
            this.pnlSidebar.Controls.Add(this.btnInventory);
            this.pnlSidebar.Controls.Add(this.btnLogout);

            // HEADER
            this.pnlHeader.BackColor =
                System.Drawing.Color.White;

            this.pnlHeader.Location =
                new System.Drawing.Point(220, 0);

            this.pnlHeader.Size =
                new System.Drawing.Size(980, 70);

            this.pnlHeader.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.lblHeader.Text =
                "PHONE SHOP MANAGEMENT SYSTEM";

            this.lblHeader.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    16F,
                    System.Drawing.FontStyle.Bold);

            this.lblHeader.ForeColor =
                System.Drawing.Color.FromArgb(30, 60, 114);

            this.lblHeader.Location =
                new System.Drawing.Point(30, 17);

            this.lblHeader.Size =
                new System.Drawing.Size(500, 40);

            this.lblUser.Text = "Administrator";

            this.lblUser.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.lblUser.TextAlign =
                System.Drawing.ContentAlignment.MiddleRight;

            this.lblUser.Location =
                new System.Drawing.Point(750, 20);

            this.lblUser.Size =
                new System.Drawing.Size(190, 30);

            this.lblUser.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;

            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.lblUser);

            // CONTENT
            this.pnlContent.BackColor =
                System.Drawing.Color.FromArgb(240, 242, 245);

            this.pnlContent.Location =
                new System.Drawing.Point(220, 70);

            this.pnlContent.Size =
                new System.Drawing.Size(980, 630);

            this.pnlContent.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            // DASHBOARD TITLE
            this.lblDashboard.Text = "Dashboard";

            this.lblDashboard.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    24F,
                    System.Drawing.FontStyle.Bold);

            this.lblDashboard.ForeColor =
                System.Drawing.Color.FromArgb(45, 45, 45);

            this.lblDashboard.Location =
                new System.Drawing.Point(40, 30);

            this.lblDashboard.Size =
                new System.Drawing.Size(300, 50);

            this.pnlContent.Controls.Add(this.lblDashboard);

            // PRODUCT CARD
            SetupCard(
                this.pnlProductCard,
                40,
                110);

            this.lblProductTitle.Text = "PRODUCTS";
            SetupCardTitle(this.lblProductTitle);

            this.lblProductCount.Text = "7";
            SetupCardNumber(this.lblProductCount);

            this.pnlProductCard.Controls.Add(
                this.lblProductTitle);

            this.pnlProductCard.Controls.Add(
                this.lblProductCount);

            // CUSTOMER CARD
            SetupCard(
                this.pnlCustomerCard,
                270,
                110);

            this.lblCustomerTitle.Text = "CUSTOMERS";
            SetupCardTitle(this.lblCustomerTitle);

            this.lblCustomerCount.Text = "7";
            SetupCardNumber(this.lblCustomerCount);

            this.pnlCustomerCard.Controls.Add(
                this.lblCustomerTitle);

            this.pnlCustomerCard.Controls.Add(
                this.lblCustomerCount);

            // ORDER CARD
            SetupCard(
                this.pnlOrderCard,
                500,
                110);

            this.lblOrderTitle.Text = "ORDERS";
            SetupCardTitle(this.lblOrderTitle);

            this.lblOrderCount.Text = "8";
            SetupCardNumber(this.lblOrderCount);

            this.pnlOrderCard.Controls.Add(
                this.lblOrderTitle);

            this.pnlOrderCard.Controls.Add(
                this.lblOrderCount);

            // EMPLOYEE CARD
            SetupCard(
                this.pnlEmployeeCard,
                730,
                110);

            this.lblEmployeeTitle.Text = "EMPLOYEES";
            SetupCardTitle(this.lblEmployeeTitle);

            this.lblEmployeeCount.Text = "5";
            SetupCardNumber(this.lblEmployeeCount);

            this.pnlEmployeeCard.Controls.Add(
                this.lblEmployeeTitle);

            this.pnlEmployeeCard.Controls.Add(
                this.lblEmployeeCount);

            this.pnlContent.Controls.Add(
                this.pnlProductCard);

            this.pnlContent.Controls.Add(
                this.pnlCustomerCard);

            this.pnlContent.Controls.Add(
                this.pnlOrderCard);

            this.pnlContent.Controls.Add(
                this.pnlEmployeeCard);

            // MAIN FORM
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(1200, 700);

            this.MinimumSize =
                new System.Drawing.Size(1100, 700);

            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Phone Shop Management System";

            this.WindowState =
                System.Windows.Forms.FormWindowState.Maximized;

            this.ResumeLayout(false);
        }

        private void SetupMenuButton(
            System.Windows.Forms.Button button,
            string text,
            int y)
        {
            button.Text = text;

            button.Location =
                new System.Drawing.Point(0, y);

            button.Size =
                new System.Drawing.Size(220, 50);

            button.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            button.FlatAppearance.BorderSize = 0;

            button.BackColor =
                System.Drawing.Color.FromArgb(30, 60, 114);

            button.ForeColor =
                System.Drawing.Color.White;

            button.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            button.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            button.Padding =
                new System.Windows.Forms.Padding(25, 0, 0, 0);

            button.Cursor =
                System.Windows.Forms.Cursors.Hand;
        }

        private void SetupCard(
            System.Windows.Forms.Panel panel,
            int x,
            int y)
        {
            panel.Location =
                new System.Drawing.Point(x, y);

            panel.Size =
                new System.Drawing.Size(200, 130);

            panel.BackColor =
                System.Drawing.Color.White;

            panel.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void SetupCardTitle(
            System.Windows.Forms.Label label)
        {
            label.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            label.ForeColor =
                System.Drawing.Color.Gray;

            label.Location =
                new System.Drawing.Point(15, 15);

            label.Size =
                new System.Drawing.Size(170, 30);
        }

        private void SetupCardNumber(
            System.Windows.Forms.Label label)
        {
            label.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    28F,
                    System.Drawing.FontStyle.Bold);

            label.ForeColor =
                System.Drawing.Color.FromArgb(30, 60, 114);

            label.Location =
                new System.Drawing.Point(15, 50);

            label.Size =
                new System.Drawing.Size(170, 60);
        }
    }
}