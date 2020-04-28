namespace sportautok
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comb1 = new System.Windows.Forms.ComboBox();
            this.comb2 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_ossze = new System.Windows.Forms.Button();
            this.RB_ar = new System.Windows.Forms.RadioButton();
            this.RB_ev = new System.Windows.Forms.RadioButton();
            this.RB_tom = new System.Windows.Forms.RadioButton();
            this.RB_telj = new System.Windows.Forms.RadioButton();
            this.RB_db = new System.Windows.Forms.RadioButton();
            this.RB_vegs = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_2 = new System.Windows.Forms.Label();
            this.Btn_elt = new System.Windows.Forms.Button();
            this.Btn_kiv = new System.Windows.Forms.Button();
            this.Lb_ered = new System.Windows.Forms.ListBox();
            this.Lb_ered2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(73, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 58);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comb1
            // 
            this.comb1.FormattingEnabled = true;
            this.comb1.Location = new System.Drawing.Point(73, 75);
            this.comb1.Name = "comb1";
            this.comb1.Size = new System.Drawing.Size(121, 21);
            this.comb1.TabIndex = 1;
            this.comb1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comb2
            // 
            this.comb2.FormattingEnabled = true;
            this.comb2.Location = new System.Drawing.Point(259, 75);
            this.comb2.Name = "comb2";
            this.comb2.Size = new System.Drawing.Size(121, 21);
            this.comb2.TabIndex = 2;
            this.comb2.SelectedIndexChanged += new System.EventHandler(this.comb2_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(259, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 58);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Btn_ossze
            // 
            this.Btn_ossze.Location = new System.Drawing.Point(89, 244);
            this.Btn_ossze.Name = "Btn_ossze";
            this.Btn_ossze.Size = new System.Drawing.Size(94, 23);
            this.Btn_ossze.TabIndex = 4;
            this.Btn_ossze.Text = "Összehasonlít";
            this.Btn_ossze.UseVisualStyleBackColor = true;
            this.Btn_ossze.Click += new System.EventHandler(this.button1_Click);
            // 
            // RB_ar
            // 
            this.RB_ar.AutoSize = true;
            this.RB_ar.Location = new System.Drawing.Point(27, 18);
            this.RB_ar.Name = "RB_ar";
            this.RB_ar.Size = new System.Drawing.Size(58, 17);
            this.RB_ar.TabIndex = 5;
            this.RB_ar.TabStop = true;
            this.RB_ar.Text = "Vételár";
            this.RB_ar.UseVisualStyleBackColor = true;
            this.RB_ar.CheckedChanged += new System.EventHandler(this.RB_ar_CheckedChanged);
            // 
            // RB_ev
            // 
            this.RB_ev.AutoSize = true;
            this.RB_ev.Location = new System.Drawing.Point(27, 41);
            this.RB_ev.Name = "RB_ev";
            this.RB_ev.Size = new System.Drawing.Size(96, 17);
            this.RB_ev.TabIndex = 6;
            this.RB_ev.TabStop = true;
            this.RB_ev.Text = "Megjelenési év";
            this.RB_ev.UseVisualStyleBackColor = true;
            // 
            // RB_tom
            // 
            this.RB_tom.AutoSize = true;
            this.RB_tom.Location = new System.Drawing.Point(27, 64);
            this.RB_tom.Name = "RB_tom";
            this.RB_tom.Size = new System.Drawing.Size(58, 17);
            this.RB_tom.TabIndex = 7;
            this.RB_tom.TabStop = true;
            this.RB_tom.Text = "Tömeg";
            this.RB_tom.UseVisualStyleBackColor = true;
            // 
            // RB_telj
            // 
            this.RB_telj.AutoSize = true;
            this.RB_telj.Location = new System.Drawing.Point(27, 87);
            this.RB_telj.Name = "RB_telj";
            this.RB_telj.Size = new System.Drawing.Size(85, 17);
            this.RB_telj.TabIndex = 9;
            this.RB_telj.TabStop = true;
            this.RB_telj.Text = "Teljesítmény";
            this.RB_telj.UseVisualStyleBackColor = true;
            // 
            // RB_db
            // 
            this.RB_db.AutoSize = true;
            this.RB_db.Location = new System.Drawing.Point(27, 110);
            this.RB_db.Name = "RB_db";
            this.RB_db.Size = new System.Drawing.Size(134, 17);
            this.RB_db.TabIndex = 10;
            this.RB_db.TabStop = true;
            this.RB_db.Text = "Értékesített darabszám";
            this.RB_db.UseVisualStyleBackColor = true;
            // 
            // RB_vegs
            // 
            this.RB_vegs.AutoSize = true;
            this.RB_vegs.Location = new System.Drawing.Point(27, 133);
            this.RB_vegs.Name = "RB_vegs";
            this.RB_vegs.Size = new System.Drawing.Size(89, 17);
            this.RB_vegs.TabIndex = 12;
            this.RB_vegs.TabStop = true;
            this.RB_vegs.Text = "Végsebesség";
            this.RB_vegs.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RB_ar);
            this.panel1.Controls.Add(this.RB_vegs);
            this.panel1.Controls.Add(this.RB_ev);
            this.panel1.Controls.Add(this.RB_tom);
            this.panel1.Controls.Add(this.RB_db);
            this.panel1.Controls.Add(this.RB_telj);
            this.panel1.Location = new System.Drawing.Point(495, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 179);
            this.panel1.TabIndex = 13;
            // 
            // Lbl_1
            // 
            this.Lbl_1.AutoSize = true;
            this.Lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_1.Location = new System.Drawing.Point(8, 24);
            this.Lbl_1.Name = "Lbl_1";
            this.Lbl_1.Size = new System.Drawing.Size(195, 24);
            this.Lbl_1.TabIndex = 14;
            this.Lbl_1.Text = "Válasszon ki 1-1 autót:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Összehasonlítási szempontok:";
            // 
            // Lbl_2
            // 
            this.Lbl_2.AutoSize = true;
            this.Lbl_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_2.Location = new System.Drawing.Point(44, 307);
            this.Lbl_2.Name = "Lbl_2";
            this.Lbl_2.Size = new System.Drawing.Size(128, 24);
            this.Lbl_2.TabIndex = 16;
            this.Lbl_2.Text = "Az eredmény:";
            // 
            // Btn_elt
            // 
            this.Btn_elt.Location = new System.Drawing.Point(480, 314);
            this.Btn_elt.Name = "Btn_elt";
            this.Btn_elt.Size = new System.Drawing.Size(75, 23);
            this.Btn_elt.TabIndex = 17;
            this.Btn_elt.Text = "Eltárolás";
            this.Btn_elt.UseVisualStyleBackColor = true;
            this.Btn_elt.Click += new System.EventHandler(this.Btn_elt_Click);
            // 
            // Btn_kiv
            // 
            this.Btn_kiv.Location = new System.Drawing.Point(581, 314);
            this.Btn_kiv.Name = "Btn_kiv";
            this.Btn_kiv.Size = new System.Drawing.Size(75, 23);
            this.Btn_kiv.TabIndex = 18;
            this.Btn_kiv.Text = "Kivétel";
            this.Btn_kiv.UseVisualStyleBackColor = true;
            // 
            // Lb_ered
            // 
            this.Lb_ered.FormattingEnabled = true;
            this.Lb_ered.Location = new System.Drawing.Point(178, 307);
            this.Lb_ered.Name = "Lb_ered";
            this.Lb_ered.Size = new System.Drawing.Size(115, 43);
            this.Lb_ered.TabIndex = 19;
            // 
            // Lb_ered2
            // 
            this.Lb_ered2.FormattingEnabled = true;
            this.Lb_ered2.Location = new System.Drawing.Point(308, 307);
            this.Lb_ered2.Name = "Lb_ered2";
            this.Lb_ered2.Size = new System.Drawing.Size(120, 43);
            this.Lb_ered2.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lb_ered2);
            this.Controls.Add(this.Lb_ered);
            this.Controls.Add(this.Btn_kiv);
            this.Controls.Add(this.Btn_elt);
            this.Controls.Add(this.Lbl_2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl_1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_ossze);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comb2);
            this.Controls.Add(this.comb1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comb1;
        private System.Windows.Forms.ComboBox comb2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Btn_ossze;
        private System.Windows.Forms.RadioButton RB_ar;
        private System.Windows.Forms.RadioButton RB_ev;
        private System.Windows.Forms.RadioButton RB_tom;
        private System.Windows.Forms.RadioButton RB_telj;
        private System.Windows.Forms.RadioButton RB_db;
        private System.Windows.Forms.RadioButton RB_vegs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_2;
        private System.Windows.Forms.Button Btn_elt;
        private System.Windows.Forms.Button Btn_kiv;
        private System.Windows.Forms.ListBox Lb_ered;
        private System.Windows.Forms.ListBox Lb_ered2;
    }
}

