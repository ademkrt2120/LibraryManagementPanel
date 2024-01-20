using System.Data.SqlClient;
using System.Windows.Forms;

namespace KütüphaneYönetimi
{
    public partial class Form1 : Form
    {
        Kitaplar kitaplar;
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FJ38RU0;Initial Catalog=DbKutuphaneYonetimi;Integrated Security=True");
        private void buttonGiris_Click(object sender, EventArgs e)
        {
            string sifre = "";

            try
            {
                baglanti.Open();

                SqlCommand sqlKomut = new SqlCommand("SELECT sifre FROM Kullanicilar WHERE kullanici_ad = @p1", baglanti);
                sqlKomut.Parameters.AddWithValue("@p1", textBoxKullaniciAd.Text);
                SqlDataReader sqlDataReader = sqlKomut.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    sifre = sqlDataReader[0].ToString();
                }

                if (sifre == textBoxSifre.Text)
                {
                    kitaplar = new Kitaplar();
                    this.Hide();
                    kitaplar.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adınız Veya Şifreniz Hatalıdır ! Lütfen Kontrol Edin");
                    textBoxKullaniciAd.Text = "";
                    textBoxSifre.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı Hatası! : " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}