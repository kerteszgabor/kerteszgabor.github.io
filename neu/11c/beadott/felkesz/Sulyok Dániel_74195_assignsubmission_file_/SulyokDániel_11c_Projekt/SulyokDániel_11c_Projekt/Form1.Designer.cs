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
            this.label2 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(315, 147);
            this.listBox1.TabIndex = 0;
            // 
            // RB_konyv
            // 
            this.RB_konyv.AutoSize = true;
            this.RB_konyv.Location = new System.Drawing.Point(339, 44);
            this.RB_konyv.Name = "RB_konyv";
            this.RB_konyv.Size = new System.Drawing.Size(97, 17);
            this.RB_konyv.TabIndex = 2;
            this.RB_konyv.TabStop = true;
            this.RB_konyv.Text = "Könyv = 750 Ft";
            this.RB_konyv.UseVisualStyleBackColor = true;
            this.RB_konyv.CheckedChanged += new System.EventHandler(this.RB_konyv_CheckedChanged);
            // 
            // RB_film
            // 
            this.RB_film.AutoSize = true;
            this.RB_film.Location = new System.Drawing.Point(516, 44);
            this.RB_film.Name = "RB_film";
            this.RB_film.Size = new System.Drawing.Size(91, 17);
            this.RB_film.TabIndex = 3;
            this.RB_film.Text = "Film = 1000 Ft";
            this.RB_film.UseVisualStyleBackColor = true;
            this.RB_film.CheckedChanged += new System.EventHandler(this.RB_film_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Könyvet vagy filmet szeretne?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vásárlási lista";
            // 
            // BTvasarlas
            // 
            this.BTvasarlas.Location = new System.Drawing.Point(12, 197);
            this.BTvasarlas.Name = "BTvasarlas";
            this.BTvasarlas.Size = new System.Drawing.Size(142, 72);
            this.BTvasarlas.TabIndex = 6;
            this.BTvasarlas.Text = "Vásárlás";
            this.BTvasarlas.UseVisualStyleBackColor = true;
            this.BTvasarlas.Click += new System.EventHandler(this.BTvasarlas_Click);
            // 
            // CBtitanic
            // 
            this.CBtitanic.AutoSize = true;
            this.CBtitanic.Location = new System.Drawing.Point(339, 103);
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
            this.CBgyurukura.Location = new System.Drawing.Point(339, 127);
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
            this.CBhobbit.Location = new System.Drawing.Point(339, 151);
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
            this.CBfrozen.Location = new System.Drawing.Point(516, 174);
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
            this.CBharrypotter.Location = new System.Drawing.Point(414, 103);
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
            this.CBjamesbond.Location = new System.Drawing.Point(516, 103);
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
            this.CBpercyjackson.Location = new System.Drawing.Point(414, 151);
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
            this.CBbeavatott.Location = new System.Drawing.Point(414, 174);
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
            this.CBalkonyat.Location = new System.Drawing.Point(339, 174);
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
            this.CBehezokviadala.Location = new System.Drawing.Point(516, 127);
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
            this.CBvasember.Location = new System.Drawing.Point(516, 151);
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
            this.CBszamkivetett.Location = new System.Drawing.Point(414, 127);
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
            this.label3.Location = new System.Drawing.Point(336, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Csak film";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Csak könyv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Filmben és könyvben is elérhető";
            // 
            // BTszamla
            // 
            this.BTszamla.Location = new System.Drawing.Point(185, 197);
            this.BTszamla.Name = "BTszamla";
            this.BTszamla.Size = new System.Drawing.Size(142, 72);
            this.BTszamla.TabIndex = 23;
            this.BTszamla.Text = "Számla nyomtatása";
            this.BTszamla.UseVisualStyleBackColor = true;
            this.BTszamla.Visible = false;
            this.BTszamla.Click += new System.EventHandler(this.BTszamla_Click);
            // 
            // LBosszesertek
            // 
            this.LBosszesertek.AutoSize = true;
            this.LBosszesertek.Location = new System.Drawing.Point(336, 227);
            this.LBosszesertek.Name = "LBosszesertek";
            this.LBosszesertek.Size = new System.Drawing.Size(93, 13);
            this.LBosszesertek.TabIndex = 24;
            this.LBosszesertek.Text = "Összesített érték: ";
            this.LBosszesertek.Visible = false;
            // 
            // LBosszesaru
            // 
            this.LBosszesaru.AutoSize = true;
            this.LBosszesaru.Location = new System.Drawing.Point(336, 256);
            this.LBosszesaru.Name = "LBosszesaru";
            this.LBosszesaru.Size = new System.Drawing.Size(65, 13);
            this.LBosszesaru.TabIndex = 25;
            this.LBosszesaru.Text = "Összes árú: ";
            this.LBosszesaru.Visible = false;
            // 
            // LBszamla
            // 
            this.LBszamla.AutoSize = true;
            this.LBszamla.Location = new System.Drawing.Point(336, 197);
            this.LBszamla.Name = "LBszamla";
            this.LBszamla.Size = new System.Drawing.Size(135, 13);
            this.LBszamla.TabIndex = 26;
            this.LBszamla.Text = "Számla  keletkezett ekkor: ";
            this.LBszamla.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 281);
            this.Controls.Add(this.LBszamla);
            this.Controls.Add(this.LBosszesaru);
            this.Controls.Add(this.LBosszesertek);
            this.Controls.Add(this.BTszamla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBszamkivetett);
            this.Controls.Add(this.CBvasember);
            this.Controls.Add(this.CBehezokviadala);
            this.Controls.Add(this.CBalkonyat);
            this.Controls.Add(this.CBbeavatott);
            this.Controls.Add(this.CBpercyjackson);
            this.Controls.Add(this.CBjamesbond);
            this.Controls.Add(this.CBharrypotter);
            this.Controls.Add(this.CBfrozen);
            this.Controls.Add(this.CBhobbit);
            this.Controls.Add(this.CBgyurukura);
            this.Controls.Add(this.CBtitanic);
            this.Controls.Add(this.BTvasarlas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RB_film);
            this.Controls.Add(this.RB_konyv);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "  ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton RB_konyv;
        private System.Windows.Forms.RadioButton RB_film;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
    }
}

