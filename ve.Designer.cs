namespace demo_btl
{
    partial class ve
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
            this.txtmashow = new System.Windows.Forms.TextBox();
            this.txtmaghe = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Show";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Ghế";
            // 
            // txtmashow
            // 
            this.txtmashow.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmashow.Location = new System.Drawing.Point(191, 50);
            this.txtmashow.Margin = new System.Windows.Forms.Padding(3, 2, 2, 3);
            this.txtmashow.Name = "txtmashow";
            this.txtmashow.Size = new System.Drawing.Size(284, 34);
            this.txtmashow.TabIndex = 2;
            this.txtmashow.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtmaghe
            // 
            this.txtmaghe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaghe.Location = new System.Drawing.Point(191, 110);
            this.txtmaghe.Name = "txtmaghe";
            this.txtmaghe.Size = new System.Drawing.Size(284, 34);
            this.txtmaghe.TabIndex = 3;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(31, 183);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(100, 39);
            this.btnthem.TabIndex = 4;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(176, 183);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(100, 39);
            this.btnsua.TabIndex = 5;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(329, 183);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(100, 39);
            this.btnxoa.TabIndex = 6;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(482, 183);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(100, 39);
            this.btnluu.TabIndex = 7;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(551, 184);
            this.dataGridView1.TabIndex = 8;
            // 
            // ve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtmaghe);
            this.Controls.Add(this.txtmashow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ve";
            this.Text = "ve";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmashow;
        private System.Windows.Forms.TextBox txtmaghe;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}