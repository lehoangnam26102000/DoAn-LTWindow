using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDoiBong_DoAn
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtMatkhau_Click(object sender, EventArgs e)
        {

        }
        public string username = "admin";
        public string password = "12345";
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTendangnhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
                txtTendangnhap.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
                txtMatKhau.Select();
                return;
            }
            if(txtTendangnhap.Text.Equals(username)&&txtMatKhau.Text.Equals(password))
            {
                this.Dispose();
                new frmDSCT().LoadDSCT();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai, vui lòng đăng nhập lại");
                new frmLogin();
            }
        }

        /*private void frmLogin_Load(object sender, EventArgs e)
        {
            //var dn = new frmLogin();
            frmLogin.//Load form đăng nhập khi form main đc gọi
            //Lấy tk và mk
            var tk = username;
            var mk = password;
        }*/
    }
}
