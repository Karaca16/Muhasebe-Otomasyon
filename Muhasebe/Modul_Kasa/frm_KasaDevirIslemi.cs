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
    public partial class frm_KasaDevirIslemi : Form
    {
        public frm_KasaDevirIslemi()
        {
            InitializeComponent();
        }
        bool Edit = false;
        int KasaID = -1;
        int IslemID = -1;
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        private void frm_KasaDevirIslemi_Load(object sender, EventArgs e)
        {
           
        }
        void Temizle()
        {
            txt_Aciklama.Text = "";
            txt_BelgeMakbuz.Text = "";
            txt_KasaAdi.Text = "";
            txt_KasaKodu.Text = "";
            txt_Tutar.Text = "0";
            dt_Tarih.Text = DateTime.Now.ToShortDateString();
            Edit = false;
            KasaID = -1;
            IslemID = -1;
            Form2.Aktarma = -1;
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.KASAHAREKETLERI Hareket = new Fonksiyonlar.KASAHAREKETLERI();
                Hareket.aciklama = txt_Aciklama.Text;
                Hareket.belgeNo = txt_BelgeMakbuz.Text;
                Hareket.evrakTuru = "Kasa Devir Kartı";
                if (rb_Cikis.Checked == true) Hareket.gcKodu = "C";
                if (rb_Giris.Checked == true) Hareket.gcKodu = "G";
                Hareket.kasaID = KasaID;
                Hareket.tarih = DateTime.Parse(dt_Tarih.Text);
                Hareket.tutar = decimal.Parse(txt_Tutar.Text);
                Hareket.saveDate = DateTime.Now;
                Hareket.saveUser = Form2.UserID;
                DB.KASAHAREKETLERIs.InsertOnSubmit(Hareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Devir Kartı Hareket Kaydı İşlenmiştir!");
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
            
        }
        void Güncelle()
        {
            try
            {
                Fonksiyonlar.KASAHAREKETLERI Hareket = DB.KASAHAREKETLERIs.First(s => s.kasaID == IslemID);
                Hareket.aciklama = txt_Aciklama.Text;
                Hareket.belgeNo = txt_BelgeMakbuz.Text;
                Hareket.evrakTuru = "Kasa Devir Kartı";
                if (rb_Cikis.Checked == true) Hareket.gcKodu = "C";
                if (rb_Giris.Checked == true) Hareket.gcKodu = "G";
                Hareket.kasaID = KasaID;
                Hareket.tarih = DateTime.Parse(dt_Tarih.Text);
                Hareket.tutar = decimal.Parse(txt_Tutar.Text);
                Hareket.editDate = DateTime.Now;
                Hareket.editUser = Form2.UserID;
                DB.SubmitChanges();
                Mesajlar.Güncelle(true);
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
                DB.KASAHAREKETLERIs.DeleteOnSubmit(DB.KASAHAREKETLERIs.First(s => s.kasaID == IslemID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }
        void KasaAc(int ID)
        {
            try
            {
                KasaID = ID;
                txt_KasaAdi.Text = DB.KASALARs.First(s => s.kasaID == KasaID).kasaAdi;
                txt_KasaKodu.Text = DB.KASALARs.First(s => s.kasaID == KasaID).kasaKodu;
            }
            catch (Exception )
            {
                
                throw;
            }
        }
        public void Ac(int ID)
        {
            try
            {
                IslemID = ID;
                Edit = true;
                Fonksiyonlar.KASAHAREKETLERI Hareket = DB.KASAHAREKETLERIs.First(s => s.kasaID == IslemID);
                txt_Aciklama.Text = Hareket.aciklama;
                txt_BelgeMakbuz.Text = Hareket.belgeNo;
                KasaAc(Hareket.kasaID.Value);
                dt_Tarih.Text = Hareket.tarih.Value.ToShortDateString();
                txt_Tutar.Text = Hareket.tutar.Value.ToString();
                if (Hareket.gcKodu == "G") rb_Giris.Checked = true;
                if (Hareket.gcKodu == "C") rb_Cikis.Checked = true;
 
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && Mesajlar.Güncelle() == DialogResult.Yes) Güncelle();
            else YeniKaydet();
        }
        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();

        }
        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
