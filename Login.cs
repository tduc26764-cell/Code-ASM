using System;
using System.Windows.Forms;

namespace code_ko_keo_tha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Please enter username.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUsername.Focus();
                return;
            }

            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Please enter password.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();
                return;
            }

            if (txtUsername.Text == "admin" &&
    txtPassword.Text == "123")
            {
                MainForm mainForm = new MainForm();

                this.Hide();

                mainForm.ShowDialog();

                this.Show();

                txtPassword.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to exit?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}