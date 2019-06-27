using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muhasebe.Modul_Kasa
{
    public partial class frm_KasaListesi : Form
    {
        public frm_KasaListesi()
        {
            InitializeComponent();
        }
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        public bool Secim = false;
        int SecimID = -1;

        private void frm_KasaListesi_Load(object sender, EventArgs e)
        {

        }
        void Göster()
        {
            var Listele = from s in DB.KASALARs
                          select s;
            lst.DataSource = Listele;
        }
        void Sec()
        {
            try
            {

            }
            catch (Exception)
            {
                SecimID = -1;
                
            }
        }
    }
}
