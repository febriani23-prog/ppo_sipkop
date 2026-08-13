namespace db_kas_pemuda
{
    partial class Form8
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
            groupBox1Laporan = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1jnisLporan = new ComboBox();
            dtpMulai = new DateTimePicker();
            dtmselesai = new DateTimePicker();
            comboBox1kt = new ComboBox();
            panel1 = new Panel();
            btmTampil = new Button();
            btnexport = new Button();
            btnPDF = new Button();
            btnBERSIH = new Button();
            groupBox1Laporan.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1Laporan
            // 
            groupBox1Laporan.Controls.Add(comboBox1kt);
            groupBox1Laporan.Controls.Add(dtmselesai);
            groupBox1Laporan.Controls.Add(dtpMulai);
            groupBox1Laporan.Controls.Add(comboBox1jnisLporan);
            groupBox1Laporan.Controls.Add(label4);
            groupBox1Laporan.Controls.Add(label3);
            groupBox1Laporan.Controls.Add(label2);
            groupBox1Laporan.Controls.Add(label1);
            groupBox1Laporan.Location = new Point(26, 44);
            groupBox1Laporan.Name = "groupBox1Laporan";
            groupBox1Laporan.Size = new Size(463, 201);
            groupBox1Laporan.TabIndex = 0;
            groupBox1Laporan.TabStop = false;
            groupBox1Laporan.Text = "Filter Laporan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 42);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Jenis Laporan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 86);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 1;
            label2.Text = "Tanggal Mulai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 120);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 2;
            label3.Text = "Tanggal selesai";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 152);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Kategori";
            // 
            // comboBox1jnisLporan
            // 
            comboBox1jnisLporan.FormattingEnabled = true;
            comboBox1jnisLporan.Location = new Point(139, 41);
            comboBox1jnisLporan.Name = "comboBox1jnisLporan";
            comboBox1jnisLporan.Size = new Size(200, 23);
            comboBox1jnisLporan.TabIndex = 4;
            // 
            // dtpMulai
            // 
            dtpMulai.Location = new Point(139, 80);
            dtpMulai.Name = "dtpMulai";
            dtpMulai.Size = new Size(200, 23);
            dtpMulai.TabIndex = 5;
            // 
            // dtmselesai
            // 
            dtmselesai.Location = new Point(139, 114);
            dtmselesai.Name = "dtmselesai";
            dtmselesai.Size = new Size(200, 23);
            dtmselesai.TabIndex = 6;
            // 
            // comboBox1kt
            // 
            comboBox1kt.FormattingEnabled = true;
            comboBox1kt.Location = new Point(139, 149);
            comboBox1kt.Name = "comboBox1kt";
            comboBox1kt.Size = new Size(200, 23);
            comboBox1kt.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBERSIH);
            panel1.Controls.Add(btnPDF);
            panel1.Controls.Add(btnexport);
            panel1.Controls.Add(btmTampil);
            panel1.Location = new Point(529, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 198);
            panel1.TabIndex = 1;
            // 
            // btmTampil
            // 
            btmTampil.Location = new Point(23, 16);
            btmTampil.Name = "btmTampil";
            btmTampil.Size = new Size(102, 38);
            btmTampil.TabIndex = 0;
            btmTampil.Text = "Tampilan";
            btmTampil.UseVisualStyleBackColor = true;
            // 
            // btnexport
            // 
            btnexport.Location = new Point(23, 60);
            btnexport.Name = "btnexport";
            btnexport.Size = new Size(102, 38);
            btnexport.TabIndex = 1;
            btnexport.Text = "Export Excel";
            btnexport.UseVisualStyleBackColor = true;
            // 
            // btnPDF
            // 
            btnPDF.Location = new Point(23, 102);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(102, 38);
            btnPDF.TabIndex = 2;
            btnPDF.Text = "Export PDF";
            btnPDF.UseVisualStyleBackColor = true;
            // 
            // btnBERSIH
            // 
            btnBERSIH.Location = new Point(23, 146);
            btnBERSIH.Name = "btnBERSIH";
            btnBERSIH.Size = new Size(102, 38);
            btnBERSIH.TabIndex = 3;
            btnBERSIH.Text = "Bersihkan";
            btnBERSIH.UseVisualStyleBackColor = true;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(groupBox1Laporan);
            Name = "Form8";
            Text = "Lporan";
            groupBox1Laporan.ResumeLayout(false);
            groupBox1Laporan.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1Laporan;
        private ComboBox comboBox1kt;
        private DateTimePicker dtmselesai;
        private DateTimePicker dtpMulai;
        private ComboBox comboBox1jnisLporan;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button btnBERSIH;
        private Button btnPDF;
        private Button btnexport;
        private Button btmTampil;
    }
}