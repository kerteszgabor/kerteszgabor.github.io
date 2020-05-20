namespace VarRol_LINQ_hazi
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
            this.BTN_beolvas = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LB_1 = new System.Windows.Forms.ListBox();
            this.LB_2 = new System.Windows.Forms.ListBox();
            this.rb_k_kezd = new System.Windows.Forms.RadioButton();
            this.RB_legdragabb_gyum = new System.Windows.Forms.RadioButton();
            this.RB_legdraggyum = new System.Windows.Forms.RadioButton();
            this.RB_osszertek = new System.Windows.Forms.RadioButton();
            this.RB_abcrend = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // BTN_beolvas
            // 
            this.BTN_beolvas.Location = new System.Drawing.Point(92, 354);
            this.BTN_beolvas.Name = "BTN_beolvas";
            this.BTN_beolvas.Size = new System.Drawing.Size(75, 23);
            this.BTN_beolvas.TabIndex = 0;
            this.BTN_beolvas.Text = "Beolvasás";
            this.BTN_beolvas.UseVisualStyleBackColor = true;
            this.BTN_beolvas.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // LB_1
            // 
            this.LB_1.FormattingEnabled = true;
            this.LB_1.Location = new System.Drawing.Point(0, 0);
            this.LB_1.Name = "LB_1";
            this.LB_1.Size = new System.Drawing.Size(236, 290);
            this.LB_1.TabIndex = 1;
            this.LB_1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LB_2
            // 
            this.LB_2.FormattingEnabled = true;
            this.LB_2.Location = new System.Drawing.Point(494, 0);
            this.LB_2.Name = "LB_2";
            this.LB_2.Size = new System.Drawing.Size(236, 290);
            this.LB_2.TabIndex = 2;
            // 
            // rb_k_kezd
            // 
            this.rb_k_kezd.AutoSize = true;
            this.rb_k_kezd.Enabled = false;
            this.rb_k_kezd.Location = new System.Drawing.Point(282, 33);
            this.rb_k_kezd.Name = "rb_k_kezd";
            this.rb_k_kezd.Size = new System.Drawing.Size(127, 17);
            this.rb_k_kezd.TabIndex = 4;
            this.rb_k_kezd.TabStop = true;
            this.rb_k_kezd.Text = "Hány K-val kezdődő?";
            this.rb_k_kezd.UseVisualStyleBackColor = true;
            this.rb_k_kezd.CheckedChanged += new System.EventHandler(this.rb_k_kezd_CheckedChanged);
            // 
            // RB_legdragabb_gyum
            // 
            this.RB_legdragabb_gyum.AutoSize = true;
            this.RB_legdragabb_gyum.Enabled = false;
            this.RB_legdragabb_gyum.Location = new System.Drawing.Point(282, 56);
            this.RB_legdragabb_gyum.Name = "RB_legdragabb_gyum";
            this.RB_legdragabb_gyum.Size = new System.Drawing.Size(181, 17);
            this.RB_legdragabb_gyum.TabIndex = 5;
            this.RB_legdragabb_gyum.TabStop = true;
            this.RB_legdragabb_gyum.Text = "Legdrágább gyümölcs (egységár)";
            this.RB_legdragabb_gyum.UseVisualStyleBackColor = true;
            this.RB_legdragabb_gyum.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RB_legdraggyum
            // 
            this.RB_legdraggyum.AutoSize = true;
            this.RB_legdraggyum.Enabled = false;
            this.RB_legdraggyum.Location = new System.Drawing.Point(282, 79);
            this.RB_legdraggyum.Name = "RB_legdraggyum";
            this.RB_legdraggyum.Size = new System.Drawing.Size(156, 17);
            this.RB_legdraggyum.TabIndex = 6;
            this.RB_legdraggyum.TabStop = true;
            this.RB_legdraggyum.Text = "Legdrágább gyümölcs (név)";
            this.RB_legdraggyum.UseVisualStyleBackColor = true;
            this.RB_legdraggyum.CheckedChanged += new System.EventHandler(this.RB_legdraggyum_CheckedChanged);
            // 
            // RB_osszertek
            // 
            this.RB_osszertek.AutoSize = true;
            this.RB_osszertek.Enabled = false;
            this.RB_osszertek.Location = new System.Drawing.Point(282, 102);
            this.RB_osszertek.Name = "RB_osszertek";
            this.RB_osszertek.Size = new System.Drawing.Size(111, 17);
            this.RB_osszertek.TabIndex = 7;
            this.RB_osszertek.TabStop = true;
            this.RB_osszertek.Text = "Raktár összértéke";
            this.RB_osszertek.UseVisualStyleBackColor = true;
            this.RB_osszertek.CheckedChanged += new System.EventHandler(this.RB_osszertek_CheckedChanged);
            // 
            // RB_abcrend
            // 
            this.RB_abcrend.AutoSize = true;
            this.RB_abcrend.Enabled = false;
            this.RB_abcrend.Location = new System.Drawing.Point(282, 125);
            this.RB_abcrend.Name = "RB_abcrend";
            this.RB_abcrend.Size = new System.Drawing.Size(84, 17);
            this.RB_abcrend.TabIndex = 8;
            this.RB_abcrend.TabStop = true;
            this.RB_abcrend.Text = "ABC sorrend";
            this.RB_abcrend.UseVisualStyleBackColor = true;
            this.RB_abcrend.CheckedChanged += new System.EventHandler(this.RB_abcrend_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RB_abcrend);
            this.Controls.Add(this.RB_osszertek);
            this.Controls.Add(this.RB_legdraggyum);
            this.Controls.Add(this.RB_legdragabb_gyum);
            this.Controls.Add(this.rb_k_kezd);
            this.Controls.Add(this.LB_2);
            this.Controls.Add(this.LB_1);
            this.Controls.Add(this.BTN_beolvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_beolvas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox LB_1;
        private System.Windows.Forms.ListBox LB_2;
        private System.Windows.Forms.RadioButton rb_k_kezd;
        private System.Windows.Forms.RadioButton RB_legdragabb_gyum;
        private System.Windows.Forms.RadioButton RB_legdraggyum;
        private System.Windows.Forms.RadioButton RB_osszertek;
        private System.Windows.Forms.RadioButton RB_abcrend;
    }
}

