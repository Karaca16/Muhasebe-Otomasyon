namespace Muhasebe.Modul_Cari
{
    partial class frmCariListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCariListesi));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCariKapat = new System.Windows.Forms.Button();
            this.btnCariTemizle = new System.Windows.Forms.Button();
            this.btnCariAra = new System.Windows.Forms.Button();
            this.txtCariGrubu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCariAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCariKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CariListe = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CariListe)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.37662F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.62337F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CariListe, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1078, 416);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 410);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(245, 410);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCariKapat);
            this.tabPage2.Controls.Add(this.btnCariTemizle);
            this.tabPage2.Controls.Add(this.btnCariAra);
            this.tabPage2.Controls.Add(this.txtCariGrubu);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtCariAdi);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtCariKodu);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(237, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Arama";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCariKapat
            // 
            this.btnCariKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCariKapat.BackgroundImage")));
            this.btnCariKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCariKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCariKapat.Location = new System.Drawing.Point(158, 158);
            this.btnCariKapat.Name = "btnCariKapat";
            this.btnCariKapat.Size = new System.Drawing.Size(62, 37);
            this.btnCariKapat.TabIndex = 8;
            this.btnCariKapat.Text = "Kapat";
            this.btnCariKapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCariKapat.UseVisualStyleBackColor = true;
            this.btnCariKapat.Click += new System.EventHandler(this.btnCariKapat_Click);
            // 
            // btnCariTemizle
            // 
            this.btnCariTemizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCariTemizle.BackgroundImage")));
            this.btnCariTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCariTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCariTemizle.Location = new System.Drawing.Point(75, 157);
            this.btnCariTemizle.Name = "btnCariTemizle";
            this.btnCariTemizle.Size = new System.Drawing.Size(77, 37);
            this.btnCariTemizle.TabIndex = 7;
            this.btnCariTemizle.Text = "Temizle";
            this.btnCariTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCariTemizle.UseVisualStyleBackColor = true;
            this.btnCariTemizle.Click += new System.EventHandler(this.btnCariTemizle_Click);
            // 
            // btnCariAra
            // 
            this.btnCariAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCariAra.BackgroundImage")));
            this.btnCariAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCariAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCariAra.Location = new System.Drawing.Point(6, 157);
            this.btnCariAra.Name = "btnCariAra";
            this.btnCariAra.Size = new System.Drawing.Size(63, 37);
            this.btnCariAra.TabIndex = 6;
            this.btnCariAra.Text = "Ara";
            this.btnCariAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCariAra.UseVisualStyleBackColor = true;
            this.btnCariAra.Click += new System.EventHandler(this.btnCariAra_Click);
            // 
            // txtCariGrubu
            // 
            this.txtCariGrubu.Location = new System.Drawing.Point(8, 119);
            this.txtCariGrubu.Name = "txtCariGrubu";
            this.txtCariGrubu.Size = new System.Drawing.Size(212, 20);
            this.txtCariGrubu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cari Grubu";
            // 
            // txtCariAdi
            // 
            this.txtCariAdi.Location = new System.Drawing.Point(8, 73);
            this.txtCariAdi.Name = "txtCariAdi";
            this.txtCariAdi.Size = new System.Drawing.Size(212, 20);
            this.txtCariAdi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cari Adı";
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.Location = new System.Drawing.Point(8, 28);
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.Size = new System.Drawing.Size(212, 20);
            this.txtCariKodu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Kodu";
            // 
            // CariListe
            // 
            this.CariListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CariListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CariListe.Location = new System.Drawing.Point(254, 3);
            this.CariListe.Name = "CariListe";
            this.CariListe.Size = new System.Drawing.Size(821, 410);
            this.CariListe.TabIndex = 1;
            this.CariListe.DoubleClick += new System.EventHandler(this.CariListe_DoubleClick);
            // 
            // frmCariListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 416);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCariListesi";
            this.Text = "Cari  Listesi";
            this.Load += new System.EventHandler(this.frmCariListesics_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CariListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCariKapat;
        private System.Windows.Forms.Button btnCariTemizle;
        private System.Windows.Forms.Button btnCariAra;
        private System.Windows.Forms.TextBox txtCariGrubu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCariAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCariKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CariListe;
    }
}