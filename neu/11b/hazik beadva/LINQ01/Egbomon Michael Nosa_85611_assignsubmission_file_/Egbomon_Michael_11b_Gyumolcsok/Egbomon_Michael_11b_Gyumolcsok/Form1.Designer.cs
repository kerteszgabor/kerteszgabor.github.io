namespace Egbomon_Michael_11b_Gyumolcsok
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
            this.lb_elemek = new System.Windows.Forms.ListBox();
            this.lb_eredmeny = new System.Windows.Forms.ListBox();
            this.btn_beolvas = new System.Windows.Forms.Button();
            this.rb_k_betuvel_kezdodo = new System.Windows.Forms.RadioButton();
            this.rb_legdragabb_ar = new System.Windows.Forms.RadioButton();
            this.rb_legdragabb_gyumolcs = new System.Windows.Forms.RadioButton();
            this.rb_raktar_osszertek = new System.Windows.Forms.RadioButton();
            this.rb_abc_sorrend = new System.Windows.Forms.RadioButton();
            this.gp_opciok = new System.Windows.Forms.GroupBox();
            this.gp_opciok.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_elemek
            // 
            this.lb_elemek.FormattingEnabled = true;
            this.lb_elemek.Location = new System.Drawing.Point(12, 12);
            this.lb_elemek.Name = "lb_elemek";
            this.lb_elemek.Size = new System.Drawing.Size(298, 277);
            this.lb_elemek.TabIndex = 0;
            // 
            // lb_eredmeny
            // 
            this.lb_eredmeny.FormattingEnabled = true;
            this.lb_eredmeny.Location = new System.Drawing.Point(607, 12);
            this.lb_eredmeny.Name = "lb_eredmeny";
            this.lb_eredmeny.Size = new System.Drawing.Size(271, 277);
            this.lb_eredmeny.TabIndex = 1;
            // 
            // btn_beolvas
            // 
            this.btn_beolvas.Location = new System.Drawing.Point(110, 314);
            this.btn_beolvas.Name = "btn_beolvas";
            this.btn_beolvas.Size = new System.Drawing.Size(96, 35);
            this.btn_beolvas.TabIndex = 2;
            this.btn_beolvas.Text = "Beolvasás";
            this.btn_beolvas.UseVisualStyleBackColor = true;
            this.btn_beolvas.Click += new System.EventHandler(this.btn_beolvas_Click);
            // 
            // rb_k_betuvel_kezdodo
            // 
            this.rb_k_betuvel_kezdodo.AutoSize = true;
            this.rb_k_betuvel_kezdodo.Location = new System.Drawing.Point(20, 29);
            this.rb_k_betuvel_kezdodo.Name = "rb_k_betuvel_kezdodo";
            this.rb_k_betuvel_kezdodo.Size = new System.Drawing.Size(206, 17);
            this.rb_k_betuvel_kezdodo.TabIndex = 3;
            this.rb_k_betuvel_kezdodo.TabStop = true;
            this.rb_k_betuvel_kezdodo.Text = "K betűvel kezdődő gyümölcsök száma";
            this.rb_k_betuvel_kezdodo.UseVisualStyleBackColor = true;
            this.rb_k_betuvel_kezdodo.CheckedChanged += new System.EventHandler(this.rb_k_betuvel_kezdodo_CheckedChanged);
            // 
            // rb_legdragabb_ar
            // 
            this.rb_legdragabb_ar.AutoSize = true;
            this.rb_legdragabb_ar.Location = new System.Drawing.Point(20, 62);
            this.rb_legdragabb_ar.Name = "rb_legdragabb_ar";
            this.rb_legdragabb_ar.Size = new System.Drawing.Size(147, 17);
            this.rb_legdragabb_ar.TabIndex = 4;
            this.rb_legdragabb_ar.TabStop = true;
            this.rb_legdragabb_ar.Text = "Legdrágább gyümölcs ára";
            this.rb_legdragabb_ar.UseVisualStyleBackColor = true;
            this.rb_legdragabb_ar.CheckedChanged += new System.EventHandler(this.rb_legdragabb_ar_CheckedChanged);
            // 
            // rb_legdragabb_gyumolcs
            // 
            this.rb_legdragabb_gyumolcs.AutoSize = true;
            this.rb_legdragabb_gyumolcs.Location = new System.Drawing.Point(20, 95);
            this.rb_legdragabb_gyumolcs.Name = "rb_legdragabb_gyumolcs";
            this.rb_legdragabb_gyumolcs.Size = new System.Drawing.Size(156, 17);
            this.rb_legdragabb_gyumolcs.TabIndex = 5;
            this.rb_legdragabb_gyumolcs.TabStop = true;
            this.rb_legdragabb_gyumolcs.Text = "Legdrágább gyümölcs neve";
            this.rb_legdragabb_gyumolcs.UseVisualStyleBackColor = true;
            this.rb_legdragabb_gyumolcs.CheckedChanged += new System.EventHandler(this.rb_legdragabb_gyumolcs_CheckedChanged);
            // 
            // rb_raktar_osszertek
            // 
            this.rb_raktar_osszertek.AutoSize = true;
            this.rb_raktar_osszertek.Location = new System.Drawing.Point(20, 131);
            this.rb_raktar_osszertek.Name = "rb_raktar_osszertek";
            this.rb_raktar_osszertek.Size = new System.Drawing.Size(111, 17);
            this.rb_raktar_osszertek.TabIndex = 6;
            this.rb_raktar_osszertek.TabStop = true;
            this.rb_raktar_osszertek.Text = "Raktár összértéke";
            this.rb_raktar_osszertek.UseVisualStyleBackColor = true;
            this.rb_raktar_osszertek.CheckedChanged += new System.EventHandler(this.rb_raktar_osszertek_CheckedChanged);
            // 
            // rb_abc_sorrend
            // 
            this.rb_abc_sorrend.AutoSize = true;
            this.rb_abc_sorrend.Location = new System.Drawing.Point(20, 169);
            this.rb_abc_sorrend.Name = "rb_abc_sorrend";
            this.rb_abc_sorrend.Size = new System.Drawing.Size(142, 17);
            this.rb_abc_sorrend.TabIndex = 7;
            this.rb_abc_sorrend.TabStop = true;
            this.rb_abc_sorrend.Text = "ABC sorrendbe rendezés";
            this.rb_abc_sorrend.UseVisualStyleBackColor = true;
            this.rb_abc_sorrend.CheckedChanged += new System.EventHandler(this.rb_abc_sorrend_CheckedChanged);
            // 
            // gp_opciok
            // 
            this.gp_opciok.Controls.Add(this.rb_abc_sorrend);
            this.gp_opciok.Controls.Add(this.rb_raktar_osszertek);
            this.gp_opciok.Controls.Add(this.rb_legdragabb_gyumolcs);
            this.gp_opciok.Controls.Add(this.rb_legdragabb_ar);
            this.gp_opciok.Controls.Add(this.rb_k_betuvel_kezdodo);
            this.gp_opciok.Enabled = false;
            this.gp_opciok.Location = new System.Drawing.Point(334, 12);
            this.gp_opciok.Name = "gp_opciok";
            this.gp_opciok.Size = new System.Drawing.Size(250, 234);
            this.gp_opciok.TabIndex = 8;
            this.gp_opciok.TabStop = false;
            this.gp_opciok.Text = "Opciók";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.gp_opciok);
            this.Controls.Add(this.btn_beolvas);
            this.Controls.Add(this.lb_eredmeny);
            this.Controls.Add(this.lb_elemek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gp_opciok.ResumeLayout(false);
            this.gp_opciok.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_elemek;
        private System.Windows.Forms.ListBox lb_eredmeny;
        private System.Windows.Forms.Button btn_beolvas;
        private System.Windows.Forms.RadioButton rb_k_betuvel_kezdodo;
        private System.Windows.Forms.RadioButton rb_legdragabb_ar;
        private System.Windows.Forms.RadioButton rb_legdragabb_gyumolcs;
        private System.Windows.Forms.RadioButton rb_raktar_osszertek;
        private System.Windows.Forms.RadioButton rb_abc_sorrend;
        private System.Windows.Forms.GroupBox gp_opciok;
    }
}

