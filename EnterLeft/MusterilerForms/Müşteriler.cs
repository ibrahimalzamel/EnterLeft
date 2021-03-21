using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete.MusterilerClass;
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
    public partial class MusterilerForm : Form
    {
        public MusterilerForm()
        {
            InitializeComponent();
        }

      
        private void Musteriler_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                db.Musteriler.Add(new Musteriler
                {
                    Address = "addr",
                    CompanyName = "com",
                    MusteriName = "name",
                    Country = "con",
                    MusteriKodID = 53543,
                    Telefon = "asdfasdf",
                    Email = "aksfkl",
                    DestenationPort = "asdflkjasdf"
                });
            }
            
            //MusterilerManager musteriler = new MusterilerManager(new EfMusterilerDal());
            //if (txtMusteriID.Text!=""&& txtName.Text!=""&& txtCompanyName.Text!=""&& txtTelefon.Text!="" && txtAddress.Text!=""&& txtDestenationPort.Text!="" && txtCountry.Text!=""&& txtMail.Text!=""&& txtMusteriID.Text!="")
            //{
            //    musteriler.Add(new Musteriler
            //    {
            //        MusteriID = txtMusteriID.Text,
            //        MusteriName = txtName.Text,
            //        CompanyName = txtCompanyName.Text,
            //        Telefon = txtTelefon.Text,
            //        Address = txtAddress.Text,
            //        DestenationPort = txtDestenationPort.Text,
            //        Country = txtCountry.Text,
            //        Email = txtMail.Text,
            //        MusteriKodID = Convert.ToInt32(txtMusteriID.Text)

            //    });
            //}
            //else
            //{
            //    MessageBox.Show("bilgileriniz eksik var lütfen kontrul edein sonra tekrar deneyiniz...");
           
            //}
          
            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            //MusterilerManager musteriler = new MusterilerManager(new EfMusterilerDal());
            //musteriler.Delete(new Musteriler
            //{
            //    MusteriID = txtMusteriID.Text,
            //    MusteriName = txtName.Text,
            //    CompanyName = txtCompanyName.Text,
            //    Telefon = txtTelefon.Text,
            //    Address = txtAddress.Text,
            //    DestenationPort = txtDestenationPort.Text,
            //    Country = txtCountry.Text,
            //    Email = txtMail.Text,
            //    MusteriKodID = Convert.ToInt32(txtMusteriID.Text)

            //});
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            //MusterilerManager musteriler = new MusterilerManager(new EfMusterilerDal());
            //musteriler.Update(new Musteriler
            //{
            //    MusteriID = txtMusteriID.Text,
            //    MusteriName = txtName.Text,
            //    CompanyName = txtCompanyName.Text,
            //    Telefon = txtTelefon.Text,
            //    Address = txtAddress.Text,
            //    DestenationPort = txtDestenationPort.Text,
            //    Country = txtCountry.Text,
            //    Email = txtMail.Text,
            //    MusteriKodID = Convert.ToInt32(txtMusteriID.Text)

            //});
        }
    }
}
