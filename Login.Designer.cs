namespace demo_btl
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_1 = new System.Windows.Forms.PictureBox();
            this.panel_chuakhung = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_quen = new System.Windows.Forms.Button();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic_admin = new System.Windows.Forms.PictureBox();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.label_matkhau = new System.Windows.Forms.Label();
            this.label_taikhoan = new System.Windows.Forms.Label();
            this.label_tieude = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).BeginInit();
            this.panel_chuakhung.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.pic_1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 501);
            this.panel1.TabIndex = 0;
            // 
            // pic_1
            // 
            this.pic_1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pic_1.Image = global::demo_btl.Properties.Resources.movie3;
            this.pic_1.Location = new System.Drawing.Point(3, 11);
            this.pic_1.Name = "pic_1";
            this.pic_1.Size = new System.Drawing.Size(466, 482);
            this.pic_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_1.TabIndex = 0;
            this.pic_1.TabStop = false;
            // 
            // panel_chuakhung
            // 
            this.panel_chuakhung.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_chuakhung.Controls.Add(this.panel3);
            this.panel_chuakhung.Controls.Add(this.groupBox1);
            this.panel_chuakhung.Controls.Add(this.label_tieude);
            this.panel_chuakhung.Location = new System.Drawing.Point(496, 1);
            this.panel_chuakhung.Name = "panel_chuakhung";
            this.panel_chuakhung.Size = new System.Drawing.Size(362, 493);
            this.panel_chuakhung.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.btn_quen);
            this.panel3.Controls.Add(this.btn_dangnhap);
            this.panel3.Location = new System.Drawing.Point(7, 329);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 142);
            this.panel3.TabIndex = 2;
            // 
            // btn_quen
            // 
            this.btn_quen.Location = new System.Drawing.Point(185, 40);
            this.btn_quen.Name = "btn_quen";
            this.btn_quen.Size = new System.Drawing.Size(114, 34);
            this.btn_quen.TabIndex = 0;
            this.btn_quen.Text = "QUÊN MẬT KHẢU";
            this.btn_quen.UseVisualStyleBackColor = true;
            this.btn_quen.Click += new System.EventHandler(this.btn_quen_Click);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Location = new System.Drawing.Point(24, 40);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(124, 34);
            this.btn_dangnhap.TabIndex = 0;
            this.btn_dangnhap.Text = "ĐĂNG NHẬP";
            this.btn_dangnhap.UseVisualStyleBackColor = true;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.pic_admin);
            this.groupBox1.Controls.Add(this.txt_mk);
            this.groupBox1.Controls.Add(this.txt_tk);
            this.groupBox1.Controls.Add(this.label_matkhau);
            this.groupBox1.Controls.Add(this.label_taikhoan);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 258);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng nhập ";
            // 
            // pic_admin
            // 
            this.pic_admin.Image = global::demo_btl.Properties.Resources.admin;
            this.pic_admin.Location = new System.Drawing.Point(129, 25);
            this.pic_admin.Name = "pic_admin";
            this.pic_admin.Size = new System.Drawing.Size(105, 88);
            this.pic_admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_admin.TabIndex = 2;
            this.pic_admin.TabStop = false;
            // 
            // txt_mk
            // 
            this.txt_mk.Location = new System.Drawing.Point(129, 212);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(170, 26);
            this.txt_mk.TabIndex = 1;
            this.txt_mk.TextChanged += new System.EventHandler(this.txt_mk_TextChanged);
            // 
            // txt_tk
            // 
            this.txt_tk.Location = new System.Drawing.Point(129, 153);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(170, 26);
            this.txt_tk.TabIndex = 1;
            this.txt_tk.TextChanged += new System.EventHandler(this.txt_tk_TextChanged);
            // 
            // label_matkhau
            // 
            this.label_matkhau.AutoSize = true;
            this.label_matkhau.Location = new System.Drawing.Point(20, 219);
            this.label_matkhau.Name = "label_matkhau";
            this.label_matkhau.Size = new System.Drawing.Size(84, 19);
            this.label_matkhau.TabIndex = 0;
            this.label_matkhau.Text = "Mật khẩu :";
            // 
            // label_taikhoan
            // 
            this.label_taikhoan.AutoSize = true;
            this.label_taikhoan.Location = new System.Drawing.Point(20, 153);
            this.label_taikhoan.Name = "label_taikhoan";
            this.label_taikhoan.Size = new System.Drawing.Size(85, 19);
            this.label_taikhoan.TabIndex = 0;
            this.label_taikhoan.Text = "Tài khoản :";
            // 
            // label_tieude
            // 
            this.label_tieude.AutoSize = true;
            this.label_tieude.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_tieude.Font = new System.Drawing.Font("Snap ITC", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tieude.Location = new System.Drawing.Point(3, 11);
            this.label_tieude.Name = "label_tieude";
            this.label_tieude.Size = new System.Drawing.Size(341, 51);
            this.label_tieude.TabIndex = 0;
            this.label_tieude.Text = "Quản Lý Phim";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(852, 497);
            this.Controls.Add(this.panel_chuakhung);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(911, 536);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).EndInit();
            this.panel_chuakhung.ResumeLayout(false);
            this.panel_chuakhung.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_chuakhung;
        private System.Windows.Forms.Label label_tieude;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pic_admin;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.Label label_matkhau;
        private System.Windows.Forms.Label label_taikhoan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_quen;
        private System.Windows.Forms.Button btn_dangnhap;
    }
}