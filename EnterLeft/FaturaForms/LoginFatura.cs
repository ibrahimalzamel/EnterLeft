using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterLeft.FaturaForms
{
    public partial class LoginFatura : Form
    {
        public LoginFatura()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "fatura" && txtpassword.Text == "12345")
            {
                // anasayfa.ActiveForm.Visible = false;
                Fatura fatura = new Fatura();
                fatura.ShowDialog();
                // this.Hide();
            }
            else
            {
                MessageBox.Show("The User name or password you entered is incorrect, try again");
                txtpassword.Clear();
                txtUserName.Clear();
                txtUserName.Focus();
            }
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtpassword.Clear();
            txtUserName.Clear();
            txtUserName.Focus();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            LoginFatura.ActiveForm.Visible = false;
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
        }
    }
}
