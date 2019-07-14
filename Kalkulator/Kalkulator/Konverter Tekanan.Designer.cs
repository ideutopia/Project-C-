namespace Kalkulator
{
    partial class Konverter_Tekanan
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
            this.tbtekananAwal = new System.Windows.Forms.TextBox();
            this.tbTekananKonversi = new System.Windows.Forms.TextBox();
            this.btKonversi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioMmHg = new System.Windows.Forms.RadioButton();
            this.radioBar = new System.Windows.Forms.RadioButton();
            this.radioPascal = new System.Windows.Forms.RadioButton();
            this.radioAtm = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioMmHgKonversi = new System.Windows.Forms.RadioButton();
            this.radioAtmKonversi = new System.Windows.Forms.RadioButton();
            this.radioBarKonversi = new System.Windows.Forms.RadioButton();
            this.radioPascalKonversi = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbtekananAwal
            // 
            this.tbtekananAwal.Location = new System.Drawing.Point(31, 61);
            this.tbtekananAwal.Name = "tbtekananAwal";
            this.tbtekananAwal.Size = new System.Drawing.Size(159, 20);
            this.tbtekananAwal.TabIndex = 0;
            // 
            // tbTekananKonversi
            // 
            this.tbTekananKonversi.Location = new System.Drawing.Point(374, 61);
            this.tbTekananKonversi.Name = "tbTekananKonversi";
            this.tbTekananKonversi.ReadOnly = true;
            this.tbTekananKonversi.Size = new System.Drawing.Size(159, 20);
            this.tbTekananKonversi.TabIndex = 1;
            // 
            // btKonversi
            // 
            this.btKonversi.Location = new System.Drawing.Point(233, 57);
            this.btKonversi.Name = "btKonversi";
            this.btKonversi.Size = new System.Drawing.Size(109, 23);
            this.btKonversi.TabIndex = 2;
            this.btKonversi.Text = "Konversi";
            this.btKonversi.UseVisualStyleBackColor = true;
            this.btKonversi.Click += new System.EventHandler(this.btKonversi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioMmHg);
            this.groupBox1.Controls.Add(this.radioBar);
            this.groupBox1.Controls.Add(this.radioPascal);
            this.groupBox1.Controls.Add(this.radioAtm);
            this.groupBox1.Location = new System.Drawing.Point(31, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satuan Awal";
            // 
            // radioMmHg
            // 
            this.radioMmHg.AutoSize = true;
            this.radioMmHg.Location = new System.Drawing.Point(7, 89);
            this.radioMmHg.Name = "radioMmHg";
            this.radioMmHg.Size = new System.Drawing.Size(56, 17);
            this.radioMmHg.TabIndex = 5;
            this.radioMmHg.TabStop = true;
            this.radioMmHg.Text = "MmHg";
            this.radioMmHg.UseVisualStyleBackColor = true;
            // 
            // radioBar
            // 
            this.radioBar.AutoSize = true;
            this.radioBar.Location = new System.Drawing.Point(7, 66);
            this.radioBar.Name = "radioBar";
            this.radioBar.Size = new System.Drawing.Size(41, 17);
            this.radioBar.TabIndex = 2;
            this.radioBar.TabStop = true;
            this.radioBar.Text = "Bar";
            this.radioBar.UseVisualStyleBackColor = true;
            // 
            // radioPascal
            // 
            this.radioPascal.AutoSize = true;
            this.radioPascal.Location = new System.Drawing.Point(7, 43);
            this.radioPascal.Name = "radioPascal";
            this.radioPascal.Size = new System.Drawing.Size(57, 17);
            this.radioPascal.TabIndex = 1;
            this.radioPascal.TabStop = true;
            this.radioPascal.Text = "Pascal";
            this.radioPascal.UseVisualStyleBackColor = true;
            // 
            // radioAtm
            // 
            this.radioAtm.AutoSize = true;
            this.radioAtm.Location = new System.Drawing.Point(7, 20);
            this.radioAtm.Name = "radioAtm";
            this.radioAtm.Size = new System.Drawing.Size(43, 17);
            this.radioAtm.TabIndex = 0;
            this.radioAtm.TabStop = true;
            this.radioAtm.Text = "Atm";
            this.radioAtm.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioMmHgKonversi);
            this.groupBox2.Controls.Add(this.radioAtmKonversi);
            this.groupBox2.Controls.Add(this.radioBarKonversi);
            this.groupBox2.Controls.Add(this.radioPascalKonversi);
            this.groupBox2.Location = new System.Drawing.Point(333, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 123);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satuan Konversi";
            // 
            // radioMmHgKonversi
            // 
            this.radioMmHgKonversi.AutoSize = true;
            this.radioMmHgKonversi.Location = new System.Drawing.Point(6, 88);
            this.radioMmHgKonversi.Name = "radioMmHgKonversi";
            this.radioMmHgKonversi.Size = new System.Drawing.Size(56, 17);
            this.radioMmHgKonversi.TabIndex = 9;
            this.radioMmHgKonversi.TabStop = true;
            this.radioMmHgKonversi.Text = "MmHg";
            this.radioMmHgKonversi.UseVisualStyleBackColor = true;
            // 
            // radioAtmKonversi
            // 
            this.radioAtmKonversi.AutoSize = true;
            this.radioAtmKonversi.Location = new System.Drawing.Point(6, 19);
            this.radioAtmKonversi.Name = "radioAtmKonversi";
            this.radioAtmKonversi.Size = new System.Drawing.Size(43, 17);
            this.radioAtmKonversi.TabIndex = 6;
            this.radioAtmKonversi.TabStop = true;
            this.radioAtmKonversi.Text = "Atm";
            this.radioAtmKonversi.UseVisualStyleBackColor = true;
            // 
            // radioBarKonversi
            // 
            this.radioBarKonversi.AutoSize = true;
            this.radioBarKonversi.Location = new System.Drawing.Point(6, 65);
            this.radioBarKonversi.Name = "radioBarKonversi";
            this.radioBarKonversi.Size = new System.Drawing.Size(41, 17);
            this.radioBarKonversi.TabIndex = 8;
            this.radioBarKonversi.TabStop = true;
            this.radioBarKonversi.Text = "Bar";
            this.radioBarKonversi.UseVisualStyleBackColor = true;
            // 
            // radioPascalKonversi
            // 
            this.radioPascalKonversi.AutoSize = true;
            this.radioPascalKonversi.Location = new System.Drawing.Point(6, 42);
            this.radioPascalKonversi.Name = "radioPascalKonversi";
            this.radioPascalKonversi.Size = new System.Drawing.Size(57, 17);
            this.radioPascalKonversi.TabIndex = 7;
            this.radioPascalKonversi.TabStop = true;
            this.radioPascalKonversi.Text = "Pascal";
            this.radioPascalKonversi.UseVisualStyleBackColor = true;
            // 
            // Konverter_Tekanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btKonversi);
            this.Controls.Add(this.tbTekananKonversi);
            this.Controls.Add(this.tbtekananAwal);
            this.Name = "Konverter_Tekanan";
            this.Text = "Konverter_Tekanan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbtekananAwal;
        private System.Windows.Forms.TextBox tbTekananKonversi;
        private System.Windows.Forms.Button btKonversi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioMmHg;
        private System.Windows.Forms.RadioButton radioBar;
        private System.Windows.Forms.RadioButton radioPascal;
        private System.Windows.Forms.RadioButton radioAtm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioMmHgKonversi;
        private System.Windows.Forms.RadioButton radioAtmKonversi;
        private System.Windows.Forms.RadioButton radioBarKonversi;
        private System.Windows.Forms.RadioButton radioPascalKonversi;
    }
}