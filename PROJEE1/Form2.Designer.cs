namespace PROJEE1
{
    partial class Kayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hesaptipcomboBox = new System.Windows.Forms.ComboBox();
            this.adtxt = new System.Windows.Forms.TextBox();
            this.soyadtxt = new System.Windows.Forms.TextBox();
            this.epostatxt = new System.Windows.Forms.TextBox();
            this.ulkecomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kayitbt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.geribt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-posta adresi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hesap Tipi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // hesaptipcomboBox
            // 
            this.hesaptipcomboBox.FormattingEnabled = true;
            this.hesaptipcomboBox.Items.AddRange(new object[] {
            "Tüketici",
            "Satıcı"});
            this.hesaptipcomboBox.Location = new System.Drawing.Point(135, 111);
            this.hesaptipcomboBox.Name = "hesaptipcomboBox";
            this.hesaptipcomboBox.Size = new System.Drawing.Size(121, 21);
            this.hesaptipcomboBox.TabIndex = 4;
            // 
            // adtxt
            // 
            this.adtxt.Location = new System.Drawing.Point(135, 12);
            this.adtxt.Name = "adtxt";
            this.adtxt.Size = new System.Drawing.Size(100, 20);
            this.adtxt.TabIndex = 6;
            // 
            // soyadtxt
            // 
            this.soyadtxt.Location = new System.Drawing.Point(135, 44);
            this.soyadtxt.Name = "soyadtxt";
            this.soyadtxt.Size = new System.Drawing.Size(100, 20);
            this.soyadtxt.TabIndex = 7;
            // 
            // epostatxt
            // 
            this.epostatxt.Location = new System.Drawing.Point(135, 77);
            this.epostatxt.Name = "epostatxt";
            this.epostatxt.Size = new System.Drawing.Size(100, 20);
            this.epostatxt.TabIndex = 8;
            // 
            // ulkecomboBox
            // 
            this.ulkecomboBox.FormattingEnabled = true;
            this.ulkecomboBox.Items.AddRange(new object[] {
            "A.B.D.",
            "ABD",
            "Abhazya",
            "Acarya",
            "Acem",
            "Adıge Cumhuriyeti",
            "Afganistan",
            "Afganistan İslam Cumhuriyeti",
            "Almanya",
            "Almanya Federal Cumhuriyeti",
            "Altay",
            "Altay Cumhuriyeti",
            "Amerika",
            "Amerika Birleşik Devletleri",
            "Amerikan Samoası",
            "Andorra",
            "Andorra Prensliği",
            "Angola",
            "Angola Cumhuriyeti",
            "Arabistan",
            "",
            "A.B.D.",
            "ABD",
            "Abhazya",
            "Acarya",
            "Acem",
            "Adıge Cumhuriyeti",
            "Afganistan",
            "Afganistan İslam Cumhuriyeti",
            "Almanya",
            "Almanya Federal Cumhuriyeti",
            "Altay",
            "Altay Cumhuriyeti",
            "Amerika",
            "Amerika Birleşik Devletleri",
            "Amerikan Samoası",
            "Andorra",
            "Andorra Prensliği",
            "Angola",
            "Angola Cumhuriyeti",
            "Arabistan",
            "Arjantin",
            "Arjantin Cumhuriyeti",
            "Arnavutluk",
            "Arnavutluk Cumhuriyeti",
            "Avustralya",
            "Avusturya",
            "Avusturya Cumhuriyeti",
            "Azerbaycan",
            "Azerbaycan Cumhuriyeti",
            "B",
            "Bahamalar",
            "Bahreyn",
            "Bahreyn Krallığı",
            "Bangladeş",
            "Bangladeş Halk Cumhuriyeti",
            "Barbados",
            "Belarus",
            "Belarus Cumhuriyeti",
            "Belçika",
            "Belçika Krallığı",
            "Belize",
            "Benin",
            "Benin Cumhuriyeti",
            "Bermuda",
            "Beyaz Rusya",
            "Beyaz Rusya Cumhuriyeti",
            "Bhutan",
            "Bhutan Krallığı",
            "Birleşik Arap Emirlikleri",
            "Birleşik Devletler",
            "Birleşik Krallık",
            "Birmanya",
            "Bolivarcı Venezuela Cumhuriyeti",
            "Bolivya",
            "Bosna ve Hersek",
            "Bosna-Hersek",
            "Botsvana",
            "Botsvana Cumhuriyeti",
            "Brezilya",
            "Brezilya Federal Cumhuriyeti",
            "Bruney",
            "Bruney Sultanlığı",
            "Bulgaristan",
            "Bulgaristan Cumhuriyeti",
            "Burkina Faso",
            "Burma",
            "Burundi",
            "Burundi Cumhuriyeti",
            "Butan",
            "Butan Krallığı",
            "C",
            "Cebelitarık Boğazı",
            "Cezayir",
            "Cezayir Demokratik Halk Cumhuriyeti",
            "Cibuti",
            "Cibuti Cumhuriyeti",
            "Cook Adaları",
            "Ç",
            "Çad",
            "Çad Cumhuriyeti",
            "ÇC",
            "Çeçenistan",
            "Çek Cumhuriyeti",
            "Çekoslovakya",
            "Çekya",
            "ÇHC",
            "Çin",
            "Çin Cumhuriyeti",
            "Çin Halk Cumhuriyeti",
            "Çokuluslu Bolivya Devleti",
            "Çuvaşistan",
            "D",
            "Dağıstan",
            "Danimarka",
            "Danimarka Krallığı",
            "Demokratik Kongo Cumhuriyeti",
            "Doğu Timor",
            "Doğu Timor Demokratik Cumhuriyeti",
            "Dominik",
            "Dominik Cumhuriyeti",
            "Dominika",
            "E",
            "Ekvador",
            "Ekvador Cumhuriyeti",
            "Ekvator Ginesi",
            "Ekvator Ginesi Cumhuriyeti",
            "El Salvador",
            "El Salvador Cumhuriyeti",
            "Endonezya",
            "Endonezya Cumhuriyeti",
            "Eritre",
            "Eritre Devleti",
            "Ermenistan",
            "Ermenistan Cumhuriyeti",
            "Eski Yugoslav Makedonya Cumhuriyeti",
            "Estonya",
            "Estonya Cumhuriyeti",
            "Etyopya",
            "Etyopya Federal Demokratik Cumhuriyeti",
            "EYMC",
            "F",
            "Fääri saared",
            "Faroe Adaları",
            "Fas",
            "Fas Krallığı",
            "Fiji",
            "Fiji Adaları Cumhuriyeti",
            "Fildişi Sahili",
            "Fildişi Sahili Cumhuriyeti",
            "Filipinler",
            "Filipinler Cumhuriyeti",
            "Finlandiya",
            "Finlandiya Cumhuriyeti",
            "Fransa",
            "Fransız Cumhuriyeti",
            "Frigya",
            "G",
            "Gabon",
            "Gabon Cumhuriyeti",
            "Gagavuzya",
            "Gambiya",
            "Gambiya Cumhuriyeti",
            "Gana",
            "Gana Cumhuriyeti",
            "Gine",
            "Gine Bissau Cumhuriyeti",
            "Gine Cumhuriyeti",
            "Gine-Bissau",
            "Gine=Bissau",
            "Grenada",
            "Guatemala",
            "Guatemala Cumhuriyeti",
            "Guyana",
            "Guyana Müşterek Cumhuriyeti",
            "Güney Afrika",
            "Güney Afrika Cumhuriyeti",
            "Güney Kore",
            "Güney Sudan",
            "Güney Sudan Cumhuriyeti",
            "Gürcistan",
            "H",
            "Haiti",
            "Haiti Cumhuriyeti",
            "Hırvatistan",
            "Hırvatistan Cumhuriyeti",
            "Hindistan",
            "Hindistan Cumhuriyeti",
            "Hollanda",
            "Hollanda Krallığı",
            "Honduras",
            "Honduras Cumhuriyeti",
            "I",
            "Irak",
            "Irak Cumhuriyeti",
            "İ",
            "İngiltere",
            "İran",
            "İran İslam Cumhuriyeti",
            "İrlanda",
            "İrlanda Cumhuriyeti",
            "İspanya",
            "İspanya Krallığı",
            "İsrail",
            "İsrail Devleti",
            "İsveç",
            "İsveç Krallığı",
            "İsviçre",
            "İsviçre Konfederasyonu",
            "İtalya",
            "İtalya Cumhuriyeti",
            "İzlanda",
            "İzlanda Cumhuriyeti",
            "J",
            "Jamaika",
            "Japonya",
            "K",
            "Kalmukya",
            "Kamboçya",
            "Kamboçya Krallığı",
            "Kamerun",
            "Kamerun Cumhuriyeti",
            "Kanada",
            "Kapo Verde",
            "Kapo Verde Cumhuriyeti",
            "Karadağ",
            "Karadağ Cumhuriyeti",
            "Katar",
            "Katar Devleti",
            "Kayman Adaları",
            "Kazakistan",
            "Kazakistan Cumhuriyeti",
            "Kenya"});
            this.ulkecomboBox.Location = new System.Drawing.Point(135, 147);
            this.ulkecomboBox.Name = "ulkecomboBox";
            this.ulkecomboBox.Size = new System.Drawing.Size(121, 21);
            this.ulkecomboBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ülke";
            // 
            // kayitbt
            // 
            this.kayitbt.BackColor = System.Drawing.Color.White;
            this.kayitbt.Location = new System.Drawing.Point(88, 224);
            this.kayitbt.Name = "kayitbt";
            this.kayitbt.Size = new System.Drawing.Size(85, 31);
            this.kayitbt.TabIndex = 11;
            this.kayitbt.Text = "Kayıt Ol";
            this.kayitbt.UseVisualStyleBackColor = false;
            this.kayitbt.Click += new System.EventHandler(this.kayitbt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Şifre";
            // 
            // sifretxt
            // 
            this.sifretxt.Location = new System.Drawing.Point(135, 181);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(100, 20);
            this.sifretxt.TabIndex = 13;
            // 
            // geribt
            // 
            this.geribt.BackColor = System.Drawing.Color.White;
            this.geribt.Location = new System.Drawing.Point(188, 224);
            this.geribt.Name = "geribt";
            this.geribt.Size = new System.Drawing.Size(85, 31);
            this.geribt.TabIndex = 14;
            this.geribt.Text = "Geri";
            this.geribt.UseVisualStyleBackColor = false;
            this.geribt.Click += new System.EventHandler(this.geribt_Click);
            // 
            // Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(395, 289);
            this.Controls.Add(this.geribt);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kayitbt);
            this.Controls.Add(this.ulkecomboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.epostatxt);
            this.Controls.Add(this.soyadtxt);
            this.Controls.Add(this.adtxt);
            this.Controls.Add(this.hesaptipcomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Formu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox hesaptipcomboBox;
        private System.Windows.Forms.TextBox adtxt;
        private System.Windows.Forms.TextBox soyadtxt;
        private System.Windows.Forms.TextBox epostatxt;
        private System.Windows.Forms.ComboBox ulkecomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button kayitbt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sifretxt;
        private System.Windows.Forms.Button geribt;
    }
}