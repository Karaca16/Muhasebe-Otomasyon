namespace Muhasebe.Modul_Cari
{
    partial class frmCariGruplari
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCariGruplari));
            this.sTOKGRUPLARITableAdapter = new Muhasebe._Sirket_MuhasebeDataSetTableAdapters.STOKGRUPLARITableAdapter();
            this._Sirket_MuhasebeDataSet = new Muhasebe._Sirket_MuhasebeDataSet();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sTOKGRUPLARIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CariListe = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGrupAdı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGrupKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this._Sirket_MuhasebeDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTOKGRUPLARIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CariListe)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sTOKGRUPLARITableAdapter
            // 
            this.sTOKGRUPLARITableAdapter.ClearBeforeFill = true;
            // 
            // _Sirket_MuhasebeDataSet
            // 
            this._Sirket_MuhasebeDataSet.DataSetName = "_Sirket_MuhasebeDataSet";
            this._Sirket_MuhasebeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKapat.BackgroundImage")));
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKapat.Location = new System.Drawing.Point(237, 11);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 35);
            this.btnKapat.TabIndex = 5;
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
            this.btnSil.Location = new System.Drawing.Point(169, 11);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(62, 35);
            this.btnSil.TabIndex = 4;
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
            this.btnKaydet.Location = new System.Drawing.Point(78, 11);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(85, 35);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnKapat);
            this.panel3.Controls.Add(this.btnSil);
            this.panel3.Controls.Add(this.btnKaydet);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 335);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 49);
            this.panel3.TabIndex = 5;
            // 
            // sTOKGRUPLARIBindingSource
            // 
            this.sTOKGRUPLARIBindingSource.DataMember = "STOKGRUPLARI";
            this.sTOKGRUPLARIBindingSource.DataSource = this._Sirket_MuhasebeDataSet;
            // 
            // CariListe
            // 
            this.CariListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CariListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CariListe.GridColor = System.Drawing.SystemColors.ControlLight;
            this.CariListe.Location = new System.Drawing.Point(0, 0);
            this.CariListe.Name = "CariListe";
            this.CariListe.Size = new System.Drawing.Size(325, 284);
            this.CariListe.TabIndex = 0;
            this.CariListe.DoubleClick += new System.EventHandler(this.CariListe_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CariListe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 284);
            this.panel2.TabIndex = 4;
            // 
            // txtGrupAdı
            // 
            this.txtGrupAdı.Location = new System.Drawing.Point(96, 32);
            this.txtGrupAdı.Name = "txtGrupAdı";
            this.txtGrupAdı.Size = new System.Drawing.Size(140, 20);
            this.txtGrupAdı.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grup Adı :";
            // 
            // txtGrupKodu
            // 
            this.txtGrupKodu.Location = new System.Drawing.Point(96, 58);
            this.txtGrupKodu.Name = "txtGrupKodu";
            this.txtGrupKodu.Size = new System.Drawing.Size(140, 20);
            this.txtGrupKodu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grup Kodu :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGrupAdı);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtGrupKodu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 100);
            this.panel1.TabIndex = 3;
            // 
            // frmCariGruplari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 384);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCariGruplari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Grupları";
            this.Load += new System.EventHandler(this.frmCariGruplari_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Sirket_MuhasebeDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sTOKGRUPLARIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CariListe)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private _Sirket_MuhasebeDataSetTableAdapters.STOKGRUPLARITableAdapter sTOKGRUPLARITableAdapter;
        private _Sirket_MuhasebeDataSet _Sirket_MuhasebeDataSet;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource sTOKGRUPLARIBindingSource;
        private System.Windows.Forms.DataGridView CariListe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtGrupAdı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGrupKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;

    }
}