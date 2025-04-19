using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyHangHoa
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (TH_DangNhap.Text == "" || TH_MatKhau.Text == "")
            {
                Login_Result.Text = "Vui lòng điền đầy đủ tên đăng nhập và mật khẩu";
                return;
            }
            else
            {
                Login_Result.Text = "Đăng nhập thành công!";
                this.Hide();
                MainForm mf = new MainForm();
                mf.Show();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
