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
    public partial class Form5 : Form
    {

        SQLBağlantim bgl = new SQLBağlantim();
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            markatxt.Items.AddRange(new string[] { "Mercedes", "BMW", "Ford", "Audi" });
            renktxt.Items.AddRange(new string[] { "Beyaz", "Siyah", "Gri", "Kırmızı" });
            yakıttxt.Items.AddRange(new string[] { "Benzin", "Dizel", "Benzin+Lpg" });

        }

        private void kayitbt_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = bgl.baglanti())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Araç (Plaka, Marka,Seri, Model, Renk, Km, Yakıt, Kira_Ücreti) VALUES (@plaka, @marka,@seri, @model, @renk, @km, @yakit, @kira)", conn);
                    cmd.Parameters.AddWithValue("@plaka", plakatxt.Text);
                    cmd.Parameters.AddWithValue("@marka", markatxt.Text);
                    cmd.Parameters.AddWithValue("@seri", seritxt.Text);
                    cmd.Parameters.AddWithValue("@model", modeltxt.Text);
                    cmd.Parameters.AddWithValue("@renk", renktxt.Text);
                    cmd.Parameters.AddWithValue("@km", kmtxt.Text);
                    cmd.Parameters.AddWithValue("@yakit", yakıttxt.Text);
                    cmd.Parameters.AddWithValue("@kira", kiraucretitxt.Text);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Araç başarıyla eklendi.");
                    AnaSayfa form3 = new AnaSayfa();
                    form3.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void iptalbt_Click(object sender, EventArgs e)
        {
            AnaSayfa form3 = new AnaSayfa();
            form3.Show();
            this.Hide();
        }

        private void resimeklebt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                resimbox.Image = Image.FromFile(openFileDialog.FileName);
                resimbox.Tag = openFileDialog.FileName; // Dosya yolunu sakla, veritabanına kaydederken kullan
            }
        }

        private void markatxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            seritxt.Items.Clear(); // Önceki serileri sil

            switch (markatxt.SelectedItem.ToString())
            {
                case "Mercedes":
                    seritxt.Items.AddRange(new string[] { "A Serisi", "C Serisi", "E Serisi" });
                    break;
                case "BMW":
                    seritxt.Items.AddRange(new string[] { "3 Serisi", "5 Serisi", "7 Serisi" });
                    break;
                case "Ford":
                    seritxt.Items.AddRange(new string[] { "Focus", "Fiesta", "Mustang" });
                    break;
                case "Audi":
                    seritxt.Items.AddRange(new string[] { "A3", "A4", "Q7" });
                    break;
            }
        }
    }
    }

      
