namespace Torpedo
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
            this.rb_naszad = new System.Windows.Forms.RadioButton();
            this.rB_rombolo = new System.Windows.Forms.RadioButton();
            this.rb_submarine = new System.Windows.Forms.RadioButton();
            this.rB_horbozó = new System.Windows.Forms.RadioButton();
            this.gB_1 = new System.Windows.Forms.GroupBox();
            this.btn_elhelyez = new System.Windows.Forms.Button();
            this.lb_1 = new System.Windows.Forms.Label();
            this.btn_fekves = new System.Windows.Forms.Button();
            this.lb_naszad = new System.Windows.Forms.Label();
            this.lb_rombolo = new System.Windows.Forms.Label();
            this.lb_sub = new System.Windows.Forms.Label();
            this.lb_carrier = new System.Windows.Forms.Label();
            this.btn_elhelyezesbef = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_loves = new System.Windows.Forms.Button();
            this.gB_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_naszad
            // 
            this.rb_naszad.AutoSize = true;
            this.rb_naszad.Checked = true;
            this.rb_naszad.Location = new System.Drawing.Point(6, 19);
            this.rb_naszad.Name = "rb_naszad";
            this.rb_naszad.Size = new System.Drawing.Size(61, 17);
            this.rb_naszad.TabIndex = 0;
            this.rb_naszad.TabStop = true;
            this.rb_naszad.Text = "Naszád";
            this.rb_naszad.UseVisualStyleBackColor = true;
            // 
            // rB_rombolo
            // 
            this.rB_rombolo.AutoSize = true;
            this.rB_rombolo.Location = new System.Drawing.Point(6, 42);
            this.rB_rombolo.Name = "rB_rombolo";
            this.rB_rombolo.Size = new System.Drawing.Size(67, 17);
            this.rB_rombolo.TabIndex = 1;
            this.rB_rombolo.TabStop = true;
            this.rB_rombolo.Text = "Romboló";
            this.rB_rombolo.UseVisualStyleBackColor = true;
            // 
            // rb_submarine
            // 
            this.rb_submarine.AutoSize = true;
            this.rb_submarine.Location = new System.Drawing.Point(6, 65);
            this.rb_submarine.Name = "rb_submarine";
            this.rb_submarine.Size = new System.Drawing.Size(96, 17);
            this.rb_submarine.TabIndex = 2;
            this.rb_submarine.TabStop = true;
            this.rb_submarine.Text = "Tengeralattjáró";
            this.rb_submarine.UseVisualStyleBackColor = true;
            // 
            // rB_horbozó
            // 
            this.rB_horbozó.AutoSize = true;
            this.rB_horbozó.Location = new System.Drawing.Point(6, 88);
            this.rB_horbozó.Name = "rB_horbozó";
            this.rB_horbozó.Size = new System.Drawing.Size(115, 17);
            this.rB_horbozó.TabIndex = 3;
            this.rB_horbozó.TabStop = true;
            this.rB_horbozó.Text = "Repülőgéphordozó";
            this.rB_horbozó.UseVisualStyleBackColor = true;
            // 
            // gB_1
            // 
            this.gB_1.Controls.Add(this.btn_reset);
            this.gB_1.Controls.Add(this.btn_elhelyezesbef);
            this.gB_1.Controls.Add(this.lb_carrier);
            this.gB_1.Controls.Add(this.lb_sub);
            this.gB_1.Controls.Add(this.lb_rombolo);
            this.gB_1.Controls.Add(this.lb_naszad);
            this.gB_1.Controls.Add(this.btn_elhelyez);
            this.gB_1.Controls.Add(this.lb_1);
            this.gB_1.Controls.Add(this.btn_fekves);
            this.gB_1.Controls.Add(this.rB_horbozó);
            this.gB_1.Controls.Add(this.rb_submarine);
            this.gB_1.Controls.Add(this.rB_rombolo);
            this.gB_1.Controls.Add(this.rb_naszad);
            this.gB_1.Location = new System.Drawing.Point(12, 12);
            this.gB_1.Name = "gB_1";
            this.gB_1.Size = new System.Drawing.Size(525, 120);
            this.gB_1.TabIndex = 4;
            this.gB_1.TabStop = false;
            // 
            // btn_elhelyez
            // 
            this.btn_elhelyez.Location = new System.Drawing.Point(325, 21);
            this.btn_elhelyez.Name = "btn_elhelyez";
            this.btn_elhelyez.Size = new System.Drawing.Size(94, 40);
            this.btn_elhelyez.TabIndex = 6;
            this.btn_elhelyez.Text = "Elhelyezés";
            this.btn_elhelyez.UseVisualStyleBackColor = true;
            this.btn_elhelyez.Click += new System.EventHandler(this.btn_elhelyez_Click);
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Location = new System.Drawing.Point(241, 64);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(58, 13);
            this.lb_1.TabIndex = 5;
            this.lb_1.Text = "Felfelé néz";
            // 
            // btn_fekves
            // 
            this.btn_fekves.Location = new System.Drawing.Point(216, 21);
            this.btn_fekves.Name = "btn_fekves";
            this.btn_fekves.Size = new System.Drawing.Size(103, 40);
            this.btn_fekves.TabIndex = 4;
            this.btn_fekves.Text = "Fordítás";
            this.btn_fekves.UseVisualStyleBackColor = true;
            this.btn_fekves.Click += new System.EventHandler(this.btn_fekves_Click);
            // 
            // lb_naszad
            // 
            this.lb_naszad.AutoSize = true;
            this.lb_naszad.Location = new System.Drawing.Point(127, 21);
            this.lb_naszad.Name = "lb_naszad";
            this.lb_naszad.Size = new System.Drawing.Size(0, 13);
            this.lb_naszad.TabIndex = 7;
            // 
            // lb_rombolo
            // 
            this.lb_rombolo.AutoSize = true;
            this.lb_rombolo.Location = new System.Drawing.Point(127, 46);
            this.lb_rombolo.Name = "lb_rombolo";
            this.lb_rombolo.Size = new System.Drawing.Size(0, 13);
            this.lb_rombolo.TabIndex = 8;
            // 
            // lb_sub
            // 
            this.lb_sub.AutoSize = true;
            this.lb_sub.Location = new System.Drawing.Point(127, 69);
            this.lb_sub.Name = "lb_sub";
            this.lb_sub.Size = new System.Drawing.Size(0, 13);
            this.lb_sub.TabIndex = 9;
            // 
            // lb_carrier
            // 
            this.lb_carrier.AutoSize = true;
            this.lb_carrier.Location = new System.Drawing.Point(127, 92);
            this.lb_carrier.Name = "lb_carrier";
            this.lb_carrier.Size = new System.Drawing.Size(0, 13);
            this.lb_carrier.TabIndex = 10;
            // 
            // btn_elhelyezesbef
            // 
            this.btn_elhelyezesbef.Location = new System.Drawing.Point(425, 21);
            this.btn_elhelyezesbef.Name = "btn_elhelyezesbef";
            this.btn_elhelyezesbef.Size = new System.Drawing.Size(94, 40);
            this.btn_elhelyezesbef.TabIndex = 11;
            this.btn_elhelyezesbef.Text = "Elhelyezés befejezése";
            this.btn_elhelyezesbef.UseVisualStyleBackColor = true;
            this.btn_elhelyezesbef.Click += new System.EventHandler(this.btn_elhelyezesbef_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(425, 69);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(94, 36);
            this.btn_reset.TabIndex = 12;
            this.btn_reset.Text = "Pálya letisztítása";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_loves
            // 
            this.btn_loves.Location = new System.Drawing.Point(356, 198);
            this.btn_loves.Name = "btn_loves";
            this.btn_loves.Size = new System.Drawing.Size(75, 76);
            this.btn_loves.TabIndex = 5;
            this.btn_loves.Text = "Lövés";
            this.btn_loves.UseVisualStyleBackColor = true;
            this.btn_loves.Visible = false;
            this.btn_loves.Click += new System.EventHandler(this.btn_loves_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_loves);
            this.Controls.Add(this.gB_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gB_1.ResumeLayout(false);
            this.gB_1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_naszad;
        private System.Windows.Forms.RadioButton rB_rombolo;
        private System.Windows.Forms.RadioButton rb_submarine;
        private System.Windows.Forms.RadioButton rB_horbozó;
        private System.Windows.Forms.GroupBox gB_1;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Button btn_fekves;
        private System.Windows.Forms.Button btn_elhelyez;
        private System.Windows.Forms.Label lb_carrier;
        private System.Windows.Forms.Label lb_sub;
        private System.Windows.Forms.Label lb_rombolo;
        private System.Windows.Forms.Label lb_naszad;
        private System.Windows.Forms.Button btn_elhelyezesbef;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_loves;
    }
}

