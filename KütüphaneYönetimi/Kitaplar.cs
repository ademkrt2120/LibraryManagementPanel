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

namespace KütüphaneYönetimi
{
    public partial class Kitaplar : Form
    {
        public Kitaplar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FJ38RU0;Initial Catalog=DbKutuphaneYonetimi;Integrated Security=True");

        private void verileriGöster()
        {
            try
            {
                string g = "SELECT * FROM Kitaplar ";
                SqlDataAdapter da = new SqlDataAdapter(g, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewKitaplar.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri gösterilirken bir hata oluştu," + ex.Message);
            }
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Kitaplar (kitap_ad,yazar_ad," +
                "yazar_soyad,ISBN,durum,kitap_tur_kodu) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", baglanti);

                sqlCommand.Parameters.AddWithValue("@P1", textBoxKitapAd.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxYazarAd.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBoxYazarSoyad.Text);
                sqlCommand.Parameters.AddWithValue("@P4", textBoxISBN.Text);
                sqlCommand.Parameters.AddWithValue("@P5", "True");
                sqlCommand.Parameters.AddWithValue("@P6", textBoxKitapTurKod.Text);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap eklenirken bir hata oluştu" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            verileriGöster();
        }

        private void buttonVeriGetir_Click(object sender, EventArgs e)
        {
            verileriGöster();
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE Kitaplar SET kitap_ad = @P1," +
                    "yazar_ad = @P2, yazar_soyad = @P3, ISBN = @P4, kitap_tur_kodu = @P5 WHERE ID = @P6", baglanti);

                sqlCommand.Parameters.AddWithValue("@P1", textBoxKitapAd.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxYazarAd.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBoxYazarSoyad.Text);
                sqlCommand.Parameters.AddWithValue("@P4", textBoxISBN.Text);
                sqlCommand.Parameters.AddWithValue("@P5", textBoxKitapTurKod.Text);
                sqlCommand.Parameters.AddWithValue("@P6", labelID.Text);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap bilgisi güncellenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            verileriGöster();
        }

        private void Kitaplar_Load(object sender, EventArgs e)
        {
            verileriGöster();
        }

        private void dataGridViewKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelGecikmeBedeli.Text = "0";
            int secilenSatir = dataGridViewKitaplar.SelectedCells[0].RowIndex;
            labelID.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxKitapAd.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[1].Value.ToString();
            textBoxYazarAd.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[2].Value.ToString();
            textBoxYazarSoyad.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[3].Value.ToString();
            textBoxISBN.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[4].Value.ToString();
            textBoxKitapTurKod.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[8].Value.ToString();

            textBoxOduncAlan.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[6].Value.ToString();
            if (dataGridViewKitaplar.Rows[secilenSatir].Cells[7].Value != System.DBNull.Value)
            {
                dateTimePickerTarih.Value = (DateTime)dataGridViewKitaplar.Rows[secilenSatir].Cells[7].Value;
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (labelID.Text == "-" || labelID.Text == "")
            {
                MessageBox.Show("Lütfen Listeden Bir Kitap Seçin");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM Kitaplar WHERE ID = @P1", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", labelID.Text);

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap silinirken hata oluştu: " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }

                verileriGöster();
                metinKutularınıTemizle();
            }
        }

        public void metinKutularınıTemizle()
        {
            labelID.Text = "";
            textBoxKitapAd.Text = "";
            textBoxYazarAd.Text = "";
            textBoxYazarSoyad.Text = "";
            textBoxKitapTurKod.Text = "";
            textBoxISBN.Text = "";
            textBoxOduncAlan.Text = "";
            labelGecikmeBedeli.Text = "0";
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            metinKutularınıTemizle();
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            aramaSonuclarıGoster();
        }

        private void aramaSonuclarıGoster()
        {
            try
            {
                string q = "SELECT * FROM Kitaplar WHERE kitap_ad LIKE '" + textBoxKitapAd.Text + "%'" +
                    "AND yazar_ad LIKE '" + textBoxYazarAd.Text + "%'" +
                    "AND yazar_soyad LIKE '" + textBoxYazarSoyad.Text + "%'" +
                    "AND ISBN LIKE '" + textBoxISBN.Text + "%'" +
                    "AND kitap_tur_kodu LIKE '" + textBoxKitapTurKod.Text + "%'";

                SqlDataAdapter da = new SqlDataAdapter(q, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewKitaplar.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap bulunurken bir hata oldu :" + ex.Message);
            }
        }

        private void buttonOduncVer_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE Kitaplar SET odunc_alan = @P1, odunc_alma_tarihi = @P2, durum = @P3 WHERE ID = @P4", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", textBoxOduncAlan.Text);
                    sqlCommand.Parameters.Add("@P2", SqlDbType.Date).Value = dateTimePickerTarih.Value.Date;
                    sqlCommand.Parameters.AddWithValue("@P3", "False");
                    sqlCommand.Parameters.AddWithValue("@P4", labelID.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap ödünç verilirken bir hata oluştu : " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }

                verileriGöster();
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir kitap seçin !");
            }
        }

        private void buttonGecikmeHesapla_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                DateTime bugununtarihi = DateTime.Now;
                int gunFarki = (int)(bugununtarihi - dateTimePickerTarih.Value.Date).TotalDays;
                if (gunFarki > 10)
                {
                    int gecikmeBedeli = (gunFarki - 10) * 1;
                    labelGecikmeBedeli.Text = gecikmeBedeli.ToString();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kitap seçimi yapınız !");
            }
        }

        private void buttonİadeEt_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE Kitaplar SET odunc_alan = @P1, odunc_alma_tarihi = @P2, durum = @P3 WHERE ID = @P4", baglanti);

                sqlCommand.Parameters.AddWithValue("@P1", " ");
                sqlCommand.Parameters.AddWithValue("@P2", SqlDbType.Date).Value = DBNull.Value;
                sqlCommand.Parameters.AddWithValue("@p3", "True");
                sqlCommand.Parameters.AddWithValue("@P4", labelID.Text);
                sqlCommand.ExecuteNonQuery();
                textBoxOduncAlan.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap iade işlemi sirasinda bir hata oluştu ! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            verileriGöster();
        }

        private void Kitaplar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
