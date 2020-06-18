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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var db = new Database();
            //drvData.DataSource = db.SelectData(null);
            var dn = new frmLogin();
            dn.ShowDialog();//Load form đăng nhập khi form main đc gọi
            //Lấy tk và mk
            var tk = dn.username;
            var mk = dn.password;
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void btnqlct_Click(object sender, EventArgs e)
        {
            var main = new frmDSCT();
            main.ShowDialog();//Load form đăng nhập khi form main đc gọi
        }

        private void btnqlhlv_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng chưa xog :))))))");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn muốn thoát chương trình ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(a==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
