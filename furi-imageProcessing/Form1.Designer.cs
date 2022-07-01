using System;

namespace furi_imageProcessing
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtBinA = new System.Windows.Forms.TextBox();
            this.btnGenA = new System.Windows.Forms.Button();
            this.btnNotA = new System.Windows.Forms.Button();
            this.btnMultA = new System.Windows.Forms.Button();
            this.btnMirrorA = new System.Windows.Forms.Button();
            this.btnGrayA = new System.Windows.Forms.Button();
            this.btnBinaryA = new System.Windows.Forms.Button();
            this.txtMultA = new System.Windows.Forms.TextBox();
            this.txtDivA = new System.Windows.Forms.TextBox();
            this.bntDivA = new System.Windows.Forms.Button();
            this.pbA = new System.Windows.Forms.PictureBox();
            this.btnA = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtBinB = new System.Windows.Forms.TextBox();
            this.btnGenB = new System.Windows.Forms.Button();
            this.btnDivB = new System.Windows.Forms.Button();
            this.btnNotB = new System.Windows.Forms.Button();
            this.btnGrayB = new System.Windows.Forms.Button();
            this.txtMultB = new System.Windows.Forms.TextBox();
            this.btnBinaryB = new System.Windows.Forms.Button();
            this.btnMultB = new System.Windows.Forms.Button();
            this.btnMirrorB = new System.Windows.Forms.Button();
            this.txtDivB = new System.Windows.Forms.TextBox();
            this.pbB = new System.Windows.Forms.PictureBox();
            this.btnB = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnEq = new System.Windows.Forms.Button();
            this.bntHist = new System.Windows.Forms.Button();
            this.btnMirror = new System.Windows.Forms.Button();
            this.btnGenAndSum = new System.Windows.Forms.Button();
            this.btnColV = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnNOT = new System.Windows.Forms.Button();
            this.btnOR = new System.Windows.Forms.Button();
            this.btnXOR = new System.Windows.Forms.Button();
            this.btnAND = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtDiv = new System.Windows.Forms.TextBox();
            this.txtBld = new System.Windows.Forms.TextBox();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnBld = new System.Windows.Forms.Button();
            this.btnAvg = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnFilterMax = new System.Windows.Forms.Button();
            this.btnFilterAvg = new System.Windows.Forms.Button();
            this.btnFilterMin = new System.Windows.Forms.Button();
            this.btnFilterMed = new System.Windows.Forms.Button();
            this.btnFilterOrd = new System.Windows.Forms.Button();
            this.btnFilterSmoothing = new System.Windows.Forms.Button();
            this.btnFilterGaus = new System.Windows.Forms.Button();
            this.txtFilterOrd = new System.Windows.Forms.TextBox();
            this.txtFilterGaus = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbA)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbB)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.pbA);
            this.groupBox1.Controls.Add(this.btnA);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(225, 439);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image A";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtBinA);
            this.groupBox8.Controls.Add(this.btnGenA);
            this.groupBox8.Controls.Add(this.btnNotA);
            this.groupBox8.Controls.Add(this.btnMultA);
            this.groupBox8.Controls.Add(this.btnMirrorA);
            this.groupBox8.Controls.Add(this.btnGrayA);
            this.groupBox8.Controls.Add(this.btnBinaryA);
            this.groupBox8.Controls.Add(this.txtMultA);
            this.groupBox8.Controls.Add(this.txtDivA);
            this.groupBox8.Controls.Add(this.bntDivA);
            this.groupBox8.Location = new System.Drawing.Point(15, 239);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(195, 195);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Edit";
            // 
            // txtBinA
            // 
            this.txtBinA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBinA.Location = new System.Drawing.Point(97, 107);
            this.txtBinA.Name = "txtBinA";
            this.txtBinA.Size = new System.Drawing.Size(48, 20);
            this.txtBinA.TabIndex = 14;
            // 
            // btnGenA
            // 
            this.btnGenA.Location = new System.Drawing.Point(107, 48);
            this.btnGenA.Name = "btnGenA";
            this.btnGenA.Size = new System.Drawing.Size(83, 23);
            this.btnGenA.TabIndex = 13;
            this.btnGenA.Text = "Generate";
            this.btnGenA.UseVisualStyleBackColor = true;
            this.btnGenA.Click += new System.EventHandler(this.btnGenA_Click);
            // 
            // btnNotA
            // 
            this.btnNotA.Location = new System.Drawing.Point(6, 21);
            this.btnNotA.Name = "btnNotA";
            this.btnNotA.Size = new System.Drawing.Size(85, 23);
            this.btnNotA.TabIndex = 10;
            this.btnNotA.Text = "Negative";
            this.btnNotA.UseVisualStyleBackColor = true;
            this.btnNotA.Click += new System.EventHandler(this.btnNotA_Click);
            // 
            // btnMultA
            // 
            this.btnMultA.Location = new System.Drawing.Point(6, 135);
            this.btnMultA.Name = "btnMultA";
            this.btnMultA.Size = new System.Drawing.Size(85, 23);
            this.btnMultA.TabIndex = 10;
            this.btnMultA.Text = "Multiplication";
            this.btnMultA.UseVisualStyleBackColor = true;
            this.btnMultA.Click += new System.EventHandler(this.btnMultA_Click);
            // 
            // btnMirrorA
            // 
            this.btnMirrorA.Location = new System.Drawing.Point(107, 19);
            this.btnMirrorA.Name = "btnMirrorA";
            this.btnMirrorA.Size = new System.Drawing.Size(83, 23);
            this.btnMirrorA.TabIndex = 12;
            this.btnMirrorA.Text = "Mirror";
            this.btnMirrorA.UseVisualStyleBackColor = true;
            this.btnMirrorA.Click += new System.EventHandler(this.btnMirrorA_Click);
            // 
            // btnGrayA
            // 
            this.btnGrayA.Location = new System.Drawing.Point(6, 48);
            this.btnGrayA.Name = "btnGrayA";
            this.btnGrayA.Size = new System.Drawing.Size(85, 23);
            this.btnGrayA.TabIndex = 8;
            this.btnGrayA.Text = "To Gray";
            this.btnGrayA.UseVisualStyleBackColor = true;
            this.btnGrayA.Click += new System.EventHandler(this.btnGrayA_Click);
            // 
            // btnBinaryA
            // 
            this.btnBinaryA.Location = new System.Drawing.Point(6, 106);
            this.btnBinaryA.Name = "btnBinaryA";
            this.btnBinaryA.Size = new System.Drawing.Size(85, 23);
            this.btnBinaryA.TabIndex = 9;
            this.btnBinaryA.Text = "To Binary";
            this.btnBinaryA.UseVisualStyleBackColor = true;
            this.btnBinaryA.Click += new System.EventHandler(this.btnBinaryA_Click);
            // 
            // txtMultA
            // 
            this.txtMultA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMultA.Location = new System.Drawing.Point(97, 135);
            this.txtMultA.Name = "txtMultA";
            this.txtMultA.Size = new System.Drawing.Size(48, 20);
            this.txtMultA.TabIndex = 11;
            // 
            // txtDivA
            // 
            this.txtDivA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDivA.Location = new System.Drawing.Point(97, 167);
            this.txtDivA.Name = "txtDivA";
            this.txtDivA.Size = new System.Drawing.Size(48, 20);
            this.txtDivA.TabIndex = 7;
            this.txtDivA.TextChanged += new System.EventHandler(this.txtDivA_TextChanged);
            // 
            // bntDivA
            // 
            this.bntDivA.Location = new System.Drawing.Point(6, 164);
            this.bntDivA.Name = "bntDivA";
            this.bntDivA.Size = new System.Drawing.Size(85, 23);
            this.bntDivA.TabIndex = 4;
            this.bntDivA.Text = "Division";
            this.bntDivA.UseVisualStyleBackColor = true;
            this.bntDivA.Click += new System.EventHandler(this.bntDivA_Click);
            // 
            // pbA
            // 
            this.pbA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbA.Location = new System.Drawing.Point(15, 17);
            this.pbA.Margin = new System.Windows.Forms.Padding(2);
            this.pbA.Name = "pbA";
            this.pbA.Size = new System.Drawing.Size(195, 195);
            this.pbA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbA.TabIndex = 0;
            this.pbA.TabStop = false;
            this.pbA.Click += new System.EventHandler(this.pbA_Click);
            // 
            // btnA
            // 
            this.btnA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnA.Location = new System.Drawing.Point(127, 216);
            this.btnA.Margin = new System.Windows.Forms.Padding(2);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(83, 23);
            this.btnA.TabIndex = 3;
            this.btnA.Text = "Load Image A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.pbB);
            this.groupBox2.Controls.Add(this.btnB);
            this.groupBox2.Location = new System.Drawing.Point(238, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(225, 439);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image B";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtBinB);
            this.groupBox9.Controls.Add(this.btnGenB);
            this.groupBox9.Controls.Add(this.btnDivB);
            this.groupBox9.Controls.Add(this.btnNotB);
            this.groupBox9.Controls.Add(this.btnGrayB);
            this.groupBox9.Controls.Add(this.txtMultB);
            this.groupBox9.Controls.Add(this.btnBinaryB);
            this.groupBox9.Controls.Add(this.btnMultB);
            this.groupBox9.Controls.Add(this.btnMirrorB);
            this.groupBox9.Controls.Add(this.txtDivB);
            this.groupBox9.Location = new System.Drawing.Point(15, 239);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(195, 195);
            this.groupBox9.TabIndex = 14;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Edit";
            // 
            // txtBinB
            // 
            this.txtBinB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBinB.Location = new System.Drawing.Point(97, 110);
            this.txtBinB.Name = "txtBinB";
            this.txtBinB.Size = new System.Drawing.Size(48, 20);
            this.txtBinB.TabIndex = 15;
            // 
            // btnGenB
            // 
            this.btnGenB.Location = new System.Drawing.Point(106, 48);
            this.btnGenB.Name = "btnGenB";
            this.btnGenB.Size = new System.Drawing.Size(83, 23);
            this.btnGenB.TabIndex = 15;
            this.btnGenB.Text = "Generate";
            this.btnGenB.UseVisualStyleBackColor = true;
            this.btnGenB.Click += new System.EventHandler(this.btnGenB_Click);
            // 
            // btnDivB
            // 
            this.btnDivB.Location = new System.Drawing.Point(6, 164);
            this.btnDivB.Name = "btnDivB";
            this.btnDivB.Size = new System.Drawing.Size(85, 23);
            this.btnDivB.TabIndex = 12;
            this.btnDivB.Text = "Division";
            this.btnDivB.UseVisualStyleBackColor = true;
            this.btnDivB.Click += new System.EventHandler(this.btnDivB_Click);
            // 
            // btnNotB
            // 
            this.btnNotB.Location = new System.Drawing.Point(6, 21);
            this.btnNotB.Name = "btnNotB";
            this.btnNotB.Size = new System.Drawing.Size(85, 23);
            this.btnNotB.TabIndex = 16;
            this.btnNotB.Text = "Negative";
            this.btnNotB.UseVisualStyleBackColor = true;
            this.btnNotB.Click += new System.EventHandler(this.btnNotB_Click);
            // 
            // btnGrayB
            // 
            this.btnGrayB.Location = new System.Drawing.Point(6, 50);
            this.btnGrayB.Name = "btnGrayB";
            this.btnGrayB.Size = new System.Drawing.Size(85, 23);
            this.btnGrayB.TabIndex = 14;
            this.btnGrayB.Text = "To Gray";
            this.btnGrayB.UseVisualStyleBackColor = true;
            this.btnGrayB.Click += new System.EventHandler(this.btnGrayB_Click);
            // 
            // txtMultB
            // 
            this.txtMultB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMultB.Location = new System.Drawing.Point(97, 138);
            this.txtMultB.Name = "txtMultB";
            this.txtMultB.Size = new System.Drawing.Size(48, 20);
            this.txtMultB.TabIndex = 18;
            this.txtMultB.TextChanged += new System.EventHandler(this.txtMultB_TextChanged);
            // 
            // btnBinaryB
            // 
            this.btnBinaryB.Location = new System.Drawing.Point(6, 108);
            this.btnBinaryB.Name = "btnBinaryB";
            this.btnBinaryB.Size = new System.Drawing.Size(85, 23);
            this.btnBinaryB.TabIndex = 15;
            this.btnBinaryB.Text = "To Binary";
            this.btnBinaryB.UseVisualStyleBackColor = true;
            this.btnBinaryB.Click += new System.EventHandler(this.btnBinaryB_Click);
            // 
            // btnMultB
            // 
            this.btnMultB.Location = new System.Drawing.Point(6, 135);
            this.btnMultB.Name = "btnMultB";
            this.btnMultB.Size = new System.Drawing.Size(85, 23);
            this.btnMultB.TabIndex = 17;
            this.btnMultB.Text = "Multiplication";
            this.btnMultB.UseVisualStyleBackColor = true;
            this.btnMultB.Click += new System.EventHandler(this.btnMultB_Click);
            // 
            // btnMirrorB
            // 
            this.btnMirrorB.Location = new System.Drawing.Point(106, 19);
            this.btnMirrorB.Name = "btnMirrorB";
            this.btnMirrorB.Size = new System.Drawing.Size(83, 23);
            this.btnMirrorB.TabIndex = 14;
            this.btnMirrorB.Text = "Mirror";
            this.btnMirrorB.UseVisualStyleBackColor = true;
            this.btnMirrorB.Click += new System.EventHandler(this.btnMirrorB_Click);
            // 
            // txtDivB
            // 
            this.txtDivB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDivB.Location = new System.Drawing.Point(97, 167);
            this.txtDivB.Name = "txtDivB";
            this.txtDivB.Size = new System.Drawing.Size(48, 20);
            this.txtDivB.TabIndex = 13;
            this.txtDivB.TextChanged += new System.EventHandler(this.txtDivB_TextChanged);
            // 
            // pbB
            // 
            this.pbB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbB.Location = new System.Drawing.Point(15, 17);
            this.pbB.Margin = new System.Windows.Forms.Padding(2);
            this.pbB.Name = "pbB";
            this.pbB.Size = new System.Drawing.Size(195, 195);
            this.pbB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbB.TabIndex = 0;
            this.pbB.TabStop = false;
            this.pbB.Click += new System.EventHandler(this.pbB_Click);
            // 
            // btnB
            // 
            this.btnB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnB.Location = new System.Drawing.Point(127, 216);
            this.btnB.Margin = new System.Windows.Forms.Padding(2);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(83, 23);
            this.btnB.TabIndex = 4;
            this.btnB.Text = "Load Image B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExport);
            this.groupBox3.Controls.Add(this.pbResult);
            this.groupBox3.Location = new System.Drawing.Point(467, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(225, 250);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // btnExport
            // 
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Location = new System.Drawing.Point(116, 219);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(94, 24);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export Image";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // pbResult
            // 
            this.pbResult.Location = new System.Drawing.Point(15, 17);
            this.pbResult.Margin = new System.Windows.Forms.Padding(2);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(195, 195);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResult.TabIndex = 0;
            this.pbResult.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnEq);
            this.groupBox7.Controls.Add(this.bntHist);
            this.groupBox7.Controls.Add(this.btnMirror);
            this.groupBox7.Controls.Add(this.btnGenAndSum);
            this.groupBox7.Controls.Add(this.btnColV);
            this.groupBox7.Location = new System.Drawing.Point(468, 265);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 184);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "More";
            // 
            // btnEq
            // 
            this.btnEq.Location = new System.Drawing.Point(20, 67);
            this.btnEq.Name = "btnEq";
            this.btnEq.Size = new System.Drawing.Size(75, 35);
            this.btnEq.TabIndex = 4;
            this.btnEq.Text = "Equalize";
            this.btnEq.UseVisualStyleBackColor = true;
            this.btnEq.Click += new System.EventHandler(this.btnEq_Click);
            // 
            // bntHist
            // 
            this.bntHist.Location = new System.Drawing.Point(110, 67);
            this.bntHist.Name = "bntHist";
            this.bntHist.Size = new System.Drawing.Size(75, 35);
            this.bntHist.TabIndex = 3;
            this.bntHist.Text = "Image Histogram";
            this.bntHist.UseVisualStyleBackColor = true;
            this.bntHist.Click += new System.EventHandler(this.bntHist_Click);
            // 
            // btnMirror
            // 
            this.btnMirror.Location = new System.Drawing.Point(110, 17);
            this.btnMirror.Name = "btnMirror";
            this.btnMirror.Size = new System.Drawing.Size(75, 35);
            this.btnMirror.TabIndex = 2;
            this.btnMirror.Text = "Mirror Result";
            this.btnMirror.UseVisualStyleBackColor = true;
            this.btnMirror.Click += new System.EventHandler(this.btnMirror_Click);
            // 
            // btnGenAndSum
            // 
            this.btnGenAndSum.Location = new System.Drawing.Point(20, 120);
            this.btnGenAndSum.Name = "btnGenAndSum";
            this.btnGenAndSum.Size = new System.Drawing.Size(75, 56);
            this.btnGenAndSum.TabIndex = 1;
            this.btnGenAndSum.Text = "Generate and Sum Images";
            this.btnGenAndSum.UseVisualStyleBackColor = true;
            this.btnGenAndSum.Click += new System.EventHandler(this.btnGenAndSum_Click);
            // 
            // btnColV
            // 
            this.btnColV.Location = new System.Drawing.Point(20, 17);
            this.btnColV.Name = "btnColV";
            this.btnColV.Size = new System.Drawing.Size(75, 35);
            this.btnColV.TabIndex = 0;
            this.btnColV.Text = "Vertical Collage";
            this.btnColV.UseVisualStyleBackColor = true;
            this.btnColV.Click += new System.EventHandler(this.btnColV_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnNOT);
            this.groupBox6.Controls.Add(this.btnOR);
            this.groupBox6.Controls.Add(this.btnXOR);
            this.groupBox6.Controls.Add(this.btnAND);
            this.groupBox6.Location = new System.Drawing.Point(685, 397);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 98);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Logic Operations";
            // 
            // btnNOT
            // 
            this.btnNOT.Location = new System.Drawing.Point(110, 66);
            this.btnNOT.Name = "btnNOT";
            this.btnNOT.Size = new System.Drawing.Size(85, 23);
            this.btnNOT.TabIndex = 5;
            this.btnNOT.Text = "NOT";
            this.btnNOT.UseVisualStyleBackColor = true;
            this.btnNOT.Click += new System.EventHandler(this.btnNOT_Click);
            // 
            // btnOR
            // 
            this.btnOR.Location = new System.Drawing.Point(110, 28);
            this.btnOR.Name = "btnOR";
            this.btnOR.Size = new System.Drawing.Size(85, 23);
            this.btnOR.TabIndex = 4;
            this.btnOR.Text = "OR";
            this.btnOR.UseVisualStyleBackColor = true;
            this.btnOR.Click += new System.EventHandler(this.btnOR_Click);
            // 
            // btnXOR
            // 
            this.btnXOR.Location = new System.Drawing.Point(6, 66);
            this.btnXOR.Name = "btnXOR";
            this.btnXOR.Size = new System.Drawing.Size(85, 23);
            this.btnXOR.TabIndex = 2;
            this.btnXOR.Text = "XOR";
            this.btnXOR.UseVisualStyleBackColor = true;
            this.btnXOR.Click += new System.EventHandler(this.btnXOR_Click);
            // 
            // btnAND
            // 
            this.btnAND.Location = new System.Drawing.Point(6, 28);
            this.btnAND.Name = "btnAND";
            this.btnAND.Size = new System.Drawing.Size(85, 23);
            this.btnAND.TabIndex = 1;
            this.btnAND.Text = "AND";
            this.btnAND.UseVisualStyleBackColor = true;
            this.btnAND.Click += new System.EventHandler(this.btnAND_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtDiv);
            this.groupBox5.Controls.Add(this.txtBld);
            this.groupBox5.Controls.Add(this.btnDiv);
            this.groupBox5.Controls.Add(this.btnBld);
            this.groupBox5.Controls.Add(this.btnAvg);
            this.groupBox5.Controls.Add(this.btnMult);
            this.groupBox5.Controls.Add(this.btnSub);
            this.groupBox5.Controls.Add(this.btnAdd);
            this.groupBox5.Location = new System.Drawing.Point(679, 270);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(261, 121);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Arithmetic Operations";
            // 
            // txtDiv
            // 
            this.txtDiv.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "0.1",
            "0.2",
            "0.3",
            "0.4",
            "0.5",
            "0.6",
            "0.7",
            "0.8",
            "0.9",
            "1"});
            this.txtDiv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiv.Location = new System.Drawing.Point(201, 30);
            this.txtDiv.Name = "txtDiv";
            this.txtDiv.Size = new System.Drawing.Size(48, 20);
            this.txtDiv.TabIndex = 13;
            this.txtDiv.Tag = "";
            this.txtDiv.TextChanged += new System.EventHandler(this.txtDiv_TextChanged);
            // 
            // txtBld
            // 
            this.txtBld.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "0.1",
            "0.2",
            "0.3",
            "0.4",
            "0.5",
            "0.6",
            "0.7",
            "0.8",
            "0.9",
            "1"});
            this.txtBld.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtBld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBld.Location = new System.Drawing.Point(201, 89);
            this.txtBld.Name = "txtBld";
            this.txtBld.Size = new System.Drawing.Size(48, 20);
            this.txtBld.TabIndex = 9;
            this.txtBld.Tag = "";
            this.txtBld.TextChanged += new System.EventHandler(this.txtBld_TextChanged);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(110, 28);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(85, 23);
            this.btnDiv.TabIndex = 12;
            this.btnDiv.Text = "Division";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnBld
            // 
            this.btnBld.Location = new System.Drawing.Point(110, 86);
            this.btnBld.Name = "btnBld";
            this.btnBld.Size = new System.Drawing.Size(85, 23);
            this.btnBld.TabIndex = 6;
            this.btnBld.Text = "Blending";
            this.btnBld.UseVisualStyleBackColor = true;
            this.btnBld.Click += new System.EventHandler(this.btnBld_Click);
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(6, 86);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(85, 23);
            this.btnAvg.TabIndex = 5;
            this.btnAvg.Text = "Average";
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(110, 57);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(85, 23);
            this.btnMult.TabIndex = 3;
            this.btnMult.Text = "Multiplication";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(6, 57);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(85, 23);
            this.btnSub.TabIndex = 2;
            this.btnSub.Text = "Subtraction";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Addition";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 19);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "QtyPixels";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(403, 203);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(6, 19);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "QtyPixels";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(403, 203);
            this.chart2.TabIndex = 9;
            this.chart2.Text = "chart2";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.chart1);
            this.groupBox11.Location = new System.Drawing.Point(940, 25);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(418, 228);
            this.groupBox11.TabIndex = 10;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Histogram Image A";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.chart2);
            this.groupBox12.Location = new System.Drawing.Point(940, 282);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(418, 228);
            this.groupBox12.TabIndex = 9;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Histogram Image A Equalized";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtFilterGaus);
            this.groupBox10.Controls.Add(this.txtFilterOrd);
            this.groupBox10.Controls.Add(this.btnFilterGaus);
            this.groupBox10.Controls.Add(this.btnFilterSmoothing);
            this.groupBox10.Controls.Add(this.btnFilterOrd);
            this.groupBox10.Controls.Add(this.btnFilterMed);
            this.groupBox10.Controls.Add(this.btnFilterMin);
            this.groupBox10.Controls.Add(this.btnFilterAvg);
            this.groupBox10.Controls.Add(this.btnFilterMax);
            this.groupBox10.Location = new System.Drawing.Point(716, 31);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(202, 216);
            this.groupBox10.TabIndex = 7;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "(Image A) New functions";
            // 
            // btnFilterMax
            // 
            this.btnFilterMax.Location = new System.Drawing.Point(6, 28);
            this.btnFilterMax.Name = "btnFilterMax";
            this.btnFilterMax.Size = new System.Drawing.Size(85, 23);
            this.btnFilterMax.TabIndex = 6;
            this.btnFilterMax.Text = "Max";
            this.btnFilterMax.UseVisualStyleBackColor = true;
            this.btnFilterMax.Click += new System.EventHandler(this.btnFilterMax_Click);
            // 
            // btnFilterAvg
            // 
            this.btnFilterAvg.Location = new System.Drawing.Point(6, 59);
            this.btnFilterAvg.Name = "btnFilterAvg";
            this.btnFilterAvg.Size = new System.Drawing.Size(85, 23);
            this.btnFilterAvg.TabIndex = 7;
            this.btnFilterAvg.Text = "Average";
            this.btnFilterAvg.UseVisualStyleBackColor = true;
            this.btnFilterAvg.Click += new System.EventHandler(this.btnFilterAvg_Click);
            // 
            // btnFilterMin
            // 
            this.btnFilterMin.Location = new System.Drawing.Point(111, 28);
            this.btnFilterMin.Name = "btnFilterMin";
            this.btnFilterMin.Size = new System.Drawing.Size(85, 23);
            this.btnFilterMin.TabIndex = 8;
            this.btnFilterMin.Text = "Min";
            this.btnFilterMin.UseVisualStyleBackColor = true;
            this.btnFilterMin.Click += new System.EventHandler(this.btnFilterMin_Click);
            // 
            // btnFilterMed
            // 
            this.btnFilterMed.Location = new System.Drawing.Point(110, 57);
            this.btnFilterMed.Name = "btnFilterMed";
            this.btnFilterMed.Size = new System.Drawing.Size(85, 23);
            this.btnFilterMed.TabIndex = 9;
            this.btnFilterMed.Text = "Median";
            this.btnFilterMed.UseVisualStyleBackColor = true;
            this.btnFilterMed.Click += new System.EventHandler(this.btnFilterMed_Click);
            // 
            // btnFilterOrd
            // 
            this.btnFilterOrd.Location = new System.Drawing.Point(6, 139);
            this.btnFilterOrd.Name = "btnFilterOrd";
            this.btnFilterOrd.Size = new System.Drawing.Size(85, 23);
            this.btnFilterOrd.TabIndex = 13;
            this.btnFilterOrd.Text = "Order";
            this.btnFilterOrd.UseVisualStyleBackColor = true;
            this.btnFilterOrd.Click += new System.EventHandler(this.btnFilterOrd_Click);
            // 
            // btnFilterSmoothing
            // 
            this.btnFilterSmoothing.Location = new System.Drawing.Point(60, 88);
            this.btnFilterSmoothing.Name = "btnFilterSmoothing";
            this.btnFilterSmoothing.Size = new System.Drawing.Size(85, 36);
            this.btnFilterSmoothing.TabIndex = 14;
            this.btnFilterSmoothing.Text = "Smoothing";
            this.btnFilterSmoothing.UseVisualStyleBackColor = true;
            this.btnFilterSmoothing.Click += new System.EventHandler(this.btnFilterSmoothing_Click);
            // 
            // btnFilterGaus
            // 
            this.btnFilterGaus.Location = new System.Drawing.Point(6, 179);
            this.btnFilterGaus.Name = "btnFilterGaus";
            this.btnFilterGaus.Size = new System.Drawing.Size(85, 23);
            this.btnFilterGaus.TabIndex = 20;
            this.btnFilterGaus.Text = "Gaussian";
            this.btnFilterGaus.UseVisualStyleBackColor = true;
            this.btnFilterGaus.Click += new System.EventHandler(this.btnFilterGaus_Click);
            // 
            // txtFilterOrd
            // 
            this.txtFilterOrd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterOrd.Location = new System.Drawing.Point(97, 142);
            this.txtFilterOrd.Name = "txtFilterOrd";
            this.txtFilterOrd.Size = new System.Drawing.Size(48, 20);
            this.txtFilterOrd.TabIndex = 21;
            // 
            // txtFilterGaus
            // 
            this.txtFilterGaus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterGaus.Location = new System.Drawing.Point(97, 179);
            this.txtFilterGaus.Name = "txtFilterGaus";
            this.txtFilterGaus.Size = new System.Drawing.Size(48, 20);
            this.txtFilterGaus.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 519);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Image Processor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbA)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbB)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnColV;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnBld;
        private System.Windows.Forms.Button btnAvg;
        private System.Windows.Forms.Button bntDivA;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnNOT;
        private System.Windows.Forms.Button btnOR;
        private System.Windows.Forms.Button btnXOR;
        private System.Windows.Forms.Button btnAND;
        private System.Windows.Forms.TextBox txtDivA;
        private System.Windows.Forms.Button btnGenAndSum;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox txtBld;
        private System.Windows.Forms.Button btnGrayA;
        private System.Windows.Forms.TextBox txtMultA;
        private System.Windows.Forms.Button btnNotA;
        private System.Windows.Forms.Button btnMultA;
        private System.Windows.Forms.Button btnBinaryA;
        private System.Windows.Forms.TextBox txtMultB;
        private System.Windows.Forms.Button btnNotB;
        private System.Windows.Forms.Button btnMultB;
        private System.Windows.Forms.Button btnGrayB;
        private System.Windows.Forms.Button btnBinaryB;
        private System.Windows.Forms.Button btnDivB;
        private System.Windows.Forms.TextBox txtDivB;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMirror;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnGenA;
        private System.Windows.Forms.Button btnMirrorA;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnGenB;
        private System.Windows.Forms.Button btnMirrorB;
        private System.Windows.Forms.TextBox txtDiv;
        private System.Windows.Forms.TextBox txtBinA;
        private System.Windows.Forms.TextBox txtBinB;
        private System.Windows.Forms.Button bntHist;
        private System.Windows.Forms.Button btnEq;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox txtFilterGaus;
        private System.Windows.Forms.TextBox txtFilterOrd;
        private System.Windows.Forms.Button btnFilterGaus;
        private System.Windows.Forms.Button btnFilterSmoothing;
        private System.Windows.Forms.Button btnFilterOrd;
        private System.Windows.Forms.Button btnFilterMed;
        private System.Windows.Forms.Button btnFilterMin;
        private System.Windows.Forms.Button btnFilterAvg;
        private System.Windows.Forms.Button btnFilterMax;
    }
}

