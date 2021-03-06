﻿using MixErp302.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixErp302.STOK
{
    public partial class frmStokDurum : Form
    {
        MixErpDbEntities1 db = new MixErpDbEntities1();
        int secimId = -1; //güncelleme
        public bool Secim = false;
        public frmStokDurum()
        {
            InitializeComponent();
        }

        private void frmStokDurum_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            liste.Rows.Clear();
            int i = 0;
            var srg = (from s in db.tblStokDurums
                       where s.tblUrunler.UrunKodu.Contains(txtBul.Text)
                       select s).ToList();
            foreach(var k in srg)
            {
                liste.Rows.Add();
                liste.Rows[i].Cells[0].Value = k.Id;
                liste.Rows[i].Cells[1].Value = k.StokKodu;
                liste.Rows[i].Cells[2].Value = k.tblUrunler.UrunKodu;
                liste.Rows[i].Cells[3].Value = k.tblUrunler.UrunAciklama;
                liste.Rows[i].Cells[4].Value = k.Depo;
                liste.Rows[i].Cells[5].Value = k.Raf;
                liste.Rows[i].Cells[6].Value = k.Ambar;
                liste.Rows[i].Cells[7].Value = k.Barkod;
                i++;
            }
            liste.AllowUserToAddRows = false;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && secimId > 0)
            {
                frmAnaSayfa.AktarmaInt = secimId;
                Close();
            }
        }

        private void Sec()
        {
            try
            {
                secimId = Convert.ToInt32(liste.CurrentRow.Cells[0].Value);
            }
            catch (Exception)
            {
                secimId = -1;
            }
        }
    }
}
