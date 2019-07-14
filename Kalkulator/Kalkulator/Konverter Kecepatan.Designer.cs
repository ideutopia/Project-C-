namespace Kalkulator
{
    partial class Konverter_Kecepatan
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioKnot = new System.Windows.Forms.RadioButton();
            this.radioMil = new System.Windows.Forms.RadioButton();
            this.radioKilometer = new System.Windows.Forms.RadioButton();
            this.radioMeter = new System.Windows.Forms.RadioButton();
            this.btKonversi = new System.Windows.Forms.Button();
            this.tbKecepatanKonversi = new System.Windows.Forms.TextBox();
            this.tbKecepatanAwal = new System.Windows.Forms.TextBox();
            this.radioKnotKonversi = new System.Windows.Forms.RadioButton();
            this.radioMilKonversi = new System.Windows.Forms.RadioButton();
            this.radioKilometerKonversi = new System.Windows.Forms.RadioButton();
            this.radioMeterKonversi = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioKnotKonversi);
            this.groupBox2.Controls.Add(this.radioMilKonversi);
            this.groupBox2.Controls.Add(this.radioKilometerKonversi);
            this.groupBox2.Controls.Add(this.radioMeterKonversi);
            this.groupBox2.Location = new System.Drawing.Point(316, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 123);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satuan Konversi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioKnot);
            this.groupBox1.Controls.Add(this.radioMil);
            this.groupBox1.Controls.Add(this.radioKilometer);
            this.groupBox1.Controls.Add(this.radioMeter);
            this.groupBox1.Location = new System.Drawing.Point(14, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 123);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satuan Awal";
            // 
            // radioKnot
            // 
            this.radioKnot.AutoSize = true;
            this.radioKnot.Location = new System.Drawing.Point(7, 89);
            this.radioKnot.Name = "radioKnot";
            this.radioKnot.Size = new System.Drawing.Size(47, 17);
            this.radioKnot.TabIndex = 5;
            this.radioKnot.TabStop = true;
            this.radioKnot.Text = "Knot";
            this.radioKnot.UseVisualStyleBackColor = true;
            // 
            // radioMil
            // 
            this.radioMil.AutoSize = true;
            this.radioMil.Location = new System.Drawing.Point(7, 66);
            this.radioMil.Name = "radioMil";
            this.radioMil.Size = new System.Drawing.Size(102, 17);
            this.radioMil.TabIndex = 2;
            this.radioMil.TabStop = true;
            this.radioMil.Text = "Mil Perjam (M/h)";
            this.radioMil.UseVisualStyleBackColor = true;
            // 
            // radioKilometer
            // 
            this.radioKilometer.AutoSize = true;
            this.radioKilometer.Location = new System.Drawing.Point(7, 43);
            this.radioKilometer.Name = "radioKilometer";
            this.radioKilometer.Size = new System.Drawing.Size(138, 17);
            this.radioKilometer.TabIndex = 1;
            this.radioKilometer.TabStop = true;
            this.radioKilometer.Text = "Kilometer Perjam (Km/h)";
            this.radioKilometer.UseVisualStyleBackColor = true;
            // 
            // radioMeter
            // 
            this.radioMeter.AutoSize = true;
            this.radioMeter.Location = new System.Drawing.Point(7, 20);
            this.radioMeter.Name = "radioMeter";
            this.radioMeter.Size = new System.Drawing.Size(121, 17);
            this.radioMeter.TabIndex = 0;
            this.radioMeter.TabStop = true;
            this.radioMeter.Text = "Meter Perdetik (m/s)";
            this.radioMeter.UseVisualStyleBackColor = true;
            // 
            // btKonversi
            // 
            this.btKonversi.Location = new System.Drawing.Point(216, 82);
            this.btKonversi.Name = "btKonversi";
            this.btKonversi.Size = new System.Drawing.Size(109, 23);
            this.btKonversi.TabIndex = 7;
            this.btKonversi.Text = "Konversi";
            this.btKonversi.UseVisualStyleBackColor = true;
            this.btKonversi.Click += new System.EventHandler(this.btKonversi_Click);
            // 
            // tbKecepatanKonversi
            // 
            this.tbKecepatanKonversi.Location = new System.Drawing.Point(357, 86);
            this.tbKecepatanKonversi.Name = "tbKecepatanKonversi";
            this.tbKecepatanKonversi.ReadOnly = true;
            this.tbKecepatanKonversi.Size = new System.Drawing.Size(159, 20);
            this.tbKecepatanKonversi.TabIndex = 6;
            // 
            // tbKecepatanAwal
            // 
            this.tbKecepatanAwal.Location = new System.Drawing.Point(14, 86);
            this.tbKecepatanAwal.Name = "tbKecepatanAwal";
            this.tbKecepatanAwal.Size = new System.Drawing.Size(159, 20);
            this.tbKecepatanAwal.TabIndex = 5;
            // 
            // radioKnotKonversi
            // 
            this.radioKnotKonversi.AutoSize = true;
            this.radioKnotKonversi.Location = new System.Drawing.Point(6, 88);
            this.radioKnotKonversi.Name = "radioKnotKonversi";
            this.radioKnotKonversi.Size = new System.Drawing.Size(47, 17);
            this.radioKnotKonversi.TabIndex = 9;
            this.radioKnotKonversi.TabStop = true;
            this.radioKnotKonversi.Text = "Knot";
            this.radioKnotKonversi.UseVisualStyleBackColor = true;
            // 
            // radioMilKonversi
            // 
            this.radioMilKonversi.AutoSize = true;
            this.radioMilKonversi.Location = new System.Drawing.Point(6, 65);
            this.radioMilKonversi.Name = "radioMilKonversi";
            this.radioMilKonversi.Size = new System.Drawing.Size(102, 17);
            this.radioMilKonversi.TabIndex = 8;
            this.radioMilKonversi.TabStop = true;
            this.radioMilKonversi.Text = "Mil Perjam (M/h)";
            this.radioMilKonversi.UseVisualStyleBackColor = true;
            // 
            // radioKilometerKonversi
            // 
            this.radioKilometerKonversi.AutoSize = true;
            this.radioKilometerKonversi.Location = new System.Drawing.Point(6, 42);
            this.radioKilometerKonversi.Name = "radioKilometerKonversi";
            this.radioKilometerKonversi.Size = new System.Drawing.Size(138, 17);
            this.radioKilometerKonversi.TabIndex = 7;
            this.radioKilometerKonversi.TabStop = true;
            this.radioKilometerKonversi.Text = "Kilometer Perjam (Km/h)";
            this.radioKilometerKonversi.UseVisualStyleBackColor = true;
            // 
            // radioMeterKonversi
            // 
            this.radioMeterKonversi.AutoSize = true;
            this.radioMeterKonversi.Location = new System.Drawing.Point(6, 19);
            this.radioMeterKonversi.Name = "radioMeterKonversi";
            this.radioMeterKonversi.Size = new System.Drawing.Size(121, 17);
            this.radioMeterKonversi.TabIndex = 6;
            this.radioMeterKonversi.TabStop = true;
            this.radioMeterKonversi.Text = "Meter Perdetik (m/s)";
            this.radioMeterKonversi.UseVisualStyleBackColor = true;
            // 
            // Konverter_Kecepatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 279);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btKonversi);
            this.Controls.Add(this.tbKecepatanKonversi);
            this.Controls.Add(this.tbKecepatanAwal);
            this.Name = "Konverter_Kecepatan";
            this.Text = "Konverter_Kecepatan";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioKnot;
        private System.Windows.Forms.RadioButton radioMil;
        private System.Windows.Forms.RadioButton radioKilometer;
        private System.Windows.Forms.RadioButton radioMeter;
        private System.Windows.Forms.Button btKonversi;
        private System.Windows.Forms.TextBox tbKecepatanKonversi;
        private System.Windows.Forms.TextBox tbKecepatanAwal;
        private System.Windows.Forms.RadioButton radioKnotKonversi;
        private System.Windows.Forms.RadioButton radioMilKonversi;
        private System.Windows.Forms.RadioButton radioKilometerKonversi;
        private System.Windows.Forms.RadioButton radioMeterKonversi;
    }
}