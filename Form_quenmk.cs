using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_btl
{
    public partial class Form_quenmk : Form
    {
        public Form_quenmk()
        {
            InitializeComponent();
        }

        private bool isPhoneNumberValid = false;

        private void guna_txtsodienthoai_TextChanged(object sender, EventArgs e)
        {
            
            string phoneNumber = guna_txtsodienthoai.Text;

            
            if (phoneNumber == "0123456789")
            {
                isPhoneNumberValid = true;
            }
            else
            {
                isPhoneNumberValid = false;
            }
        }

        private void guna_txtsodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

      
            if (guna_txtsodienthoai.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna_btn_dongy_Click(object sender, EventArgs e)
        {
            string phoneNumber = guna_txtsodienthoai.Text;

            if (phoneNumber.Length == 10)
            {
                if (phoneNumber.All(char.IsDigit) && phoneNumber == "0123456789")
                {
                    MessageBox.Show("Tài khoản: admin, mật khẩu: 123");
                }
                else
                {
                    MessageBox.Show("Số điện thoại không đúng!", "Thông báo!");
                }
            }
            else
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập lại.");
            }
        }


        private void guna_txtsodienthoai_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự vừa nhập có phải là số không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Từ chối ký tự không phải số
            }

            // Giới hạn độ dài tối đa là 10 chữ số
            if (guna_txtsodienthoai.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna_btn_ve_Click(object sender, EventArgs e)
        {
          
            DialogResult result = MessageBox.Show("Bạn có muốn trở về màn hình đăng nhập không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
              
                this.Hide(); 
                Login loginForm = new Login();
                loginForm.Show();
            }
        }

    }
}
