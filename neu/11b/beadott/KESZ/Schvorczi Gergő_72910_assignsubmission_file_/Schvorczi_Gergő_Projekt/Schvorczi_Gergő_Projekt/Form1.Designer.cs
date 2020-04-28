namespace Schvorczi_Gergő_Projekt
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_ellen = new System.Windows.Forms.Button();
            this.rb_lin = new System.Windows.Forms.RadioButton();
            this.rb_mac = new System.Windows.Forms.RadioButton();
            this.rb_win = new System.Windows.Forms.RadioButton();
            this.bt_telepit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_cpu = new System.Windows.Forms.TextBox();
            this.tb_gpu = new System.Windows.Forms.TextBox();
            this.tb_bit = new System.Windows.Forms.TextBox();
            this.lbx_eredmeny = new System.Windows.Forms.ListBox();
            this.bt_uzenet = new System.Windows.Forms.Button();
            this.bt_kikapcs = new System.Windows.Forms.Button();
            this.bt_progszam = new System.Windows.Forms.Button();
            this.bt_adatok = new System.Windows.Forms.Button();
            this.bt_torles = new System.Windows.Forms.Button();
            this.nud_ram = new System.Windows.Forms.NumericUpDown();
            this.nud_progszam = new System.Windows.Forms.NumericUpDown();
            this.bt_segit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_progszam)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_ellen);
            this.groupBox1.Controls.Add(this.rb_lin);
            this.groupBox1.Controls.Add(this.rb_mac);
            this.groupBox1.Controls.Add(this.rb_win);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operációs rendszerek";
            // 
            // bt_ellen
            // 
            this.bt_ellen.Location = new System.Drawing.Point(74, 31);
            this.bt_ellen.Name = "bt_ellen";
            this.bt_ellen.Size = new System.Drawing.Size(131, 42);
            this.bt_ellen.TabIndex = 3;
            this.bt_ellen.Text = "Operációs rendszer ellenőrzése";
            this.bt_ellen.UseVisualStyleBackColor = true;
            this.bt_ellen.Click += new System.EventHandler(this.bt_ellen_Click);
            // 
            // rb_lin
            // 
            this.rb_lin.AutoSize = true;
            this.rb_lin.Location = new System.Drawing.Point(7, 68);
            this.rb_lin.Name = "rb_lin";
            this.rb_lin.Size = new System.Drawing.Size(50, 17);
            this.rb_lin.TabIndex = 2;
            this.rb_lin.TabStop = true;
            this.rb_lin.Text = "Linux";
            this.rb_lin.UseVisualStyleBackColor = true;
            // 
            // rb_mac
            // 
            this.rb_mac.AutoSize = true;
            this.rb_mac.Location = new System.Drawing.Point(7, 44);
            this.rb_mac.Name = "rb_mac";
            this.rb_mac.Size = new System.Drawing.Size(61, 17);
            this.rb_mac.TabIndex = 1;
            this.rb_mac.TabStop = true;
            this.rb_mac.Text = "MacOS";
            this.rb_mac.UseVisualStyleBackColor = true;
            // 
            // rb_win
            // 
            this.rb_win.AutoSize = true;
            this.rb_win.Location = new System.Drawing.Point(7, 20);
            this.rb_win.Name = "rb_win";
            this.rb_win.Size = new System.Drawing.Size(69, 17);
            this.rb_win.TabIndex = 0;
            this.rb_win.TabStop = true;
            this.rb_win.Text = "Windows";
            this.rb_win.UseVisualStyleBackColor = true;
            // 
            // bt_telepit
            // 
            this.bt_telepit.Enabled = false;
            this.bt_telepit.Location = new System.Drawing.Point(237, 90);
            this.bt_telepit.Name = "bt_telepit";
            this.bt_telepit.Size = new System.Drawing.Size(558, 23);
            this.bt_telepit.TabIndex = 2;
            this.bt_telepit.Text = "Választott rendszer telepítése";
            this.bt_telepit.UseVisualStyleBackColor = true;
            this.bt_telepit.Click += new System.EventHandler(this.bt_telepit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Processzor típusa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Memória mennyisége(GB):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Videókártya típusa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hány bites rendszer?";
            // 
            // tb_cpu
            // 
            this.tb_cpu.Enabled = false;
            this.tb_cpu.Location = new System.Drawing.Point(340, 10);
            this.tb_cpu.Name = "tb_cpu";
            this.tb_cpu.Size = new System.Drawing.Size(100, 20);
            this.tb_cpu.TabIndex = 11;
            // 
            // tb_gpu
            // 
            this.tb_gpu.Enabled = false;
            this.tb_gpu.Location = new System.Drawing.Point(340, 58);
            this.tb_gpu.Name = "tb_gpu";
            this.tb_gpu.Size = new System.Drawing.Size(100, 20);
            this.tb_gpu.TabIndex = 12;
            // 
            // tb_bit
            // 
            this.tb_bit.Enabled = false;
            this.tb_bit.Location = new System.Drawing.Point(693, 56);
            this.tb_bit.Name = "tb_bit";
            this.tb_bit.Size = new System.Drawing.Size(100, 20);
            this.tb_bit.TabIndex = 14;
            // 
            // lbx_eredmeny
            // 
            this.lbx_eredmeny.FormattingEnabled = true;
            this.lbx_eredmeny.Location = new System.Drawing.Point(13, 119);
            this.lbx_eredmeny.Name = "lbx_eredmeny";
            this.lbx_eredmeny.Size = new System.Drawing.Size(362, 225);
            this.lbx_eredmeny.TabIndex = 15;
            // 
            // bt_uzenet
            // 
            this.bt_uzenet.Enabled = false;
            this.bt_uzenet.Location = new System.Drawing.Point(382, 169);
            this.bt_uzenet.Name = "bt_uzenet";
            this.bt_uzenet.Size = new System.Drawing.Size(413, 23);
            this.bt_uzenet.TabIndex = 16;
            this.bt_uzenet.Text = "Napi üzenet";
            this.bt_uzenet.UseVisualStyleBackColor = true;
            this.bt_uzenet.Click += new System.EventHandler(this.bt_uzenet_Click);
            // 
            // bt_kikapcs
            // 
            this.bt_kikapcs.Enabled = false;
            this.bt_kikapcs.Location = new System.Drawing.Point(382, 198);
            this.bt_kikapcs.Name = "bt_kikapcs";
            this.bt_kikapcs.Size = new System.Drawing.Size(413, 23);
            this.bt_kikapcs.TabIndex = 17;
            this.bt_kikapcs.Text = "Kikapcsolás";
            this.bt_kikapcs.UseVisualStyleBackColor = true;
            this.bt_kikapcs.Click += new System.EventHandler(this.bt_kikapcs_Click);
            // 
            // bt_progszam
            // 
            this.bt_progszam.Enabled = false;
            this.bt_progszam.Location = new System.Drawing.Point(382, 227);
            this.bt_progszam.Name = "bt_progszam";
            this.bt_progszam.Size = new System.Drawing.Size(413, 23);
            this.bt_progszam.TabIndex = 18;
            this.bt_progszam.Text = "Programok száma(írja a gomb alatt levő rublikába, és a gép majd kiszámolja!)";
            this.bt_progszam.UseVisualStyleBackColor = true;
            this.bt_progszam.Click += new System.EventHandler(this.bt_progszam_Click);
            // 
            // bt_adatok
            // 
            this.bt_adatok.Enabled = false;
            this.bt_adatok.Location = new System.Drawing.Point(382, 283);
            this.bt_adatok.Name = "bt_adatok";
            this.bt_adatok.Size = new System.Drawing.Size(413, 23);
            this.bt_adatok.TabIndex = 20;
            this.bt_adatok.Text = "Számítógép adatai";
            this.bt_adatok.UseVisualStyleBackColor = true;
            this.bt_adatok.Click += new System.EventHandler(this.bt_adatok_Click);
            // 
            // bt_torles
            // 
            this.bt_torles.Enabled = false;
            this.bt_torles.Location = new System.Drawing.Point(382, 313);
            this.bt_torles.Name = "bt_torles";
            this.bt_torles.Size = new System.Drawing.Size(413, 23);
            this.bt_torles.TabIndex = 21;
            this.bt_torles.Text = "Telepített rendszer törlése";
            this.bt_torles.UseVisualStyleBackColor = true;
            this.bt_torles.Click += new System.EventHandler(this.bt_torles_Click);
            // 
            // nud_ram
            // 
            this.nud_ram.Enabled = false;
            this.nud_ram.Location = new System.Drawing.Point(693, 11);
            this.nud_ram.Name = "nud_ram";
            this.nud_ram.Size = new System.Drawing.Size(100, 20);
            this.nud_ram.TabIndex = 22;
            // 
            // nud_progszam
            // 
            this.nud_progszam.Enabled = false;
            this.nud_progszam.Location = new System.Drawing.Point(382, 257);
            this.nud_progszam.Name = "nud_progszam";
            this.nud_progszam.Size = new System.Drawing.Size(413, 20);
            this.nud_progszam.TabIndex = 23;
            // 
            // bt_segit
            // 
            this.bt_segit.Location = new System.Drawing.Point(13, 360);
            this.bt_segit.Name = "bt_segit";
            this.bt_segit.Size = new System.Drawing.Size(782, 23);
            this.bt_segit.TabIndex = 24;
            this.bt_segit.Text = "Segítség";
            this.bt_segit.UseVisualStyleBackColor = true;
            this.bt_segit.Click += new System.EventHandler(this.bt_segit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 395);
            this.Controls.Add(this.bt_segit);
            this.Controls.Add(this.nud_progszam);
            this.Controls.Add(this.nud_ram);
            this.Controls.Add(this.bt_torles);
            this.Controls.Add(this.bt_adatok);
            this.Controls.Add(this.bt_progszam);
            this.Controls.Add(this.bt_kikapcs);
            this.Controls.Add(this.bt_uzenet);
            this.Controls.Add(this.lbx_eredmeny);
            this.Controls.Add(this.tb_bit);
            this.Controls.Add(this.tb_gpu);
            this.Controls.Add(this.tb_cpu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_telepit);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Schvorczi Gergő OPRendszerek";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_progszam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_lin;
        private System.Windows.Forms.RadioButton rb_mac;
        private System.Windows.Forms.RadioButton rb_win;
        private System.Windows.Forms.Button bt_telepit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_cpu;
        private System.Windows.Forms.TextBox tb_gpu;
        private System.Windows.Forms.TextBox tb_bit;
        private System.Windows.Forms.ListBox lbx_eredmeny;
        private System.Windows.Forms.Button bt_uzenet;
        private System.Windows.Forms.Button bt_kikapcs;
        private System.Windows.Forms.Button bt_progszam;
        private System.Windows.Forms.Button bt_adatok;
        private System.Windows.Forms.Button bt_torles;
        private System.Windows.Forms.NumericUpDown nud_ram;
        private System.Windows.Forms.NumericUpDown nud_progszam;
        private System.Windows.Forms.Button bt_ellen;
        private System.Windows.Forms.Button bt_segit;
    }
}

