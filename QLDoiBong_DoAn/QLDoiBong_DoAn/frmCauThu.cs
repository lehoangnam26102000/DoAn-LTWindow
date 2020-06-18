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
    //Thêm mới  hoặc update thông tin cầu thủ
    public partial class frmCauThu : Form
    {
        public frmCauThu(string mct)
        {
            this.mct = mct;
            InitializeComponent();
        }
        private string mct;
        private void frmCauThu_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(mct))//Không có thì thêm mới
            {
                this.Text = "Thêm mới cầu thủ";
            }
            else
            {
                this.Text = "Cập nhật thông tin cầu thủ";
                //Lấy thông tin của 1 cầu thủ dựa vào mã cầu thủ
                //Mã cầu thủ được truyền vào từ dsct
                var change = new Database().Select("selectCT '" + mct+"'");
                //Set các giá trị vào các component(thành phần) của form
                txtMaCT.Text = change["macauthu"].ToString();
                txtTenCT.Text = change["tencauthu"].ToString();
                txtNamThiDau.Text = change["namthidau"].ToString();
                txtSoTran.Text = change["sotrangopmat"].ToString();
                txtBanThang.Text = change["banthangdaghi"].ToString();
                txtLoaiCT.Text = change["loaicauthu"].ToString();
            }
        }
        //Nút lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            
            //khai báo danh sách thamm số = class CustomParamete
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mct))
            {
                sql = "ThemMoiCT";
                /*var a = new CustomParameter()
                {
                    key = "macauthu",
                    value = mct
                };*/
                /*lstPara.Add(new CustomParameter()
                {
                    key = "macauthu",
                    value = mct
                });*/
            }
            else
            {
                sql = "updateCT";
            }
            /*var mact = new CustomParameter()
               {
                   key = "macauthu",
                   value = mct
               };*/
            lstPara.Add(new CustomParameter()
            {
                key = "macauthu",
                value = txtMaCT.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "tencauthu",
                value = txtTenCT.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "loaicauthu",
                value = txtLoaiCT.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "sotrangopmat",
                value = txtSoTran.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "banthangdaghi",
                value = txtBanThang.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "namthidau",
                value = txtNamThiDau.Text
            });
            var rs = new Database().Execute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mct))//Thêm mới ct
                    MessageBox.Show("Thêm mới thành công");
                else
                    MessageBox.Show("Cập nhật thành công");
                this.Dispose();
            }
            else{
                MessageBox.Show("Thực thi thất bại");
            }
        }
        //Nút hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //new frmDSCT().LoadDSCT();
        }
        //Xóa cầu thủ
        /*public void XoaCT()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            var change = new Database().Select("delete from qlCauThu where @macauthu=macauthu '" + mct + "'");
            txtMaCT.Text = change["macauthu"].ToString();
            txtTenCT.Text = change["tencauthu"].ToString();
            txtNamThiDau.Text = change["namthidau"].ToString();
            txtSoTran.Text = change["sotrangopmat"].ToString();
            txtBanThang.Text = change["banthangdaghi"].ToString();
            txtLoaiCT.Text = change["loaicauthu"].ToString();
            lstPara.Remove(new CustomParameter()
            {
                key = "@macauthu",
                value = txtMaCT.Text
            });
            lstPara.Remove(new CustomParameter()
            {
                key = "@tencauthu",
                value = txtTenCT.Text
            });
            lstPara.Remove(new CustomParameter()
            {
                key = "@namthidau",
                value = txtNamThiDau.Text
            });
            lstPara.Remove(new CustomParameter()
            {
                key = "@sobanthangdaghi",
                value = txtBanThang.Text
            });
            lstPara.Remove(new CustomParameter()
            {
                key = "@sotrangopmat",
                value = txtSoTran.Text
            });
            lstPara.Remove(new CustomParameter()
            {
                key = "@loaicauthu",
                value = txtLoaiCT.Text
            });
        }*/

    }
}
