namespace Szabó_Richárd_Projekt
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
            this.bt_indit = new System.Windows.Forms.Button();
            this.tb_tavolsag = new System.Windows.Forms.TextBox();
            this.pb_fegyver = new System.Windows.Forms.PictureBox();
            this.lb_fegyverlista = new System.Windows.Forms.ListBox();
            this.bt_fejsebzes = new System.Windows.Forms.Button();
            this.bt_testsebzes = new System.Windows.Forms.Button();
            this.bt_labsebzes = new System.Windows.Forms.Button();
            this.bt_fegyverar = new System.Windows.Forms.Button();
            this.bt_fegyverfirerate = new System.Windows.Forms.Button();
            this.bt_fegyvertarmeret = new System.Windows.Forms.Button();
            this.lb_tavolsag = new System.Windows.Forms.Label();
            this.lb_kep = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fegyver)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_indit
            // 
            this.bt_indit.Location = new System.Drawing.Point(12, 12);
            this.bt_indit.Name = "bt_indit";
            this.bt_indit.Size = new System.Drawing.Size(267, 54);
            this.bt_indit.TabIndex = 0;
            this.bt_indit.Text = "Fegyverek megjelenítése";
            this.bt_indit.UseVisualStyleBackColor = true;
            this.bt_indit.Click += new System.EventHandler(this.bt_indit_Click);
            // 
            // tb_tavolsag
            // 
            this.tb_tavolsag.Location = new System.Drawing.Point(77, 72);
            this.tb_tavolsag.Name = "tb_tavolsag";
            this.tb_tavolsag.Size = new System.Drawing.Size(202, 20);
            this.tb_tavolsag.TabIndex = 1;
            // 
            // pb_fegyver
            // 
            this.pb_fegyver.Location = new System.Drawing.Point(538, 98);
            this.pb_fegyver.Name = "pb_fegyver";
            this.pb_fegyver.Size = new System.Drawing.Size(414, 316);
            this.pb_fegyver.TabIndex = 2;
            this.pb_fegyver.TabStop = false;
            // 
            // lb_fegyverlista
            // 
            this.lb_fegyverlista.FormattingEnabled = true;
            this.lb_fegyverlista.Location = new System.Drawing.Point(19, 98);
            this.lb_fegyverlista.Name = "lb_fegyverlista";
            this.lb_fegyverlista.Size = new System.Drawing.Size(260, 316);
            this.lb_fegyverlista.TabIndex = 3;
            this.lb_fegyverlista.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bt_fejsebzes
            // 
            this.bt_fejsebzes.Location = new System.Drawing.Point(19, 429);
            this.bt_fejsebzes.Name = "bt_fejsebzes";
            this.bt_fejsebzes.Size = new System.Drawing.Size(127, 23);
            this.bt_fejsebzes.TabIndex = 4;
            this.bt_fejsebzes.Text = "Fegyver sebzése fejre";
            this.bt_fejsebzes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_fejsebzes.UseVisualStyleBackColor = true;
            this.bt_fejsebzes.Click += new System.EventHandler(this.bt_fejsebzes_Click);
            // 
            // bt_testsebzes
            // 
            this.bt_testsebzes.Location = new System.Drawing.Point(19, 458);
            this.bt_testsebzes.Name = "bt_testsebzes";
            this.bt_testsebzes.Size = new System.Drawing.Size(127, 23);
            this.bt_testsebzes.TabIndex = 5;
            this.bt_testsebzes.Text = "Fegyver sebzése testre";
            this.bt_testsebzes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_testsebzes.UseVisualStyleBackColor = true;
            this.bt_testsebzes.Click += new System.EventHandler(this.bt_testsebzes_Click);
            // 
            // bt_labsebzes
            // 
            this.bt_labsebzes.Location = new System.Drawing.Point(19, 484);
            this.bt_labsebzes.Name = "bt_labsebzes";
            this.bt_labsebzes.Size = new System.Drawing.Size(127, 23);
            this.bt_labsebzes.TabIndex = 6;
            this.bt_labsebzes.Text = "Fegyver sebzése lábra";
            this.bt_labsebzes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_labsebzes.UseVisualStyleBackColor = true;
            this.bt_labsebzes.Click += new System.EventHandler(this.bt_labsebzes_Click);
            // 
            // bt_fegyverar
            // 
            this.bt_fegyverar.Location = new System.Drawing.Point(152, 429);
            this.bt_fegyverar.Name = "bt_fegyverar";
            this.bt_fegyverar.Size = new System.Drawing.Size(127, 22);
            this.bt_fegyverar.TabIndex = 7;
            this.bt_fegyverar.Text = "Fegyver ára";
            this.bt_fegyverar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_fegyverar.UseVisualStyleBackColor = true;
            this.bt_fegyverar.Click += new System.EventHandler(this.bt_fegyverar_Click);
            // 
            // bt_fegyverfirerate
            // 
            this.bt_fegyverfirerate.Location = new System.Drawing.Point(152, 457);
            this.bt_fegyverfirerate.Name = "bt_fegyverfirerate";
            this.bt_fegyverfirerate.Size = new System.Drawing.Size(127, 22);
            this.bt_fegyverfirerate.TabIndex = 8;
            this.bt_fegyverfirerate.Text = "Fegyver firerateje";
            this.bt_fegyverfirerate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_fegyverfirerate.UseVisualStyleBackColor = true;
            this.bt_fegyverfirerate.Click += new System.EventHandler(this.bt_fegyverfirerate_Click);
            // 
            // bt_fegyvertarmeret
            // 
            this.bt_fegyvertarmeret.Location = new System.Drawing.Point(152, 485);
            this.bt_fegyvertarmeret.Name = "bt_fegyvertarmeret";
            this.bt_fegyvertarmeret.Size = new System.Drawing.Size(127, 22);
            this.bt_fegyvertarmeret.TabIndex = 9;
            this.bt_fegyvertarmeret.Text = "Fegyver tármérete";
            this.bt_fegyvertarmeret.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_fegyvertarmeret.UseVisualStyleBackColor = true;
            this.bt_fegyvertarmeret.Click += new System.EventHandler(this.bt_fegyvertarmeret_Click);
            // 
            // lb_tavolsag
            // 
            this.lb_tavolsag.AutoSize = true;
            this.lb_tavolsag.Location = new System.Drawing.Point(17, 75);
            this.lb_tavolsag.Name = "lb_tavolsag";
            this.lb_tavolsag.Size = new System.Drawing.Size(54, 13);
            this.lb_tavolsag.TabIndex = 10;
            this.lb_tavolsag.Text = "Távolság:";
            // 
            // lb_kep
            // 
            this.lb_kep.AutoSize = true;
            this.lb_kep.Location = new System.Drawing.Point(285, 98);
            this.lb_kep.Name = "lb_kep";
            this.lb_kep.Size = new System.Drawing.Size(247, 13);
            this.lb_kep.TabIndex = 11;
            this.lb_kep.Text = "Fegyver képe (Kattins a listában a fegyver nevére):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 570);
            this.Controls.Add(this.lb_kep);
            this.Controls.Add(this.lb_tavolsag);
            this.Controls.Add(this.bt_fegyvertarmeret);
            this.Controls.Add(this.bt_fegyverfirerate);
            this.Controls.Add(this.bt_fegyverar);
            this.Controls.Add(this.bt_labsebzes);
            this.Controls.Add(this.bt_testsebzes);
            this.Controls.Add(this.bt_fejsebzes);
            this.Controls.Add(this.lb_fegyverlista);
            this.Controls.Add(this.pb_fegyver);
            this.Controls.Add(this.tb_tavolsag);
            this.Controls.Add(this.bt_indit);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_fegyver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_indit;
        private System.Windows.Forms.TextBox tb_tavolsag;
        private System.Windows.Forms.PictureBox pb_fegyver;
        private System.Windows.Forms.ListBox lb_fegyverlista;
        private System.Windows.Forms.Button bt_fejsebzes;
        private System.Windows.Forms.Button bt_testsebzes;
        private System.Windows.Forms.Button bt_labsebzes;
        private System.Windows.Forms.Button bt_fegyverar;
        private System.Windows.Forms.Button bt_fegyverfirerate;
        private System.Windows.Forms.Button bt_fegyvertarmeret;
        private System.Windows.Forms.Label lb_tavolsag;
        private System.Windows.Forms.Label lb_kep;
    }
}

