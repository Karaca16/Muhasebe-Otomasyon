using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Muhasebe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Sirket-Muhasebe;Integrated Security=true;");      

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into Uye(uyeSirketAdi,uyeSirketTür,uyeSirketSehir,uyeKullaniciAdi,uyeSifre) Values('" + textBox1.Text + "','" + comboBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            ConnectionQuerry.ExecuteQueries(sorgu);        
            textBox1.Clear();
            comboBox1.Text = "";
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            MessageBox.Show("Kaydınız Başarıyla Yapıldı!");
            panel1.Visible = false;
            panel2.Visible = true;

        }
        Form2 fr2 = new Form2();
      

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;

        }

        private void Giris_Click(object sender, EventArgs e)
        {
            string sorgu = "Select * From Uye Where uyeKullaniciAdi = '" + textBox5.Text + "'AND uyeSifre = '" + textBox6.Text + "'";
            SqlDataReader dr = ConnectionQuerry.DataReader(sorgu);
            if (dr.Read())
            {

                this.Hide();
                fr2.Show();
            }
            else
            {
                MessageBox.Show("Giriş işlemi yapılamıyor");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            fr2.Show();
            
        }

     
    }
}
