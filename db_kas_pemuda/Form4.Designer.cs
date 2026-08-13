namespace db_kas_pemuda
{
    partial class Form4
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtusr = new TextBox();
            txtpw = new TextBox();
            txtnma = new TextBox();
            cmbRoll = new ComboBox();
            btntmbh = new Button();
            btnubh = new Button();
            btnhps = new Button();
            btnbrsh = new Button();
            panel1 = new Panel();
            dataGridViewdta = new DataGridView();
            gbdta = new GroupBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewdta).BeginInit();
            gbdta.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbRoll);
            groupBox1.Controls.Add(txtnma);
            groupBox1.Controls.Add(txtpw);
            groupBox1.Controls.Add(txtusr);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.DodgerBlue;
            groupBox1.Location = new Point(37, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 184);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Form Input User";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(15, 32);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(18, 65);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(18, 97);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Nama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(18, 137);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 1;
            label4.Text = "Role";
            // 
            // txtusr
            // 
            txtusr.Location = new Point(95, 29);
            txtusr.Name = "txtusr";
            txtusr.Size = new Size(177, 23);
            txtusr.TabIndex = 3;
            // 
            // txtpw
            // 
            txtpw.Location = new Point(95, 62);
            txtpw.Name = "txtpw";
            txtpw.Size = new Size(177, 23);
            txtpw.TabIndex = 4;
            // 
            // txtnma
            // 
            txtnma.Location = new Point(95, 97);
            txtnma.Name = "txtnma";
            txtnma.Size = new Size(177, 23);
            txtnma.TabIndex = 5;
            // 
            // cmbRoll
            // 
            cmbRoll.FormattingEnabled = true;
            cmbRoll.Location = new Point(95, 137);
            cmbRoll.Name = "cmbRoll";
            cmbRoll.Size = new Size(177, 23);
            cmbRoll.TabIndex = 6;
            // 
            // btntmbh
            // 
            btntmbh.Location = new Point(26, 12);
            btntmbh.Name = "btntmbh";
            btntmbh.Size = new Size(90, 30);
            btntmbh.TabIndex = 1;
            btntmbh.Text = "Tambah";
            btntmbh.UseVisualStyleBackColor = true;
            // 
            // btnubh
            // 
            btnubh.Location = new Point(26, 48);
            btnubh.Name = "btnubh";
            btnubh.Size = new Size(90, 30);
            btnubh.TabIndex = 2;
            btnubh.Text = "Ubah";
            btnubh.UseVisualStyleBackColor = true;
            // 
            // btnhps
            // 
            btnhps.Location = new Point(26, 84);
            btnhps.Name = "btnhps";
            btnhps.Size = new Size(90, 30);
            btnhps.TabIndex = 3;
            btnhps.Text = "Hapus";
            btnhps.UseVisualStyleBackColor = true;
            // 
            // btnbrsh
            // 
            btnbrsh.Location = new Point(26, 117);
            btnbrsh.Name = "btnbrsh";
            btnbrsh.Size = new Size(90, 30);
            btnbrsh.TabIndex = 4;
            btnbrsh.Text = "bersihkan";
            btnbrsh.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btntmbh);
            panel1.Controls.Add(btnhps);
            panel1.Controls.Add(btnbrsh);
            panel1.Controls.Add(btnubh);
            panel1.Location = new Point(476, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 164);
            panel1.TabIndex = 5;
            // 
            // dataGridViewdta
            // 
            dataGridViewdta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewdta.Location = new Point(0, 22);
            dataGridViewdta.Name = "dataGridViewdta";
            dataGridViewdta.Size = new Size(721, 169);
            dataGridViewdta.TabIndex = 6;
            // 
            // gbdta
            // 
            gbdta.Controls.Add(dataGridViewdta);
            gbdta.Location = new Point(37, 247);
            gbdta.Name = "gbdta";
            gbdta.Size = new Size(721, 191);
            gbdta.TabIndex = 7;
            gbdta.TabStop = false;
            gbdta.Text = "Data User";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbdta);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "Form4";
            Text = "Data Anggota";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewdta).EndInit();
            gbdta.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private ComboBox cmbRoll;
        private TextBox txtnma;
        private TextBox txtpw;
        private TextBox txtusr;
        private Button btntmbh;
        private Button btnubh;
        private Button btnhps;
        private Button btnbrsh;
        private Panel panel1;
        private DataGridView dataGridViewdta;
        private GroupBox gbdta;
    }
}