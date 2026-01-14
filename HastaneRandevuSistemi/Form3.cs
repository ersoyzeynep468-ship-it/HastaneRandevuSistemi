using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace HastaneRandevuSistemi
{
    public partial class Form3: Form
    {
        List<string> doluSaatler = new List<string>();
        Random rastgele = new Random();
        List<DateTime> doluTarihler = new List<DateTime>();

        string secilenBransAdi;
        public Form3(string gelenBrans)
        {
            InitializeComponent();
            DoluGunleriBelirle();
            secilenBransAdi = gelenBrans;
            
            if (secilenBransAdi == "Beyin Cerrahisi")
            {
                listBox1.Items.Add("Prof. Dr. Azmi Hamzaoğlu");
                listBox1.Items.Add("Op. Dr. Erkan Gümüş");
                listBox1.Items.Add("Prof. Dr. Zeynep Ersoy");
                listBox1.Items.Add("Op. Dr. Elif Evlek");
                listBox1.Items.Add("Prof. Dr. Fatih Terim");
                listBox1.Items.Add("Op. Dr. Mete Kılıç");
            }
            else if (secilenBransAdi == "Kadın Doğum")
            {
                listBox1.Items.Add("Dr. Mükremin Gezgin");
                listBox1.Items.Add("Dr. Testo Taylan");
                listBox1.Items.Add("Prof. Dr. Tuba Güleç");
                listBox1.Items.Add("Op. Dr. Şeyda Erdoğan");
                listBox1.Items.Add("Prof. Dr. İbrahim Kalın");
                listBox1.Items.Add("Op. Dr. Medine Sayan");
            }
            else if (secilenBransAdi == "Aile Hekimliği")
            {
                listBox1.Items.Add("Dr. Mehmet Akif Ersoy");
                listBox1.Items.Add("Dr. Ela Rümeysa Cebeci");
                listBox1.Items.Add("Prof. Dr. Şenol Güneş");
                listBox1.Items.Add("Op. Dr. Emirhan Kızıldağ");
                listBox1.Items.Add("Prof. Dr. Mustafa Sarıgül");
                listBox1.Items.Add("Op. Dr.Ümidi ");
            }
            else if (secilenBransAdi == "Nöroloji")
            {
                listBox1.Items.Add("Dr. Murat Övüç");
                listBox1.Items.Add("Dr. Mertcan Bahar ");
                listBox1.Items.Add("Prof. Dr. Mika Raun ");
                listBox1.Items.Add("Op. Dr. Hayrettin ");
                listBox1.Items.Add("Prof. Dr. Mustafa Bilginer ");
                listBox1.Items.Add("Op. Dr. Nejat İşler");
            }
            else if (secilenBransAdi == "Kulak Burun Boğaz")
            {
                listBox1.Items.Add("Dr. Kobra Murat");
                listBox1.Items.Add("Dr. Onur Bal");
                listBox1.Items.Add("Prof. Dr. Kadıköy Boğası");
                listBox1.Items.Add("Op. Dr.Laz Ziya ");
                listBox1.Items.Add("Prof. Dr. Tolunay Ören ");
                listBox1.Items.Add("Op. Dr. Eren Karayılan ");
            }
            else if (secilenBransAdi == "Psikiyatri")
            {
                listBox1.Items.Add("Prof. Dr. Elanur Çolak");
                listBox1.Items.Add("Dr. Mehmet Öz");
                listBox1.Items.Add("Op. Dr. Mustafa Şoray");
                listBox1.Items.Add("Prof. Dr. Ünal Baba ");
                listBox1.Items.Add("Op. Dr. Derbeder Berk ");
                listBox1.Items.Add("Op. Dr. Taksim Cenk");
                listBox1.Items.Add("Op. Dr. Recep Ertan");
            }
            else if (secilenBransAdi == "Göz Kliniği")
            {
                listBox1.Items.Add("Dr. Güven Demir");
                listBox1.Items.Add("Dr. Enes Batur ");
                listBox1.Items.Add("Prof. Dr. Tuna Tavus  ");
                listBox1.Items.Add("Op. Dr. Murat GF ");
                listBox1.Items.Add("Prof. Dr. Mahmut Ekrem ");
                listBox1.Items.Add("Op. Dr. Ajdar Anık ");
            }
            else if (secilenBransAdi == "Onkoloji")
            {
                listBox1.Items.Add("Dr. Oytun Erbaş");
                listBox1.Items.Add("Dr. Kandıralı Ferdi");
                listBox1.Items.Add("Op. Dr. Rambo Okan ");
                listBox1.Items.Add("Prof. Dr. Hakan Yağar");
                listBox1.Items.Add("Op. Dr. Mahsun Karaca ");
            }
            else if (secilenBransAdi == "Kardiyoloji")
            {
                listBox1.Items.Add("Dr. Şeyma Sünbül ");
                listBox1.Items.Add("Dr.Yaşar Ersoy ");
                listBox1.Items.Add("Op. Dr.Barış Bra ");
                listBox1.Items.Add("Prof. Dr. Yakup Usta ");
                listBox1.Items.Add("Op. Dr. Erdi Kızgır");
            }
        }

      

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            comboBoxSaat.Visible = true;
            labelSaat.Visible = true;
            SaatleriYukle();
            DateTime secilenTarih = dateTimePicker1.Value.Date;

           
            if (doluTarihler.Contains(secilenTarih))
            {
                MessageBox.Show("Üzgünüz, seçtiğiniz tarihte doktorun tüm randevuları doludur. Lütfen başka bir gün seçiniz.", "Tarih Dolu");

                
                comboBoxSaat.Visible = false;
                labelSaat.Visible = false;
                return;
            }

            
            labelSaat.Visible = true;
            comboBoxSaat.Visible = true;
            SaatleriYukle();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                
                dateTimePicker1.Visible = true;
                labelGun.Visible = true;
            }
        }
        private void SaatleriYukle()
        {
            comboBoxSaat.Items.Clear();
            doluSaatler.Clear();

            string[] tumSaatler = { "09:00", "10:00", "11:00","12:00", "13:00", "14:00", "15:00", "16:00","17:00"};

            foreach (string saat in tumSaatler)
            {
                
                if (rastgele.Next(0, 10) < 3)
                {
                    comboBoxSaat.Items.Add(saat + " (DOLU)");
                    doluSaatler.Add(saat + " (DOLU)"); 
                }
                else
                {
                    comboBoxSaat.Items.Add(saat);
                }
            }
        }
        private void DoluGunleriBelirle()
        {
            doluTarihler.Clear();
            DateTime bugun = DateTime.Today;

            
            for (int i = 0; i < 7; i++)
            {
                
                int rastgeleGunEkle = rastgele.Next(1, 31);
                DateTime secilenDoluGun = bugun.AddDays(rastgeleGunEkle);

                
                if (!doluTarihler.Contains(secilenDoluGun.Date))
                {
                    doluTarihler.Add(secilenDoluGun.Date);
                }
            }
        }
        private void comboBoxSaat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSaat.SelectedItem != null)
            {
                string secim = comboBoxSaat.SelectedItem.ToString();

                
                if (secim.Contains("(DOLU)"))
                {
                    MessageBox.Show("Bu saat doludur, lütfen başka bir saat seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                   
                    comboBoxSaat.SelectedIndex = -1;
                }
            }
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null || comboBoxSaat.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Doktor ve Saat seçimini eksiksiz yapınız!");
                return;
            }

           
            string doktor = listBox1.SelectedItem.ToString();
            string tarih = dateTimePicker1.Value.ToString("dd.MM.yyyy"); 
            string saat = comboBoxSaat.SelectedItem.ToString();

            
            Form5 onaySayfasi = new Form5(doktor, tarih, saat);

            
            onaySayfasi.Show();
            this.Hide();
        }
    }
}
