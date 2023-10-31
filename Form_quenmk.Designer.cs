namespace demo_btl
{
    partial class Form_quenmk
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
            this.guna_btn_dongy = new Guna.UI2.WinForms.Guna2Button();
            this.guna_btn_ve = new Guna.UI2.WinForms.Guna2Button();
            this.label_nhacadmin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna_txtsodienthoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // guna_btn_dongy
            // 
            this.guna_btn_dongy.BorderColor = System.Drawing.Color.Lime;
            this.guna_btn_dongy.BorderRadius = 13;
            this.guna_btn_dongy.BorderThickness = 2;
            this.guna_btn_dongy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna_btn_dongy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna_btn_dongy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna_btn_dongy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna_btn_dongy.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.guna_btn_dongy.ForeColor = System.Drawing.Color.White;
            this.guna_btn_dongy.Location = new System.Drawing.Point(71, 278);
            this.guna_btn_dongy.Name = "guna_btn_dongy";
            this.guna_btn_dongy.Size = new System.Drawing.Size(129, 45);
            this.guna_btn_dongy.TabIndex = 0;
            this.guna_btn_dongy.Text = "Đồng Ý";
            this.guna_btn_dongy.Click += new System.EventHandler(this.guna_btn_dongy_Click);
            // 
            // guna_btn_ve
            // 
            this.guna_btn_ve.BorderColor = System.Drawing.Color.Lime;
            this.guna_btn_ve.BorderRadius = 13;
            this.guna_btn_ve.BorderThickness = 2;
            this.guna_btn_ve.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna_btn_ve.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna_btn_ve.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna_btn_ve.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna_btn_ve.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.guna_btn_ve.ForeColor = System.Drawing.Color.White;
            this.guna_btn_ve.Location = new System.Drawing.Point(267, 278);
            this.guna_btn_ve.Name = "guna_btn_ve";
            this.guna_btn_ve.Size = new System.Drawing.Size(181, 45);
            this.guna_btn_ve.TabIndex = 0;
            this.guna_btn_ve.Text = "Về màn hình đăng nhập";
            this.guna_btn_ve.Click += new System.EventHandler(this.guna_btn_ve_Click);
            // 
            // label_nhacadmin
            // 
            this.label_nhacadmin.AutoSize = true;
            this.label_nhacadmin.BackColor = System.Drawing.SystemColors.Control;
            this.label_nhacadmin.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_nhacadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_nhacadmin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nhacadmin.ForeColor = System.Drawing.Color.Black;
            this.label_nhacadmin.Location = new System.Drawing.Point(29, 82);
            this.label_nhacadmin.Name = "label_nhacadmin";
            this.label_nhacadmin.Size = new System.Drawing.Size(454, 15);
            this.label_nhacadmin.TabIndex = 2;
            this.label_nhacadmin.Text = "NHẬP SỐ ĐIỆN THOẠI CỦA BẠN ĐỂ XÁC MINH LẠI BẠN LÀ ADMIN KHÔNG?";
            this.label_nhacadmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(131, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vui lòng nhập số điện thoại (+84*********)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna_txtsodienthoai
            // 
            this.guna_txtsodienthoai.BorderColor = System.Drawing.Color.LimeGreen;
            this.guna_txtsodienthoai.BorderThickness = 4;
            this.guna_txtsodienthoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna_txtsodienthoai.DefaultText = "";
            this.guna_txtsodienthoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna_txtsodienthoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna_txtsodienthoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna_txtsodienthoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna_txtsodienthoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna_txtsodienthoai.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.guna_txtsodienthoai.ForeColor = System.Drawing.Color.Blue;
            this.guna_txtsodienthoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna_txtsodienthoai.Location = new System.Drawing.Point(96, 163);
            this.guna_txtsodienthoai.Name = "guna_txtsodienthoai";
            this.guna_txtsodienthoai.PasswordChar = '\0';
            this.guna_txtsodienthoai.PlaceholderText = "";
            this.guna_txtsodienthoai.SelectedText = "";
            this.guna_txtsodienthoai.Size = new System.Drawing.Size(312, 58);
            this.guna_txtsodienthoai.TabIndex = 3;
            this.guna_txtsodienthoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna_txtsodienthoai.TextChanged += new System.EventHandler(this.guna_txtsodienthoai_TextChanged);
            this.guna_txtsodienthoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guna_txtsodienthoai_KeyPress_1);
            // 
            // Form_quenmk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(495, 373);
            this.Controls.Add(this.guna_txtsodienthoai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_nhacadmin);
            this.Controls.Add(this.guna_btn_ve);
            this.Controls.Add(this.guna_btn_dongy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_quenmk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_quenmk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna_btn_dongy;
        private Guna.UI2.WinForms.Guna2Button guna_btn_ve;
        private System.Windows.Forms.Label label_nhacadmin;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna_txtsodienthoai;
    }
}