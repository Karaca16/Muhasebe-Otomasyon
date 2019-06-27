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
    public partial class frmStokGruplari : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesaj = new Fonksiyonlar.Mesajlar();
        public frmStokGruplari()
        {
            InitializeComponent();
        }
        public bool Secim = false;
        int secimID = -1;
        bool edit = false;

        private void frmStokGruplari_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()  
        {
            var listele = from s in DB.STOKGRUPLARIs
                          select s;
            lst.DataSource = listele;
            
        }
        void Temizle()
        {
            txtGrupAdı.Text = "";
            txtGrupKodu.Text = "";
            edit = false;
            Listele(); 
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.STOKGRUPLARI Grup = new Fonksiyonlar.STOKGRUPLARI();
                Grup.grupAdi = txtGrupAdı.Text;
                Grup.grupKodu = txtGrupKodu.Text;
                Grup.grupSaveDate = DateTime.Now;
                Grup.grupSaveUser = Form2.UserID;
                DB.STOKGRUPLARIs.InsertOnSubmit(Grup);
                DB.SubmitChanges();
                Mesaj.YeniKayit("Yeni Grup Oluşturuldu!");
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
                Fonksiyonlar.STOKGRUPLARI Grup = DB.STOKGRUPLARIs.First(s => s.grupID == secimID);
                Grup.grupAdi = txtGrupAdı.Text;
                Grup.grupKodu = txtGrupKodu.Text;
                Grup.grupEditUser = Form2.UserID;
                Grup.grupEditDate = DateTime.Now;
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
                DB.STOKGRUPLARIs.DeleteOnSubmit(DB.STOKGRUPLARIs.First(s => s.grupID == secimID));
                DB.SubmitChanges();
                Temizle();

            }
            catch (Exception)
            {
                
                throw;
            }

        }
        void Sec()
        {
            try
            {
                edit = true;
                Secim = true;
                secimID = int.Parse(lst.CurrentRow.Cells["grupID"].Value.ToString());
                txtGrupAdı.Text = lst.CurrentRow.Cells["grupAdi"].Value.ToString();
                txtGrupKodu.Text = lst.CurrentRow.Cells["grupKodu"].Value.ToString();
            }
            catch (Exception)
            {
                edit = false;
                secimID = -1;


            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (edit && secimID > 0 && Mesaj.Sil() == DialogResult.Yes) Sil();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //İF'in içi Güncelleme Yaptırıyor
            if (edit && secimID > 0 && Mesaj.Güncelle() == DialogResult.Yes) Güncelle();

            else
            {
                //İşlem güncelleme değilse kaydetme çalışıyor.
                YeniKaydet();
            }
            
                
            
        }

        

        private void lst_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && secimID >0 )
            {
                Form2.Aktarma = secimID;
                //this.Hide();
                
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

//DOUBLE CLİCK OLDUĞU ZAMAN (EDİT=TRUE) OLUYOR.
//EDİT TRUE OLDUĞU ZAMAN GÜNCELLEME,SİLME KOMUTLARI ÇALIŞABİLİYOR.
//SEC() İŞLEMİ SECİMID Yİ SECİLEN GRUBUN IDSİNE EŞİTLİYOR.

