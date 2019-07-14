namespace Kalkulator
{
    partial class Konverter_Suhu
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.CelciusSatu = new System.Windows.Forms.RadioButton();
            this.fahrenheitSatu = new System.Windows.Forms.RadioButton();
            this.reamurSatu = new System.Windows.Forms.RadioButton();
            this.kelvinSatu = new System.Windows.Forms.RadioButton();
            this.celciusDua = new System.Windows.Forms.RadioButton();
            this.fahrenheitDua = new System.Windows.Forms.RadioButton();
            this.reamurDua = new System.Windows.Forms.RadioButton();
            this.kelvinDua = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.angka1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.angka2 = new System.Windows.Forms.Button();
            this.angka3 = new System.Windows.Forms.Button();
            this.angka4 = new System.Windows.Forms.Button();
            this.angka5 = new System.Windows.Forms.Button();
            this.angka6 = new System.Windows.Forms.Button();
            this.angka7 = new System.Windows.Forms.Button();
            this.angka8 = new System.Windows.Forms.Button();
            this.angka9 = new System.Windows.Forms.Button();
            this.angka0 = new System.Windows.Forms.Button();
            this.tandaKoma = new System.Windows.Forms.Button();
            this.samaDengan = new System.Windows.Forms.Button();
            this.positifNegatif = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(258, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham Black", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Masukkan Kuantitas Suhu Lalu Klik Convert Untuk Mengkonversi";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(157, 79);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 23);
            this.buttonConvert.TabIndex = 3;
            this.buttonConvert.Text = "CONVERT";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // CelciusSatu
            // 
            this.CelciusSatu.AutoSize = true;
            this.CelciusSatu.Location = new System.Drawing.Point(8, 19);
            this.CelciusSatu.Name = "CelciusSatu";
            this.CelciusSatu.Size = new System.Drawing.Size(59, 17);
            this.CelciusSatu.TabIndex = 4;
            this.CelciusSatu.TabStop = true;
            this.CelciusSatu.Text = "Celcius";
            this.CelciusSatu.UseVisualStyleBackColor = true;
            // 
            // fahrenheitSatu
            // 
            this.fahrenheitSatu.AutoSize = true;
            this.fahrenheitSatu.Location = new System.Drawing.Point(8, 42);
            this.fahrenheitSatu.Name = "fahrenheitSatu";
            this.fahrenheitSatu.Size = new System.Drawing.Size(75, 17);
            this.fahrenheitSatu.TabIndex = 5;
            this.fahrenheitSatu.TabStop = true;
            this.fahrenheitSatu.Text = "Fahrenheit";
            this.fahrenheitSatu.UseVisualStyleBackColor = true;
            // 
            // reamurSatu
            // 
            this.reamurSatu.AutoSize = true;
            this.reamurSatu.Location = new System.Drawing.Point(6, 65);
            this.reamurSatu.Name = "reamurSatu";
            this.reamurSatu.Size = new System.Drawing.Size(62, 17);
            this.reamurSatu.TabIndex = 6;
            this.reamurSatu.TabStop = true;
            this.reamurSatu.Text = "Reamur";
            this.reamurSatu.UseVisualStyleBackColor = true;
            // 
            // kelvinSatu
            // 
            this.kelvinSatu.AutoSize = true;
            this.kelvinSatu.Location = new System.Drawing.Point(8, 88);
            this.kelvinSatu.Name = "kelvinSatu";
            this.kelvinSatu.Size = new System.Drawing.Size(54, 17);
            this.kelvinSatu.TabIndex = 7;
            this.kelvinSatu.TabStop = true;
            this.kelvinSatu.Text = "Kelvin";
            this.kelvinSatu.UseVisualStyleBackColor = true;
            this.kelvinSatu.CheckedChanged += new System.EventHandler(this.kelvinSatu_CheckedChanged);
            // 
            // celciusDua
            // 
            this.celciusDua.AutoSize = true;
            this.celciusDua.Location = new System.Drawing.Point(19, 19);
            this.celciusDua.Name = "celciusDua";
            this.celciusDua.Size = new System.Drawing.Size(74, 17);
            this.celciusDua.TabIndex = 8;
            this.celciusDua.TabStop = true;
            this.celciusDua.Text = "Celcius (II)";
            this.celciusDua.UseVisualStyleBackColor = true;
            // 
            // fahrenheitDua
            // 
            this.fahrenheitDua.AutoSize = true;
            this.fahrenheitDua.Location = new System.Drawing.Point(19, 42);
            this.fahrenheitDua.Name = "fahrenheitDua";
            this.fahrenheitDua.Size = new System.Drawing.Size(90, 17);
            this.fahrenheitDua.TabIndex = 9;
            this.fahrenheitDua.TabStop = true;
            this.fahrenheitDua.Text = "Fahrenheit (II)";
            this.fahrenheitDua.UseVisualStyleBackColor = true;
            // 
            // reamurDua
            // 
            this.reamurDua.AutoSize = true;
            this.reamurDua.Location = new System.Drawing.Point(19, 65);
            this.reamurDua.Name = "reamurDua";
            this.reamurDua.Size = new System.Drawing.Size(77, 17);
            this.reamurDua.TabIndex = 10;
            this.reamurDua.TabStop = true;
            this.reamurDua.Text = "Reamur (II)";
            this.reamurDua.UseVisualStyleBackColor = true;
            // 
            // kelvinDua
            // 
            this.kelvinDua.AutoSize = true;
            this.kelvinDua.Location = new System.Drawing.Point(19, 88);
            this.kelvinDua.Name = "kelvinDua";
            this.kelvinDua.Size = new System.Drawing.Size(69, 17);
            this.kelvinDua.TabIndex = 11;
            this.kelvinDua.TabStop = true;
            this.kelvinDua.Text = "Kelvin (II)";
            this.kelvinDua.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.celciusDua);
            this.groupBox1.Controls.Add(this.kelvinDua);
            this.groupBox1.Controls.Add(this.fahrenheitDua);
            this.groupBox1.Controls.Add(this.reamurDua);
            this.groupBox1.Location = new System.Drawing.Point(239, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 116);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satuan Konversi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CelciusSatu);
            this.groupBox2.Controls.Add(this.fahrenheitSatu);
            this.groupBox2.Controls.Add(this.kelvinSatu);
            this.groupBox2.Controls.Add(this.reamurSatu);
            this.groupBox2.Location = new System.Drawing.Point(28, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 111);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satuan Asal";
            // 
            // angka1
            // 
            this.angka1.Location = new System.Drawing.Point(7, 72);
            this.angka1.Name = "angka1";
            this.angka1.Size = new System.Drawing.Size(50, 50);
            this.angka1.TabIndex = 14;
            this.angka1.Text = "1";
            this.angka1.UseVisualStyleBackColor = true;
            this.angka1.Click += new System.EventHandler(this.angka1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonClear);
            this.groupBox3.Controls.Add(this.btDel);
            this.groupBox3.Controls.Add(this.positifNegatif);
            this.groupBox3.Controls.Add(this.samaDengan);
            this.groupBox3.Controls.Add(this.tandaKoma);
            this.groupBox3.Controls.Add(this.angka0);
            this.groupBox3.Controls.Add(this.angka9);
            this.groupBox3.Controls.Add(this.angka8);
            this.groupBox3.Controls.Add(this.angka7);
            this.groupBox3.Controls.Add(this.angka6);
            this.groupBox3.Controls.Add(this.angka5);
            this.groupBox3.Controls.Add(this.angka4);
            this.groupBox3.Controls.Add(this.angka3);
            this.groupBox3.Controls.Add(this.angka2);
            this.groupBox3.Controls.Add(this.angka1);
            this.groupBox3.Location = new System.Drawing.Point(150, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(177, 296);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // angka2
            // 
            this.angka2.Location = new System.Drawing.Point(65, 72);
            this.angka2.Name = "angka2";
            this.angka2.Size = new System.Drawing.Size(50, 50);
            this.angka2.TabIndex = 15;
            this.angka2.Text = "2";
            this.angka2.UseVisualStyleBackColor = true;
            this.angka2.Click += new System.EventHandler(this.angka2_Click);
            // 
            // angka3
            // 
            this.angka3.Location = new System.Drawing.Point(121, 72);
            this.angka3.Name = "angka3";
            this.angka3.Size = new System.Drawing.Size(50, 50);
            this.angka3.TabIndex = 16;
            this.angka3.Text = "3";
            this.angka3.UseVisualStyleBackColor = true;
            this.angka3.Click += new System.EventHandler(this.angka3_Click);
            // 
            // angka4
            // 
            this.angka4.Location = new System.Drawing.Point(6, 128);
            this.angka4.Name = "angka4";
            this.angka4.Size = new System.Drawing.Size(50, 50);
            this.angka4.TabIndex = 16;
            this.angka4.Text = "4";
            this.angka4.UseVisualStyleBackColor = true;
            this.angka4.Click += new System.EventHandler(this.angka4_Click);
            // 
            // angka5
            // 
            this.angka5.Location = new System.Drawing.Point(62, 128);
            this.angka5.Name = "angka5";
            this.angka5.Size = new System.Drawing.Size(50, 50);
            this.angka5.TabIndex = 16;
            this.angka5.Text = "5";
            this.angka5.UseVisualStyleBackColor = true;
            this.angka5.Click += new System.EventHandler(this.angka5_Click);
            // 
            // angka6
            // 
            this.angka6.Location = new System.Drawing.Point(118, 128);
            this.angka6.Name = "angka6";
            this.angka6.Size = new System.Drawing.Size(50, 50);
            this.angka6.TabIndex = 16;
            this.angka6.Text = "6";
            this.angka6.UseVisualStyleBackColor = true;
            this.angka6.Click += new System.EventHandler(this.angka6_Click);
            // 
            // angka7
            // 
            this.angka7.Location = new System.Drawing.Point(7, 184);
            this.angka7.Name = "angka7";
            this.angka7.Size = new System.Drawing.Size(50, 50);
            this.angka7.TabIndex = 16;
            this.angka7.Text = "7";
            this.angka7.UseVisualStyleBackColor = true;
            this.angka7.Click += new System.EventHandler(this.angka7_Click);
            // 
            // angka8
            // 
            this.angka8.Location = new System.Drawing.Point(62, 184);
            this.angka8.Name = "angka8";
            this.angka8.Size = new System.Drawing.Size(50, 50);
            this.angka8.TabIndex = 16;
            this.angka8.Text = "8";
            this.angka8.UseVisualStyleBackColor = true;
            this.angka8.Click += new System.EventHandler(this.angka8_Click);
            // 
            // angka9
            // 
            this.angka9.Location = new System.Drawing.Point(118, 184);
            this.angka9.Name = "angka9";
            this.angka9.Size = new System.Drawing.Size(50, 50);
            this.angka9.TabIndex = 17;
            this.angka9.Text = "9";
            this.angka9.UseVisualStyleBackColor = true;
            this.angka9.Click += new System.EventHandler(this.angka9_Click);
            // 
            // angka0
            // 
            this.angka0.Location = new System.Drawing.Point(62, 240);
            this.angka0.Name = "angka0";
            this.angka0.Size = new System.Drawing.Size(50, 50);
            this.angka0.TabIndex = 18;
            this.angka0.Text = "0";
            this.angka0.UseVisualStyleBackColor = true;
            // 
            // tandaKoma
            // 
            this.tandaKoma.Location = new System.Drawing.Point(6, 240);
            this.tandaKoma.Name = "tandaKoma";
            this.tandaKoma.Size = new System.Drawing.Size(50, 50);
            this.tandaKoma.TabIndex = 16;
            this.tandaKoma.Text = ",";
            this.tandaKoma.UseVisualStyleBackColor = true;
            this.tandaKoma.Click += new System.EventHandler(this.tandaKoma_Click);
            // 
            // samaDengan
            // 
            this.samaDengan.Location = new System.Drawing.Point(118, 240);
            this.samaDengan.Name = "samaDengan";
            this.samaDengan.Size = new System.Drawing.Size(50, 50);
            this.samaDengan.TabIndex = 19;
            this.samaDengan.Text = "=";
            this.samaDengan.UseVisualStyleBackColor = true;
            this.samaDengan.Click += new System.EventHandler(this.samaDengan_Click);
            // 
            // positifNegatif
            // 
            this.positifNegatif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positifNegatif.Location = new System.Drawing.Point(6, 16);
            this.positifNegatif.Name = "positifNegatif";
            this.positifNegatif.Size = new System.Drawing.Size(50, 50);
            this.positifNegatif.TabIndex = 16;
            this.positifNegatif.Text = "-";
            this.positifNegatif.UseVisualStyleBackColor = true;
            this.positifNegatif.Click += new System.EventHandler(this.positifNegatif_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(62, 16);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(50, 50);
            this.btDel.TabIndex = 16;
            this.btDel.Text = "DEL";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(118, 16);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(50, 50);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Konverter_Suhu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 580);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Konverter_Suhu";
            this.Text = "Konverter_Suhu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.RadioButton CelciusSatu;
        private System.Windows.Forms.RadioButton fahrenheitSatu;
        private System.Windows.Forms.RadioButton reamurSatu;
        private System.Windows.Forms.RadioButton kelvinSatu;
        private System.Windows.Forms.RadioButton celciusDua;
        private System.Windows.Forms.RadioButton fahrenheitDua;
        private System.Windows.Forms.RadioButton reamurDua;
        private System.Windows.Forms.RadioButton kelvinDua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button angka1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button samaDengan;
        private System.Windows.Forms.Button tandaKoma;
        private System.Windows.Forms.Button angka0;
        private System.Windows.Forms.Button angka9;
        private System.Windows.Forms.Button angka8;
        private System.Windows.Forms.Button angka7;
        private System.Windows.Forms.Button angka6;
        private System.Windows.Forms.Button angka5;
        private System.Windows.Forms.Button angka4;
        private System.Windows.Forms.Button angka3;
        private System.Windows.Forms.Button angka2;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button positifNegatif;
    }
}