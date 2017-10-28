namespace CarFactory
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSilnik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBak = new System.Windows.Forms.TextBox();
            this.btJedz = new System.Windows.Forms.Button();
            this.tbDystans = new System.Windows.Forms.TextBox();
            this.lbDroga = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbIle_wBaku = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(12, 40);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(100, 22);
            this.tbMarka.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Silnik";
            // 
            // tbSilnik
            // 
            this.tbSilnik.Location = new System.Drawing.Point(12, 88);
            this.tbSilnik.Name = "tbSilnik";
            this.tbSilnik.Size = new System.Drawing.Size(100, 22);
            this.tbSilnik.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pojemność baku";
            // 
            // tbBak
            // 
            this.tbBak.Location = new System.Drawing.Point(12, 136);
            this.tbBak.Name = "tbBak";
            this.tbBak.Size = new System.Drawing.Size(47, 22);
            this.tbBak.TabIndex = 4;
            // 
            // btJedz
            // 
            this.btJedz.Location = new System.Drawing.Point(11, 164);
            this.btJedz.Name = "btJedz";
            this.btJedz.Size = new System.Drawing.Size(110, 47);
            this.btJedz.TabIndex = 6;
            this.btJedz.Text = "Przyotowanie do jazdy";
            this.btJedz.UseVisualStyleBackColor = true;
            this.btJedz.Click += new System.EventHandler(this.btJedz_Click);
            // 
            // tbDystans
            // 
            this.tbDystans.Location = new System.Drawing.Point(10, 21);
            this.tbDystans.Name = "tbDystans";
            this.tbDystans.Size = new System.Drawing.Size(100, 22);
            this.tbDystans.TabIndex = 7;
            // 
            // lbDroga
            // 
            this.lbDroga.FormattingEnabled = true;
            this.lbDroga.ItemHeight = 16;
            this.lbDroga.Location = new System.Drawing.Point(160, 40);
            this.lbDroga.Name = "lbDroga";
            this.lbDroga.Size = new System.Drawing.Size(212, 276);
            this.lbDroga.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Jedź";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDystans);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(5, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 94);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // tbIle_wBaku
            // 
            this.tbIle_wBaku.Location = new System.Drawing.Point(77, 136);
            this.tbIle_wBaku.Name = "tbIle_wBaku";
            this.tbIle_wBaku.Size = new System.Drawing.Size(47, 22);
            this.tbIle_wBaku.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 331);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbIle_wBaku);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbDroga);
            this.Controls.Add(this.btJedz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbBak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSilnik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMarka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSilnik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBak;
        private System.Windows.Forms.Button btJedz;
        private System.Windows.Forms.TextBox tbDystans;
        private System.Windows.Forms.ListBox lbDroga;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbIle_wBaku;
        private System.Windows.Forms.Label label4;
    }
}

