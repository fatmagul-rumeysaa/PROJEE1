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
    public partial class Form1 : Form
    {

        SQLBağlantim bgl = new SQLBağlantim();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void kayıtbt_Click(object sender, EventArgs e)
        {

            Kayit form2 = new Kayit();
            form2.Show();
            this.Hide();
        }

        private void girisbt_Click(object sender, EventArgs e)
        {

            string eposta = textBox1.Text;
            string sifre = textBox2.Text;

            using (SqlConnection conn = bgl.baglanti())
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Kayıt WHERE E_Posta=@eposta AND şifre=@sifre", conn);
                cmd.Parameters.AddWithValue("@eposta", eposta);
                cmd.Parameters.AddWithValue("@sifre", sifre);

                int sonuc = (int)cmd.ExecuteScalar();

                if (sonuc > 0)
                {
                    AnaSayfa form3 = new AnaSayfa();
                    form3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı e-posta veya şifre!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        }
    }

