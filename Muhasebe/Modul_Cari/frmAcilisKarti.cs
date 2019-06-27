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
    public partial class frmAcilisKarti : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        bool Edit = false;
        int CariID = -1;
        int GrupID = -1;
        public frmAcilisKarti()
        {
            InitializeComponent();
        }
        void Temizle()
        {
            txtAdres.Text = "";
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtFax1.Text = "";
            txtFax2.Text = "";
            txtGrupAdi.Text = "";
            txtGrupKodu.Text = "";
            txtIlce.Text = "";
            txtMailInfo.Text = "";
            txtSehir.Text = "";
            txtTelefon1.Text = "";
            txtTelefon2.Text = "";
            txtÜlke.Text = "";
            txtVergiDairesi.Text = "";
            txtVergiNo.Text = "";
            txtWebAdresi.Text = "";
            txtYetkili1.Text = "";
            txtYetkili2.Text = "";
            txtYetkiliEmail1.Text = "";
            txtYetkiliEmail2.Text = "";
            Edit = false;
            CariID = -1;
            GrupID = -1;
            Form2.Aktarma = -1;

        }
        void Güncelle()
        {
            try
            {
                Fonksiyonlar.CARILER Cari = DB.CARILERs.First(s => s.ID == CariID);
                Cari.Adres = txtAdres.Text;
                Cari.CariAdi = txtCariAdi.Text;
                Cari.CariKodu = txtCariKodu.Text;
                Cari.Fax1 = txtFax1.Text;
                Cari.Fax2 = txtFax2.Text;
                Cari.GrupID = GrupID;
                Cari.Ilce = txtIlce.Text;
                Cari.MailInfo = txtMailInfo.Text;
                Cari.Sehir = txtSehir.Text;
                Cari.Telefon1 = txtTelefon1.Text;
                Cari.Telefon2 = txtTelefon2.Text;
                Cari.Ulke = txtÜlke.Text;
                Cari.VergiDairesi = txtVergiDairesi.Text;
                Cari.VergiNo = txtVergiNo.Text;
                Cari.WebAdres = txtWebAdresi.Text;
                Cari.Yetkili1 = txtYetkili1.Text;
                Cari.Yetkili2 = txtYetkili2.Text;
                Cari.YetkiliEmail1 = txtYetkiliEmail1.Text;
                Cari.YetkiliEmail2 = txtYetkiliEmail2.Text;
                Cari.EditDate = DateTime.Now;
                Cari.EditUser = Form2.UserID;
                DB.SubmitChanges();
                Mesajlar.Güncelle(true);
                Temizle();

            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
   
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.CARILER Cari = new Fonksiyonlar.CARILER();
                Cari.Adres = txtAdres.Text;
                Cari.CariAdi = txtCariAdi.Text;
                Cari.CariKodu = txtCariKodu.Text;
                Cari.Fax1 = txtFax1.Text;
                Cari.Fax2 = txtFax2.Text;
                Cari.GrupID = GrupID;
                Cari.Ilce = txtIlce.Text;
                Cari.MailInfo = txtMailInfo.Text;
                Cari.Sehir = txtSehir.Text;
                Cari.Telefon1 = txtTelefon1.Text;
                Cari.Telefon2 = txtTelefon2.Text;
                Cari.Ulke = txtÜlke.Text;
                Cari.VergiDairesi = txtVergiDairesi.Text;
                Cari.VergiNo = txtVergiNo.Text;
                Cari.WebAdres = txtWebAdresi.Text;
                Cari.Yetkili1 = txtYetkili1.Text;
                Cari.Yetkili2 = txtYetkili2.Text;
                Cari.YetkiliEmail1 = txtYetkiliEmail1.Text;
                Cari.YetkiliEmail2 = txtYetkiliEmail2.Text;
                Cari.SaveDate = DateTime.Now;
                Cari.SaveUser = Form2.UserID;
                DB.CARILERs.InsertOnSubmit(Cari);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Kayıt Oluşturuldu");
                Temizle();
               
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }
        void Sil()
        {
            try
            {
                DB.CARILERs.DeleteOnSubmit(DB.CARILERs.First(s => s.ID == CariID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }
        void GrupAc(int ID)
        {
            try
            {
                GrupID = ID;
                Fonksiyonlar.CARIGRUPLARI Gruplar = DB.CARIGRUPLARIs.First(s => s.cariID == GrupID);
                txtGrupAdi.Text = Gruplar.cariGrupAdi;
                txtGrupKodu.Text = Gruplar.cariGrupKodu;
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }
        public void Ac(int ID)
        {
            try
            {
                Edit = true;
                CariID = ID;
                Fonksiyonlar.CARILER Cari = DB.CARILERs.First(s => s.ID == CariID);
                txtAdres.Text = Cari.Adres;
                txtCariAdi.Text = Cari.CariAdi;
                txtCariKodu.Text = Cari.CariKodu;
                txtFax1.Text = Cari.Fax1;
                txtFax2.Text = Cari.Fax2;
                txtIlce.Text = Cari.Ilce;
                txtMailInfo.Text = Cari.MailInfo;
                txtSehir.Text = Cari.Sehir;
                txtTelefon1.Text = Cari.Telefon1;
                txtTelefon2.Text = Cari.Telefon2;
                txtÜlke.Text = Cari.Ulke;
                txtVergiDairesi.Text = Cari.VergiDairesi;
                txtVergiNo.Text = Cari.VergiNo;
                txtWebAdresi.Text = Cari.WebAdres;
                txtYetkili1.Text = Cari.Yetkili1;
                txtYetkili2.Text = Cari.Yetkili2;
                txtYetkiliEmail1.Text = Cari.YetkiliEmail1;
                txtYetkiliEmail2.Text = Cari.YetkiliEmail2;
                GrupAc(Cari.GrupID.Value);
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && Mesajlar.Güncelle() == DialogResult.Yes) Güncelle();
            else YeniKaydet();
        }

        private void txtGrupKodu_DoubleClick(object sender, EventArgs e)
        {

        }

        private void txtCariKodu_DoubleClick(object sender, EventArgs e)
        {
            int ID = Formlar.CariListesi(true);
            if (ID>0)
            {
                Ac(ID);

                
            }
            Form2.Aktarma = -1;

        }

        private void frmAcilisKarti_Load(object sender, EventArgs e)
        {                   
        }
       
    }
}
