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

namespace PROJEE1
{
    public partial class Kayit : Form

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
        public Kayit()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void kayitbt_Click(object sender, EventArgs e)
        
        {
            if (string.IsNullOrWhiteSpace(adtxt.Text) ||
                string.IsNullOrWhiteSpace(soyadtxt.Text) ||
                string.IsNullOrWhiteSpace(epostatxt.Text) ||
                string.IsNullOrWhiteSpace(ulkecomboBox.Text) ||
                string.IsNullOrWhiteSpace(sifretxt.Text))  
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5KQACGN\SQLEXPRESS;Initial Catalog=arackiralama;Integrated Security=True"))
                {
                    conn.Open();

                    // SQL INSERT sorgusu
                    string sorgu = "INSERT INTO Kayıt (Ad, Soyad,E_Posta,Ulke,şifre ) " +
                    "VALUES (@Ad, @Soyad, @E_Posta, @Ulke, @sifre )";

                    SqlCommand komut = new SqlCommand(sorgu, conn);
                    komut.Parameters.AddWithValue("@Ad", adtxt.Text);
                    komut.Parameters.AddWithValue("@Soyad", soyadtxt.Text);
                    komut.Parameters.AddWithValue("@E_Posta", epostatxt.Text);
                    komut.Parameters.AddWithValue("@Ulke", ulkecomboBox.Text);
                    komut.Parameters.AddWithValue("@sifre", sifretxt.Text);
                    
                    int sonuc = komut.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kayıt başarıyla tamamlandı!", "Başarılı");
                        AnaSayfa form3 = new AnaSayfa();
                        form3.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt başarısız. Hiçbir satır eklenmedi.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void geribt_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
    }

