using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe.Fonksiyonlar
{
    class Formlar
    {
        #region StokFormları 
        public int StokListesi(bool Secim = false)
        {
            Modul_Stok.frmStokListesi frm = new Modul_Stok.frmStokListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Form2.ActiveForm;
                frm.Show();
            }
            return Form2.Aktarma;
        }
        public int StokGrupları(bool Secim = false)
        {
            Modul_Stok.frmStokGruplari frm = new Modul_Stok.frmStokGruplari();
            if (Secim) frm.Secim = Secim;
            frm.ShowDialog();
            return Form2.Aktarma;
        }
        public void StokHareketleri(bool Ac = false)
        {
        }
        public void StokKarti(bool Ac = false)
        {
            Modul_Stok.frmStokKarti frm = new Modul_Stok.frmStokKarti();
            frm.ShowDialog();
        }
        #endregion    
    
        public int CariGrupları(bool Secim = false)
        {
            Modul_Cari.frmCariGruplari frm = new Modul_Cari.frmCariGruplari();
            if (Secim) frm.Secim = Secim;
            frm.ShowDialog();
            return Form2.Aktarma;       
 
        }
        public int CariListesi(bool Secim = false)
        {
            Modul_Cari.frmCariListesi frm = new Modul_Cari.frmCariListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();              
            }
            else
            {
                frm.MdiParent = Form2.ActiveForm;
                frm.Show();
            }

            return Form2.Aktarma;
 
        }

        public void BankaAcilisKarti(bool Ac = false)
        {
            Modul_Banka.frmBankaAcilisKarti frm = new Modul_Banka.frmBankaAcilisKarti();
            frm.ShowDialog();
        }

        public void Ac(bool Ac = false, int IslemID = -1)
        {
            Modul_Kasa.frm_KasaDevirIslemi frm = new Modul_Kasa.frm_KasaDevirIslemi();
            if (Ac) frm.Ac(IslemID);
            frm.ShowDialog();
        }


        

    }
}
