namespace MixErp302.Urun
{
    partial class frmUrunSatisListe
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
            this.split1 = new System.Windows.Forms.SplitContainer();
            this.liste = new System.Windows.Forms.DataGridView();
            this.UrunAlisGrupNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBul = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtIlce = new System.Windows.Forms.ComboBox();
            this.txtSehir = new System.Windows.Forms.ComboBox();
            this.txtCariTip = new System.Windows.Forms.ComboBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtVergiD = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtCariAdi = new System.Windows.Forms.TextBox();
            this.txtCariNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VergiDairesi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.split1)).BeginInit();
            this.split1.Panel1.SuspendLayout();
            this.split1.Panel2.SuspendLayout();
            this.split1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.split1.Panel1.Controls.Add(this.liste);
            // 
            // split1.Panel2
            // 
            this.split1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.split1.Panel2.Controls.Add(this.btnBul);
            this.split1.Panel2.Controls.Add(this.button3);
            this.split1.Size = new System.Drawing.Size(1313, 744);
            this.split1.SplitterDistance = 1102;
            this.split1.SplitterWidth = 5;
            this.split1.TabIndex = 9;
            // 
            // liste
            // 
            this.liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UrunAlisGrupNo,
            this.CariAdii,
            this.Atarih});
            this.liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liste.Location = new System.Drawing.Point(0, 0);
            this.liste.Name = "liste";
            this.liste.RowTemplate.Height = 24;
            this.liste.Size = new System.Drawing.Size(1098, 740);
            this.liste.TabIndex = 0;
            this.liste.DoubleClick += new System.EventHandler(this.liste_DoubleClick);
            // 
            // UrunAlisGrupNo
            // 
            this.UrunAlisGrupNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UrunAlisGrupNo.HeaderText = "Grup No";
            this.UrunAlisGrupNo.Name = "UrunAlisGrupNo";
            this.UrunAlisGrupNo.Width = 91;
            // 
            // CariAdii
            // 
            this.CariAdii.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariAdii.HeaderText = "Cari Adı";
            this.CariAdii.Name = "CariAdii";
            // 
            // Atarih
            // 
            this.Atarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Atarih.HeaderText = "Alış Tarihi";
            this.Atarih.Name = "Atarih";
            this.Atarih.Width = 99;
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBul.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBul.ForeColor = System.Drawing.Color.Green;
            this.btnBul.Location = new System.Drawing.Point(0, 0);
            this.btnBul.Margin = new System.Windows.Forms.Padding(4);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(202, 65);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(0, 675);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 65);
            this.button3.TabIndex = 2;
            this.button3.Text = "Kapat";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtAdres);
            this.splitContainer1.Panel1.Controls.Add(this.txtIlce);
            this.splitContainer1.Panel1.Controls.Add(this.txtSehir);
            this.splitContainer1.Panel1.Controls.Add(this.txtCariTip);
            this.splitContainer1.Panel1.Controls.Add(this.txtTc);
            this.splitContainer1.Panel1.Controls.Add(this.txtVergiD);
            this.splitContainer1.Panel1.Controls.Add(this.txtTel);
            this.splitContainer1.Panel1.Controls.Add(this.txtCariAdi);
            this.splitContainer1.Panel1.Controls.Add(this.txtCariNo);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.splitContainer1.Panel2.Controls.Add(this.btnKapat);
            this.splitContainer1.Panel2.Controls.Add(this.btnKaydet);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1313, 744);
            this.splitContainer1.SplitterDistance = 530;
            this.splitContainer1.TabIndex = 8;
            this.splitContainer1.Visible = false;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(109, 219);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(226, 78);
            this.txtAdres.TabIndex = 9;
            // 
            // txtIlce
            // 
            this.txtIlce.FormattingEnabled = true;
            this.txtIlce.Location = new System.Drawing.Point(397, 98);
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.Size = new System.Drawing.Size(179, 24);
            this.txtIlce.TabIndex = 8;
            // 
            // txtSehir
            // 
            this.txtSehir.FormattingEnabled = true;
            this.txtSehir.Location = new System.Drawing.Point(397, 54);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(179, 24);
            this.txtSehir.TabIndex = 7;
            // 
            // txtCariTip
            // 
            this.txtCariTip.FormattingEnabled = true;
            this.txtCariTip.Location = new System.Drawing.Point(397, 12);
            this.txtCariTip.Name = "txtCariTip";
            this.txtCariTip.Size = new System.Drawing.Size(179, 24);
            this.txtCariTip.TabIndex = 6;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(100, 169);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(147, 22);
            this.txtTc.TabIndex = 5;
            // 
            // txtVergiD
            // 
            this.txtVergiD.Location = new System.Drawing.Point(100, 129);
            this.txtVergiD.Name = "txtVergiD";
            this.txtVergiD.Size = new System.Drawing.Size(147, 22);
            this.txtVergiD.TabIndex = 4;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(100, 91);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(147, 22);
            this.txtTel.TabIndex = 3;
            // 
            // txtCariAdi
            // 
            this.txtCariAdi.Location = new System.Drawing.Point(100, 59);
            this.txtCariAdi.Name = "txtCariAdi";
            this.txtCariAdi.Size = new System.Drawing.Size(147, 22);
            this.txtCariAdi.TabIndex = 2;
            // 
            // txtCariNo
            // 
            this.txtCariNo.Location = new System.Drawing.Point(100, 17);
            this.txtCariNo.Name = "txtCariNo";
            this.txtCariNo.Size = new System.Drawing.Size(147, 22);
            this.txtCariNo.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(355, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "İlçe Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Şehir Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cari Tipi Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "VergiNo/Tc :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vergi Dairesi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tel :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adres :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cari Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari No :";
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(0, 166);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(1309, 40);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Location = new System.Drawing.Point(0, 39);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(1309, 37);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CariNo,
            this.CariAdi,
            this.VergiDairesi});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1309, 167);
            this.dataGridView1.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 48;
            // 
            // CariNo
            // 
            this.CariNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariNo.HeaderText = "Cari No";
            this.CariNo.Name = "CariNo";
            this.CariNo.Width = 62;
            // 
            // CariAdi
            // 
            this.CariAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariAdi.HeaderText = "Cari Adı";
            this.CariAdi.Name = "CariAdi";
            // 
            // VergiDairesi
            // 
            this.VergiDairesi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.VergiDairesi.HeaderText = "Vergi Dairesi";
            this.VergiDairesi.Name = "VergiDairesi";
            this.VergiDairesi.Width = 109;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 39);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmUrunSatisListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 744);
            this.Controls.Add(this.split1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmUrunSatisListe";
            this.Text = "frmUrunSatisListe";
            this.Load += new System.EventHandler(this.frmUrunSatisListe_Load);
            this.split1.Panel1.ResumeLayout(false);
            this.split1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split1)).EndInit();
            this.split1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer split1;
        private System.Windows.Forms.DataGridView liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAlisGrupNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdii;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atarih;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.ComboBox txtIlce;
        private System.Windows.Forms.ComboBox txtSehir;
        private System.Windows.Forms.ComboBox txtCariTip;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtVergiD;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtCariAdi;
        private System.Windows.Forms.TextBox txtCariNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn VergiDairesi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}