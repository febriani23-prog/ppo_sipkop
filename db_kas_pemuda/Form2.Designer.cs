namespace db_kas_pemuda
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label12 = new Label();
            btnDashboard = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(23, 17);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 596);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_9_Agu_2026__13_55_19;
            pictureBox1.Location = new Point(59, 17);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(333, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 33);
            label1.TabIndex = 1;
            label1.Text = "Dashboard";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DodgerBlue;
            label9.Location = new Point(17, 17);
            label9.Name = "label9";
            label9.Size = new Size(199, 21);
            label9.TabIndex = 2;
            label9.Text = "Selamat Datang di SIPKAP";
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(17, 53);
            label10.Name = "label10";
            label10.Size = new Size(265, 38);
            label10.TabIndex = 3;
            label10.Text = "Sistem Informasi Pengelolaan Kas Pemuda Kelola data keuangan organisasi dengan mudah dan akurat";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DodgerBlue;
            label11.Location = new Point(912, 17);
            label11.Name = "label11";
            label11.Size = new Size(146, 17);
            label11.TabIndex = 4;
            label11.Text = "Selamat datang,Admin";
            // 
            // panel2
            // 
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(333, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 101);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(label12);
            panel3.Location = new Point(333, 206);
            panel3.Name = "panel3";
            panel3.Size = new Size(149, 100);
            panel3.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(45, 33);
            label12.Name = "label12";
            label12.Size = new Size(66, 21);
            label12.TabIndex = 0;
            label12.Text = "label12";
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.Location = new Point(59, 122);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(140, 38);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 630);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label11);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form2";
            Text = "DASHBOARD";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label9;
        private Label label10;
        private Label label11;
        private Panel panel2;
        private Panel panel3;
        private Label label12;
        private Button btnDashboard;
    }
}