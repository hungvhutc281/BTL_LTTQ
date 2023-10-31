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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txt_mk.UseSystemPasswordChar = true;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_tk_TextChanged(object sender, EventArgs e)
        {
            string taikhoan = txt_tk.Text;
        }

        private string maskedPassword = "";

        private void txt_mk_TextChanged(object sender, EventArgs e)
        {
            txt_mk.UseSystemPasswordChar = true;

            string matkhau = txt_mk.Text;
            if (matkhau.StartsWith("1") && txt_tk.Text == "admin")
            {

                txt_mk.UseSystemPasswordChar = false;
            }
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txt_tk.Text; 
            string matKhau = txt_mk.Text; 

          
            if (KiemTraDangNhap(taiKhoan, matKhau))
            {
               
                Main mainForm = new Main();

             
                mainForm.ShowDialog();

              
            }
            else
            {
                MessageBox.Show("Vui lòng xem bạn đã nhập đủ thông tin hoặc thông tin tài khoản và mật khẩu đã bị lỗi !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool KiemTraDangNhap(string taiKhoan, string matKhau)
        {
          
            if (taiKhoan == "admin" && matKhau == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_quen_Click(object sender, EventArgs e)
        {
       
               Form_quenmk mk =new Form_quenmk();
               mk.ShowDialog();
            
        }

      

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
           
              DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    e.Cancel = true; 
                }
            

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
