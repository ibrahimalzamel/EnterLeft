using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterLeft.SettingsForms
{
    public partial class LoginSettings : Form
    {
        public LoginSettings()
        {
            InitializeComponent();
        }

       

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtpassword.Clear();
            txtUserName.Clear();
            txtUserName.Focus();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            LoginSettings.ActiveForm.Visible = false;
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (txtUserName.Text == "settings" && txtpassword.Text == "12345")
            {
                // anasayfa.ActiveForm.Visible = false;
                // LoginSettings.ActiveForm.Visible = false;
                Settings setting = new Settings();
                setting.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("The User name or password you entered is incorrect, try again");
                txtpassword.Clear();
                txtUserName.Clear();
                txtUserName.Focus();
            }
        }
    }
}
