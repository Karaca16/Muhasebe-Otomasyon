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
    public partial class frmCariGruplari : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesaj = new Fonksiyonlar.Mesajlar();
        bool Edit = false;
        int SecimID = -1;
        public bool Secim = false;

        public frmCariGruplari()
        {
            InitializeComponent();
        }
        private void frmCariGruplari_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {

            var lst = from s in DB.CARIGRUPLARIs
                   select s;
           CariListe.DataSource = lst;
            
        }

        void Temizle()
        {
            txtGrupAdı.Text = "";
            txtGrupKodu.Text = "";
            Edit = false;
            SecimID = -1;
            Listele();

        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.CARIGRUPLARI Grup = new Fonksiyonlar.CARIGRUPLARI();
                Grup.cariGrupAdi = txtGrupAdı.Text;
                Grup.cariGrupKodu = txtGrupKodu.Text;
                Grup.cariSaveDate = DateTime.Now;
                Grup.cariSaveUser = Form2.UserID;
                DB.CARIGRUPLARIs.InsertOnSubmit(Grup);
                DB.SubmitChanges();
                Mesaj.YeniKayit("Yeni Cari Grup Kaydı Oluşturuldu");
                Temizle();  
            }
            catch (Exception e)
            {
                Mesaj.Hata(e);
            }
        }
     
        void Güncelle()
        {
            try
            {
                Fonksiyonlar.CARIGRUPLARI Grup = DB.CARIGRUPLARIs.First(s => s.cariID == SecimID);
                Grup.cariGrupAdi = txtGrupAdı.Text;
                Grup.cariGrupKodu = txtGrupKodu.Text;
                Grup.cariEditDate = DateTime.Now;
                Grup.cariEditUser = Form2.UserID;                
                DB.SubmitChanges();
                Mesaj.Güncelle(true);
                Temizle();  
            }
            catch (Exception e)
            {

                Mesaj.Hata(e);
            }
        }

        void Sil()
        {
            try
            {
                DB.CARIGRUPLARIs.DeleteOnSubmit(DB.CARIGRUPLARIs.First(s => s.cariID == SecimID));
                DB.SubmitChanges();
                Temizle();

            }
            catch (Exception e)
            {

                Mesaj.Hata(e);
            }
        }

        void Sec()
        {
            try
            {
               Edit = true;
                SecimID = int.Parse(CariListe.CurrentRow.Cells["cariID"].Value.ToString());
                txtGrupAdı.Text = CariListe.CurrentRow.Cells["cariGrupAdi"].Value.ToString();
                txtGrupKodu.Text = CariListe.CurrentRow.Cells["cariGrupKodu"].Value.ToString();
            }
            catch (Exception)
            {
                Edit = false;
                SecimID = -1;
                
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesaj.Güncelle() == DialogResult.Yes) Güncelle();
            else
            {
                YeniKaydet();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesaj.Sil() == DialogResult.Yes) Sil();
           
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CariListe_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Edit && SecimID > 0 )
            {
                Form2.Aktarma = SecimID;
                //this.Hide();
            }

        }

     
    }
}
