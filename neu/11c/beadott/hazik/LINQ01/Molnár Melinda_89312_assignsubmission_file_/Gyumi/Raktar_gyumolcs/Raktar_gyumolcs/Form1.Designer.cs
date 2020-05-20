namespace Raktar_gyumolcs
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
            this.bt_beolvas = new System.Windows.Forms.Button();
            this.lb_raktarom = new System.Windows.Forms.ListBox();
            this.rb_k = new System.Windows.Forms.RadioButton();
            this.rb_dragagyar = new System.Windows.Forms.RadioButton();
            this.rb_dragagyn = new System.Windows.Forms.RadioButton();
            this.rb_rertek = new System.Windows.Forms.RadioButton();
            this.rb_ABC = new System.Windows.Forms.RadioButton();
            this.lb_eredmeny = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bt_beolvas
            // 
            this.bt_beolvas.Location = new System.Drawing.Point(36, 361);
            this.bt_beolvas.Name = "bt_beolvas";
            this.bt_beolvas.Size = new System.Drawing.Size(137, 26);
            this.bt_beolvas.TabIndex = 0;
            this.bt_beolvas.Text = "Beolvasás";
            this.bt_beolvas.UseVisualStyleBackColor = true;
            this.bt_beolvas.Click += new System.EventHandler(this.bt_beolvas_Click);
            // 
            // lb_raktarom
            // 
            this.lb_raktarom.FormattingEnabled = true;
            this.lb_raktarom.Location = new System.Drawing.Point(22, 12);
            this.lb_raktarom.Name = "lb_raktarom";
            this.lb_raktarom.Size = new System.Drawing.Size(200, 329);
            this.lb_raktarom.TabIndex = 1;
            // 
            // rb_k
            // 
            this.rb_k.AutoSize = true;
            this.rb_k.Location = new System.Drawing.Point(252, 77);
            this.rb_k.Name = "rb_k";
            this.rb_k.Size = new System.Drawing.Size(32, 17);
            this.rb_k.TabIndex = 2;
            this.rb_k.TabStop = true;
            this.rb_k.Text = "K";
            this.rb_k.UseVisualStyleBackColor = true;
            this.rb_k.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_dragagyar
            // 
            this.rb_dragagyar.AutoSize = true;
            this.rb_dragagyar.Location = new System.Drawing.Point(252, 115);
            this.rb_dragagyar.Name = "rb_dragagyar";
            this.rb_dragagyar.Size = new System.Drawing.Size(164, 17);
            this.rb_dragagyar.TabIndex = 3;
            this.rb_dragagyar.TabStop = true;
            this.rb_dragagyar.Text = "Legdrágább gyümi egységára";
            this.rb_dragagyar.UseVisualStyleBackColor = true;
            this.rb_dragagyar.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb_dragagyn
            // 
            this.rb_dragagyn.AutoSize = true;
            this.rb_dragagyn.Location = new System.Drawing.Point(252, 159);
            this.rb_dragagyn.Name = "rb_dragagyn";
            this.rb_dragagyn.Size = new System.Drawing.Size(115, 17);
            this.rb_dragagyn.TabIndex = 4;
            this.rb_dragagyn.TabStop = true;
            this.rb_dragagyn.Text = "Legdrágább gyümi ";
            this.rb_dragagyn.UseVisualStyleBackColor = true;
            this.rb_dragagyn.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rb_rertek
            // 
            this.rb_rertek.AutoSize = true;
            this.rb_rertek.Location = new System.Drawing.Point(252, 203);
            this.rb_rertek.Name = "rb_rertek";
            this.rb_rertek.Size = new System.Drawing.Size(90, 17);
            this.rb_rertek.TabIndex = 5;
            this.rb_rertek.TabStop = true;
            this.rb_rertek.Text = "Raktár értéke";
            this.rb_rertek.UseVisualStyleBackColor = true;
            this.rb_rertek.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rb_ABC
            // 
            this.rb_ABC.AutoSize = true;
            this.rb_ABC.Location = new System.Drawing.Point(252, 245);
            this.rb_ABC.Name = "rb_ABC";
            this.rb_ABC.Size = new System.Drawing.Size(46, 17);
            this.rb_ABC.TabIndex = 6;
            this.rb_ABC.TabStop = true;
            this.rb_ABC.Text = "ABC";
            this.rb_ABC.UseVisualStyleBackColor = true;
            this.rb_ABC.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // lb_eredmeny
            // 
            this.lb_eredmeny.FormattingEnabled = true;
            this.lb_eredmeny.Location = new System.Drawing.Point(422, 12);
            this.lb_eredmeny.Name = "lb_eredmeny";
            this.lb_eredmeny.Size = new System.Drawing.Size(311, 329);
            this.lb_eredmeny.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 394);
            this.Controls.Add(this.lb_eredmeny);
            this.Controls.Add(this.rb_ABC);
            this.Controls.Add(this.rb_rertek);
            this.Controls.Add(this.rb_dragagyn);
            this.Controls.Add(this.rb_dragagyar);
            this.Controls.Add(this.rb_k);
            this.Controls.Add(this.lb_raktarom);
            this.Controls.Add(this.bt_beolvas);
            this.Name = "Form1";
            this.Text = "Raktárom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_beolvas;
        private System.Windows.Forms.ListBox lb_raktarom;
        private System.Windows.Forms.RadioButton rb_k;
        private System.Windows.Forms.RadioButton rb_dragagyar;
        private System.Windows.Forms.RadioButton rb_dragagyn;
        private System.Windows.Forms.RadioButton rb_rertek;
        private System.Windows.Forms.RadioButton rb_ABC;
        private System.Windows.Forms.ListBox lb_eredmeny;
    }
}

