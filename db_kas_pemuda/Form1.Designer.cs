namespace db_kas_pemuda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbRol = new ComboBox();
            txtPw = new TextBox();
            txtUser = new TextBox();
            btnLog = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 66);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 118);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateBlue;
            label3.Location = new Point(59, 216);
            label3.Name = "label3";
            label3.Size = new Size(189, 47);
            label3.TabIndex = 2;
            label3.Text = "Sistem Informasi Pengelolaan Kas Pemuda";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 166);
            label4.Name = "label4";
            label4.Size = new Size(63, 17);
            label4.TabIndex = 3;
            label4.Text = "Pilih Role";
            // 
            // cmbRol
            // 
            cmbRol.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Admin", "Bendahara" });
            cmbRol.Location = new Point(108, 165);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(196, 23);
            cmbRol.TabIndex = 8;
            cmbRol.Text = "Pilih Role";
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;
            // 
            // txtPw
            // 
            txtPw.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPw.Location = new Point(108, 110);
            txtPw.Name = "txtPw";
            txtPw.Size = new Size(196, 23);
            txtPw.TabIndex = 7;
            txtPw.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(108, 66);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(198, 23);
            txtUser.TabIndex = 6;
            txtUser.Text = "Username";
            // 
            // btnLog
            // 
            btnLog.BackColor = Color.RoyalBlue;
            btnLog.ForeColor = SystemColors.Control;
            btnLog.Location = new Point(29, 212);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(277, 34);
            btnLog.TabIndex = 4;
            btnLog.Text = "LOGIN";
            btnLog.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(89, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateBlue;
            label5.Location = new Point(100, 187);
            label5.Name = "label5";
            label5.Size = new Size(98, 32);
            label5.TabIndex = 6;
            label5.Text = "SIPKAP";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(btnLog);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbRol);
            panel1.Controls.Add(txtPw);
            panel1.Controls.Add(txtUser);
            panel1.Location = new Point(328, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 291);
            panel1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkSlateBlue;
            label6.Location = new Point(27, 16);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 9;
            label6.Text = "Login";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(255, 406);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 8;
            label7.Text = "2026 SIPKAP";
            label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 464);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            ForeColor = Color.DarkSlateBlue;
            Name = "Form1";
            Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private ComboBox cmbRol;
        private TextBox txtPw;
        private TextBox txtUser;
        private Button btnLog;
        private Label label5;
        private Panel panel1;
        private Label label6;
        private Label label7;
    }
}
