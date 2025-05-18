using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROJEE1
{

    public partial class Form4 : Form
    {

        SQLBağlantim bgl = new SQLBağlantim();
        public class Baglanti
        {
            public SqlConnection baglanti()
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5KQACGN\SQLEXPRESS;Initial Catalog=arackiralama;Integrated Security=True");
                return conn;
            }
        }

        public Form4()
        {
            InitializeComponent();
        }
        public void AraclariYukle()
        {

            try
            {
                Baglanti b = new Baglanti();
                using (SqlConnection conn = b.baglanti())
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [Araç]", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yüklenirken hata: " + ex.Message);
            }
        }
        public void MusaitAraclariYukle()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5KQACGN\SQLEXPRESS;Initial Catalog=arackiralama;Integrated Security=True"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Plaka FROM [Araç] WHERE Ad IS NULL", conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        plakatxt.Items.Add(dr["Plaka"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müsait araçlar yüklenirken hata: " + ex.Message);
            }
        }
        private void musaitAraclarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5KQACGN\SQLEXPRESS;Initial Catalog=arackiralama;Integrated Security=True"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM [Araç] WHERE Plaka=@plaka", conn);
                    cmd.Parameters.AddWithValue("@plaka", plakatxt.SelectedItem.ToString());

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        markatxt.Text = dr["Marka"].ToString();
                        modeltxt.Text = dr["Model"].ToString();
                        seritxt.Text = dr["Seri"].ToString();
                        renktxt.Text = dr["Renk"].ToString();
                        kmtxt.Text = dr["Km"].ToString();
                        yakittxt.Text = dr["Yakıt"].ToString();
                        kiraucretitxt.Text = dr["Kira_Ücreti"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Araç bilgileri yüklenirken hata: " + ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
            this.araçTableAdapter.Fill(this.arackiralamaDataSet.Araç);
            MusaitAraclariYukle();
            AraclariYukle();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void satısbt_Click(object sender, EventArgs e)
        {
            try
            {
                // Tarihleri DateTime olarak parse et
                DateTime cikisTarihi = DateTime.Parse(cıkıstxt.Text);
                DateTime donusTarihi = DateTime.Parse(donustxt.Text);

                // Gün farkı hesapla (en az 1 gün olmalı)
                int gunFarki = (donusTarihi - cikisTarihi).Days;
                if (gunFarki <= 0)
                {
                    MessageBox.Show("Dönüş tarihi, çıkış tarihinden sonra olmalıdır.");
                    return;
                }

                // Kira ücretini decimal olarak al
                decimal kiraUcreti;
                if (!decimal.TryParse(kiraucretitxt.Text, out kiraUcreti))
                {
                    MessageBox.Show("Kira ücreti geçerli bir sayı olmalıdır.");
                    return;
                }

                // Toplam tutar hesapla
                decimal toplamTutar = gunFarki * kiraUcreti;

                // Textbox'a yaz
                toplamtutartxt.Text = toplamTutar.ToString("0.00");
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5KQACGN\SQLEXPRESS;Initial Catalog=arackiralama;Integrated Security=True"))
                {
                    conn.Open();

                    // SQL INSERT sorgusu
                    string sorgu = "INSERT INTO [Araç] (Plaka, Marka, Model, Renk, Km, Yakıt, Kira_Ücreti, Ad, Soyad, [E-Posta], Ülke, [Kira Şekli], [Çıkış Tarihi], [Dönüş Tarihi], [Toplam Tutar] ) " +
                    "VALUES (@plaka, @marka, @model, @renk, @km, @yakit, @kiraucreti, @ad, @soyad, @eposta, @ulke, @kirasekli, @cikistarihi, @donustarihi, @toplamtutar )";

                    SqlCommand komut = new SqlCommand(sorgu, conn);
                    komut.Parameters.AddWithValue("@plaka", plakatxt.Text);
                    komut.Parameters.AddWithValue("@marka", markatxt.Text);
                    komut.Parameters.AddWithValue("@model", modeltxt.Text);
                    komut.Parameters.AddWithValue("@renk", renktxt.Text);
                    komut.Parameters.AddWithValue("@km",   kmtxt.Text);
                    komut.Parameters.AddWithValue("@yakit", yakittxt.Text);
                    komut.Parameters.AddWithValue("@kiraucreti", Convert.ToDecimal(kiraucretitxt.Text));
                    komut.Parameters.AddWithValue("@ad", adtxt.Text);
                    komut.Parameters.AddWithValue("@soyad", soyadtxt.Text);
                    komut.Parameters.AddWithValue("@eposta", epostatxt.Text);
                    komut.Parameters.AddWithValue("@ulke", ulketxt.Text);
                    komut.Parameters.AddWithValue("@kirasekli", kiraseklitxt.Text);
                    komut.Parameters.AddWithValue("@cikistarihi", cikisTarihi.ToString());
                    komut.Parameters.AddWithValue("@donustarihi", donusTarihi.ToString());
                    komut.Parameters.AddWithValue("@toplamtutar", Convert.ToDecimal(toplamtutartxt.Text));

                    int sonuc = komut.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kiralama işlemi başarıyla tamamlandı!", "Başarılı");
                        AnaSayfa form3 = new AnaSayfa();
                        form3.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kiralama başarısız. ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cıkısbt_Click(object sender, EventArgs e)
        {
            AnaSayfa form3 = new AnaSayfa();
            form3.Show();
            this.Hide();
        }
    }
}
