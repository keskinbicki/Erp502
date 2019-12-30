namespace MixErp302.Urun
{
    partial class frmUrunSatis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlÜst = new System.Windows.Forms.Panel();
            this.txtKarOran = new System.Windows.Forms.ComboBox();
            this.txtUrunKodu = new System.Windows.Forms.ComboBox();
            this.txtGenelToplam = new System.Windows.Forms.TextBox();
            this.txtKdvToplam = new System.Windows.Forms.TextBox();
            this.txtAraToplam = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.liste = new System.Windows.Forms.DataGridView();
            this.split2 = new System.Windows.Forms.SplitContainer();
            this.txtSTarih = new System.Windows.Forms.DateTimePicker();
            this.txtCari = new System.Windows.Forms.ComboBox();
            this.txtVade = new System.Windows.Forms.ComboBox();
            this.txtOdemeTuru = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.split1 = new System.Windows.Forms.SplitContainer();
            this.txtSatisGrupNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PersonelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Satis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sadet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlÜst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.split2)).BeginInit();
            this.split2.Panel1.SuspendLayout();
            this.split2.Panel2.SuspendLayout();
            this.split2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split1)).BeginInit();
            this.split1.Panel1.SuspendLayout();
            this.split1.Panel2.SuspendLayout();
            this.split1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlÜst
            // 
            this.pnlÜst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlÜst.Controls.Add(this.txtKarOran);
            this.pnlÜst.Controls.Add(this.txtUrunKodu);
            this.pnlÜst.Controls.Add(this.txtGenelToplam);
            this.pnlÜst.Controls.Add(this.txtKdvToplam);
            this.pnlÜst.Controls.Add(this.txtAraToplam);
            this.pnlÜst.Controls.Add(this.btnSil);
            this.pnlÜst.Controls.Add(this.label2);
            this.pnlÜst.Controls.Add(this.txt);
            this.pnlÜst.Controls.Add(this.label14);
            this.pnlÜst.Controls.Add(this.label12);
            this.pnlÜst.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlÜst.Location = new System.Drawing.Point(0, 285);
            this.pnlÜst.Margin = new System.Windows.Forms.Padding(4);
            this.pnlÜst.Name = "pnlÜst";
            this.pnlÜst.Size = new System.Drawing.Size(1050, 117);
            this.pnlÜst.TabIndex = 0;
            // 
            // txtKarOran
            // 
            this.txtKarOran.FormattingEnabled = true;
            this.txtKarOran.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35"});
            this.txtKarOran.Location = new System.Drawing.Point(472, 42);
            this.txtKarOran.Name = "txtKarOran";
            this.txtKarOran.Size = new System.Drawing.Size(181, 24);
            this.txtKarOran.TabIndex = 24;
            this.txtKarOran.SelectedIndexChanged += new System.EventHandler(this.txtKarOran_SelectedIndexChanged);
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.FormattingEnabled = true;
            this.txtUrunKodu.Location = new System.Drawing.Point(80, 71);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(159, 24);
            this.txtUrunKodu.TabIndex = 8;
            // 
            // txtGenelToplam
            // 
            this.txtGenelToplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenelToplam.Location = new System.Drawing.Point(829, 88);
            this.txtGenelToplam.Name = "txtGenelToplam";
            this.txtGenelToplam.Size = new System.Drawing.Size(141, 22);
            this.txtGenelToplam.TabIndex = 13;
            // 
            // txtKdvToplam
            // 
            this.txtKdvToplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKdvToplam.Location = new System.Drawing.Point(829, 54);
            this.txtKdvToplam.Name = "txtKdvToplam";
            this.txtKdvToplam.Size = new System.Drawing.Size(141, 22);
            this.txtKdvToplam.TabIndex = 14;
            // 
            // txtAraToplam
            // 
            this.txtAraToplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAraToplam.Location = new System.Drawing.Point(829, 17);
            this.txtAraToplam.Name = "txtAraToplam";
            this.txtAraToplam.Size = new System.Drawing.Size(141, 22);
            this.txtAraToplam.TabIndex = 15;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Yellow;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSil.Location = new System.Drawing.Point(80, 6);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 43);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(375, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kar Oranı :";
            // 
            // txt
            // 
            this.txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt.AutoSize = true;
            this.txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt.Location = new System.Drawing.Point(728, 20);
            this.txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(94, 18);
            this.txt.TabIndex = 10;
            this.txt.Text = "Ara Toplam";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(725, 54);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 18);
            this.label14.TabIndex = 11;
            this.label14.Text = "Kdv Toplam";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(709, 88);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 18);
            this.label12.TabIndex = 12;
            this.label12.Text = "Genel Toplam";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.Red;
            this.btnKaydet.Location = new System.Drawing.Point(0, 0);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(189, 65);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Red;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKapat.Location = new System.Drawing.Point(0, 637);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(189, 65);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            // 
            // liste
            // 
            this.liste.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonelNo,
            this.PersonelAdi,
            this.Telefon,
            this.Departman,
            this.Satis,
            this.Adet,
            this.Kdv,
            this.Id,
            this.Sadet});
            this.liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liste.Location = new System.Drawing.Point(0, 0);
            this.liste.Margin = new System.Windows.Forms.Padding(4);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(1050, 285);
            this.liste.TabIndex = 1;
            this.liste.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.liste_CellEndEdit);
            this.liste.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.liste_EditingControlShowing);
            // 
            // split2
            // 
            this.split2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.split2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.split2.Location = new System.Drawing.Point(0, 0);
            this.split2.Margin = new System.Windows.Forms.Padding(4);
            this.split2.Name = "split2";
            this.split2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // split2.Panel1
            // 
            this.split2.Panel1.Controls.Add(this.txtSTarih);
            this.split2.Panel1.Controls.Add(this.txtCari);
            this.split2.Panel1.Controls.Add(this.txtVade);
            this.split2.Panel1.Controls.Add(this.txtOdemeTuru);
            this.split2.Panel1.Controls.Add(this.label11);
            this.split2.Panel1.Controls.Add(this.label10);
            this.split2.Panel1.Controls.Add(this.label15);
            this.split2.Panel1.Controls.Add(this.label17);
            this.split2.Panel1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            // 
            // split2.Panel2
            // 
            this.split2.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.split2.Panel2.Controls.Add(this.liste);
            this.split2.Panel2.Controls.Add(this.pnlÜst);
            this.split2.Size = new System.Drawing.Size(1054, 706);
            this.split2.SplitterDistance = 295;
            this.split2.SplitterWidth = 5;
            this.split2.TabIndex = 0;
            // 
            // txtSTarih
            // 
            this.txtSTarih.Location = new System.Drawing.Point(255, 112);
            this.txtSTarih.Name = "txtSTarih";
            this.txtSTarih.Size = new System.Drawing.Size(200, 22);
            this.txtSTarih.TabIndex = 23;
            // 
            // txtCari
            // 
            this.txtCari.FormattingEnabled = true;
            this.txtCari.Location = new System.Drawing.Point(255, 74);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(181, 24);
            this.txtCari.TabIndex = 22;
            // 
            // txtVade
            // 
            this.txtVade.FormattingEnabled = true;
            this.txtVade.Items.AddRange(new object[] {
            "Belirtilmemiş",
            "1",
            "3",
            "4",
            "5",
            "6",
            "9",
            "12"});
            this.txtVade.Location = new System.Drawing.Point(645, 68);
            this.txtVade.Name = "txtVade";
            this.txtVade.Size = new System.Drawing.Size(148, 24);
            this.txtVade.TabIndex = 21;
            // 
            // txtOdemeTuru
            // 
            this.txtOdemeTuru.FormattingEnabled = true;
            this.txtOdemeTuru.Location = new System.Drawing.Point(645, 109);
            this.txtOdemeTuru.Name = "txtOdemeTuru";
            this.txtOdemeTuru.Size = new System.Drawing.Size(148, 24);
            this.txtOdemeTuru.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(537, 112);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 18);
            this.label11.TabIndex = 17;
            this.label11.Text = "Ödeme Türü";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(593, 69);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Vade";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(145, 112);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 18);
            this.label15.TabIndex = 13;
            this.label15.Text = "Satış Tarihi :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(171, 74);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 18);
            this.label17.TabIndex = 15;
            this.label17.Text = "Cari Adı :";
            // 
            // split1
            // 
            this.split1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.split1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.split1.Location = new System.Drawing.Point(0, 0);
            this.split1.Margin = new System.Windows.Forms.Padding(4);
            this.split1.Name = "split1";
            // 
            // split1.Panel1
            // 
            this.split1.Panel1.Controls.Add(this.split2);
            // 
            // split1.Panel2
            // 
            this.split1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.split1.Panel2.Controls.Add(this.txtSatisGrupNo);
            this.split1.Panel2.Controls.Add(this.label1);
            this.split1.Panel2.Controls.Add(this.btnKaydet);
            this.split1.Panel2.Controls.Add(this.btnKapat);
            this.split1.Size = new System.Drawing.Size(1252, 706);
            this.split1.SplitterDistance = 1054;
            this.split1.SplitterWidth = 5;
            this.split1.TabIndex = 3;
            // 
            // txtSatisGrupNo
            // 
            this.txtSatisGrupNo.Location = new System.Drawing.Point(19, 124);
            this.txtSatisGrupNo.Name = "txtSatisGrupNo";
            this.txtSatisGrupNo.Size = new System.Drawing.Size(139, 22);
            this.txtSatisGrupNo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Satış Grup No";
            // 
            // PersonelNo
            // 
            this.PersonelNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PersonelNo.HeaderText = "Ürün Kodu";
            this.PersonelNo.Name = "PersonelNo";
            this.PersonelNo.Width = 105;
            // 
            // PersonelAdi
            // 
            this.PersonelAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PersonelAdi.HeaderText = "Ürün Açıklama";
            this.PersonelAdi.Name = "PersonelAdi";
            // 
            // Telefon
            // 
            this.Telefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Telefon.HeaderText = "Birim ";
            this.Telefon.Name = "Telefon";
            this.Telefon.Width = 72;
            // 
            // Departman
            // 
            this.Departman.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Departman.HeaderText = "Birim Fiyat";
            this.Departman.Name = "Departman";
            this.Departman.Width = 102;
            // 
            // Satis
            // 
            this.Satis.HeaderText = "Satış Fiyatı";
            this.Satis.Name = "Satis";
            // 
            // Adet
            // 
            this.Adet.HeaderText = "Adet";
            this.Adet.Name = "Adet";
            // 
            // Kdv
            // 
            this.Kdv.HeaderText = "Kdv";
            this.Kdv.Name = "Kdv";
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 48;
            // 
            // Sadet
            // 
            this.Sadet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sadet.HeaderText = "Stok Adet";
            this.Sadet.Name = "Sadet";
            this.Sadet.Width = 91;
            // 
            // frmUrunSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 706);
            this.Controls.Add(this.split1);
            this.Name = "frmUrunSatis";
            this.Text = "frmUrunSatis";
            this.Load += new System.EventHandler(this.frmUrunSatis_Load);
            this.pnlÜst.ResumeLayout(false);
            this.pnlÜst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            this.split2.Panel1.ResumeLayout(false);
            this.split2.Panel1.PerformLayout();
            this.split2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split2)).EndInit();
            this.split2.ResumeLayout(false);
            this.split1.Panel1.ResumeLayout(false);
            this.split1.Panel2.ResumeLayout(false);
            this.split1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split1)).EndInit();
            this.split1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlÜst;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridView liste;
        private System.Windows.Forms.SplitContainer split2;
        private System.Windows.Forms.SplitContainer split1;
        private System.Windows.Forms.ComboBox txtCari;
        private System.Windows.Forms.ComboBox txtVade;
        private System.Windows.Forms.ComboBox txtOdemeTuru;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox txtUrunKodu;
        private System.Windows.Forms.TextBox txtGenelToplam;
        private System.Windows.Forms.TextBox txtKdvToplam;
        private System.Windows.Forms.TextBox txtAraToplam;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSatisGrupNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtSTarih;
        private System.Windows.Forms.ComboBox txtKarOran;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Satis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sadet;
    }
}