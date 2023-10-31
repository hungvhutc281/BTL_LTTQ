namespace demo_btl
{
    partial class QuanLyPhim
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checklistTheLoai = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.txtNDchinh = new System.Windows.Forms.TextBox();
            this.txtNamDVchinh = new System.Windows.Forms.TextBox();
            this.txtNuDVchinh = new System.Windows.Forms.TextBox();
            this.txtDaoDien = new System.Windows.Forms.TextBox();
            this.txtTongChi = new System.Windows.Forms.TextBox();
            this.dtNgayKC = new System.Windows.Forms.DateTimePicker();
            this.dtNgayKT = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTongThu = new System.Windows.Forms.TextBox();
            this.btn_taianh = new System.Windows.Forms.Button();
            this.dataGridViewQLPhim = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.pic_anhtai = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLPhim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_anhtai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên phim";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checklistTheLoai);
            this.groupBox1.Location = new System.Drawing.Point(38, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 118);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thể loại";
            // 
            // checklistTheLoai
            // 
            this.checklistTheLoai.FormattingEnabled = true;
            this.checklistTheLoai.Items.AddRange(new object[] {
            "Hành động",
            "Hoạt hình",
            "Hài",
            "Viễn tưởng",
            "Phiêu lưu",
            "Gia đình",
            "Tình cảm",
            "Tâm lý"});
            this.checklistTheLoai.Location = new System.Drawing.Point(0, 23);
            this.checklistTheLoai.MultiColumn = true;
            this.checklistTheLoai.Name = "checklistTheLoai";
            this.checklistTheLoai.Size = new System.Drawing.Size(667, 73);
            this.checklistTheLoai.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nội dung chính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nam DV chính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nữ DV chính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày KC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ngày KT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(422, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Đạo diễn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(422, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tổng chi phí";
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Location = new System.Drawing.Point(162, 14);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(133, 26);
            this.txtMaPhim.TabIndex = 10;
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Location = new System.Drawing.Point(162, 52);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(133, 26);
            this.txtTenPhim.TabIndex = 11;
            // 
            // txtNDchinh
            // 
            this.txtNDchinh.Location = new System.Drawing.Point(162, 89);
            this.txtNDchinh.Name = "txtNDchinh";
            this.txtNDchinh.Size = new System.Drawing.Size(133, 26);
            this.txtNDchinh.TabIndex = 12;
            // 
            // txtNamDVchinh
            // 
            this.txtNamDVchinh.Location = new System.Drawing.Point(162, 126);
            this.txtNamDVchinh.Name = "txtNamDVchinh";
            this.txtNamDVchinh.Size = new System.Drawing.Size(133, 26);
            this.txtNamDVchinh.TabIndex = 13;
            // 
            // txtNuDVchinh
            // 
            this.txtNuDVchinh.Location = new System.Drawing.Point(162, 158);
            this.txtNuDVchinh.Name = "txtNuDVchinh";
            this.txtNuDVchinh.Size = new System.Drawing.Size(133, 26);
            this.txtNuDVchinh.TabIndex = 14;
            // 
            // txtDaoDien
            // 
            this.txtDaoDien.Location = new System.Drawing.Point(532, 89);
            this.txtDaoDien.Name = "txtDaoDien";
            this.txtDaoDien.Size = new System.Drawing.Size(172, 26);
            this.txtDaoDien.TabIndex = 15;
            // 
            // txtTongChi
            // 
            this.txtTongChi.Location = new System.Drawing.Point(532, 123);
            this.txtTongChi.Name = "txtTongChi";
            this.txtTongChi.Size = new System.Drawing.Size(172, 26);
            this.txtTongChi.TabIndex = 16;
            // 
            // dtNgayKC
            // 
            this.dtNgayKC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayKC.Location = new System.Drawing.Point(532, 15);
            this.dtNgayKC.Name = "dtNgayKC";
            this.dtNgayKC.Size = new System.Drawing.Size(172, 26);
            this.dtNgayKC.TabIndex = 17;
            // 
            // dtNgayKT
            // 
            this.dtNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayKT.Location = new System.Drawing.Point(532, 51);
            this.dtNgayKT.Name = "dtNgayKT";
            this.dtNgayKT.Size = new System.Drawing.Size(172, 26);
            this.dtNgayKT.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(422, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tổng thu";
            // 
            // txtTongThu
            // 
            this.txtTongThu.Location = new System.Drawing.Point(532, 158);
            this.txtTongThu.Name = "txtTongThu";
            this.txtTongThu.Size = new System.Drawing.Size(172, 26);
            this.txtTongThu.TabIndex = 20;
            // 
            // btn_taianh
            // 
            this.btn_taianh.Location = new System.Drawing.Point(855, 232);
            this.btn_taianh.Name = "btn_taianh";
            this.btn_taianh.Size = new System.Drawing.Size(102, 31);
            this.btn_taianh.TabIndex = 22;
            this.btn_taianh.Text = "Tải ảnh lên";
            this.btn_taianh.UseVisualStyleBackColor = true;
            // 
            // dataGridViewQLPhim
            // 
            this.dataGridViewQLPhim.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewQLPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQLPhim.Location = new System.Drawing.Point(12, 386);
            this.dataGridViewQLPhim.Name = "dataGridViewQLPhim";
            this.dataGridViewQLPhim.RowHeadersWidth = 62;
            this.dataGridViewQLPhim.RowTemplate.Height = 28;
            this.dataGridViewQLPhim.Size = new System.Drawing.Size(1074, 183);
            this.dataGridViewQLPhim.TabIndex = 23;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(87, 328);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(78, 37);
            this.btn_them.TabIndex = 24;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(426, 328);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(76, 37);
            this.btn_sua.TabIndex = 25;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(264, 328);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(78, 37);
            this.btn_xoa.TabIndex = 26;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(576, 328);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(81, 37);
            this.btn_luu.TabIndex = 27;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            // 
            // pic_anhtai
            // 
            this.pic_anhtai.Location = new System.Drawing.Point(832, 22);
            this.pic_anhtai.Name = "pic_anhtai";
            this.pic_anhtai.Size = new System.Drawing.Size(154, 191);
            this.pic_anhtai.TabIndex = 21;
            this.pic_anhtai.TabStop = false;
            // 
            // QuanLyPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1096, 597);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dataGridViewQLPhim);
            this.Controls.Add(this.btn_taianh);
            this.Controls.Add(this.pic_anhtai);
            this.Controls.Add(this.txtTongThu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtNgayKT);
            this.Controls.Add(this.dtNgayKC);
            this.Controls.Add(this.txtTongChi);
            this.Controls.Add(this.txtDaoDien);
            this.Controls.Add(this.txtNuDVchinh);
            this.Controls.Add(this.txtNamDVchinh);
            this.Controls.Add(this.txtNDchinh);
            this.Controls.Add(this.txtTenPhim);
            this.Controls.Add(this.txtMaPhim);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyPhim";
            this.Text = "Phim";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLPhim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_anhtai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checklistTheLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.TextBox txtNDchinh;
        private System.Windows.Forms.TextBox txtNamDVchinh;
        private System.Windows.Forms.TextBox txtNuDVchinh;
        private System.Windows.Forms.TextBox txtDaoDien;
        private System.Windows.Forms.TextBox txtTongChi;
        private System.Windows.Forms.DateTimePicker dtNgayKC;
        private System.Windows.Forms.DateTimePicker dtNgayKT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTongThu;
        private System.Windows.Forms.PictureBox pic_anhtai;
        private System.Windows.Forms.Button btn_taianh;
        private System.Windows.Forms.DataGridView dataGridViewQLPhim;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_luu;
    }
}