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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (!maskedTextBox1.MaskFull) 
            {
                MessageBox.Show("Lütfen doğum tarihini (gün.ay.yıl) eksiksiz giriniz!");
                return;
            }

            string dogumTarihi = maskedTextBox1.Text;
            string[] parcalar = dogumTarihi.Split('.');
            int gun = int.Parse(parcalar[0]);
            int ay = int.Parse(parcalar[1]);
            int yil = int.Parse(parcalar[2]);

            
            if (gun < 1 || gun > 31)
            {
                MessageBox.Show("Gün 01 ile 31 arasında olmalıdır!");
                return; 
            }

            if (ay < 1 || ay > 12)
            {
                MessageBox.Show("Ay 01 ile 12 arasında olmalıdır!");
                return;
            }

           
            if (yil > 2025 || (!parcalar[2].StartsWith("19") && !parcalar[2].StartsWith("20")))
            {
                MessageBox.Show("Yıl 1900-2025 arasında olmalı!");
                return;
            }

           
            if (textBox1.Text.Length != 11)
            {
                MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır!");
                return;
            }

           
            string sifre = textBox2.Text;
            bool buyukVar = false, kucukVar = false, ozelVar = false;

            foreach (char c in sifre)
            {
                if (char.IsUpper(c)) buyukVar = true;
                else if (char.IsLower(c)) kucukVar = true;
                else if (!char.IsLetterOrDigit(c)) ozelVar = true;
            }

            if (sifre.Length < 5 || !buyukVar || !kucukVar || !ozelVar)
            {
                MessageBox.Show("Şifre 5-10 karakter arası, en az bir büyük, bir küçük ve bir özel karakter içermelidir!");
                return;
            }

            
            MessageBox.Show("Giriş Başarılı! Branş seçimine gidiliyor.");
            Form2 bransSayfasi = new Form2();
            bransSayfasi.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
               
                e.Handled = true;
            }
        }
    }
}