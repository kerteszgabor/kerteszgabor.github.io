namespace SulyokDániel_11c_Projekt
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.RB_konyv = new System.Windows.Forms.RadioButton();
            this.RB_film = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.LBvasarlasilista = new System.Windows.Forms.Label();
            this.BTvasarlas = new System.Windows.Forms.Button();
            this.CBtitanic = new System.Windows.Forms.CheckBox();
            this.CBgyurukura = new System.Windows.Forms.CheckBox();
            this.CBhobbit = new System.Windows.Forms.CheckBox();
            this.CBfrozen = new System.Windows.Forms.CheckBox();
            this.CBharrypotter = new System.Windows.Forms.CheckBox();
            this.CBjamesbond = new System.Windows.Forms.CheckBox();
            this.CBpercyjackson = new System.Windows.Forms.CheckBox();
            this.CBbeavatott = new System.Windows.Forms.CheckBox();
            this.CBalkonyat = new System.Windows.Forms.CheckBox();
            this.CBehezokviadala = new System.Windows.Forms.CheckBox();
            this.CBvasember = new System.Windows.Forms.CheckBox();
            this.CBszamkivetett = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTszamla = new System.Windows.Forms.Button();
            this.LBosszesertek = new System.Windows.Forms.Label();
            this.LBosszesaru = new System.Windows.Forms.Label();
            this.LBszamla = new System.Windows.Forms.Label();
            this.GBfilm = new System.Windows.Forms.GroupBox();
            this.GBkonyv = new System.Windows.Forms.GroupBox();
            this.GBfilmeskonyv = new System.Windows.Forms.GroupBox();
            this.LBszamlakiiras = new System.Windows.Forms.Label();
            this.LBszamlaosszesitettertek = new System.Windows.Forms.Label();
            this.GBfilm.SuspendLayout();
            this.GBkonyv.SuspendLayout();
            this.GBfilmeskonyv.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 294);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 290);
            this.listBox1.TabIndex = 0;
            this.listBox1.Visible = false;
            // 
            // RB_konyv
            // 
            this.RB_konyv.AutoSize = true;
            this.RB_konyv.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_konyv.ForeColor = System.Drawing.Color.SaddleBrown;
            this.RB_konyv.Location = new System.Drawing.Point(17, 64);
            this.RB_konyv.Name = "RB_konyv";
            this.RB_konyv.Size = new System.Drawing.Size(119, 21);
            this.RB_konyv.TabIndex = 2;
            this.RB_konyv.Text = "Könyv = 750 Ft";
            this.RB_konyv.UseVisualStyleBackColor = true;
            this.RB_konyv.CheckedChanged += new System.EventHandler(this.RB_konyv_CheckedChanged);
            // 
            // RB_film
            // 
            this.RB_film.AutoSize = true;
            this.RB_film.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_film.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RB_film.Location = new System.Drawing.Point(208, 64);
            this.RB_film.Name = "RB_film";
            this.RB_film.Size = new System.Drawing.Size(117, 21);
            this.RB_film.TabIndex = 3;
            this.RB_film.Text = "Film = 1000 Ft";
            this.RB_film.UseVisualStyleBackColor = true;
            this.RB_film.CheckedChanged += new System.EventHandler(this.RB_film_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Könyvet vagy filmet szeretne?";
            // 
            // LBvasarlasilista
            // 
            this.LBvasarlasilista.AutoSize = true;
            this.LBvasarlasilista.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBvasarlasilista.Location = new System.Drawing.Point(15, 263);
            this.LBvasarlasilista.Name = "LBvasarlasilista";
            this.LBvasarlasilista.Size = new System.Drawing.Size(116, 18);
            this.LBvasarlasilista.TabIndex = 5;
            this.LBvasarlasilista.Text = "Vásárlási lista";
            this.LBvasarlasilista.Visible = false;
            // 
            // BTvasarlas
            // 
            this.BTvasarlas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTvasarlas.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTvasarlas.Location = new System.Drawing.Point(227, 294);
            this.BTvasarlas.Name = "BTvasarlas";
            this.BTvasarlas.Size = new System.Drawing.Size(173, 72);
            this.BTvasarlas.TabIndex = 6;
            this.BTvasarlas.Text = "Vásárlás";
            this.BTvasarlas.UseVisualStyleBackColor = false;
            this.BTvasarlas.Visible = false;
            this.BTvasarlas.Click += new System.EventHandler(this.BTvasarlas_Click);
            // 
            // CBtitanic
            // 
            this.CBtitanic.AutoSize = true;
            this.CBtitanic.Location = new System.Drawing.Point(10, 51);
            this.CBtitanic.Name = "CBtitanic";
            this.CBtitanic.Size = new System.Drawing.Size(58, 17);
            this.CBtitanic.TabIndex = 7;
            this.CBtitanic.Text = "Titanic";
            this.CBtitanic.UseVisualStyleBackColor = true;
            this.CBtitanic.Visible = false;
            this.CBtitanic.CheckedChanged += new System.EventHandler(this.CBtitanic_CheckedChanged);
            // 
            // CBgyurukura
            // 
            this.CBgyurukura.AutoSize = true;
            this.CBgyurukura.Location = new System.Drawing.Point(10, 73);
            this.CBgyurukura.Name = "CBgyurukura";
            this.CBgyurukura.Size = new System.Drawing.Size(78, 17);
            this.CBgyurukura.TabIndex = 8;
            this.CBgyurukura.Text = "Gyűrűk ura";
            this.CBgyurukura.UseVisualStyleBackColor = true;
            this.CBgyurukura.Visible = false;
            this.CBgyurukura.CheckedChanged += new System.EventHandler(this.CBgyurukura_CheckedChanged);
            // 
            // CBhobbit
            // 
            this.CBhobbit.AutoSize = true;
            this.CBhobbit.Location = new System.Drawing.Point(10, 99);
            this.CBhobbit.Name = "CBhobbit";
            this.CBhobbit.Size = new System.Drawing.Size(57, 17);
            this.CBhobbit.TabIndex = 9;
            this.CBhobbit.Text = "Hobbit";
            this.CBhobbit.UseVisualStyleBackColor = true;
            this.CBhobbit.Visible = false;
            this.CBhobbit.CheckedChanged += new System.EventHandler(this.CBhobbit_CheckedChanged);
            // 
            // CBfrozen
            // 
            this.CBfrozen.AutoSize = true;
            this.CBfrozen.Location = new System.Drawing.Point(10, 120);
            this.CBfrozen.Name = "CBfrozen";
            this.CBfrozen.Size = new System.Drawing.Size(58, 17);
            this.CBfrozen.TabIndex = 10;
            this.CBfrozen.Text = "Frozen";
            this.CBfrozen.UseVisualStyleBackColor = true;
            this.CBfrozen.Visible = false;
            this.CBfrozen.CheckedChanged += new System.EventHandler(this.CBfrozen_CheckedChanged);
            // 
            // CBharrypotter
            // 
            this.CBharrypotter.AutoSize = true;
            this.CBharrypotter.Location = new System.Drawing.Point(9, 51);
            this.CBharrypotter.Name = "CBharrypotter";
            this.CBharrypotter.Size = new System.Drawing.Size(82, 17);
            this.CBharrypotter.TabIndex = 11;
            this.CBharrypotter.Text = "Harry Potter";
            this.CBharrypotter.UseVisualStyleBackColor = true;
            this.CBharrypotter.Visible = false;
            this.CBharrypotter.CheckedChanged += new System.EventHandler(this.CBharrypotter_CheckedChanged);
            // 
            // CBjamesbond
            // 
            this.CBjamesbond.AutoSize = true;
            this.CBjamesbond.Location = new System.Drawing.Point(10, 49);
            this.CBjamesbond.Name = "CBjamesbond";
            this.CBjamesbond.Size = new System.Drawing.Size(84, 17);
            this.CBjamesbond.TabIndex = 12;
            this.CBjamesbond.Text = "James Bond";
            this.CBjamesbond.UseVisualStyleBackColor = true;
            this.CBjamesbond.Visible = false;
            this.CBjamesbond.CheckedChanged += new System.EventHandler(this.CBjamesbond_CheckedChanged);
            // 
            // CBpercyjackson
            // 
            this.CBpercyjackson.AutoSize = true;
            this.CBpercyjackson.Location = new System.Drawing.Point(9, 98);
            this.CBpercyjackson.Name = "CBpercyjackson";
            this.CBpercyjackson.Size = new System.Drawing.Size(96, 17);
            this.CBpercyjackson.TabIndex = 13;
            this.CBpercyjackson.Text = "Percy Jackson";
            this.CBpercyjackson.UseVisualStyleBackColor = true;
            this.CBpercyjackson.Visible = false;
            this.CBpercyjackson.CheckedChanged += new System.EventHandler(this.CBpercyjackson_CheckedChanged);
            // 
            // CBbeavatott
            // 
            this.CBbeavatott.AutoSize = true;
            this.CBbeavatott.Location = new System.Drawing.Point(9, 122);
            this.CBbeavatott.Name = "CBbeavatott";
            this.CBbeavatott.Size = new System.Drawing.Size(72, 17);
            this.CBbeavatott.TabIndex = 14;
            this.CBbeavatott.Text = "Beavatott";
            this.CBbeavatott.UseVisualStyleBackColor = true;
            this.CBbeavatott.Visible = false;
            this.CBbeavatott.CheckedChanged += new System.EventHandler(this.CBbeavatott_CheckedChanged);
            // 
            // CBalkonyat
            // 
            this.CBalkonyat.AutoSize = true;
            this.CBalkonyat.Location = new System.Drawing.Point(10, 122);
            this.CBalkonyat.Name = "CBalkonyat";
            this.CBalkonyat.Size = new System.Drawing.Size(67, 17);
            this.CBalkonyat.TabIndex = 15;
            this.CBalkonyat.Text = "Alkonyat";
            this.CBalkonyat.UseVisualStyleBackColor = true;
            this.CBalkonyat.Visible = false;
            this.CBalkonyat.CheckedChanged += new System.EventHandler(this.CBalkonyat_CheckedChanged);
            // 
            // CBehezokviadala
            // 
            this.CBehezokviadala.AutoSize = true;
            this.CBehezokviadala.Location = new System.Drawing.Point(10, 73);
            this.CBehezokviadala.Name = "CBehezokviadala";
            this.CBehezokviadala.Size = new System.Drawing.Size(99, 17);
            this.CBehezokviadala.TabIndex = 16;
            this.CBehezokviadala.Text = "Éhezők viadala";
            this.CBehezokviadala.UseVisualStyleBackColor = true;
            this.CBehezokviadala.Visible = false;
            this.CBehezokviadala.CheckedChanged += new System.EventHandler(this.CBehezokviadala_CheckedChanged);
            // 
            // CBvasember
            // 
            this.CBvasember.AutoSize = true;
            this.CBvasember.Location = new System.Drawing.Point(10, 97);
            this.CBvasember.Name = "CBvasember";
            this.CBvasember.Size = new System.Drawing.Size(73, 17);
            this.CBvasember.TabIndex = 17;
            this.CBvasember.Text = "Vasember";
            this.CBvasember.UseVisualStyleBackColor = true;
            this.CBvasember.Visible = false;
            this.CBvasember.CheckedChanged += new System.EventHandler(this.CBvasember_CheckedChanged);
            // 
            // CBszamkivetett
            // 
            this.CBszamkivetett.AutoSize = true;
            this.CBszamkivetett.Location = new System.Drawing.Point(9, 75);
            this.CBszamkivetett.Name = "CBszamkivetett";
            this.CBszamkivetett.Size = new System.Drawing.Size(87, 17);
            this.CBszamkivetett.TabIndex = 18;
            this.CBszamkivetett.Text = "Számkivetett";
            this.CBszamkivetett.UseVisualStyleBackColor = true;
            this.CBszamkivetett.Visible = false;
            this.CBszamkivetett.CheckedChanged += new System.EventHandler(this.CBszamkivetett_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Csak film";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Csak könyv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 30);
            this.label5.TabIndex = 21;
            this.label5.Text = "Filmben és\r\nkönyvben is elérhető";
            // 
            // BTszamla
            // 
            this.BTszamla.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTszamla.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTszamla.Location = new System.Drawing.Point(227, 512);
            this.BTszamla.Name = "BTszamla";
            this.BTszamla.Size = new System.Drawing.Size(173, 72);
            this.BTszamla.TabIndex = 23;
            this.BTszamla.Text = "Számla nyomtatása";
            this.BTszamla.UseVisualStyleBackColor = false;
            this.BTszamla.Visible = false;
            this.BTszamla.Click += new System.EventHandler(this.BTszamla_Click);
            // 
            // LBosszesertek
            // 
            this.LBosszesertek.AutoSize = true;
            this.LBosszesertek.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBosszesertek.Location = new System.Drawing.Point(224, 429);
            this.LBosszesertek.Name = "LBosszesertek";
            this.LBosszesertek.Size = new System.Drawing.Size(117, 15);
            this.LBosszesertek.TabIndex = 24;
            this.LBosszesertek.Text = "Összesített érték: ";
            this.LBosszesertek.Visible = false;
            // 
            // LBosszesaru
            // 
            this.LBosszesaru.AutoSize = true;
            this.LBosszesaru.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBosszesaru.Location = new System.Drawing.Point(224, 481);
            this.LBosszesaru.Name = "LBosszesaru";
            this.LBosszesaru.Size = new System.Drawing.Size(147, 15);
            this.LBosszesaru.TabIndex = 25;
            this.LBosszesaru.Text = "Termékek darabszáma:";
            this.LBosszesaru.Visible = false;
            // 
            // LBszamla
            // 
            this.LBszamla.AutoSize = true;
            this.LBszamla.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBszamla.Location = new System.Drawing.Point(224, 379);
            this.LBszamla.Name = "LBszamla";
            this.LBszamla.Size = new System.Drawing.Size(176, 15);
            this.LBszamla.TabIndex = 26;
            this.LBszamla.Text = "Számla  keletkezett ekkor: ";
            this.LBszamla.Visible = false;
            // 
            // GBfilm
            // 
            this.GBfilm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GBfilm.Controls.Add(this.label3);
            this.GBfilm.Controls.Add(this.CBalkonyat);
            this.GBfilm.Controls.Add(this.CBhobbit);
            this.GBfilm.Controls.Add(this.CBtitanic);
            this.GBfilm.Controls.Add(this.CBgyurukura);
            this.GBfilm.Location = new System.Drawing.Point(18, 91);
            this.GBfilm.Name = "GBfilm";
            this.GBfilm.Size = new System.Drawing.Size(92, 155);
            this.GBfilm.TabIndex = 27;
            this.GBfilm.TabStop = false;
            this.GBfilm.Visible = false;
            // 
            // GBkonyv
            // 
            this.GBkonyv.BackColor = System.Drawing.Color.SaddleBrown;
            this.GBkonyv.Controls.Add(this.label4);
            this.GBkonyv.Controls.Add(this.CBszamkivetett);
            this.GBkonyv.Controls.Add(this.CBbeavatott);
            this.GBkonyv.Controls.Add(this.CBharrypotter);
            this.GBkonyv.Controls.Add(this.CBpercyjackson);
            this.GBkonyv.Location = new System.Drawing.Point(116, 91);
            this.GBkonyv.Name = "GBkonyv";
            this.GBkonyv.Size = new System.Drawing.Size(106, 157);
            this.GBkonyv.TabIndex = 28;
            this.GBkonyv.TabStop = false;
            this.GBkonyv.Visible = false;
            // 
            // GBfilmeskonyv
            // 
            this.GBfilmeskonyv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GBfilmeskonyv.Controls.Add(this.label5);
            this.GBfilmeskonyv.Controls.Add(this.CBvasember);
            this.GBfilmeskonyv.Controls.Add(this.CBehezokviadala);
            this.GBfilmeskonyv.Controls.Add(this.CBjamesbond);
            this.GBfilmeskonyv.Controls.Add(this.CBfrozen);
            this.GBfilmeskonyv.Location = new System.Drawing.Point(227, 91);
            this.GBfilmeskonyv.Name = "GBfilmeskonyv";
            this.GBfilmeskonyv.Size = new System.Drawing.Size(173, 157);
            this.GBfilmeskonyv.TabIndex = 29;
            this.GBfilmeskonyv.TabStop = false;
            this.GBfilmeskonyv.Visible = false;
            // 
            // LBszamlakiiras
            // 
            this.LBszamlakiiras.AutoSize = true;
            this.LBszamlakiiras.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBszamlakiiras.Location = new System.Drawing.Point(224, 394);
            this.LBszamlakiiras.Name = "LBszamlakiiras";
            this.LBszamlakiiras.Size = new System.Drawing.Size(0, 15);
            this.LBszamlakiiras.TabIndex = 30;
            // 
            // LBszamlaosszesitettertek
            // 
            this.LBszamlaosszesitettertek.AutoSize = true;
            this.LBszamlaosszesitettertek.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBszamlaosszesitettertek.Location = new System.Drawing.Point(224, 444);
            this.LBszamlaosszesitettertek.Name = "LBszamlaosszesitettertek";
            this.LBszamlaosszesitettertek.Size = new System.Drawing.Size(0, 15);
            this.LBszamlaosszesitettertek.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 641);
            this.Controls.Add(this.LBszamlaosszesitettertek);
            this.Controls.Add(this.LBszamlakiiras);
            this.Controls.Add(this.GBfilmeskonyv);
            this.Controls.Add(this.GBkonyv);
            this.Controls.Add(this.GBfilm);
            this.Controls.Add(this.LBszamla);
            this.Controls.Add(this.LBosszesaru);
            this.Controls.Add(this.LBosszesertek);
            this.Controls.Add(this.BTszamla);
            this.Controls.Add(this.BTvasarlas);
            this.Controls.Add(this.LBvasarlasilista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RB_film);
            this.Controls.Add(this.RB_konyv);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "  ";
            this.GBfilm.ResumeLayout(false);
            this.GBfilm.PerformLayout();
            this.GBkonyv.ResumeLayout(false);
            this.GBkonyv.PerformLayout();
            this.GBfilmeskonyv.ResumeLayout(false);
            this.GBfilmeskonyv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton RB_konyv;
        private System.Windows.Forms.RadioButton RB_film;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBvasarlasilista;
        private System.Windows.Forms.Button BTvasarlas;
        private System.Windows.Forms.CheckBox CBtitanic;
        private System.Windows.Forms.CheckBox CBgyurukura;
        private System.Windows.Forms.CheckBox CBhobbit;
        private System.Windows.Forms.CheckBox CBfrozen;
        private System.Windows.Forms.CheckBox CBharrypotter;
        private System.Windows.Forms.CheckBox CBjamesbond;
        private System.Windows.Forms.CheckBox CBpercyjackson;
        private System.Windows.Forms.CheckBox CBbeavatott;
        private System.Windows.Forms.CheckBox CBalkonyat;
        private System.Windows.Forms.CheckBox CBehezokviadala;
        private System.Windows.Forms.CheckBox CBvasember;
        private System.Windows.Forms.CheckBox CBszamkivetett;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTszamla;
        private System.Windows.Forms.Label LBosszesertek;
        private System.Windows.Forms.Label LBosszesaru;
        private System.Windows.Forms.Label LBszamla;
        private System.Windows.Forms.GroupBox GBfilm;
        private System.Windows.Forms.GroupBox GBkonyv;
        private System.Windows.Forms.GroupBox GBfilmeskonyv;
        private System.Windows.Forms.Label LBszamlakiiras;
        private System.Windows.Forms.Label LBszamlaosszesitettertek;
    }
}

