using EnterLeft.AdminForms;
using EnterLeft.MekaKontrolForms;
using EnterLeft.SettingsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using EnterLeft.OfferForms;
using EnterLeft.SAForms;
using EnterLeft.FaturaForms;
using EnterLeft.MusterilerForms;
using EnterLeft.EtiketForms;

namespace EnterLeft
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {

           // anasayfa.ActiveForm.Visible = false;
            LoginAdmin loginAdmin = new LoginAdmin();
            loginAdmin.ShowDialog();
            this.Hide();
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            //anasayfa.ActiveForm.Visible = false;
            LoginSettings loginsettings = new LoginSettings();
            loginsettings.ShowDialog();
            this.Hide();
        }
        private void btnOffer_Click(object sender, EventArgs e)
        {
           // anasayfa.ActiveForm.Visible = false;
            LoginOffer loginoffer = new LoginOffer();
            loginoffer.ShowDialog();
            this.Hide();
        }

        private void btnSA_Click(object sender, EventArgs e)
        {
            //anasayfa.ActiveForm.Visible = false;
            LoginSA loginsa = new LoginSA();
            loginsa.ShowDialog();
            this.Hide();
        }

        private void btnMekaKontrol_Click(object sender, EventArgs e)
        {
            //anasayfa.ActiveForm.Visible = false;
            LoginMekaKontrol loginmekaKontrol = new LoginMekaKontrol();
            loginmekaKontrol.ShowDialog();
            this.Hide();
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {
            //anasayfa.ActiveForm.Visible = false;
            LoginFatura loginfatura = new LoginFatura();
            loginfatura.ShowDialog();
            this.Hide();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            //anasayfa.ActiveForm.Visible = false;
            LoginMusteriler loginmusteriler = new LoginMusteriler();
            loginmusteriler.ShowDialog();
            this.Hide();
        }

        private void btnEtiket_Click(object sender, EventArgs e)
        {
            //anasayfa.ActiveForm.Visible = false;
            LoginEtiket loginetiket = new LoginEtiket();
            loginetiket.ShowDialog();
            this.Hide();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            bool Check = NetworkInterface.GetIsNetworkAvailable();
            if (Check==false)
            {
                MessageBox.Show("intente bağli değil lütfen internte bağlnti kontrol et sonra bir daha giriş yap");
            }
            else
            {
                if (this.Enabled == false)
                {
                    this.Enabled = true;
                }
            }
        }
    }
}
