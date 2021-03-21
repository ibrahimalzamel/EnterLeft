using EnterLeft.EtiketForms;
using EnterLeft.FaturaForms;
using EnterLeft.MekaKontrolForms;
using EnterLeft.MusterilerForms;
using EnterLeft.OfferForms;
using EnterLeft.SAForms;
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

namespace EnterLeft

{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin.ActiveForm.Visible = false;
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
        }

        private void btnOffer_Click(object sender, EventArgs e)
        {
            //Admin.ActiveForm.Visible = false;
            Offer offer = new Offer();
            offer.ShowDialog();
        }

        private void btnSA_Click(object sender, EventArgs e)
        {
            //Admin.ActiveForm.Visible = false;
            SA sa = new SA();
            sa.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //Admin.ActiveForm.Visible = false;
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void btnMekaKontrol_Click(object sender, EventArgs e)
        {
           // Admin.ActiveForm.Visible = false;
            MekaKontrol mekaKontrol = new MekaKontrol();
            mekaKontrol.ShowDialog();
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {
            //Admin.ActiveForm.Visible = false;
            Fatura fatura = new Fatura();
            fatura.ShowDialog();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
           // Admin.ActiveForm.Visible = false;
            MusterilerForm musteriler = new MusterilerForm();
            musteriler.ShowDialog();
        }

        private void btnEtiket_Click(object sender, EventArgs e)
        {
           // Admin.ActiveForm.Visible = false;
            Etiket etiket = new Etiket();
            etiket.ShowDialog();

        }

    }
}
