using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace code_ko_keo_tha
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();

            this.Load += PaymentForm_Load;

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;

            dgvPayments.CellClick += dgvPayments_CellClick;
            cboOrder.SelectedIndexChanged += cboOrder_SelectedIndexChanged;
        }

        // FORM LOAD
        private void PaymentForm_Load(
            object sender,
            EventArgs e)
        {
            LoadOrders();
            LoadPayments();

            cboOrder.SelectedIndex = -1;
            cboMethod.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;
        }

        // LOAD ORDERS
        private void LoadOrders()
        {
            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        SELECT
                            Order_ID,
                            Total_Amount,
                            'Order #' + CAST(Order_ID AS VARCHAR(20))
                            AS Order_Display
                        FROM Sale_Order
                        ORDER BY Order_ID";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, con);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    cboOrder.DataSource = dt;
                    cboOrder.DisplayMember = "Order_Display";
                    cboOrder.ValueMember = "Order_ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cannot load orders.\n" +
                    ex.Message);
            }
        }

        // LOAD PAYMENTS
        private void LoadPayments()
        {
            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        SELECT
                            Payment_ID,
                            Order_ID,
                            Payment_Date,
                            Payment_Method,
                            Amount,
                            Payment_Status
                        FROM Payment
                        ORDER BY Payment_ID";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, con);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvPayments.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database error:\n" +
                    ex.Message);
            }
        }

        // AUTO GET ORDER TOTAL
        private void cboOrder_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cboOrder.SelectedIndex == -1)
                return;

            DataRowView row =
                cboOrder.SelectedItem as DataRowView;

            if (row != null &&
                row["Total_Amount"] != DBNull.Value)
            {
                txtAmount.Text =
                    Convert.ToDecimal(
                        row["Total_Amount"])
                    .ToString("0.##");
            }
        }

        // ADD
        private void btnAdd_Click(
            object sender,
            EventArgs e)
        {
            int paymentID;
            decimal amount;

            if (!int.TryParse(
                txtPaymentID.Text.Trim(),
                out paymentID))
            {
                MessageBox.Show(
                    "Payment ID must be a number.");

                return;
            }

            if (cboOrder.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select an Order.");

                return;
            }

            if (cboMethod.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select Payment Method.");

                return;
            }

            if (!decimal.TryParse(
                txtAmount.Text.Trim(),
                out amount))
            {
                MessageBox.Show(
                    "Amount must be a number.");

                return;
            }

            if (cboStatus.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select Payment Status.");

                return;
            }

            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        INSERT INTO Payment
                        (
                            Payment_ID,
                            Order_ID,
                            Payment_Date,
                            Payment_Method,
                            Amount,
                            Payment_Status
                        )
                        VALUES
                        (
                            @Payment_ID,
                            @Order_ID,
                            @Payment_Date,
                            @Method,
                            @Amount,
                            @Status
                        )";

                    SqlCommand cmd =
                        new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue(
                        "@Payment_ID",
                        paymentID);

                    cmd.Parameters.AddWithValue(
                        "@Order_ID",
                        cboOrder.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@Payment_Date",
                        dtpPaymentDate.Value.Date);

                    cmd.Parameters.AddWithValue(
                        "@Method",
                        cboMethod.Text);

                    cmd.Parameters.AddWithValue(
                        "@Amount",
                        amount);

                    cmd.Parameters.AddWithValue(
                        "@Status",
                        cboStatus.Text);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Payment added successfully.");

                LoadPayments();
                ClearFields();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 ||
                    ex.Number == 2601)
                {
                    MessageBox.Show(
                        "This Payment ID or Order already has a payment.",
                        "Duplicate Payment",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(
                        "Cannot add payment.\n\n" +
                        ex.Message);
                }
            }
        }

        // UPDATE
        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            int paymentID;
            decimal amount;

            if (!int.TryParse(
                txtPaymentID.Text.Trim(),
                out paymentID))
            {
                MessageBox.Show(
                    "Please select a Payment.");

                return;
            }

            if (cboOrder.SelectedIndex == -1 ||
                cboMethod.SelectedIndex == -1 ||
                cboStatus.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please complete all payment information.");

                return;
            }

            if (!decimal.TryParse(
                txtAmount.Text.Trim(),
                out amount))
            {
                MessageBox.Show(
                    "Amount must be a number.");

                return;
            }

            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        UPDATE Payment
                        SET
                            Order_ID = @Order_ID,
                            Payment_Date = @Payment_Date,
                            Payment_Method = @Method,
                            Amount = @Amount,
                            Payment_Status = @Status
                        WHERE Payment_ID = @Payment_ID";

                    SqlCommand cmd =
                        new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue(
                        "@Payment_ID",
                        paymentID);

                    cmd.Parameters.AddWithValue(
                        "@Order_ID",
                        cboOrder.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@Payment_Date",
                        dtpPaymentDate.Value.Date);

                    cmd.Parameters.AddWithValue(
                        "@Method",
                        cboMethod.Text);

                    cmd.Parameters.AddWithValue(
                        "@Amount",
                        amount);

                    cmd.Parameters.AddWithValue(
                        "@Status",
                        cboStatus.Text);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Payment updated successfully.");

                LoadPayments();
                ClearFields();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 ||
                    ex.Number == 2601)
                {
                    MessageBox.Show(
                        "The selected Order already has another payment.",
                        "Duplicate Payment",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // DELETE
        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            int paymentID;

            if (!int.TryParse(
                txtPaymentID.Text.Trim(),
                out paymentID))
            {
                MessageBox.Show(
                    "Please select a Payment.");

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Do you want to delete this payment?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection con =
                    DatabaseConnection.GetConnection())
                {
                    string sql = @"
                        DELETE FROM Payment
                        WHERE Payment_ID = @Payment_ID";

                    SqlCommand cmd =
                        new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue(
                        "@Payment_ID",
                        paymentID);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Payment deleted successfully.");

                LoadPayments();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cannot delete payment.\n\n" +
                    ex.Message);
            }
        }

        // CLICK ROW
        private void dgvPayments_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvPayments.Rows[e.RowIndex];

            txtPaymentID.Text =
                row.Cells["Payment_ID"]
                    .Value.ToString();

            cboOrder.SelectedValue =
                row.Cells["Order_ID"].Value;

            if (row.Cells["Payment_Date"].Value != DBNull.Value)
            {
                dtpPaymentDate.Value =
                    Convert.ToDateTime(
                        row.Cells["Payment_Date"].Value);
            }

            cboMethod.Text =
                row.Cells["Payment_Method"]
                    .Value.ToString();

            txtAmount.Text =
                row.Cells["Amount"]
                    .Value.ToString();

            cboStatus.Text =
                row.Cells["Payment_Status"]
                    .Value.ToString();

            txtPaymentID.ReadOnly = true;
        }

        // CLEAR
        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtPaymentID.Clear();

            cboOrder.SelectedIndex = -1;

            dtpPaymentDate.Value =
                DateTime.Today;

            cboMethod.SelectedIndex = -1;

            txtAmount.Clear();

            cboStatus.SelectedIndex = -1;

            txtPaymentID.ReadOnly = false;

            txtPaymentID.Focus();
        }
    }
}