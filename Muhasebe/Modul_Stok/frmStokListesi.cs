using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muhasebe.Modul_Stok
{
    public partial class frmStokListesi : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        public bool Secim = false;
        int SecimID = -1;
        public frmStokListesi()
        {
            InitializeComponent();
        }
        private void frmStokListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
           var listele = from s in DB.STOKLARs
                         where s.stokKodu.Contains(txtStokKodu.Text) && s.stokAdi.Contains(txtStokAdı.Text) && s.stokBarkod.Contains(txtBarkod.Text)
                         select s;
            CariListe.DataSource = listele;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtBarkod.Text = "";
            txtStokAdı.Text = "";
            txtStokKodu.Text = "";

            var listele = from s in DB.STOKLARs                        
                          select s;
            CariListe.DataSource = listele;
        }

        void Sec()
        {
            Fonksiyonlar.STOKLAR Grup = new Fonksiyonlar.STOKLAR();
            try
            {
                SecimID = int.Parse(CariListe.CurrentRow.Cells["stokID"].Value.ToString());
                //txtStokKodu.Text = gridliste.CurrentRow.Cells["stokKodu"].Value.ToString();
               // txtStokAdı.Text = gridliste.CurrentRow.Cells["stokAdi"].Value.ToString();                   

            }
            catch (Exception)
            {

                SecimID = -1;
            }
        }

        private void gridliste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecimID> 0)
            {
                Form2.Aktarma = SecimID;
                this.Close();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
