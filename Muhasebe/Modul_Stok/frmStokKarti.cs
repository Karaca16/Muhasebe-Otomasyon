using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace Muhasebe.Modul_Stok
{
    public partial class frmStokKarti : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Resimleme Resimleme = new Fonksiyonlar.Resimleme();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        bool Edit = false;
        bool Resim = false;
        OpenFileDialog Dosya = new OpenFileDialog();
        int GRUPID= -1;
        int StokID = -1;
        public frmStokKarti()
        {
            InitializeComponent();
        } //Boş

        private void frmStokKarti_Load(object sender, EventArgs e)
        {
           
        }
        void Temizle()
        {
            txtAlışFiyatı.Text = "";
            txtAlışKDV.Text = "";
            txtBarkod.Text = "";
            txtBirim.Text = "";
            txtGrupAdı.Text = "";
            txtGrupKodu.Text = "";
            txtSatışFiyatı.Text = "";
            txtSatışKDV.Text = "";
            txtStokAdı.Text = "";
            txtStokKodu.Text = "";
            Edit = false;
            Resim = false;
            GRUPID = -1;
            StokID = -1;
            Form2.Aktarma = -1;
        }
        void ResimSec()
        {
            Dosya.Filter = "Jpeg(*.jpg)|*.jpg|Jpeg(*.Jpeg)|*.Jpeg";
            if (Dosya.ShowDialog() == DialogResult.OK)
            {
                ResimKutusu.ImageLocation = Dosya.FileName;
                Resim = true;

            }
        }
        private void btnResimSec_Click_1(object sender, EventArgs e)
        {
            ResimSec();
        }
        void YeniKaydet()
        {
            try
            {
            Fonksiyonlar.STOKLAR Stok = new Fonksiyonlar.STOKLAR();
            Stok.stokAdi = txtStokAdı.Text;
            Stok.stokAlisfiyat = decimal.Parse(txtAlışFiyatı.Text);
            Stok.stokAlisKDV = decimal.Parse(txtAlışKDV.Text);
            Stok.stokBarkod = txtBarkod.Text;
            Stok.stokBirim = txtBirim.Text;
            Stok.stokGrupID = GRUPID;
            Stok.stokKodu = txtStokKodu.Text;
            Stok.stokResim = new System.Data.Linq.Binary(Resimleme.ResimYukleme(ResimKutusu.Image));
            Stok.stokSatisfiyat = decimal.Parse(txtSatışFiyatı.Text);
            Stok.stokSatisKDV = decimal.Parse(txtSatışKDV.Text);
            Stok.stokSavedate = DateTime.Now;
            Stok.stokSaveuser = Form2.UserID;
            DB.STOKLARs.InsertOnSubmit(Stok);
            DB.SubmitChanges();
            Mesajlar.YeniKayit("Yeni Stok Kaydı Oluşturuldu!");
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
                Fonksiyonlar.STOKLAR Stok = DB.STOKLARs.First(s => s.stokID == StokID);
                Stok.stokAdi = txtStokAdı.Text;
                Stok.stokAlisfiyat = decimal.Parse(txtAlışFiyatı.Text);
                Stok.stokAlisKDV = decimal.Parse(txtAlışKDV.Text);
                Stok.stokBarkod = txtBarkod.Text;
                Stok.stokBirim = txtBirim.Text;
                Stok.stokGrupID = GRUPID;
                Stok.stokKodu = txtStokKodu.Text;
                  if (Resim) Stok.stokResim = new System.Data.Linq.Binary(Resimleme.ResimYukleme(ResimKutusu.Image));
                Stok.stokSatisfiyat = decimal.Parse(txtSatışFiyatı.Text);
                Stok.stokSatisKDV = decimal.Parse(txtSatışKDV.Text);
                Stok.stokEdittime = DateTime.Now;
                Stok.stokEdituser = Form2.UserID;
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
                DB.STOKLARs.DeleteOnSubmit(DB.STOKLARs.First(s => s.stokID == StokID));
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
            GRUPID = ID;
            txtGrupAdı.Text = DB.STOKGRUPLARIs.First(s => s.grupID == GRUPID).grupAdi;
            txtGrupKodu.Text = DB.STOKGRUPLARIs.First(s => s.grupID == GRUPID).grupKodu; 
        }

        public void Ac(int ID)
        {
            Edit = true;
            StokID = ID;
            Fonksiyonlar.STOKLAR Stok = DB.STOKLARs.First(s => s.stokID == StokID);         
            //GrupAc(Stok.stokGrupID.Value);
            ResimKutusu.Image = Resimleme.ResimGetirme(Stok.stokResim.ToArray());
            txtAlışFiyatı.Text = Stok.stokAlisfiyat.ToString();
            txtAlışKDV.Text = Stok.stokAlisKDV.ToString();
            txtBarkod.Text = Stok.stokBarkod;
            txtBirim.Text = Stok.stokBirim;
            txtSatışFiyatı.Text = Stok.stokSatisfiyat.ToString();
            txtSatışKDV.Text = Stok.stokSatisKDV.ToString();
            txtStokAdı.Text = Stok.stokAdi; 
            txtStokKodu.Text = Stok.stokKodu;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && StokID > 0 && Mesajlar.Güncelle() == DialogResult.Yes) 
            {
                Güncelle();
            }
               
            else
            {
                YeniKaydet();
            }
      
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && StokID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
            {

            }
        }

        private void txtStokKodu_DoubleClick(object sender, EventArgs e)
        {
            int ID = Formlar.StokListesi(true);
            if (ID > 0)
            {
                Ac(ID);
            }
            Form2.Aktarma = -1;

        }

        private void txtGrupKodu_DoubleClick(object sender, EventArgs e)
        {
            int ID = Formlar.StokGrupları(true);
            if (ID>0)
            {
                GrupAc(ID);
                
            }
            Form2.Aktarma = -1;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
    }
}

           


 
