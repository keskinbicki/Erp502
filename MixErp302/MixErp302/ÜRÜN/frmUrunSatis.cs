﻿using MixErp302.Data;
using MixErp302.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixErp302.Urun
{
    public partial class frmUrunSatis : Form
    {

        MixErpDbEntities1 db = new MixErpDbEntities1();


        Numaralar N = new Numaralar();
        
        bool edit = false;

        public int UrnSatisId { get; private set; }

        public string[] MyArray { get; set; }
        public frmUrunSatis()
        {
            InitializeComponent();
        }

        private void frmUrunSatis_Load(object sender, EventArgs e)
        {
            txtSatisGrupNo.Text = N.SatisGrupNo();
            Combo();
            txtKarOran.SelectedIndex = 0;
        }

        private void Combo()
        {
            txtCari.AutoCompleteSource = AutoCompleteSource.CustomSource; //e yazdığımda emre çıksın diye
            txtCari.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection veri = new AutoCompleteStringCollection();
            var lst = db.TblCaris.Select(x => x.CariAdi).Distinct();
            foreach (var cari in lst)
            {
                veri.Add(cari);
                txtCari.Items.Add(cari);
            }
            txtCari.AutoCompleteCustomSource = veri;
            //7.işlem=> Ödeme tipi için combobox doldur.

            txtOdemeTuru.DataSource = db.bOdemeTurleris.ToList();
            txtOdemeTuru.ValueMember = "Id";
            txtOdemeTuru.DisplayMember = "OdemeTipi";

            //8.işlem
            var srg = db.tblUrunlers.Select(x => x.UrunKodu); //Öğrennnnnnnnnnnnn
            foreach (var k in srg)
            {
                txtUrunKodu.Items.Add(k);
            }

            //10. işlem
            int dgv;
            dgv = txtUrunKodu.Items.Count;
            MyArray = new string[dgv];

            for (int i = 0; i < dgv; i++)
            {
                MyArray[i] = txtUrunKodu.Items[i].ToString();
            }



        }

        private void liste_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;
            if (liste.CurrentCell.ColumnIndex == 0 && txt != null)
            {
                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt.AutoCompleteCustomSource.AddRange(MyArray);

            }
            else if (liste.CurrentCell.ColumnIndex != 0 && txt != null)
            {
                txt.AutoCompleteMode = AutoCompleteMode.None;
            }
        }

        private void liste_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string a = liste.CurrentRow.Cells[0].Value.ToString();
                var lst = (from s in db.tblUrunlers
                           where s.UrunKodu == a
                           select s).First();

                liste.CurrentRow.Cells[1].Value = lst.UrunAciklama;
                liste.CurrentRow.Cells[2].Value = lst.bBirim.BirimAdi;
                liste.CurrentRow.Cells[3].Value = db.tblStokDurums.First(x => x.UrunId == lst.Id).OBFiyat;
                liste.CurrentRow.Cells[8].Value = db.tblStokDurums.First(x => x.UrunId == lst.Id).Raf;

                decimal bFiyat = Convert.ToDecimal(liste.CurrentRow.Cells[3].Value);
                int karOrn = Convert.ToInt32(txtKarOran.Text);
                liste.CurrentRow.Cells[4].Value = bFiyat + (bFiyat * karOrn) / 100; //aynısı aşağıdakiyle

                //liste.CurrentRow.Cells[4].Value = Convert.ToDecimal(liste.CurrentRow.Cells[3].Value) + (Convert.ToDecimal(liste.CurrentRow.Cells[3].Value) * Convert.ToInt32(txtKarOran.Text))/100;

            }
            if (e.ColumnIndex == 5)
            {
                if (liste.CurrentRow.Cells[4].Value != null)
                {
                    Rowhesapla();
                }
                
            }
            if (e.ColumnIndex == 4)
            {
                if (liste.CurrentRow.Cells[5].Value != null)
                {
                    Rowhesapla();
                }
            }
        }

        private void Rowhesapla()
        {
            if (liste.CurrentRow.Cells[4].Value != null && liste.CurrentRow.Cells[5].Value != null)
            {
                decimal a, b;
                a = Convert.ToDecimal(liste.CurrentRow.Cells[4].Value.ToString());
                b = Convert.ToDecimal(liste.CurrentRow.Cells[5].Value.ToString());
                liste.CurrentRow.Cells[6].Value = a * b * 0.18M;     //Decimal yapmak içim M koyduk F koyarsak float.   //cell[3]*cell[4] 

                decimal atop = 0;
                decimal ktop = 0;
                decimal gtop = 0;

                for (int i = 0; i < liste.RowCount; i++)
                {
                    atop += (Convert.ToDecimal(liste.Rows[i].Cells[4].Value) * Convert.ToDecimal(liste.Rows[i].Cells[5].Value)); //bunu bil!!!
                    ktop += Convert.ToDecimal(liste.Rows[i].Cells[6].Value);
                }
                gtop = atop + ktop;
                txtAraToplam.Text = atop.ToString();
                txtKdvToplam.Text = ktop.ToString();
                txtGenelToplam.Text = gtop.ToString();
            }
            else
            {
                MessageBox.Show("Adam gibi değer gir.");
                liste.CurrentRow.Cells[6].Value = "";
            }


        }
        bool KayitKont=false;
        void YeniKaydet()
        {
            for (int i = 0; i < liste.RowCount; i++)
            {
                if (Convert.ToInt32(liste.Rows[i].Cells[5].Value) > Convert.ToInt32(liste.Rows[i].Cells[8].Value)) //stok adedinden sonra yaptık.Stok yoksa sattırmasın
                {
                    MessageBox.Show("Yeterli ürün adedi yoktur.Stok adedini kontrol ediniz.");
                    KayitKont = true;
                    liste.Rows[i].Cells[5].Style.BackColor = Color.Red;
                    liste.Rows[i].Cells[5].Style.ForeColor = Color.White;
                }
                else
                {
                    liste.Rows[i].Cells[5].Style.BackColor = Color.Empty;
                    liste.Rows[i].Cells[5].Style.ForeColor = DefaultForeColor;
                }
            }
            if(KayitKont)
            {
                KayitKont = false;
                return;
            }

            var srch = new tblUrunSatisUst();
            srch.SatisGrupNo = txtSatisGrupNo.Text;
            srch.AraToplam = Convert.ToDecimal(txtAraToplam.Text);
            srch.STarih = Convert.ToDateTime(txtSTarih.Text);
            srch.Durum = false;
            srch.CariId = db.TblCaris.First(x => x.CariAdi == txtCari.Text).Id;
            srch.Vade = Convert.ToInt32(txtVade.Text);
            srch.OdemeId = db.bOdemeTurleris.First(x => x.OdemeTipi == txtOdemeTuru.Text).Id;
            srch.KdvToplam = Convert.ToDecimal(txtKdvToplam.Text);
            srch.GenelToplam = Convert.ToDecimal(txtGenelToplam.Text);

            db.tblUrunSatisUsts.Add(srch);
            db.SaveChanges();
            liste.AllowUserToAddRows = false;




            tblUrunSatisAlt[] ualt = new tblUrunSatisAlt[liste.RowCount];
            for (int i = 0; i < liste.RowCount; i++)
            {
                ualt[i] = new tblUrunSatisAlt();
                ualt[i].Miktar = Convert.ToInt32(liste.Rows[i].Cells[5].Value.ToString());
                ualt[i].SatisGrupNo = txtSatisGrupNo.Text;
                ualt[i].BirimFiyat = Convert.ToDecimal(liste.Rows[i].Cells[3].Value.ToString());
                ualt[i].SatisFiyat = Convert.ToDecimal(liste.Rows[i].Cells[4].Value.ToString());
                string brm = liste.Rows[i].Cells[2].Value.ToString();
                ualt[i].BirimId = db.bBirims.First(x => x.BirimAdi == brm).Id;
                string urn = liste.Rows[i].Cells[1].Value.ToString();
                ualt[i].UrunId = db.tblUrunlers.First(x => x.UrunAciklama == urn).Id;
                ualt[i].AToplam = Convert.ToDecimal(liste.Rows[i].Cells[4].Value) * Convert.ToDecimal(liste.Rows[i].Cells[5].Value);
                ualt[i].Kdv = Convert.ToDecimal(liste.Rows[i].Cells[6].Value);


                db.tblUrunSatisAlts.Add(ualt[i]);

                string ubarkod = liste.Rows[i].Cells[0].Value.ToString() + "/" + liste.Rows[i].Cells[1].Value.ToString(); //stoktan sonra yaptık.
                var sKontrol = db.tblStokDurums.First(x => x.Barkod == ubarkod);
                sKontrol.Ambar += 0;
                sKontrol.Depo -= Convert.ToInt32(liste.Rows[i].Cells[5].Value.ToString());
                sKontrol.Raf -= Convert.ToInt32(liste.Rows[i].Cells[5].Value.ToString());


            }
            db.SaveChanges();
            MessageBox.Show("Başarıyla Kaydedildi.");
        }
        void Guncelle()
        {
            /*var srch = new tblUrunSatisUst();*/ /*böyle değil*/
            var srch = db.tblUrunSatisUsts.First(x => x.SatisGrupNo == txtSatisGrupNo.Text);
            srch.SatisGrupNo = txtSatisGrupNo.Text;
            srch.AraToplam = Convert.ToDecimal(txtAraToplam.Text);
            srch.STarih = Convert.ToDateTime(txtSTarih.Text);
            srch.Durum = false;
            srch.CariId = db.TblCaris.First(x => x.CariAdi == txtCari.Text).Id;
            srch.Vade = Convert.ToInt32(txtVade.Text);
            srch.OdemeId = db.bOdemeTurleris.First(x => x.OdemeTipi == txtOdemeTuru.Text).Id;
            srch.KdvToplam = Convert.ToDecimal(txtKdvToplam.Text);
            srch.GenelToplam = Convert.ToDecimal(txtGenelToplam.Text);


            db.SaveChanges();
            liste.AllowUserToAddRows = false;




            tblUrunSatisAlt[] ualt = new tblUrunSatisAlt[liste.RowCount];
            for (int i = 0; i < liste.RowCount; i++)
            {
                var altId = Convert.ToInt32(liste.Rows[i].Cells[7].Value);
                ualt[i].Miktar = Convert.ToInt32(liste.Rows[i].Cells[4].Value.ToString());
                ualt[i].SatisGrupNo = txtSatisGrupNo.Text;
                ualt[i].BirimFiyat = Convert.ToDecimal(liste.Rows[i].Cells[3].Value.ToString());
                ualt[i].SatisFiyat = Convert.ToDecimal(liste.Rows[i].Cells[4].Value.ToString());
                string brm = liste.Rows[i].Cells[2].Value.ToString();
                ualt[i].BirimId = db.bBirims.First(x => x.BirimAdi == brm).Id;
                string urn = liste.Rows[i].Cells[1].Value.ToString();
                ualt[i].UrunId = db.tblUrunlers.First(x => x.UrunAciklama == urn).Id;
                ualt[i].AToplam = Convert.ToDecimal(liste.Rows[i].Cells[4].Value) * Convert.ToDecimal(liste.Rows[i].Cells[5].Value);
                ualt[i].Kdv = Convert.ToDecimal(liste.Rows[i].Cells[6].Value);




                string ubarkod = liste.Rows[i].Cells[0].Value.ToString() + "/" + liste.Rows[i].Cells[1].Value.ToString(); //stoktan sonra yaptık.
                var sKontrol = db.tblStokDurums.First(x => x.Barkod == ubarkod);
                sKontrol.Ambar += 0;
                sKontrol.Depo += Convert.ToInt32(liste.Rows[i].Cells[4].Value.ToString());
                sKontrol.Raf += Convert.ToInt32(liste.Rows[i].Cells[4].Value.ToString());


            }
            db.SaveChanges();
            MessageBox.Show("Başarıyla Güncellendi.");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (edit && UrnSatisId > 0) Guncelle();
            else if (!edit) YeniKaydet();
        }
        protected override void OnLoad(EventArgs e)
        {
            //Buraya öyle bir kod yazacağımki değiştirmek istediğim kodun üzerine yazılarak onu manipule etmiş olacağım.
            var btnUrunSatisNo = new Button();
            btnUrunSatisNo.Size = new Size(25, txtSatisGrupNo.ClientSize.Height + 2);
            btnUrunSatisNo.Location = new Point(txtSatisGrupNo.ClientSize.Width - btnUrunSatisNo.Width, -1); //sanal butonun yerini belirlemek boyutunu.
            btnUrunSatisNo.Cursor = Cursors.Default;
            //btnUrunAlisNo.Image = Properties.Resources.arrow; içine indirdiğimiz arrow adındaki imageyi koyar.
            btnUrunSatisNo.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            btnUrunSatisNo.Text = ".."; //içine yazı yazar
            txtSatisGrupNo.Controls.Add(btnUrunSatisNo);

            base.OnLoad(e);

            btnUrunSatisNo.Click += btnUrunSatisNo_Click;
        }
        Formlar F = new Formlar();

        private void btnUrunSatisNo_Click(object sender, EventArgs e)
        {
            int id = F.UrunSatisNo(true);
            if (id > 0) //sonradan yaptık
            {
                Ac(id);
            }
            frmAnaSayfa.AktarmaInt = -1;
        }

        private void Ac(int id)
        {
            edit = true;
            UrnSatisId = id;
            string ustNo = id.ToString().PadLeft(7, '0');
            tblUrunSatisUst ust = db.tblUrunSatisUsts.First(x => x.SatisGrupNo == ustNo);
            txtSatisGrupNo.Text = ust.SatisGrupNo;
            txtAraToplam.Text = ust.AraToplam.ToString();
            txtSTarih.Text = ust.STarih.ToString();
            txtCari.Text = ust.TblCari.CariAdi;
            txtGenelToplam.Text = ust.GenelToplam.ToString();
            txtKdvToplam.Text = ust.KdvToplam.ToString();
            txtOdemeTuru.Text = ust.bOdemeTurleri.OdemeTipi;
            txtVade.Text = ust.Vade.ToString();

            liste.Rows.Clear();
            //liste.AllowUserToAddRows = false; 
            int i = 0;
            var alt = (from s in db.tblUrunSatisAlts
                       where s.SatisGrupNo == ustNo
                       select s).ToList();
            foreach (var k in alt)
            {
                liste.Rows.Add();
                liste.Rows[i].Cells[0].Value = k.tblUrunler.UrunKodu;
                liste.Rows[i].Cells[1].Value = k.tblUrunler.UrunAciklama;
                liste.Rows[i].Cells[2].Value = k.bBirim.BirimAdi;
                liste.Rows[i].Cells[3].Value = k.BirimFiyat;
                liste.Rows[i].Cells[4].Value = k.SatisFiyat;
                liste.Rows[i].Cells[5].Value = k.Miktar;
                liste.Rows[i].Cells[6].Value = k.Kdv;
                liste.Rows[i].Cells[7].Value = k.Id;
                                
                i++;
            }


        }

        private void txtKarOran_SelectedIndexChanged(object sender, EventArgs e) //kar oranını değiştirdiğimde fiyatlarım da değişsin.
        {
            if(liste.RowCount>1)
            {
                 liste.AllowUserToAddRows = false;

                decimal a, b;   //yukardan aldım row hesaptan
                decimal atop = 0; 
                decimal ktop = 0;
                decimal gtop = 0;

                for (int i=0;i < liste.RowCount; i++)
                 {
                    decimal bFiyat = Convert.ToDecimal(liste.Rows[i].Cells[3].Value); //currentrow olduğun satırı etkiler 
                    int karOrn = Convert.ToInt32(txtKarOran.Text);

                    liste.Rows[i].Cells[4].Value = bFiyat + (bFiyat * karOrn) / 100; //row i hepsini
   
                    a = Convert.ToDecimal(liste.Rows[i].Cells[4].Value.ToString());
                    b = Convert.ToDecimal(liste.Rows[i].Cells[5].Value.ToString());
                    liste.Rows[i].Cells[6].Value = a * b * 0.18M;

                    atop += (Convert.ToDecimal(liste.Rows[i].Cells[4].Value) * Convert.ToDecimal(liste.Rows[i].Cells[5].Value));  //bunu bil!!!
                    ktop += Convert.ToDecimal(liste.Rows[i].Cells[6].Value);
                    
                    gtop = atop + ktop;
                    txtAraToplam.Text = atop.ToString();
                    txtKdvToplam.Text = ktop.ToString();
                    txtGenelToplam.Text = gtop.ToString();
                }
                 liste.AllowUserToAddRows = true;
            }
            
        }
    }
}
