namespace Memória_Melinda
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
            this.bt_kils = new System.Windows.Forms.Button();
            this.rb_SRAM = new System.Windows.Forms.RadioButton();
            this.rb_DRAM = new System.Windows.Forms.RadioButton();
            this.rb_PROM = new System.Windows.Forms.RadioButton();
            this.rb_EPROM = new System.Windows.Forms.RadioButton();
            this.Ismerteto = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_ramf = new System.Windows.Forms.Button();
            this.lb_SRAM = new System.Windows.Forms.Label();
            this.lb_DRAM = new System.Windows.Forms.Label();
            this.lb_PROM = new System.Windows.Forms.Label();
            this.lb_EPROM = new System.Windows.Forms.Label();
            this.bt_has = new System.Windows.Forms.Button();
            this.bt_has2 = new System.Windows.Forms.Button();
            this.RAMhasonlitas = new System.Windows.Forms.ListBox();
            this.ROMhasonlitas = new System.Windows.Forms.ListBox();
            this.gb_RAM = new System.Windows.Forms.GroupBox();
            this.gb_ROM = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.gb_RAM.SuspendLayout();
            this.gb_ROM.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_kils
            // 
            this.bt_kils.BackColor = System.Drawing.Color.Salmon;
            this.bt_kils.Location = new System.Drawing.Point(197, 31);
            this.bt_kils.Name = "bt_kils";
            this.bt_kils.Size = new System.Drawing.Size(91, 37);
            this.bt_kils.TabIndex = 0;
            this.bt_kils.Text = "Ismerető";
            this.bt_kils.UseVisualStyleBackColor = false;
            this.bt_kils.Click += new System.EventHandler(this.button1_Click);
            // 
            // rb_SRAM
            // 
            this.rb_SRAM.AutoSize = true;
            this.rb_SRAM.BackColor = System.Drawing.Color.SandyBrown;
            this.rb_SRAM.Location = new System.Drawing.Point(19, 31);
            this.rb_SRAM.Name = "rb_SRAM";
            this.rb_SRAM.Size = new System.Drawing.Size(56, 17);
            this.rb_SRAM.TabIndex = 1;
            this.rb_SRAM.TabStop = true;
            this.rb_SRAM.Text = "SRAM";
            this.rb_SRAM.UseVisualStyleBackColor = false;
            // 
            // rb_DRAM
            // 
            this.rb_DRAM.AutoSize = true;
            this.rb_DRAM.BackColor = System.Drawing.Color.SandyBrown;
            this.rb_DRAM.Location = new System.Drawing.Point(18, 59);
            this.rb_DRAM.Name = "rb_DRAM";
            this.rb_DRAM.Size = new System.Drawing.Size(57, 17);
            this.rb_DRAM.TabIndex = 2;
            this.rb_DRAM.TabStop = true;
            this.rb_DRAM.Text = "DRAM";
            this.rb_DRAM.UseVisualStyleBackColor = false;
            // 
            // rb_PROM
            // 
            this.rb_PROM.AutoSize = true;
            this.rb_PROM.BackColor = System.Drawing.Color.SandyBrown;
            this.rb_PROM.Location = new System.Drawing.Point(108, 31);
            this.rb_PROM.Name = "rb_PROM";
            this.rb_PROM.Size = new System.Drawing.Size(57, 17);
            this.rb_PROM.TabIndex = 3;
            this.rb_PROM.TabStop = true;
            this.rb_PROM.Text = "PROM";
            this.rb_PROM.UseVisualStyleBackColor = false;
            // 
            // rb_EPROM
            // 
            this.rb_EPROM.AutoSize = true;
            this.rb_EPROM.BackColor = System.Drawing.Color.SandyBrown;
            this.rb_EPROM.Location = new System.Drawing.Point(108, 59);
            this.rb_EPROM.Name = "rb_EPROM";
            this.rb_EPROM.Size = new System.Drawing.Size(67, 17);
            this.rb_EPROM.TabIndex = 4;
            this.rb_EPROM.TabStop = true;
            this.rb_EPROM.Text = "EPROM ";
            this.rb_EPROM.UseVisualStyleBackColor = false;
            // 
            // Ismerteto
            // 
            this.Ismerteto.FormattingEnabled = true;
            this.Ismerteto.Location = new System.Drawing.Point(309, 19);
            this.Ismerteto.Name = "Ismerteto";
            this.Ismerteto.Size = new System.Drawing.Size(411, 69);
            this.Ismerteto.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gb_RAM);
            this.groupBox1.Controls.Add(this.gb_ROM);
            this.groupBox1.Controls.Add(this.rb_EPROM);
            this.groupBox1.Controls.Add(this.Ismerteto);
            this.groupBox1.Controls.Add(this.bt_kils);
            this.groupBox1.Controls.Add(this.rb_SRAM);
            this.groupBox1.Controls.Add(this.rb_PROM);
            this.groupBox1.Controls.Add(this.rb_DRAM);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 352);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ismertető";
            // 
            // bt_ramf
            // 
            this.bt_ramf.BackColor = System.Drawing.Color.Salmon;
            this.bt_ramf.Location = new System.Drawing.Point(320, 345);
            this.bt_ramf.Name = "bt_ramf";
            this.bt_ramf.Size = new System.Drawing.Size(137, 66);
            this.bt_ramf.TabIndex = 7;
            this.bt_ramf.Text = "RAM frissítése";
            this.bt_ramf.UseVisualStyleBackColor = false;
            this.bt_ramf.Click += new System.EventHandler(this.bt_ramf_Click);
            // 
            // lb_SRAM
            // 
            this.lb_SRAM.AutoSize = true;
            this.lb_SRAM.BackColor = System.Drawing.Color.Gold;
            this.lb_SRAM.Location = new System.Drawing.Point(41, 35);
            this.lb_SRAM.Name = "lb_SRAM";
            this.lb_SRAM.Size = new System.Drawing.Size(38, 13);
            this.lb_SRAM.TabIndex = 8;
            this.lb_SRAM.Text = "SRAM";
            // 
            // lb_DRAM
            // 
            this.lb_DRAM.AutoSize = true;
            this.lb_DRAM.BackColor = System.Drawing.Color.Gold;
            this.lb_DRAM.Location = new System.Drawing.Point(231, 35);
            this.lb_DRAM.Name = "lb_DRAM";
            this.lb_DRAM.Size = new System.Drawing.Size(39, 13);
            this.lb_DRAM.TabIndex = 9;
            this.lb_DRAM.Text = "DRAM";
            // 
            // lb_PROM
            // 
            this.lb_PROM.AutoSize = true;
            this.lb_PROM.BackColor = System.Drawing.Color.Gold;
            this.lb_PROM.Location = new System.Drawing.Point(41, 33);
            this.lb_PROM.Name = "lb_PROM";
            this.lb_PROM.Size = new System.Drawing.Size(39, 13);
            this.lb_PROM.TabIndex = 10;
            this.lb_PROM.Text = "PROM";
            // 
            // lb_EPROM
            // 
            this.lb_EPROM.AutoSize = true;
            this.lb_EPROM.BackColor = System.Drawing.Color.Gold;
            this.lb_EPROM.Location = new System.Drawing.Point(224, 33);
            this.lb_EPROM.Name = "lb_EPROM";
            this.lb_EPROM.Size = new System.Drawing.Size(46, 13);
            this.lb_EPROM.TabIndex = 11;
            this.lb_EPROM.Text = "EPROM";
            // 
            // bt_has
            // 
            this.bt_has.BackColor = System.Drawing.Color.Salmon;
            this.bt_has.Location = new System.Drawing.Point(109, 26);
            this.bt_has.Name = "bt_has";
            this.bt_has.Size = new System.Drawing.Size(96, 30);
            this.bt_has.TabIndex = 12;
            this.bt_has.Text = "Összehasonlít";
            this.bt_has.UseVisualStyleBackColor = false;
            // 
            // bt_has2
            // 
            this.bt_has2.BackColor = System.Drawing.Color.Salmon;
            this.bt_has2.Location = new System.Drawing.Point(101, 25);
            this.bt_has2.Name = "bt_has2";
            this.bt_has2.Size = new System.Drawing.Size(104, 28);
            this.bt_has2.TabIndex = 13;
            this.bt_has2.Text = "Összehasonlít";
            this.bt_has2.UseVisualStyleBackColor = false;
            // 
            // RAMhasonlitas
            // 
            this.RAMhasonlitas.FormattingEnabled = true;
            this.RAMhasonlitas.Location = new System.Drawing.Point(24, 62);
            this.RAMhasonlitas.Name = "RAMhasonlitas";
            this.RAMhasonlitas.Size = new System.Drawing.Size(274, 108);
            this.RAMhasonlitas.TabIndex = 14;
            // 
            // ROMhasonlitas
            // 
            this.ROMhasonlitas.FormattingEnabled = true;
            this.ROMhasonlitas.Location = new System.Drawing.Point(24, 69);
            this.ROMhasonlitas.Name = "ROMhasonlitas";
            this.ROMhasonlitas.Size = new System.Drawing.Size(274, 108);
            this.ROMhasonlitas.TabIndex = 15;
            // 
            // gb_RAM
            // 
            this.gb_RAM.BackColor = System.Drawing.Color.Ivory;
            this.gb_RAM.Controls.Add(this.lb_SRAM);
            this.gb_RAM.Controls.Add(this.bt_has);
            this.gb_RAM.Controls.Add(this.RAMhasonlitas);
            this.gb_RAM.Controls.Add(this.lb_DRAM);
            this.gb_RAM.Location = new System.Drawing.Point(18, 113);
            this.gb_RAM.Name = "gb_RAM";
            this.gb_RAM.Size = new System.Drawing.Size(326, 205);
            this.gb_RAM.TabIndex = 16;
            this.gb_RAM.TabStop = false;
            this.gb_RAM.Text = "RAM";
            // 
            // gb_ROM
            // 
            this.gb_ROM.BackColor = System.Drawing.Color.Ivory;
            this.gb_ROM.Controls.Add(this.bt_has2);
            this.gb_ROM.Controls.Add(this.lb_EPROM);
            this.gb_ROM.Controls.Add(this.ROMhasonlitas);
            this.gb_ROM.Controls.Add(this.lb_PROM);
            this.gb_ROM.Location = new System.Drawing.Point(395, 113);
            this.gb_ROM.Name = "gb_ROM";
            this.gb_ROM.Size = new System.Drawing.Size(325, 198);
            this.gb_ROM.TabIndex = 17;
            this.gb_ROM.TabStop = false;
            this.gb_ROM.Text = "ROM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_ramf);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Memória";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_RAM.ResumeLayout(false);
            this.gb_RAM.PerformLayout();
            this.gb_ROM.ResumeLayout(false);
            this.gb_ROM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_kils;
        private System.Windows.Forms.RadioButton rb_SRAM;
        private System.Windows.Forms.RadioButton rb_DRAM;
        private System.Windows.Forms.RadioButton rb_PROM;
        private System.Windows.Forms.RadioButton rb_EPROM;
        private System.Windows.Forms.ListBox Ismerteto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_ramf;
        private System.Windows.Forms.Label lb_SRAM;
        private System.Windows.Forms.Label lb_DRAM;
        private System.Windows.Forms.Label lb_PROM;
        private System.Windows.Forms.Label lb_EPROM;
        private System.Windows.Forms.Button bt_has;
        private System.Windows.Forms.Button bt_has2;
        private System.Windows.Forms.ListBox RAMhasonlitas;
        private System.Windows.Forms.ListBox ROMhasonlitas;
        private System.Windows.Forms.GroupBox gb_RAM;
        private System.Windows.Forms.GroupBox gb_ROM;
    }
}

