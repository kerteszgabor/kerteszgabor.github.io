namespace VorosCsanad_lamba1
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
            this.lbx_beolv = new System.Windows.Forms.ListBox();
            this.lbx_eredm = new System.Windows.Forms.ListBox();
            this.rbtn_kbetu = new System.Windows.Forms.RadioButton();
            this.rbtn_legdrag = new System.Windows.Forms.RadioButton();
            this.rbtn_ossz = new System.Windows.Forms.RadioButton();
            this.rbtn_sorrend = new System.Windows.Forms.RadioButton();
            this.btn_beolv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbx_beolv
            // 
            this.lbx_beolv.FormattingEnabled = true;
            this.lbx_beolv.Location = new System.Drawing.Point(30, 34);
            this.lbx_beolv.Name = "lbx_beolv";
            this.lbx_beolv.Size = new System.Drawing.Size(255, 329);
            this.lbx_beolv.TabIndex = 0;
            // 
            // lbx_eredm
            // 
            this.lbx_eredm.FormattingEnabled = true;
            this.lbx_eredm.Location = new System.Drawing.Point(523, 34);
            this.lbx_eredm.Name = "lbx_eredm";
            this.lbx_eredm.Size = new System.Drawing.Size(265, 329);
            this.lbx_eredm.TabIndex = 1;
            // 
            // rbtn_kbetu
            // 
            this.rbtn_kbetu.AutoSize = true;
            this.rbtn_kbetu.Location = new System.Drawing.Point(360, 100);
            this.rbtn_kbetu.Name = "rbtn_kbetu";
            this.rbtn_kbetu.Size = new System.Drawing.Size(114, 17);
            this.rbtn_kbetu.TabIndex = 2;
            this.rbtn_kbetu.TabStop = true;
            this.rbtn_kbetu.Text = "K betűvel kezdődő";
            this.rbtn_kbetu.UseVisualStyleBackColor = true;
            this.rbtn_kbetu.CheckedChanged += new System.EventHandler(this.rbtn_kbetu_CheckedChanged);
            // 
            // rbtn_legdrag
            // 
            this.rbtn_legdrag.AutoSize = true;
            this.rbtn_legdrag.Location = new System.Drawing.Point(360, 171);
            this.rbtn_legdrag.Name = "rbtn_legdrag";
            this.rbtn_legdrag.Size = new System.Drawing.Size(82, 17);
            this.rbtn_legdrag.TabIndex = 3;
            this.rbtn_legdrag.TabStop = true;
            this.rbtn_legdrag.Text = "Legdrágább";
            this.rbtn_legdrag.UseVisualStyleBackColor = true;
            this.rbtn_legdrag.CheckedChanged += new System.EventHandler(this.rbtn_legdrag_CheckedChanged);
            // 
            // rbtn_ossz
            // 
            this.rbtn_ossz.AutoSize = true;
            this.rbtn_ossz.Location = new System.Drawing.Point(360, 257);
            this.rbtn_ossz.Name = "rbtn_ossz";
            this.rbtn_ossz.Size = new System.Drawing.Size(72, 17);
            this.rbtn_ossz.TabIndex = 4;
            this.rbtn_ossz.TabStop = true;
            this.rbtn_ossz.Text = "Összérték";
            this.rbtn_ossz.UseVisualStyleBackColor = true;
            this.rbtn_ossz.CheckedChanged += new System.EventHandler(this.rbtn_ossz_CheckedChanged);
            // 
            // rbtn_sorrend
            // 
            this.rbtn_sorrend.AutoSize = true;
            this.rbtn_sorrend.Location = new System.Drawing.Point(360, 346);
            this.rbtn_sorrend.Name = "rbtn_sorrend";
            this.rbtn_sorrend.Size = new System.Drawing.Size(84, 17);
            this.rbtn_sorrend.TabIndex = 5;
            this.rbtn_sorrend.TabStop = true;
            this.rbtn_sorrend.Text = "ABC sorrend";
            this.rbtn_sorrend.UseVisualStyleBackColor = true;
            this.rbtn_sorrend.CheckedChanged += new System.EventHandler(this.rbtn_sorrend_CheckedChanged);
            // 
            // btn_beolv
            // 
            this.btn_beolv.Location = new System.Drawing.Point(370, 34);
            this.btn_beolv.Name = "btn_beolv";
            this.btn_beolv.Size = new System.Drawing.Size(75, 23);
            this.btn_beolv.TabIndex = 6;
            this.btn_beolv.Text = "Beolvasás";
            this.btn_beolv.UseVisualStyleBackColor = true;
            this.btn_beolv.Click += new System.EventHandler(this.btn_beolv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_beolv);
            this.Controls.Add(this.rbtn_sorrend);
            this.Controls.Add(this.rbtn_ossz);
            this.Controls.Add(this.rbtn_legdrag);
            this.Controls.Add(this.rbtn_kbetu);
            this.Controls.Add(this.lbx_eredm);
            this.Controls.Add(this.lbx_beolv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_beolv;
        private System.Windows.Forms.ListBox lbx_eredm;
        private System.Windows.Forms.RadioButton rbtn_kbetu;
        private System.Windows.Forms.RadioButton rbtn_legdrag;
        private System.Windows.Forms.RadioButton rbtn_ossz;
        private System.Windows.Forms.RadioButton rbtn_sorrend;
        private System.Windows.Forms.Button btn_beolv;
    }
}

