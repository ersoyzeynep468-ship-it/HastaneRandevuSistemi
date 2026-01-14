using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevuSistemi
{
    public partial class Form4: Form
    {
        string gelenDoktorAdi;
        string doktorAdi;
        string secilenSaat;
        public Form4(string gelenDoktor)
        {
            InitializeComponent();
            gelenDoktorAdi = gelenDoktor;
            this.Text = doktorAdi + "-Saat Seçimi";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Parantez içinde doktor adını ve tıkladığımız saati gönderiyoruz.
            Form5 onaySayfasi = new Form5(gelenDoktorAdi, "09:00");
            onaySayfasi.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Parantez içinde doktor adını ve tıkladığımız saati gönderiyoruz.
            Form5 onaySayfasi = new Form5(gelenDoktorAdi, "10:00");
            onaySayfasi.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Parantez içinde doktor adını ve tıkladığımız saati gönderiyoruz.
            Form5 onaySayfasi = new Form5(gelenDoktorAdi, "11:00");
            onaySayfasi.Show();
            this.Hide();
            }

        private void button4_Click(object sender, EventArgs e)
        {
           
            // Form 5'i (Onay Sayfası) açıyoruz. 
            // Parantez içinde doktor adını ve tıkladığımız saati gönderiyoruz.
            Form5 onaySayfasi = new Form5(gelenDoktorAdi, "12:00");
            onaySayfasi.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            // Form 5'i (Onay Sayfası) açıyoruz. 
            // Parantez içinde doktor adını ve tıkladığımız saati gönderiyoruz.
            Form5 onaySayfasi = new Form5(gelenDoktorAdi, "13:00");
            onaySayfasi.Show();
            this.Hide();
        }
        

        private void button6_Click(object sender, EventArgs e)
        {   
            // Form 5'i (Onay Sayfası) açıyoruz. 
            // Parantez içinde doktor adını ve tıkladığımız saati gönderiyoruz.
            Form5 onaySayfasi = new Form5(gelenDoktorAdi, "14:00");
            onaySayfasi.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            // Form 5'i (Onay Sayfası) açıyoruz. 
            // Parantez içinde doktor adını ve tıkladığımız saati gönderiyoruz.
            Form5 onaySayfasi = new Form5(gelenDoktorAdi, "15:00");
            onaySayfasi.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            // Form 5'i (Onay Sayfası) açıyoruz. 
            // Parantez içinde doktor adını ve tıkladığımız saati gönderiyoruz.
            Form5 onaySayfasi = new Form5(gelenDoktorAdi, "16:00");
            onaySayfasi.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
       
            // Form 5'i (Onay Sayfası) açıyoruz. 
            // Parantez içinde doktor adını ve tıkladığımız saati gönderiyoruz.
            Form5 onaySayfasi = new Form5(gelenDoktorAdi, "17:00");
            onaySayfasi.Show();
            this.Hide();
        }
    }
        
    }

