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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            gbLogin = new GroupBox();
            pictureBox1 = new PictureBox();
            btnLog = new Button();
            btnKel = new Button();
            txtUser = new TextBox();
            txtPw = new TextBox();
            cmbRol = new ComboBox();
            gbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 97);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(79, 192);
            label3.Name = "label3";
            label3.Size = new Size(189, 47);
            label3.TabIndex = 2;
            label3.Text = "Sistem Informasi Pengelolaan Kas Pemuda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 144);
            label4.Name = "label4";
            label4.Size = new Size(63, 17);
            label4.TabIndex = 3;
            label4.Text = "Pilih Role";
            // 
            // gbLogin
            // 
            gbLogin.BackColor = SystemColors.Control;
            gbLogin.Controls.Add(cmbRol);
            gbLogin.Controls.Add(txtPw);
            gbLogin.Controls.Add(txtUser);
            gbLogin.Controls.Add(btnKel);
            gbLogin.Controls.Add(btnLog);
            gbLogin.Controls.Add(label1);
            gbLogin.Controls.Add(label4);
            gbLogin.Controls.Add(label2);
            gbLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbLogin.Location = new Point(278, 72);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(345, 253);
            gbLogin.TabIndex = 4;
            gbLogin.TabStop = false;
            gbLogin.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_9_Agu_2026__13_55_19;
            pictureBox1.Location = new Point(79, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnLog
            // 
            btnLog.BackColor = Color.DodgerBlue;
            btnLog.Location = new Point(29, 199);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(91, 30);
            btnLog.TabIndex = 4;
            btnLog.Text = "LOGIN";
            btnLog.UseVisualStyleBackColor = false;
            // 
            // btnKel
            // 
            btnKel.BackColor = Color.DodgerBlue;
            btnKel.Location = new Point(206, 199);
            btnKel.Name = "btnKel";
            btnKel.Size = new Size(87, 30);
            btnKel.TabIndex = 5;
            btnKel.Text = "KELUAR";
            btnKel.UseVisualStyleBackColor = false;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(95, 40);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(198, 25);
            txtUser.TabIndex = 6;
            // 
            // txtPw
            // 
            txtPw.Location = new Point(97, 91);
            txtPw.Name = "txtPw";
            txtPw.Size = new Size(196, 25);
            txtPw.TabIndex = 7;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Admin", "Bendahara" });
            cmbRol.Location = new Point(97, 144);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(196, 25);
            cmbRol.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 398);
            Controls.Add(pictureBox1);
            Controls.Add(gbLogin);
            Controls.Add(label3);
            Name = "Form1";
            Text = "LOGIN";
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox gbLogin;
        private PictureBox pictureBox1;
        private ComboBox cmbRol;
        private TextBox txtPw;
        private TextBox txtUser;
        private Button btnKel;
        private Button btnLog;
    }
}
