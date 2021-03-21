using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterLeft.OfferForms
{
    public partial class LoginOffer : Form
    {
        public LoginOffer()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "offer" && txtpassword.Text == "12345")
            {
                // anasayfa.ActiveForm.Visible = false;
                Offer offer = new Offer();
                offer.ShowDialog();
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
            LoginOffer.ActiveForm.Visible = false;
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
        }

        private void LoginOffer_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();

        }
    }
}
