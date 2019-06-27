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
    public partial class frm_KasaAcilisKarti : Form
    {
        public frm_KasaAcilisKarti()
        {
            InitializeComponent();
        }
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        bool Edit = false;
        int SecimID = -1;

        private void frm_KasaAcilisKarti_Load(object sender, EventArgs e)
        {
            Göster();
        }
        void Temizle()
        {
            Edit = false;
            SecimID = -1;
            txt_Aciklama.Text = "";
            txt_KasaAdi.Text = "";
            txt_KasaKodu.Text = "";
            Göster();
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.KASALAR Kasa = new Fonksiyonlar.KASALAR();
                Kasa.kasaAdi = txt_KasaAdi.Text;
                Kasa.kasaAciklama = txt_Aciklama.Text;
                Kasa.kasaKodu = txt_KasaKodu.Text;
                Kasa.kasaSaveDate = DateTime.Now;
                Kasa.kasaSaveUser = Form2.UserID;
                DB.KASALARs.InsertOnSubmit(Kasa);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Kasa Kaydı Oluşturuldu!");
                Temizle();
                Göster();

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
                Fonksiyonlar.KASALAR Kasa = DB.KASALARs.First(s => s.kasaID == SecimID);
                Kasa.kasaAdi = txt_KasaAdi.Text;
                Kasa.kasaAciklama = txt_Aciklama.Text;
                Kasa.kasaKodu = txt_KasaKodu.Text;
                Kasa.kasaEditDate = DateTime.Now;
                Kasa.kasaEditUser = Form2.UserID;
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
                DB.KASALARs.DeleteOnSubmit(DB.KASALARs.First(s => s.kasaID == SecimID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }
        void Sec()
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(lst.CurrentRow.Cells["kasaID"].Value.ToString());
                txt_Aciklama.Text = lst.CurrentRow.Cells["kasaAciklama"].Value.ToString();
                txt_KasaAdi.Text = lst.CurrentRow.Cells["kasaAdi"].Value.ToString();
                txt_KasaKodu.Text = lst.CurrentRow.Cells["kasaKodu"].Value.ToString();

            }
            catch (Exception)
            {
                

                Edit = false;
                SecimID = -1;
            }
 
        }
        void Göster()
        {
            var listele = from s in DB.KASALARs
                          select s;
            lst.DataSource = listele;

        }

        private void lst_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txt_KasaAdi.Text != "" && txt_Aciklama.Text != "" &&txt_KasaKodu.Text !="")
            {
                if (Edit && SecimID > 0 && Mesajlar.Güncelle() == DialogResult.Yes) Güncelle();
                else YeniKaydet();
            }
            else MessageBox.Show("Değerler Boş Bırakılamaz!","İşlem Hatası",MessageBoxButtons.OK,MessageBoxIcon.Error);
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
