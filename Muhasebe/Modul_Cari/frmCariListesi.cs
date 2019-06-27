using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muhasebe.Modul_Cari
{
    public partial class frmCariListesi : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        public bool Secim = false;
        int SecimID = -1;
        public frmCariListesi()
        {
            InitializeComponent();
        }

        private void frmCariListesics_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            var Listele = from s in DB.CARILERs
                          where s.CariAdi.Contains(txtCariAdi.Text) && s.CariKodu.Contains(txtCariKodu.Text)                     
                          select s;
            CariListe.DataSource = Listele;
          
        }
        void Sec()
        {
            Fonksiyonlar.CARILER grup = new Fonksiyonlar.CARILER();
            try
            {
                SecimID = int.Parse(CariListe.CurrentRow.Cells["ID"].Value.ToString());
               // txtCariAdi.Text = CariListe.CurrentRow.Cells["CariAdi"].Value.ToString();
               // txtCariKodu.Text = CariListe.CurrentRow.Cells["CariKodu"].Value.ToString();
            }
            catch (Exception)
            {

                SecimID = -1;
            }
        }

        private void btnCariAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnCariTemizle_Click(object sender, EventArgs e)
        {
            txtCariAdi.Text = "";
            txtCariGrubu.Text = "";
            txtCariKodu.Text = "";
            Listele();
        }

        private void btnCariKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CariListe_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecimID > 0)
            {
                Form2.Aktarma = SecimID;
                this.Close();

            }
        }
    }
}
