namespace Proje
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Musteri = new System.Windows.Forms.ToolStripMenuItem();
            this.Siparis = new System.Windows.Forms.ToolStripMenuItem();
            this.Stoklar = new System.Windows.Forms.ToolStripMenuItem();
            this.Satis = new System.Windows.Forms.ToolStripMenuItem();
            this.PROGRAMDANÇIKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(306, 396);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(264, 29);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(51, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 54);
            this.label1.TabIndex = 17;
            this.label1.Text = "ŞAHLAN PLASTİK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gold;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(0, 397);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 29);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "DUYURULAR";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Musteri,
            this.Siparis,
            this.Stoklar,
            this.Satis,
            this.PROGRAMDANÇIKToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuStrip1.Size = new System.Drawing.Size(573, 55);
            this.MenuStrip1.TabIndex = 20;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // Musteri
            // 
            this.Musteri.Image = ((System.Drawing.Image)(resources.GetObject("Musteri.Image")));
            this.Musteri.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Musteri.Name = "Musteri";
            this.Musteri.Size = new System.Drawing.Size(86, 51);
            this.Musteri.Text = "MÜŞTERİLER";
            this.Musteri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Musteri.Click += new System.EventHandler(this.Musteri_Click);
            // 
            // Siparis
            // 
            this.Siparis.Image = ((System.Drawing.Image)(resources.GetObject("Siparis.Image")));
            this.Siparis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Siparis.Name = "Siparis";
            this.Siparis.Size = new System.Drawing.Size(91, 51);
            this.Siparis.Text = "SİPARİŞ GİRİŞİ";
            this.Siparis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Siparis.Click += new System.EventHandler(this.Siparis_Click);
            // 
            // Stoklar
            // 
            this.Stoklar.Image = ((System.Drawing.Image)(resources.GetObject("Stoklar.Image")));
            this.Stoklar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Stoklar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Stoklar.Name = "Stoklar";
            this.Stoklar.Size = new System.Drawing.Size(68, 51);
            this.Stoklar.Text = "STOKLAR";
            this.Stoklar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Stoklar.Click += new System.EventHandler(this.Stoklar_Click);
            // 
            // Satis
            // 
            this.Satis.Image = ((System.Drawing.Image)(resources.GetObject("Satis.Image")));
            this.Satis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Satis.Name = "Satis";
            this.Satis.ShortcutKeyDisplayString = "F11";
            this.Satis.Size = new System.Drawing.Size(86, 51);
            this.Satis.Text = "SATIŞ İŞLEMİ";
            this.Satis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Satis.Click += new System.EventHandler(this.Satis_Click);
            // 
            // PROGRAMDANÇIKToolStripMenuItem
            // 
            this.PROGRAMDANÇIKToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PROGRAMDANÇIKToolStripMenuItem.Image")));
            this.PROGRAMDANÇIKToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PROGRAMDANÇIKToolStripMenuItem.Name = "PROGRAMDANÇIKToolStripMenuItem";
            this.PROGRAMDANÇIKToolStripMenuItem.ShortcutKeyDisplayString = "ALT+F4";
            this.PROGRAMDANÇIKToolStripMenuItem.Size = new System.Drawing.Size(122, 51);
            this.PROGRAMDANÇIKToolStripMenuItem.Text = "PROGRAMDAN ÇIK";
            this.PROGRAMDANÇIKToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PROGRAMDANÇIKToolStripMenuItem.Click += new System.EventHandler(this.PROGRAMDANÇIKToolStripMenuItem_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 426);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem Musteri;
        internal System.Windows.Forms.ToolStripMenuItem Siparis;
        internal System.Windows.Forms.ToolStripMenuItem Stoklar;
        internal System.Windows.Forms.ToolStripMenuItem Satis;
        internal System.Windows.Forms.ToolStripMenuItem PROGRAMDANÇIKToolStripMenuItem;
    }
}