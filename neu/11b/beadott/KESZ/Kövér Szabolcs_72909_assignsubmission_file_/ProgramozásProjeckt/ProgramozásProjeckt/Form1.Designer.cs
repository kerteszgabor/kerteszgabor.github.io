namespace ProgramozásProjeckt
{
    partial class f_munkás
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
            this.btn_add = new System.Windows.Forms.Button();
            this.lb_valami = new System.Windows.Forms.ListBox();
            this.nud = new System.Windows.Forms.NumericUpDown();
            this.rb_fizikai = new System.Windows.Forms.RadioButton();
            this.rb_szellemi = new System.Windows.Forms.RadioButton();
            this.btn_töröl = new System.Windows.Forms.Button();
            this.btn_bezár = new System.Windows.Forms.Button();
            this.lb_összes = new System.Windows.Forms.ListBox();
            this.btn_egesz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(115, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Hozzáad";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_egy_Click);
            // 
            // lb_valami
            // 
            this.lb_valami.FormattingEnabled = true;
            this.lb_valami.ItemHeight = 16;
            this.lb_valami.Location = new System.Drawing.Point(133, 12);
            this.lb_valami.Name = "lb_valami";
            this.lb_valami.Size = new System.Drawing.Size(317, 228);
            this.lb_valami.TabIndex = 1;
            // 
            // nud
            // 
            this.nud.Location = new System.Drawing.Point(32, 134);
            this.nud.Name = "nud";
            this.nud.Size = new System.Drawing.Size(75, 22);
            this.nud.TabIndex = 2;
            // 
            // rb_fizikai
            // 
            this.rb_fizikai.AutoSize = true;
            this.rb_fizikai.Location = new System.Drawing.Point(32, 162);
            this.rb_fizikai.Name = "rb_fizikai";
            this.rb_fizikai.Size = new System.Drawing.Size(68, 21);
            this.rb_fizikai.TabIndex = 3;
            this.rb_fizikai.Text = "Fizikai";
            this.rb_fizikai.UseVisualStyleBackColor = true;
            // 
            // rb_szellemi
            // 
            this.rb_szellemi.AutoSize = true;
            this.rb_szellemi.Location = new System.Drawing.Point(32, 189);
            this.rb_szellemi.Name = "rb_szellemi";
            this.rb_szellemi.Size = new System.Drawing.Size(81, 21);
            this.rb_szellemi.TabIndex = 4;
            this.rb_szellemi.Text = "Szellemi";
            this.rb_szellemi.UseVisualStyleBackColor = true;
            // 
            // btn_töröl
            // 
            this.btn_töröl.Location = new System.Drawing.Point(12, 41);
            this.btn_töröl.Name = "btn_töröl";
            this.btn_töröl.Size = new System.Drawing.Size(115, 23);
            this.btn_töröl.TabIndex = 5;
            this.btn_töröl.Text = "Töröl";
            this.btn_töröl.UseVisualStyleBackColor = true;
            this.btn_töröl.Click += new System.EventHandler(this.btn_töröl_Click);
            // 
            // btn_bezár
            // 
            this.btn_bezár.Location = new System.Drawing.Point(12, 251);
            this.btn_bezár.Name = "btn_bezár";
            this.btn_bezár.Size = new System.Drawing.Size(75, 23);
            this.btn_bezár.TabIndex = 6;
            this.btn_bezár.Text = "Bezárás";
            this.btn_bezár.UseVisualStyleBackColor = true;
            this.btn_bezár.Click += new System.EventHandler(this.btn_bezár_Click);
            // 
            // lb_összes
            // 
            this.lb_összes.FormattingEnabled = true;
            this.lb_összes.ItemHeight = 16;
            this.lb_összes.Location = new System.Drawing.Point(456, 12);
            this.lb_összes.Name = "lb_összes";
            this.lb_összes.Size = new System.Drawing.Size(332, 228);
            this.lb_összes.TabIndex = 7;
            // 
            // btn_egesz
            // 
            this.btn_egesz.Location = new System.Drawing.Point(12, 105);
            this.btn_egesz.Name = "btn_egesz";
            this.btn_egesz.Size = new System.Drawing.Size(115, 23);
            this.btn_egesz.TabIndex = 8;
            this.btn_egesz.Text = "Összes kiírás\r\n\r\n";
            this.btn_egesz.UseVisualStyleBackColor = true;
            this.btn_egesz.Click += new System.EventHandler(this.btn_egesz_Click);
            // 
            // f_munkás
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 278);
            this.Controls.Add(this.btn_egesz);
            this.Controls.Add(this.lb_összes);
            this.Controls.Add(this.btn_bezár);
            this.Controls.Add(this.btn_töröl);
            this.Controls.Add(this.rb_szellemi);
            this.Controls.Add(this.rb_fizikai);
            this.Controls.Add(this.nud);
            this.Controls.Add(this.lb_valami);
            this.Controls.Add(this.btn_add);
            this.Name = "f_munkás";
            this.Text = "Munkások";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListBox lb_valami;
        private System.Windows.Forms.NumericUpDown nud;
        private System.Windows.Forms.RadioButton rb_fizikai;
        private System.Windows.Forms.RadioButton rb_szellemi;
        private System.Windows.Forms.Button btn_töröl;
        private System.Windows.Forms.Button btn_bezár;
        private System.Windows.Forms.ListBox lb_összes;
        private System.Windows.Forms.Button btn_egesz;
    }
}

