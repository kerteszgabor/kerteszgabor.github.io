namespace Szoftver
{
    partial class Form1
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
            this.BT_word = new System.Windows.Forms.Button();
            this.BT_paint = new System.Windows.Forms.Button();
            this.LB_kiir = new System.Windows.Forms.ListBox();
            this.BT_wordinfo = new System.Windows.Forms.Button();
            this.BT_paintinfo = new System.Windows.Forms.Button();
            this.BT_vissza = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BT_kep = new System.Windows.Forms.Button();
            this.BT_visszaP = new System.Windows.Forms.Button();
            this.Eredmeny = new System.Windows.Forms.Label();
            this.R = new System.Windows.Forms.NumericUpDown();
            this.G = new System.Windows.Forms.NumericUpDown();
            this.B = new System.Windows.Forms.NumericUpDown();
            this.LBL_RGB = new System.Windows.Forms.Label();
            this.TB_wordszoveg = new System.Windows.Forms.TextBox();
            this.GB_szerkesztés = new System.Windows.Forms.GroupBox();
            this.Meret = new System.Windows.Forms.NumericUpDown();
            this.betumeret = new System.Windows.Forms.Label();
            this.csakszo = new System.Windows.Forms.Label();
            this.LBL_worderedmeny = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).BeginInit();
            this.GB_szerkesztés.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Meret)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_word
            // 
            this.BT_word.Location = new System.Drawing.Point(241, 33);
            this.BT_word.Name = "BT_word";
            this.BT_word.Size = new System.Drawing.Size(75, 23);
            this.BT_word.TabIndex = 0;
            this.BT_word.Text = "Word";
            this.BT_word.UseVisualStyleBackColor = true;
            this.BT_word.Click += new System.EventHandler(this.BT_word_Click);
            // 
            // BT_paint
            // 
            this.BT_paint.Location = new System.Drawing.Point(411, 33);
            this.BT_paint.Name = "BT_paint";
            this.BT_paint.Size = new System.Drawing.Size(75, 23);
            this.BT_paint.TabIndex = 1;
            this.BT_paint.Text = "Paint";
            this.BT_paint.UseVisualStyleBackColor = true;
            this.BT_paint.Click += new System.EventHandler(this.BT_paint_Click);
            // 
            // LB_kiir
            // 
            this.LB_kiir.FormattingEnabled = true;
            this.LB_kiir.Location = new System.Drawing.Point(43, 386);
            this.LB_kiir.Name = "LB_kiir";
            this.LB_kiir.Size = new System.Drawing.Size(458, 56);
            this.LB_kiir.TabIndex = 2;
            this.LB_kiir.Visible = false;
            // 
            // BT_wordinfo
            // 
            this.BT_wordinfo.Location = new System.Drawing.Point(241, 74);
            this.BT_wordinfo.Name = "BT_wordinfo";
            this.BT_wordinfo.Size = new System.Drawing.Size(75, 23);
            this.BT_wordinfo.TabIndex = 3;
            this.BT_wordinfo.Text = "Információk";
            this.BT_wordinfo.UseVisualStyleBackColor = true;
            this.BT_wordinfo.Visible = false;
            this.BT_wordinfo.Click += new System.EventHandler(this.BT_wordinfo_Click);
            // 
            // BT_paintinfo
            // 
            this.BT_paintinfo.Location = new System.Drawing.Point(411, 74);
            this.BT_paintinfo.Name = "BT_paintinfo";
            this.BT_paintinfo.Size = new System.Drawing.Size(75, 23);
            this.BT_paintinfo.TabIndex = 4;
            this.BT_paintinfo.Text = "Információk";
            this.BT_paintinfo.UseVisualStyleBackColor = true;
            this.BT_paintinfo.Visible = false;
            this.BT_paintinfo.Click += new System.EventHandler(this.BT_paintinfo_Click);
            // 
            // BT_vissza
            // 
            this.BT_vissza.Location = new System.Drawing.Point(602, 419);
            this.BT_vissza.Name = "BT_vissza";
            this.BT_vissza.Size = new System.Drawing.Size(75, 23);
            this.BT_vissza.TabIndex = 5;
            this.BT_vissza.Text = "Vissza";
            this.BT_vissza.UseVisualStyleBackColor = true;
            this.BT_vissza.Visible = false;
            this.BT_vissza.Click += new System.EventHandler(this.BT_vissza_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // BT_kep
            // 
            this.BT_kep.Location = new System.Drawing.Point(395, 115);
            this.BT_kep.Name = "BT_kep";
            this.BT_kep.Size = new System.Drawing.Size(106, 23);
            this.BT_kep.TabIndex = 7;
            this.BT_kep.Text = "Kép megjelenítése";
            this.BT_kep.UseVisualStyleBackColor = true;
            this.BT_kep.Visible = false;
            this.BT_kep.Click += new System.EventHandler(this.BT_kep_Click);
            // 
            // BT_visszaP
            // 
            this.BT_visszaP.Location = new System.Drawing.Point(1, 1);
            this.BT_visszaP.Name = "BT_visszaP";
            this.BT_visszaP.Size = new System.Drawing.Size(51, 38);
            this.BT_visszaP.TabIndex = 8;
            this.BT_visszaP.Text = "Vissza (Paint)";
            this.BT_visszaP.UseVisualStyleBackColor = true;
            this.BT_visszaP.Visible = false;
            this.BT_visszaP.Click += new System.EventHandler(this.BT_visszaP_Click);
            // 
            // Eredmeny
            // 
            this.Eredmeny.AutoSize = true;
            this.Eredmeny.Location = new System.Drawing.Point(147, 135);
            this.Eredmeny.Name = "Eredmeny";
            this.Eredmeny.Size = new System.Drawing.Size(57, 13);
            this.Eredmeny.TabIndex = 9;
            this.Eredmeny.Text = "Eredmény:";
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(133, 62);
            this.R.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(51, 20);
            this.R.TabIndex = 11;
            this.R.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.R.ValueChanged += new System.EventHandler(this.R_ValueChanged);
            // 
            // G
            // 
            this.G.Location = new System.Drawing.Point(190, 62);
            this.G.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(51, 20);
            this.G.TabIndex = 12;
            this.G.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.G.ValueChanged += new System.EventHandler(this.G_ValueChanged);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(247, 62);
            this.B.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(51, 20);
            this.B.TabIndex = 13;
            this.B.Value = new decimal(new int[] {
            147,
            0,
            0,
            0});
            this.B.ValueChanged += new System.EventHandler(this.B_ValueChanged);
            // 
            // LBL_RGB
            // 
            this.LBL_RGB.AutoSize = true;
            this.LBL_RGB.Location = new System.Drawing.Point(17, 64);
            this.LBL_RGB.Name = "LBL_RGB";
            this.LBL_RGB.Size = new System.Drawing.Size(110, 13);
            this.LBL_RGB.TabIndex = 14;
            this.LBL_RGB.Text = "Szín beállítás(R-G-B):";
            // 
            // TB_wordszoveg
            // 
            this.TB_wordszoveg.Location = new System.Drawing.Point(150, 25);
            this.TB_wordszoveg.MaxLength = 20;
            this.TB_wordszoveg.Name = "TB_wordszoveg";
            this.TB_wordszoveg.Size = new System.Drawing.Size(100, 20);
            this.TB_wordszoveg.TabIndex = 15;
            this.TB_wordszoveg.Text = "-szó-";
            this.TB_wordszoveg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_wordszoveg.TextChanged += new System.EventHandler(this.TB_wordszoveg_TextChanged);
            // 
            // GB_szerkesztés
            // 
            this.GB_szerkesztés.Controls.Add(this.Meret);
            this.GB_szerkesztés.Controls.Add(this.betumeret);
            this.GB_szerkesztés.Controls.Add(this.csakszo);
            this.GB_szerkesztés.Controls.Add(this.LBL_worderedmeny);
            this.GB_szerkesztés.Controls.Add(this.LBL_RGB);
            this.GB_szerkesztés.Controls.Add(this.TB_wordszoveg);
            this.GB_szerkesztés.Controls.Add(this.Eredmeny);
            this.GB_szerkesztés.Controls.Add(this.R);
            this.GB_szerkesztés.Controls.Add(this.G);
            this.GB_szerkesztés.Controls.Add(this.B);
            this.GB_szerkesztés.Location = new System.Drawing.Point(75, 154);
            this.GB_szerkesztés.Name = "GB_szerkesztés";
            this.GB_szerkesztés.Size = new System.Drawing.Size(373, 209);
            this.GB_szerkesztés.TabIndex = 16;
            this.GB_szerkesztés.TabStop = false;
            this.GB_szerkesztés.Text = "Szerkesztés";
            this.GB_szerkesztés.Visible = false;
            // 
            // Meret
            // 
            this.Meret.Location = new System.Drawing.Point(178, 101);
            this.Meret.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Meret.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Meret.Name = "Meret";
            this.Meret.Size = new System.Drawing.Size(53, 20);
            this.Meret.TabIndex = 19;
            this.Meret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Meret.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.Meret.ValueChanged += new System.EventHandler(this.Meret_ValueChanged);
            // 
            // betumeret
            // 
            this.betumeret.AutoSize = true;
            this.betumeret.Location = new System.Drawing.Point(48, 103);
            this.betumeret.Name = "betumeret";
            this.betumeret.Size = new System.Drawing.Size(124, 13);
            this.betumeret.TabIndex = 18;
            this.betumeret.Text = "Adj meg 50 alatti számot:";
            // 
            // csakszo
            // 
            this.csakszo.AutoSize = true;
            this.csakszo.Location = new System.Drawing.Point(48, 28);
            this.csakszo.Name = "csakszo";
            this.csakszo.Size = new System.Drawing.Size(96, 13);
            this.csakszo.TabIndex = 17;
            this.csakszo.Text = "Csak szót adj meg:";
            // 
            // LBL_worderedmeny
            // 
            this.LBL_worderedmeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_worderedmeny.Location = new System.Drawing.Point(6, 148);
            this.LBL_worderedmeny.Name = "LBL_worderedmeny";
            this.LBL_worderedmeny.Size = new System.Drawing.Size(356, 54);
            this.LBL_worderedmeny.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 448);
            this.Controls.Add(this.GB_szerkesztés);
            this.Controls.Add(this.BT_visszaP);
            this.Controls.Add(this.BT_kep);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BT_vissza);
            this.Controls.Add(this.BT_paintinfo);
            this.Controls.Add(this.BT_wordinfo);
            this.Controls.Add(this.LB_kiir);
            this.Controls.Add(this.BT_paint);
            this.Controls.Add(this.BT_word);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mészáros Dominik Projekt";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).EndInit();
            this.GB_szerkesztés.ResumeLayout(false);
            this.GB_szerkesztés.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Meret)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_word;
        private System.Windows.Forms.Button BT_paint;
        private System.Windows.Forms.ListBox LB_kiir;
        private System.Windows.Forms.Button BT_wordinfo;
        private System.Windows.Forms.Button BT_paintinfo;
        private System.Windows.Forms.Button BT_vissza;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BT_kep;
        private System.Windows.Forms.Button BT_visszaP;
        private System.Windows.Forms.Label Eredmeny;
        private System.Windows.Forms.NumericUpDown R;
        private System.Windows.Forms.NumericUpDown G;
        private System.Windows.Forms.NumericUpDown B;
        private System.Windows.Forms.Label LBL_RGB;
        private System.Windows.Forms.TextBox TB_wordszoveg;
        private System.Windows.Forms.GroupBox GB_szerkesztés;
        private System.Windows.Forms.Label LBL_worderedmeny;
        private System.Windows.Forms.Label betumeret;
        private System.Windows.Forms.Label csakszo;
        private System.Windows.Forms.NumericUpDown Meret;
    }
}

