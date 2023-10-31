namespace demo_btl
{
    partial class Giochieu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_marap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_magiochieu = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã rạp";
            // 
            // txt_marap
            // 
            this.txt_marap.Location = new System.Drawing.Point(259, 40);
            this.txt_marap.Name = "txt_marap";
            this.txt_marap.Size = new System.Drawing.Size(215, 20);
            this.txt_marap.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đơn giá";
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(259, 110);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(215, 20);
            this.txt_dongia.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã giờ chiếu";
            // 
            // txt_magiochieu
            // 
            this.txt_magiochieu.Location = new System.Drawing.Point(259, 75);
            this.txt_magiochieu.Name = "txt_magiochieu";
            this.txt_magiochieu.Size = new System.Drawing.Size(215, 20);
            this.txt_magiochieu.TabIndex = 1;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(83, 188);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 2;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(197, 188);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(326, 188);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(442, 188);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 23);
            this.btn_luu.TabIndex = 2;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(655, 224);
            this.dataGridView1.TabIndex = 3;
            // 
            // Giochieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_magiochieu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_marap);
            this.Controls.Add(this.label1);
            this.Name = "Giochieu";
            this.Text = "Giochieu";
            this.Load += new System.EventHandler(this.Giochieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_marap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_magiochieu;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}