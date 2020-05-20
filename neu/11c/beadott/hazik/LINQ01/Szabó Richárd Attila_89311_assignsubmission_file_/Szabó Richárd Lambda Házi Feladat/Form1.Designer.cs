namespace Szabó_Richárd_Lambda_Házi_Feladat
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
            this.lb_lista = new System.Windows.Forms.ListBox();
            this.bt_k = new System.Windows.Forms.Button();
            this.lb_k = new System.Windows.Forms.Label();
            this.bt_maxar = new System.Windows.Forms.Button();
            this.bt_maxarnev = new System.Windows.Forms.Button();
            this.bt_osszertek = new System.Windows.Forms.Button();
            this.bt_abc = new System.Windows.Forms.Button();
            this.lb_maxar = new System.Windows.Forms.Label();
            this.lb_maxarnev = new System.Windows.Forms.Label();
            this.lb_osszertek = new System.Windows.Forms.Label();
            this.lb_abc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bt_indit
            // 
            this.bt_indit.Location = new System.Drawing.Point(104, 42);
            this.bt_indit.Name = "bt_indit";
            this.bt_indit.Size = new System.Drawing.Size(142, 23);
            this.bt_indit.TabIndex = 0;
            this.bt_indit.Text = "Fájl beolvasás";
            this.bt_indit.UseVisualStyleBackColor = true;
            this.bt_indit.Click += new System.EventHandler(this.bt_indit_Click);
            // 
            // lb_lista
            // 
            this.lb_lista.FormattingEnabled = true;
            this.lb_lista.Location = new System.Drawing.Point(12, 71);
            this.lb_lista.Name = "lb_lista";
            this.lb_lista.Size = new System.Drawing.Size(333, 277);
            this.lb_lista.TabIndex = 1;
            // 
            // bt_k
            // 
            this.bt_k.Location = new System.Drawing.Point(365, 71);
            this.bt_k.Name = "bt_k";
            this.bt_k.Size = new System.Drawing.Size(209, 23);
            this.bt_k.TabIndex = 2;
            this.bt_k.Text = "K betűvel kezdődő gyümölcsök száma";
            this.bt_k.UseVisualStyleBackColor = true;
            this.bt_k.Click += new System.EventHandler(this.bt_k_Click);
            // 
            // lb_k
            // 
            this.lb_k.AutoSize = true;
            this.lb_k.Location = new System.Drawing.Point(580, 76);
            this.lb_k.Name = "lb_k";
            this.lb_k.Size = new System.Drawing.Size(0, 13);
            this.lb_k.TabIndex = 3;
            // 
            // bt_maxar
            // 
            this.bt_maxar.Location = new System.Drawing.Point(365, 154);
            this.bt_maxar.Name = "bt_maxar";
            this.bt_maxar.Size = new System.Drawing.Size(209, 23);
            this.bt_maxar.TabIndex = 4;
            this.bt_maxar.Text = "Legdrágább gyümölcs ára";
            this.bt_maxar.UseVisualStyleBackColor = true;
            this.bt_maxar.Click += new System.EventHandler(this.bt_maxar_Click);
            // 
            // bt_maxarnev
            // 
            this.bt_maxarnev.Location = new System.Drawing.Point(365, 234);
            this.bt_maxarnev.Name = "bt_maxarnev";
            this.bt_maxarnev.Size = new System.Drawing.Size(209, 23);
            this.bt_maxarnev.TabIndex = 5;
            this.bt_maxarnev.Text = "Legdrágább gyümölcs neve";
            this.bt_maxarnev.UseVisualStyleBackColor = true;
            this.bt_maxarnev.Click += new System.EventHandler(this.bt_maxarnev_Click);
            // 
            // bt_osszertek
            // 
            this.bt_osszertek.Location = new System.Drawing.Point(365, 325);
            this.bt_osszertek.Name = "bt_osszertek";
            this.bt_osszertek.Size = new System.Drawing.Size(209, 23);
            this.bt_osszertek.TabIndex = 6;
            this.bt_osszertek.Text = "Raktár összértéke";
            this.bt_osszertek.UseVisualStyleBackColor = true;
            this.bt_osszertek.Click += new System.EventHandler(this.bt_osszertek_Click);
            // 
            // bt_abc
            // 
            this.bt_abc.Location = new System.Drawing.Point(104, 366);
            this.bt_abc.Name = "bt_abc";
            this.bt_abc.Size = new System.Drawing.Size(142, 23);
            this.bt_abc.TabIndex = 7;
            this.bt_abc.Text = "ABC sorrendbe rendezés";
            this.bt_abc.UseVisualStyleBackColor = true;
            this.bt_abc.Click += new System.EventHandler(this.bt_abc_Click);
            // 
            // lb_maxar
            // 
            this.lb_maxar.AutoSize = true;
            this.lb_maxar.Location = new System.Drawing.Point(580, 159);
            this.lb_maxar.Name = "lb_maxar";
            this.lb_maxar.Size = new System.Drawing.Size(0, 13);
            this.lb_maxar.TabIndex = 8;
            // 
            // lb_maxarnev
            // 
            this.lb_maxarnev.AutoSize = true;
            this.lb_maxarnev.Location = new System.Drawing.Point(580, 239);
            this.lb_maxarnev.Name = "lb_maxarnev";
            this.lb_maxarnev.Size = new System.Drawing.Size(0, 13);
            this.lb_maxarnev.TabIndex = 9;
            // 
            // lb_osszertek
            // 
            this.lb_osszertek.AutoSize = true;
            this.lb_osszertek.Location = new System.Drawing.Point(580, 330);
            this.lb_osszertek.Name = "lb_osszertek";
            this.lb_osszertek.Size = new System.Drawing.Size(0, 13);
            this.lb_osszertek.TabIndex = 10;
            // 
            // lb_abc
            // 
            this.lb_abc.FormattingEnabled = true;
            this.lb_abc.Location = new System.Drawing.Point(12, 395);
            this.lb_abc.Name = "lb_abc";
            this.lb_abc.Size = new System.Drawing.Size(333, 277);
            this.lb_abc.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 687);
            this.Controls.Add(this.lb_abc);
            this.Controls.Add(this.lb_osszertek);
            this.Controls.Add(this.lb_maxarnev);
            this.Controls.Add(this.lb_maxar);
            this.Controls.Add(this.bt_abc);
            this.Controls.Add(this.bt_osszertek);
            this.Controls.Add(this.bt_maxarnev);
            this.Controls.Add(this.bt_maxar);
            this.Controls.Add(this.lb_k);
            this.Controls.Add(this.bt_k);
            this.Controls.Add(this.lb_lista);
            this.Controls.Add(this.bt_indit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_indit;
        private System.Windows.Forms.ListBox lb_lista;
        private System.Windows.Forms.Button bt_k;
        private System.Windows.Forms.Label lb_k;
        private System.Windows.Forms.Button bt_maxar;
        private System.Windows.Forms.Button bt_maxarnev;
        private System.Windows.Forms.Button bt_osszertek;
        private System.Windows.Forms.Button bt_abc;
        private System.Windows.Forms.Label lb_maxar;
        private System.Windows.Forms.Label lb_maxarnev;
        private System.Windows.Forms.Label lb_osszertek;
        private System.Windows.Forms.ListBox lb_abc;
    }
}

