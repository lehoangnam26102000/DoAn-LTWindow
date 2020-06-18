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
    public partial class frmDSCT : Form
    {
        public frmDSCT()
        {
            InitializeComponent();
        }
        
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmCauThu(null).ShowDialog();//Nếu thêm mới cầu thủ thì macauthu=null
            LoadDSCT();
        }

        private void frmDSCT_Load(object sender, EventArgs e)
        {
            LoadDSCT();//Gọi hàm load lại cầu thủ khi form đc load
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDSCT();
        }
        //Load toàn bộ DSCT khi form được load
        public void LoadDSCT()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = txtTuKhoa.Text
            });
            dgvCauThu.DataSource = new Database().SelectData("SelectAllCauThu", lstPara);
             
            //Đặt lại tên cột
            dgvCauThu.Columns["macauthu"].HeaderText = "Mã cầu thủ";
            dgvCauThu.Columns["tencauthu"].HeaderText = "Tên cầu thủ";
            dgvCauThu.Columns["namthidau"].HeaderText = "Năm bắt đầu thi đấu";
            dgvCauThu.Columns["sotrangopmat"].HeaderText = "Số trận đã đá";
            dgvCauThu.Columns["banthangdaghi"].HeaderText = "số bàn thắng";
            dgvCauThu.Columns["loaicauthu"].HeaderText = "Vị trí";
        }

        private void dgvCauThu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Khi double click vào cầu thủ trên dataGridview sẽ hiển thị ra phần cập nhật cầu thủ
            //Lấy mã cầu thủ
            if(e.RowIndex>=0)
            {
                //Lấy mã cầu thủ
                var mct = dgvCauThu.Rows[e.RowIndex].Cells["macauthu"].Value.ToString();
                //Truyền mã ct vào formCauThu
                new frmCauThu(mct).ShowDialog();
                LoadDSCT();
            }
        }
        //Nút xóa
        public void xoaCT()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@macauthu",
                value = txtTuKhoa.Text
            });
            //load data lên dataGridView
            dgvCauThu.DataSource = new Database().SelectData("xoaCT", lstPara);
        }

        private void txtXoa_Click(object sender, EventArgs e)
        {
            xoaCT();
            MessageBox.Show("Xóa thành công");
            LoadDSCT();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int s = 0;
            int ds=0;
            int kq = r.Next(0, 3);
            if(kq==0)
            {
                s += kq;
                MessageBox.Show("Kết quả là thua");
                txtKQ.Text = s.ToString();
            }
            else if(kq==1)
            {
                s += kq;
                MessageBox.Show("Kết quả là hòa");
                txtKQ.Text = s.ToString();
            }
            else if (kq == 3)
            {
                s += kq;
                MessageBox.Show("Kết quả là thắng");
                txtKQ.Text = s.ToString();
            }
            else
            {
                MessageBox.Show("Đá lại");
            }
            kq += s;
            for (int i = 0; i < 10; i++)
            {
                txtDiemso.Text = dgvCauThu.Rows[i].Cells[i].Value.ToString();
            }
            //txtDiemso.Text = dgvCauThu.Rows[6].Cells[2].Value.ToString();
            /*if(txtDiemso.Text!="Def")
            {
                MessageBox.Show("not ok");
            }
            else
            {
                MessageBox.Show("ok");
            }*/
        }
    }
}
