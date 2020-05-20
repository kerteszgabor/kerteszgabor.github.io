namespace Schvorczi_Gergo_raktar_05._10
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
            this.lb_beolv = new System.Windows.Forms.ListBox();
            this.bt_beolv = new System.Windows.Forms.Button();
            this.lb_ered = new System.Windows.Forms.ListBox();
            this.rb_kval = new System.Windows.Forms.RadioButton();
            this.rb_legd = new System.Windows.Forms.RadioButton();
            this.rb_ossz = new System.Windows.Forms.RadioButton();
            this.rb_abc = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lb_beolv
            // 
            this.lb_beolv.FormattingEnabled = true;
            this.lb_beolv.Location = new System.Drawing.Point(12, 13);
            this.lb_beolv.Name = "lb_beolv";
            this.lb_beolv.Size = new System.Drawing.Size(317, 290);
            this.lb_beolv.TabIndex = 0;
            // 
            // bt_beolv
            // 
            this.bt_beolv.Location = new System.Drawing.Point(12, 317);
            this.bt_beolv.Name = "bt_beolv";
            this.bt_beolv.Size = new System.Drawing.Size(317, 23);
            this.bt_beolv.TabIndex = 1;
            this.bt_beolv.Text = "Beolvasás";
            this.bt_beolv.UseVisualStyleBackColor = true;
            this.bt_beolv.Click += new System.EventHandler(this.bt_beolv_Click);
            // 
            // lb_ered
            // 
            this.lb_ered.FormattingEnabled = true;
            this.lb_ered.Location = new System.Drawing.Point(466, 13);
            this.lb_ered.Name = "lb_ered";
            this.lb_ered.Size = new System.Drawing.Size(317, 290);
            this.lb_ered.TabIndex = 2;
            // 
            // rb_kval
            // 
            this.rb_kval.AutoSize = true;
            this.rb_kval.Enabled = false;
            this.rb_kval.Location = new System.Drawing.Point(336, 72);
            this.rb_kval.Name = "rb_kval";
            this.rb_kval.Size = new System.Drawing.Size(99, 17);
            this.rb_kval.TabIndex = 3;
            this.rb_kval.TabStop = true;
            this.rb_kval.Text = "K-val kezdődők";
            this.rb_kval.UseVisualStyleBackColor = true;
            this.rb_kval.CheckedChanged += new System.EventHandler(this.rb_kval_CheckedChanged);
            // 
            // rb_legd
            // 
            this.rb_legd.AutoSize = true;
            this.rb_legd.Enabled = false;
            this.rb_legd.Location = new System.Drawing.Point(336, 95);
            this.rb_legd.Name = "rb_legd";
            this.rb_legd.Size = new System.Drawing.Size(129, 17);
            this.rb_legd.TabIndex = 4;
            this.rb_legd.TabStop = true;
            this.rb_legd.Text = "Legdrágább gyümölcs";
            this.rb_legd.UseVisualStyleBackColor = true;
            this.rb_legd.CheckedChanged += new System.EventHandler(this.rb_legd_CheckedChanged);
            // 
            // rb_ossz
            // 
            this.rb_ossz.AutoSize = true;
            this.rb_ossz.Enabled = false;
            this.rb_ossz.Location = new System.Drawing.Point(336, 118);
            this.rb_ossz.Name = "rb_ossz";
            this.rb_ossz.Size = new System.Drawing.Size(111, 17);
            this.rb_ossz.TabIndex = 6;
            this.rb_ossz.TabStop = true;
            this.rb_ossz.Text = "Raktár összértéke";
            this.rb_ossz.UseVisualStyleBackColor = true;
            this.rb_ossz.CheckedChanged += new System.EventHandler(this.rb_ossz_CheckedChanged);
            // 
            // rb_abc
            // 
            this.rb_abc.AutoSize = true;
            this.rb_abc.Enabled = false;
            this.rb_abc.Location = new System.Drawing.Point(336, 141);
            this.rb_abc.Name = "rb_abc";
            this.rb_abc.Size = new System.Drawing.Size(128, 17);
            this.rb_abc.TabIndex = 7;
            this.rb_abc.TabStop = true;
            this.rb_abc.Text = "A raktár ABC rendben";
            this.rb_abc.UseVisualStyleBackColor = true;
            this.rb_abc.CheckedChanged += new System.EventHandler(this.rb_abc_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 352);
            this.Controls.Add(this.rb_abc);
            this.Controls.Add(this.rb_ossz);
            this.Controls.Add(this.rb_legd);
            this.Controls.Add(this.rb_kval);
            this.Controls.Add(this.lb_ered);
            this.Controls.Add(this.bt_beolv);
            this.Controls.Add(this.lb_beolv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_beolv;
        private System.Windows.Forms.Button bt_beolv;
        private System.Windows.Forms.ListBox lb_ered;
        private System.Windows.Forms.RadioButton rb_kval;
        private System.Windows.Forms.RadioButton rb_legd;
        private System.Windows.Forms.RadioButton rb_ossz;
        private System.Windows.Forms.RadioButton rb_abc;
    }
}

