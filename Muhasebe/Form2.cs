using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muhasebe
{
    public partial class Form2 : Form
    {
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        public static int UserID = -1;
        public static int Aktarma = -1;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnStokKarti_Click(object sender, EventArgs e)
        {
            // Modul_Stok.frmStokKarti frm = new Modul_Stok.frmStokKarti();
            //  frm.ShowDialog();
            Formlar.StokKarti();
        }

        private void btnStokListesi_Click(object sender, EventArgs e)
        {
            Modul_Stok.frmStokListesi frm = new Modul_Stok.frmStokListesi();
            frm.ShowDialog();
            //Formlar.StokListesi();
        }

        private void btnStokGruplari_Click(object sender, EventArgs e)
        {
            //Modul_Stok.frmStokGruplari frm = new Modul_Stok.frmStokGruplari();
            // frm.ShowDialog();
            Formlar.StokGrupları();
        }

        private void btnStokHareket_Click(object sender, EventArgs e)
        {
            // Modul_Stok.frmStokHareketleri frm = new Modul_Stok.frmStokHareketleri();
            // frm.ShowDialog();
            Formlar.StokHareketleri();
        }

        private void btnAçılışKarti_Click(object sender, EventArgs e)
        {
            Modul_Cari.frmAcilisKarti frm = new Modul_Cari.frmAcilisKarti();
            frm.ShowDialog();            
        }

        private void btnCariGruplari_Click(object sender, EventArgs e)
        {
            Formlar.CariGrupları();
        }

        private void btnCariListesi_Click(object sender, EventArgs e)
        {
            Modul_Cari.frmCariListesi frm = new Modul_Cari.frmCariListesi();
            frm.ShowDialog();
        }

        private void btnBankaAcilisKarti_Click(object sender, EventArgs e)
        {
            Formlar.BankaAcilisKarti();
        }

        private void btnParaTransferi_Click(object sender, EventArgs e)
        {
            Modul_Banka.frmParaTransferi frm = new Modul_Banka.frmParaTransferi();
            frm.ShowDialog();
        }

        private void btnBankaListesi_Click(object sender, EventArgs e)
        {
            Modul_Banka.frmBankaListesi frm = new Modul_Banka.frmBankaListesi();
            frm.ShowDialog();
        }

        private void btnBankaIslemleri_Click(object sender, EventArgs e)
        {
            Modul_Banka.frmBankaIslemi frm = new Modul_Banka.frmBankaIslemi();
            frm.ShowDialog();
        }

        private void btnBankaHareketleri_Click(object sender, EventArgs e)
        {
            Modul_Banka.frmBankaHareketleri frm = new Modul_Banka.frmBankaHareketleri();
            frm.ShowDialog();
        }
        private void btn_KasaAcilisKarti_Click(object sender, EventArgs e)
        {
            Modul_Kasa.frm_KasaAcilisKarti frm = new Modul_Kasa.frm_KasaAcilisKarti();
            frm.ShowDialog();
        }

        private void btn_KasaListesi_Click(object sender, EventArgs e)
        {
            Modul_Kasa.frm_KasaListesi frm = new Modul_Kasa.frm_KasaListesi();
            frm.ShowDialog();
        }

        private void btn_KasaDevir_Click(object sender, EventArgs e)
        {
            Modul_Kasa.frm_KasaDevirIslemi frm = new Modul_Kasa.frm_KasaDevirIslemi();
            frm.ShowDialog();
        }

        private void btn_KasaTahsilat_Click(object sender, EventArgs e)
        {
            Modul_Kasa.frm_KasaTahsilatOdeme frm = new Modul_Kasa.frm_KasaTahsilatOdeme();
            frm.ShowDialog();
        }

        private void btn_SatisFaturasi_Click(object sender, EventArgs e)
        {
            Modul_Fatura.frm_SatisFaturasi frm = new Modul_Fatura.frm_SatisFaturasi();
            frm.ShowDialog();
        }
    }
}
