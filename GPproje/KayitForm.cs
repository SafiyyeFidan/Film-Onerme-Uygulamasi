using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GPproje
{
    public partial class KayitForm : Form
    {
        public KayitForm()
        {
            InitializeComponent();
        }
        private void KayitForm_Load(object sender, EventArgs e)
        {
            

        private void label2_Click(object sender, EventArgs e)
        {

        }

            private void btnKayitOl_Click(object sender, EventArgs e) // Butonunun adı farklı olabilir
        {
            // 1. ADIM: Bağlantı adresini kesinlikle logingp yapıyoruz
            string baglantiAdresi = @"Data Source=DESKTOP-0NO23VL\SQLEXPRESS;Initial Catalog=logingp;Integrated Security=True;TrustServerCertificate=True;";

            // Textbox'ların boş olup olmadığını kontrol edelim ki SQL'e boş veri gitmesin
            if (string.IsNullOrEmpty(kayitİsimtextbox.Text) || string.IsNullOrEmpty(kayitSifretextbox.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
                return;
            }
            
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();

                    // 2. ADIM: Tablo ve sütun isimlerinin SQL ile birebir aynı olduğundan emin oluyoruz
                    string sorgu = "INSERT INTO Kullanicilar (KullaniciAdi, Sifre) VALUES (@kadi, @sifre)";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        // Parametreleri tırnak işaretleriyle güvenli şekilde bağlıyoruz
                        komut.Parameters.AddWithValue("@kadi", kayitİsimtextbox.Text);
                        komut.Parameters.AddWithValue("@sifre", kayitSifretextbox.Text);

                        int etkilenenSatir = komut.ExecuteNonQuery(); // Veriyi SQL'e işler

                        if (etkilenenSatir > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla oluşturuldu! Giriş ekranına yönlendiriliyorsunuz.");

                            // Giriş ekranına geri döndür
                            Form2 girisEkrani = new Form2();
                            girisEkrani.Show();
                            this.Close(); // Kayıt formunu tamamen kapat
                        }
                        else
                        {
                            MessageBox.Show("Kayıt oluşturulamadı, lütfen tekrar deneyin.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Bilgisayarın bize tam olarak neden hata verdiğini göstermesi için catch kısmını böyle yapalım:
                MessageBox.Show("Hata Oluştu: " + ex.Message);
            }
        }
    }
            }





