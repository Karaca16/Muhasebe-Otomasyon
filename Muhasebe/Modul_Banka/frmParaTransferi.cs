using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muhasebe.Modul_Banka
{
    public partial class frmParaTransferi : Form
    {
        public frmParaTransferi()
        {
            InitializeComponent();
        }
        string IslemTuru = "Banka Havale";

        private void frmParaTransferi_Load(object sender, EventArgs e)
        {
            txt_Tarih.Text = DateTime.Now.ToShortDateString();
        }

        private void txt_TransferTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_TransferTuru.SelectedIndex == 0)
            {
                rbGelen.Text = "Gelen Havale";
                rbGiden.Text = "Giden Havale";
                IslemTuru = "Banka Havale";
            }
            else if (txt_TransferTuru.SelectedIndex == 1)
            {
                rbGelen.Text = "Gelen EFT";
                rbGiden.Text = "Giden EFT";
                IslemTuru = "Banka EFT";

               
            }
        }
    }
}
