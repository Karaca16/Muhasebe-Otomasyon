using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muhasebe.Fonksiyonlar
{
    class Mesajlar
    {
        public void YeniKayit(string Mesaj)
        {
            MessageBox.Show(Mesaj, "Yeni Kayıt Girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public DialogResult Güncelle()
        {
            return MessageBox.Show("Seçili Kayıt Kalıcı Olarak Güncellenecektir\n Güncelleme işlemini onaylıyormusunuz? ", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }
        public DialogResult Sil()
        {
            return MessageBox.Show("Seçili Kayıt Kalıcı Olarak Silinecektir.\n Silme işlemini onaylıyormusunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public void Güncelle(bool Güncelleme )
        {
            MessageBox.Show("Kayıt Güncellenmiştir", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Hata(Exception Hata)
        {
            MessageBox.Show(Hata.Message, "Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
