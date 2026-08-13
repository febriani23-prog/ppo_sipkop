namespace db_kas_pemuda
{
    partial class Form5
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
            groupBox1ktgrorii = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            textBoxnmaktgri = new TextBox();
            comboBoxjnis = new ComboBox();
            panel1tm = new Panel();
            button1ubh = new Button();
            button2hpus = new Button();
            button3brshkn = new Button();
            button4tmbh = new Button();
            groupBox2ktgri = new GroupBox();
            dataGridView1dftr = new DataGridView();
            groupBox1ktgrorii.SuspendLayout();
            panel1tm.SuspendLayout();
            groupBox2ktgri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1dftr).BeginInit();
            SuspendLayout();
            // 
            // groupBox1ktgrorii
            // 
            groupBox1ktgrorii.Controls.Add(comboBoxjnis);
            groupBox1ktgrorii.Controls.Add(textBoxnmaktgri);
            groupBox1ktgrorii.Controls.Add(label2);
            groupBox1ktgrorii.Controls.Add(label1);
            groupBox1ktgrorii.Location = new Point(38, 46);
            groupBox1ktgrorii.Name = "groupBox1ktgrorii";
            groupBox1ktgrorii.Size = new Size(389, 125);
            groupBox1ktgrorii.TabIndex = 1;
            groupBox1ktgrorii.TabStop = false;
            groupBox1ktgrorii.Text = "Form Input kategori";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 25);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama Kategori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 75);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "Jenis";
            // 
            // textBoxnmaktgri
            // 
            textBoxnmaktgri.Location = new Point(127, 25);
            textBoxnmaktgri.Name = "textBoxnmaktgri";
            textBoxnmaktgri.Size = new Size(201, 23);
            textBoxnmaktgri.TabIndex = 2;
            // 
            // comboBoxjnis
            // 
            comboBoxjnis.FormattingEnabled = true;
            comboBoxjnis.Location = new Point(127, 72);
            comboBoxjnis.Name = "comboBoxjnis";
            comboBoxjnis.Size = new Size(201, 23);
            comboBoxjnis.TabIndex = 3;
            // 
            // panel1tm
            // 
            panel1tm.Controls.Add(button4tmbh);
            panel1tm.Controls.Add(button3brshkn);
            panel1tm.Controls.Add(button2hpus);
            panel1tm.Controls.Add(button1ubh);
            panel1tm.Location = new Point(475, 46);
            panel1tm.Name = "panel1tm";
            panel1tm.Size = new Size(200, 162);
            panel1tm.TabIndex = 2;
            // 
            // button1ubh
            // 
            button1ubh.Location = new Point(34, 50);
            button1ubh.Name = "button1ubh";
            button1ubh.Size = new Size(97, 31);
            button1ubh.TabIndex = 0;
            button1ubh.Text = "Ubah";
            button1ubh.UseVisualStyleBackColor = true;
            // 
            // button2hpus
            // 
            button2hpus.Location = new Point(34, 87);
            button2hpus.Name = "button2hpus";
            button2hpus.Size = new Size(97, 31);
            button2hpus.TabIndex = 1;
            button2hpus.Text = "Hapus";
            button2hpus.UseVisualStyleBackColor = true;
            // 
            // button3brshkn
            // 
            button3brshkn.Location = new Point(34, 124);
            button3brshkn.Name = "button3brshkn";
            button3brshkn.Size = new Size(97, 31);
            button3brshkn.TabIndex = 2;
            button3brshkn.Text = "Bersihkan";
            button3brshkn.UseVisualStyleBackColor = true;
            // 
            // button4tmbh
            // 
            button4tmbh.Location = new Point(34, 13);
            button4tmbh.Name = "button4tmbh";
            button4tmbh.Size = new Size(97, 31);
            button4tmbh.TabIndex = 3;
            button4tmbh.Text = "Tambah";
            button4tmbh.UseVisualStyleBackColor = true;
            // 
            // groupBox2ktgri
            // 
            groupBox2ktgri.Controls.Add(dataGridView1dftr);
            groupBox2ktgri.Location = new Point(28, 272);
            groupBox2ktgri.Name = "groupBox2ktgri";
            groupBox2ktgri.Size = new Size(482, 166);
            groupBox2ktgri.TabIndex = 3;
            groupBox2ktgri.TabStop = false;
            groupBox2ktgri.Text = "Daftar Kategori";
            // 
            // dataGridView1dftr
            // 
            dataGridView1dftr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1dftr.Location = new Point(24, 22);
            dataGridView1dftr.Name = "dataGridView1dftr";
            dataGridView1dftr.Size = new Size(441, 138);
            dataGridView1dftr.TabIndex = 0;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2ktgri);
            Controls.Add(panel1tm);
            Controls.Add(groupBox1ktgrorii);
            Name = "Form5";
            Text = "Data kategori";
            groupBox1ktgrorii.ResumeLayout(false);
            groupBox1ktgrorii.PerformLayout();
            panel1tm.ResumeLayout(false);
            groupBox2ktgri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1dftr).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1ktgrorii;
        private ComboBox comboBoxjnis;
        private TextBox textBoxnmaktgri;
        private Label label2;
        private Label label1;
        private Panel panel1tm;
        private Button button4tmbh;
        private Button button3brshkn;
        private Button button2hpus;
        private Button button1ubh;
        private GroupBox groupBox2ktgri;
        private DataGridView dataGridView1dftr;
    }
}