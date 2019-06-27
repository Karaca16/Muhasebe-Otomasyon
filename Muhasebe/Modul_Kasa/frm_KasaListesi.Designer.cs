namespace Muhasebe.Modul_Kasa
{
    partial class frm_KasaListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_KasaListesi));
            this.button1 = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStokAdı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStokKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lst = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.stokID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasaAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasaSaveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasaSaveUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasaEditDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasaEditUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lst)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(182, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kapat";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTemizle.BackgroundImage")));
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Location = new System.Drawing.Point(88, 166);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(88, 37);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // btnAra
            // 
            this.btnAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAra.BackgroundImage")));
            this.btnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.Location = new System.Drawing.Point(19, 166);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(63, 37);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "Ara";
            this.btnAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(18, 118);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(227, 20);
            this.txtBarkod.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Birtane Daha Ekle";
            // 
            // txtStokAdı
            // 
            this.txtStokAdı.Location = new System.Drawing.Point(18, 72);
            this.txtStokAdı.Name = "txtStokAdı";
            this.txtStokAdı.Size = new System.Drawing.Size(227, 20);
            this.txtStokAdı.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kasa Adı";
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(18, 27);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Size = new System.Drawing.Size(227, 20);
            this.txtStokKodu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasa Kodu";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btnTemizle);
            this.tabPage2.Controls.Add(this.btnAra);
            this.tabPage2.Controls.Add(this.txtBarkod);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtStokAdı);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtStokKodu);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(273, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Arama";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(281, 463);
            this.tabControl1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 463);
            this.panel1.TabIndex = 0;
            // 
            // lst
            // 
            this.lst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stokID,
            this.stokBarkod,
            this.stokKodu,
            this.kasaAciklama,
            this.kasaSaveDate,
            this.kasaSaveUser,
            this.kasaEditDate,
            this.kasaEditUser});
            this.lst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst.Location = new System.Drawing.Point(290, 3);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(710, 463);
            this.lst.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.61416F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.38584F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lst, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1003, 469);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // stokID
            // 
            this.stokID.DataPropertyName = "kasaID";
            this.stokID.HeaderText = "Kasa ID";
            this.stokID.Name = "stokID";
            this.stokID.Width = 70;
            // 
            // stokBarkod
            // 
            this.stokBarkod.DataPropertyName = "kasaKodu";
            this.stokBarkod.HeaderText = "Kasa Kodu";
            this.stokBarkod.Name = "stokBarkod";
            this.stokBarkod.Width = 75;
            // 
            // stokKodu
            // 
            this.stokKodu.DataPropertyName = "kasaAdi";
            this.stokKodu.HeaderText = "Kasa Adı";
            this.stokKodu.Name = "stokKodu";
            // 
            // kasaAciklama
            // 
            this.kasaAciklama.DataPropertyName = "kasaAciklama";
            this.kasaAciklama.HeaderText = "Kasa Açıklama";
            this.kasaAciklama.Name = "kasaAciklama";
            // 
            // kasaSaveDate
            // 
            this.kasaSaveDate.DataPropertyName = "kasaSaveDate";
            this.kasaSaveDate.HeaderText = "Kasa Save Date";
            this.kasaSaveDate.Name = "kasaSaveDate";
            this.kasaSaveDate.Visible = false;
            // 
            // kasaSaveUser
            // 
            this.kasaSaveUser.DataPropertyName = "kasaSaveUser";
            this.kasaSaveUser.HeaderText = "Kasa Save User";
            this.kasaSaveUser.Name = "kasaSaveUser";
            this.kasaSaveUser.Visible = false;
            // 
            // kasaEditDate
            // 
            this.kasaEditDate.DataPropertyName = "kasaEditDate";
            this.kasaEditDate.HeaderText = "kasaEditDate";
            this.kasaEditDate.Name = "kasaEditDate";
            this.kasaEditDate.Visible = false;
            // 
            // kasaEditUser
            // 
            this.kasaEditUser.DataPropertyName = "kasaEditUser";
            this.kasaEditUser.HeaderText = "Kasa Edit User";
            this.kasaEditUser.Name = "kasaEditUser";
            this.kasaEditUser.Visible = false;
            // 
            // frm_KasaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 469);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_KasaListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Listesi";
            this.Load += new System.EventHandler(this.frm_KasaListesi_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lst)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStokAdı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStokKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView lst;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokID;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokBarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasaAciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasaSaveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasaSaveUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasaEditDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasaEditUser;
    }
}