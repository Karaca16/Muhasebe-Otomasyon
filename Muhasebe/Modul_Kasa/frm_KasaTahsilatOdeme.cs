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
    public partial class frm_KasaTahsilatOdeme : Form
    {
        public frm_KasaTahsilatOdeme()
        {
            InitializeComponent();
        }
        bool Edit = false;
        int IslemID = -1;
        string IslemTuru = "Kasa Tahsilat";

        private void frm_KasaTahsilatOdeme_Load(object sender, EventArgs e)
        {
            cmb_Tarih.Text = DateTime.Now.ToShortDateString();
        }

        private void txt_Tarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            IslemTuru = cmb_IslemTürü.SelectedItem.ToString();
        
        }
    }
}
