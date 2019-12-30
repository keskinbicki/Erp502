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
    
    public partial class FrmKulGiris : Form
    {
        MixErpDbEntities1 db = new MixErpDbEntities1();
        int secimId = -1;
        bool edit = false;
        public FrmKulGiris()
        {
            InitializeComponent();
        }

        private void FrmKulGiris_Load(object sender, EventArgs e)
        {
            
            Listele();
            txtRole.SelectedIndex = -1;
        }

        private void Listele()
        {
            liste.Rows.Clear();
            int i = 0;
            var lst = (from s in db.tblUsers
                       select s).ToList();
            foreach(var k in lst)
            {
                liste.Rows.Add();
                liste.Rows[i].Cells[0].Value = k.Id;
                liste.Rows[i].Cells[1].Value = k.KulAdi;
                liste.Rows[i].Cells[2].Value = k.Sifre;
                liste.Rows[i].Cells[3].Value = k.Role;
                i++;

            }
            liste.AllowUserToAddRows = false;
        }

        private void YeniKaydet()
        {
            tblUser user = new tblUser();
            user.KulAdi = txtKullaniciAdi.Text;
            user.Sifre = txtSifre.Text;
            user.Role = txtRole.SelectedIndex;

            db.tblUsers.Add(user);
            db.SaveChanges();

            MessageBox.Show("Kayıt Başarılı.");

            Listele();
            Temizle();
        }

        private void Temizle()
        {
            foreach (Control con in split2.Panel1.Controls)
            {
                if (con is TextBox || con is ComboBox || con is DateTimePicker)
                {
                    con.Text = "";
                }
                
                secimId = -1;
                edit = false;
                txtRole.SelectedIndex = 0;
            }
        }
        void Guncelle()
        {
            tblUser user = db.tblUsers.Find(secimId); //bilr bunu
            user.KulAdi = txtKullaniciAdi.Text;
            user.Sifre = txtSifre.Text;
            user.Role = txtRole.SelectedIndex;

            
            db.SaveChanges();

            MessageBox.Show("Güncelleme Başarılı.");

            Listele();
            Temizle();
        }

        private void liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secimId > 0)
            {
                Ac(secimId);
            }
        }

        private void Ac(int secimId)
        {
            edit = true; 
            tblUser user = db.tblUsers.Find(secimId);
            txtKullaniciAdi.Text = user.KulAdi;              
            txtSifre.Text = user.Sifre;
            for (int i = 0; i < txtRole.Items.Count; i++)
            {
                if(user.Role==i)
                {
                    txtRole.SelectedIndex = i;
                }

            }   
            
        }

        private void Sec()
        {
            try
            {
                secimId = Convert.ToInt32(liste.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                secimId = -1;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (edit && secimId > 0)
            {
                Sil();
            }
        }

        private void Sil()
        {
            if (txtKullaniciAdi.Text!="" && secimId!=-1)
            {
                db.tblUsers.Remove(db.tblUsers.Find(secimId));
                db.SaveChanges();
                MessageBox.Show($"{secimId}'nolu kayıt silinmiştir.");
                Listele();
                Temizle(); 
            }
            else
            {
                MessageBox.Show("İlk olarak listeden kayıt seçiniz.");
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnkaydett_Click(object sender, EventArgs e)
        {
            if (edit && secimId > 0) Guncelle();
            else if (edit == false) YeniKaydet();
        }

        
    }
}
