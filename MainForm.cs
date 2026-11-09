using System;
using System.Windows.Forms;

namespace code_ko_keo_tha
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            btnDashboard.Click += btnDashboard_Click;
            btnProducts.Click += btnProducts_Click;
            btnBrands.Click += btnBrands_Click;
            btnCustomers.Click += btnCustomers_Click;
            btnEmployees.Click += btnEmployees_Click;
            btnOrders.Click += btnOrders_Click;
            btnOrderDetails.Click += btnOrderDetails_Click;
            btnPayments.Click += btnPayments_Click;
            btnInventory.Click += btnInventory_Click;
            btnLogout.Click += btnLogout_Click;
        }

        private void btnDashboard_Click(
            object sender, EventArgs e)
        {
            MessageBox.Show("Dashboard");
        }

        private void btnProducts_Click(
    object sender,
    EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
        }

        private void btnBrands_Click(
    object sender,
    EventArgs e)
        {
            BrandForm brandForm = new BrandForm();
            brandForm.ShowDialog();
        }

        private void btnCustomers_Click(
    object sender,
    EventArgs e)
        {
            CustomerForm customerForm =
                new CustomerForm();

            customerForm.ShowDialog();
        }

        private void btnEmployees_Click(
    object sender,
    EventArgs e)
        {
            EmployeeForm employeeForm =
                new EmployeeForm();

            employeeForm.ShowDialog();
        }

        private void btnOrders_Click(
     object sender,
     EventArgs e)
        {
            OrderForm orderForm =
                new OrderForm();

            orderForm.ShowDialog();
        }

        private void btnOrderDetails_Click(
    object sender,
    EventArgs e)
        {
            OrderDetailForm orderDetailForm =
                new OrderDetailForm();

            orderDetailForm.ShowDialog();
        }

        private void btnPayments_Click(
    object sender,
    EventArgs e)
        {
            PaymentForm paymentForm =
                new PaymentForm();

            paymentForm.ShowDialog();
        }

        private void btnInventory_Click(
    object sender,
    EventArgs e)
        {
            InventoryForm inventoryForm =
                new InventoryForm();

            inventoryForm.ShowDialog();
        }

        private void btnLogout_Click(
            object sender, EventArgs e)
        {
            this.Close();
        }
    }
}