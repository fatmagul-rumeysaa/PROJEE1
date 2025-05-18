namespace PROJEE1
{
    partial class Form5
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
            this.seritxt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iptalbt = new System.Windows.Forms.Button();
            this.kayitbt = new System.Windows.Forms.Button();
            this.resimeklebt = new System.Windows.Forms.Button();
            this.kiraucretitxt = new System.Windows.Forms.TextBox();
            this.yakıttxt = new System.Windows.Forms.ComboBox();
            this.kmtxt = new System.Windows.Forms.TextBox();
            this.modeltxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.markatxt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plakatxt = new System.Windows.Forms.TextBox();
            this.resimbox = new System.Windows.Forms.PictureBox();
            this.renktxt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.resimbox)).BeginInit();
            this.SuspendLayout();
            // 
            // seritxt
            // 
            this.seritxt.FormattingEnabled = true;
            this.seritxt.Location = new System.Drawing.Point(106, 100);
            this.seritxt.Name = "seritxt";
            this.seritxt.Size = new System.Drawing.Size(121, 21);
            this.seritxt.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Seri";
            // 
            // iptalbt
            // 
            this.iptalbt.Location = new System.Drawing.Point(188, 315);
            this.iptalbt.Name = "iptalbt";
            this.iptalbt.Size = new System.Drawing.Size(76, 32);
            this.iptalbt.TabIndex = 59;
            this.iptalbt.Text = "İptal";
            this.iptalbt.UseVisualStyleBackColor = true;
            this.iptalbt.Click += new System.EventHandler(this.iptalbt_Click);
            // 
            // kayitbt
            // 
            this.kayitbt.Location = new System.Drawing.Point(88, 315);
            this.kayitbt.Name = "kayitbt";
            this.kayitbt.Size = new System.Drawing.Size(76, 32);
            this.kayitbt.TabIndex = 58;
            this.kayitbt.Text = "Kayıt";
            this.kayitbt.UseVisualStyleBackColor = true;
            this.kayitbt.Click += new System.EventHandler(this.kayitbt_Click);
            // 
            // resimeklebt
            // 
            this.resimeklebt.Location = new System.Drawing.Point(318, 175);
            this.resimeklebt.Name = "resimeklebt";
            this.resimeklebt.Size = new System.Drawing.Size(78, 30);
            this.resimeklebt.TabIndex = 57;
            this.resimeklebt.Text = "Resim Ekle";
            this.resimeklebt.UseVisualStyleBackColor = true;
            this.resimeklebt.Click += new System.EventHandler(this.resimeklebt_Click);
            // 
            // kiraucretitxt
            // 
            this.kiraucretitxt.Location = new System.Drawing.Point(106, 276);
            this.kiraucretitxt.Name = "kiraucretitxt";
            this.kiraucretitxt.Size = new System.Drawing.Size(121, 20);
            this.kiraucretitxt.TabIndex = 55;
            // 
            // yakıttxt
            // 
            this.yakıttxt.FormattingEnabled = true;
            this.yakıttxt.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin+Lpg"});
            this.yakıttxt.Location = new System.Drawing.Point(106, 238);
            this.yakıttxt.Name = "yakıttxt";
            this.yakıttxt.Size = new System.Drawing.Size(121, 21);
            this.yakıttxt.TabIndex = 54;
            // 
            // kmtxt
            // 
            this.kmtxt.Location = new System.Drawing.Point(106, 202);
            this.kmtxt.Name = "kmtxt";
            this.kmtxt.Size = new System.Drawing.Size(121, 20);
            this.kmtxt.TabIndex = 53;
            // 
            // modeltxt
            // 
            this.modeltxt.Location = new System.Drawing.Point(106, 132);
            this.modeltxt.Name = "modeltxt";
            this.modeltxt.Size = new System.Drawing.Size(121, 20);
            this.modeltxt.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Kira Ücreti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Yakıt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Km";
            // 
            // markatxt
            // 
            this.markatxt.FormattingEnabled = true;
            this.markatxt.Items.AddRange(new object[] {
            "Audi",
            "Mercedes",
            "BMW",
            "Ford"});
            this.markatxt.Location = new System.Drawing.Point(106, 67);
            this.markatxt.Name = "markatxt";
            this.markatxt.Size = new System.Drawing.Size(121, 21);
            this.markatxt.TabIndex = 47;
            this.markatxt.SelectedIndexChanged += new System.EventHandler(this.markatxt_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Model(Yıl)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Plaka";
            // 
            // plakatxt
            // 
            this.plakatxt.Location = new System.Drawing.Point(106, 31);
            this.plakatxt.Name = "plakatxt";
            this.plakatxt.Size = new System.Drawing.Size(121, 20);
            this.plakatxt.TabIndex = 42;
            // 
            // resimbox
            // 
            this.resimbox.Location = new System.Drawing.Point(278, 31);
            this.resimbox.Name = "resimbox";
            this.resimbox.Size = new System.Drawing.Size(152, 135);
            this.resimbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resimbox.TabIndex = 56;
            this.resimbox.TabStop = false;
            // 
            // renktxt
            // 
            this.renktxt.FormattingEnabled = true;
            this.renktxt.Location = new System.Drawing.Point(106, 166);
            this.renktxt.Name = "renktxt";
            this.renktxt.Size = new System.Drawing.Size(121, 21);
            this.renktxt.TabIndex = 62;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 371);
            this.Controls.Add(this.renktxt);
            this.Controls.Add(this.seritxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iptalbt);
            this.Controls.Add(this.kayitbt);
            this.Controls.Add(this.resimeklebt);
            this.Controls.Add(this.resimbox);
            this.Controls.Add(this.kiraucretitxt);
            this.Controls.Add(this.yakıttxt);
            this.Controls.Add(this.kmtxt);
            this.Controls.Add(this.modeltxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.markatxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plakatxt);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kayıt";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resimbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox seritxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button iptalbt;
        private System.Windows.Forms.Button kayitbt;
        private System.Windows.Forms.Button resimeklebt;
        private System.Windows.Forms.PictureBox resimbox;
        private System.Windows.Forms.TextBox kiraucretitxt;
        private System.Windows.Forms.ComboBox yakıttxt;
        private System.Windows.Forms.TextBox kmtxt;
        private System.Windows.Forms.TextBox modeltxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox markatxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox plakatxt;
        private System.Windows.Forms.ComboBox renktxt;
    }
}