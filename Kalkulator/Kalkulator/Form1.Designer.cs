namespace Kalkulator
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
            this.components = new System.ComponentModel.Container();
            this.tbCalc = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btNol = new System.Windows.Forms.Button();
            this.btTitik = new System.Windows.Forms.Button();
            this.btEquals = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.btsubs = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btdel = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.Mode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konversiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suhuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jarakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.massaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kecepatanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekananToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penghitungLuasVolumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penghitungZakatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konversiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.suhuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.massaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tekananToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kecepatanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.luasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.waktuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tentangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.situsWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btMod = new System.Windows.Forms.Button();
            this.btRoot = new System.Windows.Forms.Button();
            this.faktorial = new System.Windows.Forms.Button();
            this.kuadratX = new System.Windows.Forms.Button();
            this.pangkatY = new System.Windows.Forms.Button();
            this.seperX = new System.Windows.Forms.Button();
            this.zakatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Mode.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCalc
            // 
            this.tbCalc.Location = new System.Drawing.Point(2, 55);
            this.tbCalc.Name = "tbCalc";
            this.tbCalc.ReadOnly = true;
            this.tbCalc.Size = new System.Drawing.Size(317, 20);
            this.tbCalc.TabIndex = 0;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(12, 100);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(50, 50);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(68, 100);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(50, 50);
            this.bt2.TabIndex = 2;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(124, 100);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(50, 50);
            this.bt3.TabIndex = 3;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(12, 156);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(50, 50);
            this.bt4.TabIndex = 4;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(68, 156);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(50, 50);
            this.bt5.TabIndex = 5;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(124, 156);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(50, 50);
            this.bt6.TabIndex = 6;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(12, 212);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(50, 50);
            this.bt7.TabIndex = 7;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(68, 212);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(50, 50);
            this.bt8.TabIndex = 8;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(124, 212);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(50, 50);
            this.bt9.TabIndex = 9;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // btNol
            // 
            this.btNol.Location = new System.Drawing.Point(68, 268);
            this.btNol.Name = "btNol";
            this.btNol.Size = new System.Drawing.Size(50, 50);
            this.btNol.TabIndex = 10;
            this.btNol.Text = "0";
            this.btNol.UseVisualStyleBackColor = true;
            this.btNol.Click += new System.EventHandler(this.btNol_Click);
            // 
            // btTitik
            // 
            this.btTitik.Location = new System.Drawing.Point(12, 268);
            this.btTitik.Name = "btTitik";
            this.btTitik.Size = new System.Drawing.Size(50, 50);
            this.btTitik.TabIndex = 11;
            this.btTitik.Text = ",";
            this.btTitik.UseVisualStyleBackColor = true;
            this.btTitik.Click += new System.EventHandler(this.btTitik_Click);
            // 
            // btEquals
            // 
            this.btEquals.Location = new System.Drawing.Point(124, 268);
            this.btEquals.Name = "btEquals";
            this.btEquals.Size = new System.Drawing.Size(50, 50);
            this.btEquals.TabIndex = 12;
            this.btEquals.Text = "=";
            this.btEquals.UseVisualStyleBackColor = true;
            this.btEquals.Click += new System.EventHandler(this.btEquals_Click);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(198, 156);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(50, 50);
            this.btAdd.TabIndex = 13;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btMul
            // 
            this.btMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMul.Location = new System.Drawing.Point(198, 212);
            this.btMul.Name = "btMul";
            this.btMul.Size = new System.Drawing.Size(50, 50);
            this.btMul.TabIndex = 14;
            this.btMul.Text = "*";
            this.btMul.UseVisualStyleBackColor = true;
            this.btMul.Click += new System.EventHandler(this.btMul_Click);
            // 
            // btsubs
            // 
            this.btsubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsubs.Location = new System.Drawing.Point(254, 156);
            this.btsubs.Name = "btsubs";
            this.btsubs.Size = new System.Drawing.Size(50, 50);
            this.btsubs.TabIndex = 15;
            this.btsubs.Text = "-";
            this.btsubs.UseVisualStyleBackColor = true;
            this.btsubs.Click += new System.EventHandler(this.btsubs_Click);
            // 
            // btDiv
            // 
            this.btDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDiv.Location = new System.Drawing.Point(254, 212);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(50, 50);
            this.btDiv.TabIndex = 16;
            this.btDiv.Text = "/";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // btdel
            // 
            this.btdel.Location = new System.Drawing.Point(198, 100);
            this.btdel.Name = "btdel";
            this.btdel.Size = new System.Drawing.Size(50, 50);
            this.btdel.TabIndex = 17;
            this.btdel.Text = "Del";
            this.btdel.UseVisualStyleBackColor = true;
            this.btdel.Click += new System.EventHandler(this.btdel_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(254, 100);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(50, 50);
            this.btClear.TabIndex = 18;
            this.btClear.Text = "C";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // Mode
            // 
            this.Mode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeToolStripMenuItem,
            this.konversiToolStripMenuItem,
            this.penghitungLuasVolumeToolStripMenuItem,
            this.penghitungZakatToolStripMenuItem});
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(210, 92);
            this.Mode.Text = "Menu";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // konversiToolStripMenuItem
            // 
            this.konversiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suhuToolStripMenuItem,
            this.jarakToolStripMenuItem,
            this.massaToolStripMenuItem,
            this.kecepatanToolStripMenuItem,
            this.tekananToolStripMenuItem,
            this.volumeToolStripMenuItem});
            this.konversiToolStripMenuItem.Name = "konversiToolStripMenuItem";
            this.konversiToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.konversiToolStripMenuItem.Text = "Konversi";
            // 
            // suhuToolStripMenuItem
            // 
            this.suhuToolStripMenuItem.Name = "suhuToolStripMenuItem";
            this.suhuToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.suhuToolStripMenuItem.Text = "Suhu";
            // 
            // jarakToolStripMenuItem
            // 
            this.jarakToolStripMenuItem.Name = "jarakToolStripMenuItem";
            this.jarakToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.jarakToolStripMenuItem.Text = "Jarak";
            // 
            // massaToolStripMenuItem
            // 
            this.massaToolStripMenuItem.Name = "massaToolStripMenuItem";
            this.massaToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.massaToolStripMenuItem.Text = "Massa";
            // 
            // kecepatanToolStripMenuItem
            // 
            this.kecepatanToolStripMenuItem.Name = "kecepatanToolStripMenuItem";
            this.kecepatanToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.kecepatanToolStripMenuItem.Text = "Kecepatan";
            // 
            // tekananToolStripMenuItem
            // 
            this.tekananToolStripMenuItem.Name = "tekananToolStripMenuItem";
            this.tekananToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.tekananToolStripMenuItem.Text = "Tekanan";
            // 
            // volumeToolStripMenuItem
            // 
            this.volumeToolStripMenuItem.Name = "volumeToolStripMenuItem";
            this.volumeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.volumeToolStripMenuItem.Text = "Volume";
            // 
            // penghitungLuasVolumeToolStripMenuItem
            // 
            this.penghitungLuasVolumeToolStripMenuItem.Name = "penghitungLuasVolumeToolStripMenuItem";
            this.penghitungLuasVolumeToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.penghitungLuasVolumeToolStripMenuItem.Text = "Penghitung Luas & Volume";
            // 
            // penghitungZakatToolStripMenuItem
            // 
            this.penghitungZakatToolStripMenuItem.Name = "penghitungZakatToolStripMenuItem";
            this.penghitungZakatToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.penghitungZakatToolStripMenuItem.Text = "Penghitung Zakat";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.tentangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(403, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konversiToolStripMenuItem1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // konversiToolStripMenuItem1
            // 
            this.konversiToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suhuToolStripMenuItem1,
            this.massaToolStripMenuItem1,
            this.tekananToolStripMenuItem1,
            this.kecepatanToolStripMenuItem1,
            this.luasToolStripMenuItem,
            this.volumeToolStripMenuItem1,
            this.waktuToolStripMenuItem,
            this.zakatToolStripMenuItem1});
            this.konversiToolStripMenuItem1.Name = "konversiToolStripMenuItem1";
            this.konversiToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.konversiToolStripMenuItem1.Text = "Konversi & Penghitung";
            // 
            // suhuToolStripMenuItem1
            // 
            this.suhuToolStripMenuItem1.Name = "suhuToolStripMenuItem1";
            this.suhuToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.suhuToolStripMenuItem1.Text = "Suhu";
            this.suhuToolStripMenuItem1.Click += new System.EventHandler(this.suhuToolStripMenuItem1_Click);
            // 
            // massaToolStripMenuItem1
            // 
            this.massaToolStripMenuItem1.Name = "massaToolStripMenuItem1";
            this.massaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.massaToolStripMenuItem1.Text = "Massa";
            this.massaToolStripMenuItem1.Click += new System.EventHandler(this.massaToolStripMenuItem1_Click);
            // 
            // tekananToolStripMenuItem1
            // 
            this.tekananToolStripMenuItem1.Name = "tekananToolStripMenuItem1";
            this.tekananToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.tekananToolStripMenuItem1.Text = "Tekanan";
            this.tekananToolStripMenuItem1.Click += new System.EventHandler(this.tekananToolStripMenuItem1_Click);
            // 
            // kecepatanToolStripMenuItem1
            // 
            this.kecepatanToolStripMenuItem1.Name = "kecepatanToolStripMenuItem1";
            this.kecepatanToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.kecepatanToolStripMenuItem1.Text = "Kecepatan";
            this.kecepatanToolStripMenuItem1.Click += new System.EventHandler(this.kecepatanToolStripMenuItem1_Click);
            // 
            // luasToolStripMenuItem
            // 
            this.luasToolStripMenuItem.Name = "luasToolStripMenuItem";
            this.luasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.luasToolStripMenuItem.Text = "Luas";
            this.luasToolStripMenuItem.Click += new System.EventHandler(this.luasToolStripMenuItem_Click);
            // 
            // volumeToolStripMenuItem1
            // 
            this.volumeToolStripMenuItem1.Name = "volumeToolStripMenuItem1";
            this.volumeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.volumeToolStripMenuItem1.Text = "Volume";
            this.volumeToolStripMenuItem1.Click += new System.EventHandler(this.volumeToolStripMenuItem1_Click);
            // 
            // waktuToolStripMenuItem
            // 
            this.waktuToolStripMenuItem.Name = "waktuToolStripMenuItem";
            this.waktuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.waktuToolStripMenuItem.Text = "Waktu";
            this.waktuToolStripMenuItem.Click += new System.EventHandler(this.waktuToolStripMenuItem_Click);
            // 
            // tentangToolStripMenuItem
            // 
            this.tentangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.situsWebToolStripMenuItem,
            this.versiToolStripMenuItem});
            this.tentangToolStripMenuItem.Name = "tentangToolStripMenuItem";
            this.tentangToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.tentangToolStripMenuItem.Text = "Tentang";
            // 
            // situsWebToolStripMenuItem
            // 
            this.situsWebToolStripMenuItem.Name = "situsWebToolStripMenuItem";
            this.situsWebToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.situsWebToolStripMenuItem.Text = "Situs Web";
            this.situsWebToolStripMenuItem.Click += new System.EventHandler(this.situsWebToolStripMenuItem_Click);
            // 
            // versiToolStripMenuItem
            // 
            this.versiToolStripMenuItem.Name = "versiToolStripMenuItem";
            this.versiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.versiToolStripMenuItem.Text = "Versi";
            this.versiToolStripMenuItem.Click += new System.EventHandler(this.versiToolStripMenuItem_Click);
            // 
            // btMod
            // 
            this.btMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMod.Location = new System.Drawing.Point(198, 268);
            this.btMod.Name = "btMod";
            this.btMod.Size = new System.Drawing.Size(50, 50);
            this.btMod.TabIndex = 22;
            this.btMod.Text = "%";
            this.btMod.UseVisualStyleBackColor = true;
            this.btMod.Click += new System.EventHandler(this.btMod_Click);
            // 
            // btRoot
            // 
            this.btRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRoot.Location = new System.Drawing.Point(254, 268);
            this.btRoot.Name = "btRoot";
            this.btRoot.Size = new System.Drawing.Size(50, 50);
            this.btRoot.TabIndex = 23;
            this.btRoot.Text = "√";
            this.btRoot.UseVisualStyleBackColor = true;
            this.btRoot.Click += new System.EventHandler(this.btRoot_Click);
            // 
            // faktorial
            // 
            this.faktorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faktorial.Location = new System.Drawing.Point(310, 100);
            this.faktorial.Name = "faktorial";
            this.faktorial.Size = new System.Drawing.Size(50, 50);
            this.faktorial.TabIndex = 24;
            this.faktorial.Text = "n!";
            this.faktorial.UseVisualStyleBackColor = true;
            this.faktorial.Click += new System.EventHandler(this.faktorial_Click);
            // 
            // kuadratX
            // 
            this.kuadratX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kuadratX.Location = new System.Drawing.Point(310, 155);
            this.kuadratX.Name = "kuadratX";
            this.kuadratX.Size = new System.Drawing.Size(50, 50);
            this.kuadratX.TabIndex = 25;
            this.kuadratX.Text = "X^2";
            this.kuadratX.UseVisualStyleBackColor = true;
            this.kuadratX.Click += new System.EventHandler(this.kuadratX_Click);
            // 
            // pangkatY
            // 
            this.pangkatY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pangkatY.Location = new System.Drawing.Point(310, 212);
            this.pangkatY.Name = "pangkatY";
            this.pangkatY.Size = new System.Drawing.Size(50, 50);
            this.pangkatY.TabIndex = 26;
            this.pangkatY.Text = "X^y";
            this.pangkatY.UseVisualStyleBackColor = true;
            this.pangkatY.Click += new System.EventHandler(this.pangkatY_Click);
            // 
            // seperX
            // 
            this.seperX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seperX.Location = new System.Drawing.Point(310, 268);
            this.seperX.Name = "seperX";
            this.seperX.Size = new System.Drawing.Size(50, 50);
            this.seperX.TabIndex = 27;
            this.seperX.Text = "1/X";
            this.seperX.UseVisualStyleBackColor = true;
            this.seperX.Click += new System.EventHandler(this.seperX_Click);
            // 
            // zakatToolStripMenuItem1
            // 
            this.zakatToolStripMenuItem1.Name = "zakatToolStripMenuItem1";
            this.zakatToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.zakatToolStripMenuItem1.Text = "Zakat";
            this.zakatToolStripMenuItem1.Click += new System.EventHandler(this.zakatToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.ContextMenuStrip = this.Mode;
            this.Controls.Add(this.seperX);
            this.Controls.Add(this.pangkatY);
            this.Controls.Add(this.kuadratX);
            this.Controls.Add(this.faktorial);
            this.Controls.Add(this.btRoot);
            this.Controls.Add(this.btMod);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btdel);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btsubs);
            this.Controls.Add(this.btMul);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btEquals);
            this.Controls.Add(this.btTitik);
            this.Controls.Add(this.btNol);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.tbCalc);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Mode.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCalc;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btNol;
        private System.Windows.Forms.Button btTitik;
        private System.Windows.Forms.Button btEquals;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btMul;
        private System.Windows.Forms.Button btsubs;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button btdel;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.ContextMenuStrip Mode;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konversiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suhuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jarakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem massaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kecepatanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tekananToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penghitungLuasVolumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penghitungZakatToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konversiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem suhuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem massaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tekananToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kecepatanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem luasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volumeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem waktuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tentangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem situsWebToolStripMenuItem;
        private System.Windows.Forms.Button btMod;
        private System.Windows.Forms.Button btRoot;
        private System.Windows.Forms.Button faktorial;
        private System.Windows.Forms.Button kuadratX;
        private System.Windows.Forms.Button pangkatY;
        private System.Windows.Forms.Button seperX;
        private System.Windows.Forms.ToolStripMenuItem versiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakatToolStripMenuItem1;
    }
}

