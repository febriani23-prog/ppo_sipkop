namespace db_kas_pemuda
{
    partial class Form3
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtnamaAng = new TextBox();
            txtAlmatt = new TextBox();
            txtNohp = new TextBox();
            cmbStatus = new ComboBox();
            button1 = new Button();
            btnUbhh = new Button();
            btnHapus = new Button();
            btnbersih = new Button();
            label6 = new Label();
            label7 = new Label();
            txtCarii = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(30, 26);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 0;
            label1.Text = "Data Anggota";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnbersih);
            groupBox1.Controls.Add(btnHapus);
            groupBox1.Controls.Add(btnUbhh);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(cmbStatus);
            groupBox1.Controls.Add(txtNohp);
            groupBox1.Controls.Add(txtAlmatt);
            groupBox1.Controls.Add(txtnamaAng);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(38, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(677, 250);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Form Input Anggota";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 43);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 0;
            label2.Text = "Nama ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 100);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 1;
            label3.Text = "Alamat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 159);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 2;
            label4.Text = "No.HP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 194);
            label5.Name = "label5";
            label5.Size = new Size(46, 17);
            label5.TabIndex = 3;
            label5.Text = "Status";
            // 
            // txtnamaAng
            // 
            txtnamaAng.Location = new Point(130, 43);
            txtnamaAng.Name = "txtnamaAng";
            txtnamaAng.Size = new Size(228, 25);
            txtnamaAng.TabIndex = 4;
            // 
            // txtAlmatt
            // 
            txtAlmatt.Location = new Point(130, 78);
            txtAlmatt.Multiline = true;
            txtAlmatt.Name = "txtAlmatt";
            txtAlmatt.Size = new Size(228, 64);
            txtAlmatt.TabIndex = 5;
            // 
            // txtNohp
            // 
            txtNohp.Location = new Point(130, 150);
            txtNohp.Name = "txtNohp";
            txtNohp.Size = new Size(165, 25);
            txtNohp.TabIndex = 6;
            // 
            // cmbStatus
            // 
            cmbStatus.AutoCompleteCustomSource.AddRange(new string[] { "Aktif", "Non Aktif" });
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(130, 185);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(165, 25);
            cmbStatus.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(474, 45);
            button1.Name = "button1";
            button1.Size = new Size(95, 41);
            button1.TabIndex = 8;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnUbhh
            // 
            btnUbhh.BackColor = Color.FromArgb(0, 192, 192);
            btnUbhh.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUbhh.Location = new Point(474, 93);
            btnUbhh.Name = "btnUbhh";
            btnUbhh.Size = new Size(95, 39);
            btnUbhh.TabIndex = 9;
            btnUbhh.Text = "Ubah";
            btnUbhh.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.LightCoral;
            btnHapus.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHapus.Location = new Point(474, 138);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(95, 40);
            btnHapus.TabIndex = 10;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // btnbersih
            // 
            btnbersih.BackColor = Color.Silver;
            btnbersih.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbersih.ForeColor = SystemColors.ControlText;
            btnbersih.Location = new Point(474, 185);
            btnbersih.Name = "btnbersih";
            btnbersih.Size = new Size(95, 44);
            btnbersih.TabIndex = 11;
            btnbersih.Text = "Bersihkan";
            btnbersih.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DodgerBlue;
            label6.Location = new Point(30, 339);
            label6.Name = "label6";
            label6.Size = new Size(128, 21);
            label6.TabIndex = 2;
            label6.Text = "Daftar Anggota";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(512, 345);
            label7.Name = "label7";
            label7.Size = new Size(31, 17);
            label7.TabIndex = 3;
            label7.Text = "Cari";
            // 
            // txtCarii
            // 
            txtCarii.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarii.Location = new Point(558, 339);
            txtCarii.Name = "txtCarii";
            txtCarii.Size = new Size(146, 23);
            txtCarii.TabIndex = 4;
            txtCarii.Text = "cari keterangan........";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 372);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(677, 150);
            dataGridView1.TabIndex = 5;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 569);
            Controls.Add(dataGridView1);
            Controls.Add(txtCarii);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form3";
            Text = "DATA ANGGOTA";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cmbStatus;
        private TextBox txtNohp;
        private TextBox txtAlmatt;
        private TextBox txtnamaAng;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnbersih;
        private Button btnHapus;
        private Button btnUbhh;
        private Button button1;
        private Label label6;
        private Label label7;
        private TextBox txtCarii;
        private DataGridView dataGridView1;
    }
}