namespace Muhasebe.Modul_Kasa
{
    partial class frm_KasaAcilisKarti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_KasaAcilisKarti));
            this.lst = new System.Windows.Forms.DataGridView();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_KasaKodu = new System.Windows.Forms.TextBox();
            this.txt_KasaAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kasaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasaKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasaAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasaSaveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasaSaveUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasaEditDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasaEditUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lst)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst
            // 
            this.lst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kasaID,
            this.kasaKodu,
            this.kasaAdi,
            this.kasaAciklama,
            this.kasaSaveDate,
            this.kasaSaveUser,
            this.kasaEditDate,
            this.kasaEditUser});
            this.lst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst.Location = new System.Drawing.Point(3, 16);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(360, 175);
            this.lst.TabIndex = 0;
            this.lst.DoubleClick += new System.EventHandler(this.lst_DoubleClick);
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Location = new System.Drawing.Point(94, 71);
            this.txt_Aciklama.Multiline = true;
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(183, 104);
            this.txt_Aciklama.TabIndex = 44;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKapat.BackgroundImage")));
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKapat.Location = new System.Drawing.Point(282, 118);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(78, 35);
            this.btnKapat.TabIndex = 53;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSil.BackgroundImage")));
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.Location = new System.Drawing.Point(282, 76);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(78, 35);
            this.btnSil.TabIndex = 51;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKaydet.BackgroundImage")));
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(282, 33);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(78, 35);
            this.btnKaydet.TabIndex = 48;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Kasa Kodu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Açıklama :";
            // 
            // txt_KasaKodu
            // 
            this.txt_KasaKodu.Location = new System.Drawing.Point(94, 19);
            this.txt_KasaKodu.Name = "txt_KasaKodu";
            this.txt_KasaKodu.Size = new System.Drawing.Size(183, 20);
            this.txt_KasaKodu.TabIndex = 40;
            // 
            // txt_KasaAdi
            // 
            this.txt_KasaAdi.Location = new System.Drawing.Point(94, 45);
            this.txt_KasaAdi.Name = "txt_KasaAdi";
            this.txt_KasaAdi.Size = new System.Drawing.Size(183, 20);
            this.txt_KasaAdi.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Kasa Adı :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 194);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Banka Listesi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Aciklama);
            this.groupBox1.Controls.Add(this.btnKapat);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_KasaKodu);
            this.groupBox1.Controls.Add(this.txt_KasaAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 219);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Banka Bilgileri";
            // 
            // kasaID
            // 
            this.kasaID.DataPropertyName = "kasaID";
            this.kasaID.HeaderText = "ID";
            this.kasaID.Name = "kasaID";
            this.kasaID.Visible = false;
            // 
            // kasaKodu
            // 
            this.kasaKodu.DataPropertyName = "kasaKodu";
            this.kasaKodu.HeaderText = "Kasa Kodu";
            this.kasaKodu.Name = "kasaKodu";
            // 
            // kasaAdi
            // 
            this.kasaAdi.DataPropertyName = "kasaAdi";
            this.kasaAdi.HeaderText = "Kasa Adı";
            this.kasaAdi.Name = "kasaAdi";
            // 
            // kasaAciklama
            // 
            this.kasaAciklama.DataPropertyName = "kasaAciklama";
            this.kasaAciklama.HeaderText = "Kasa Açıklama";
            this.kasaAciklama.Name = "kasaAciklama";
            this.kasaAciklama.Width = 110;
            // 
            // kasaSaveDate
            // 
            this.kasaSaveDate.DataPropertyName = "kasaSaveDate";
            this.kasaSaveDate.HeaderText = "Save Date";
            this.kasaSaveDate.Name = "kasaSaveDate";
            this.kasaSaveDate.Visible = false;
            // 
            // kasaSaveUser
            // 
            this.kasaSaveUser.DataPropertyName = "kasaSaveUser";
            this.kasaSaveUser.HeaderText = "Save User";
            this.kasaSaveUser.Name = "kasaSaveUser";
            this.kasaSaveUser.Visible = false;
            // 
            // kasaEditDate
            // 
            this.kasaEditDate.DataPropertyName = "kasaEditDate";
            this.kasaEditDate.HeaderText = "Edit Date";
            this.kasaEditDate.Name = "kasaEditDate";
            this.kasaEditDate.Visible = false;
            // 
            // kasaEditUser
            // 
            this.kasaEditUser.DataPropertyName = "kasaEditUser";
            this.kasaEditUser.HeaderText = "Edit User";
            this.kasaEditUser.Name = "kasaEditUser";
            this.kasaEditUser.Visible = false;
            // 
            // frm_KasaAcilisKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 413);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_KasaAcilisKarti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Açılış Kartı";
            this.Load += new System.EventHandler(this.frm_KasaAcilisKarti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lst)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView lst;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_KasaKodu;
        private System.Windows.Forms.TextBox txt_KasaAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasaKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasaAciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasaSaveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasaSaveUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasaEditDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasaEditUser;
    }
}