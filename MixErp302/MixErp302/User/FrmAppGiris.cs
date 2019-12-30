using MixErp302.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixErp302.User
{
    public partial class FrmAppGiris : Form
    {
        MixErpDbEntities1 db = new MixErpDbEntities1();

        public FrmAppGiris()
        {
            InitializeComponent();
        }

        private void FrmAppGiris_Load(object sender, EventArgs e)
        {

        }
        void GirisKontrol() //databasede kullanıcı var mı diye bakmam lazım
        {
            try
            {
                int srg = (from s in db.tblUsers
                           where s.KulAdi == txtKulAdi.Text && s.Sifre == txtSifre.Text
                           select s).First().Id; //Id yi getirsin.
                if (srg > 0) //ana sayfaya aktarsın diye
                {
                    frmAnaSayfa ana = new frmAnaSayfa();
                    ana.WindowState = FormWindowState.Maximized;
                    ana.roleId = db.tblUsers.Find(srg).Role.Value; //ÖĞREN!!!!!!!!
                    ana.Show();
                    //this.Hide();
                    Hide();
                }
                else
                {
                    MessageBox.Show("NAPTIN KRALLLLL HATALISIN");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("NAPTIN KRALLLLL HATALISIN");
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            GirisKontrol();
            
        }
    }
}
