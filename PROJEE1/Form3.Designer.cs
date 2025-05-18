namespace PROJEE1
{
    partial class AnaSayfa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cıkısbt = new System.Windows.Forms.Button();
            this.araceklebt = new System.Windows.Forms.Button();
            this.satısbt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cıkısbt);
            this.panel1.Controls.Add(this.araceklebt);
            this.panel1.Controls.Add(this.satısbt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 66);
            this.panel1.TabIndex = 0;
            // 
            // cıkısbt
            // 
            this.cıkısbt.Location = new System.Drawing.Point(219, 13);
            this.cıkısbt.Name = "cıkısbt";
            this.cıkısbt.Size = new System.Drawing.Size(76, 41);
            this.cıkısbt.TabIndex = 2;
            this.cıkısbt.Text = "Çıkış";
            this.cıkısbt.UseVisualStyleBackColor = true;
            this.cıkısbt.Click += new System.EventHandler(this.cıkısbt_Click);
            // 
            // araceklebt
            // 
            this.araceklebt.Location = new System.Drawing.Point(12, 13);
            this.araceklebt.Name = "araceklebt";
            this.araceklebt.Size = new System.Drawing.Size(76, 41);
            this.araceklebt.TabIndex = 0;
            this.araceklebt.Text = "Araç Ekle";
            this.araceklebt.UseVisualStyleBackColor = true;
            this.araceklebt.Click += new System.EventHandler(this.araceklebt_Click);
            // 
            // satısbt
            // 
            this.satısbt.Location = new System.Drawing.Point(114, 13);
            this.satısbt.Name = "satısbt";
            this.satısbt.Size = new System.Drawing.Size(77, 41);
            this.satısbt.TabIndex = 1;
            this.satısbt.Text = "Satış";
            this.satısbt.UseVisualStyleBackColor = true;
            this.satısbt.Click += new System.EventHandler(this.satısbt_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PROJEE1.Properties.Resources.arackiralama;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(322, 257);
            this.Controls.Add(this.panel1);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cıkısbt;
        private System.Windows.Forms.Button satısbt;
        private System.Windows.Forms.Button araceklebt;
    }
}