using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiBaoBTL
{
    public partial class LichTour : Form
    {
        KetNoi_Database dtBase = new KetNoi_Database();
        public LichTour()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dtLichTour = dtBase.SelectData("Select * from LichTour where DaKhoiHanh ='0'");
            dgvLichTour.DataSource = dtLichTour;
            dgvLichTour.Columns[0].HeaderText = "Mã lịch tour";
            dgvLichTour.Columns[1].HeaderText = "Mã công ty";
            dgvLichTour.Columns[2].HeaderText = "Mã Tour";
            dgvLichTour.Columns[3].HeaderText = "Mã HDV";
            dgvLichTour.Columns[4].HeaderText = "Ngày khỏi hành";
            dgvLichTour.Columns[5].HeaderText = "Số người ĐK";
            dgvLichTour.Columns[6].HeaderText = "Tổng tiền";
            dgvLichTour.Columns[7].HeaderText = "Đã khởi hành";


            DataTable dtMaCongTy = dtBase.SelectData("Select MaCongTy from CongTy");
            cbMaCongTy.DataSource = dtMaCongTy;
            cbMaCongTy.DisplayMember = "MaCongTy";

            DataTable dtMaTour = dtBase.SelectData("Select MaTour from DanhMucTour ");
            cbMaTour.DataSource = dtMaTour;
            cbMaTour.DisplayMember = "MaTour";

            DataTable dtMaHDV = dtBase.SelectData("Select MaHDV from HuongDanVien ");
            cbMaHDV.DataSource = dtMaHDV;

            cbMaHDV.DisplayMember = "MaHDV";
        }

        private void dgvLichTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbMaLichTour.Text = dgvLichTour.CurrentRow.Cells[0].Value.ToString();
            cbMaCongTy.Text = dgvLichTour.CurrentRow.Cells[1].Value.ToString();
            cbMaTour.Text = dgvLichTour.CurrentRow.Cells[2].Value.ToString();
            cbMaHDV.Text = dgvLichTour.CurrentRow.Cells[3].Value.ToString();
            dtpNgayKhoiHanh.Text = dgvLichTour.CurrentRow.Cells[4].Value.ToString();
            txtSoNguoiDK.Text = dgvLichTour.CurrentRow.Cells[5].Value.ToString();
            txtTongTien.Text = dgvLichTour.CurrentRow.Cells[6].Value.ToString();
            string khoiHanh= dgvLichTour.CurrentRow.Cells[7].Value.ToString();
            if(khoiHanh == "1")
            {
                ckbDaKhoiHanh.Checked=true;
            }
            else
            {
                ckbDaKhoiHanh.Checked = false;
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cbMaLichTour.Text = null;
            cbMaCongTy.Text = null;
            cbMaTour.Text = null;
            cbMaHDV.Text = null;
            dtpNgayKhoiHanh.Text = null;
            txtSoNguoiDK.Text = null;
            txtTongTien.Text=null;
            ckbDaKhoiHanh.Checked = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String khoiHanh;
            if (ckbDaKhoiHanh.Checked == true)
            {
                khoiHanh = "1";

            }
            else
            {
                khoiHanh = "0";
            }
            dtBase.UpdateData("insert into LichTour values('" + cbMaLichTour.Text + "',N'" 
                + cbMaCongTy.Text + "',N'" + cbMaTour.Text + "',N'"
                + cbMaHDV.Text + "',N'" + dtpNgayKhoiHanh.Text +
                        "',N'" + txtSoNguoiDK.Text + "','" + txtTongTien.Text +"','"+khoiHanh+ "')");
            MessageBox.Show("Bạn đã thêm mới thành công");
            dgvLichTour.DataSource = dtBase.SelectData("Select * from LichTour where DaKhoiHanh='0'");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String khoiHanh;
            if (ckbDaKhoiHanh.Checked == true)
            {
                khoiHanh = "1";

            }
            else
            {
                khoiHanh = "0";
            }
            dtBase.UpdateData("update LichTour set MaCongTy=N'" + cbMaCongTy.Text + "',MaTour='" +
                "" + cbMaTour.Text + "',MaHDV=N'" + cbMaHDV.Text + "',NgayKhoiHanh='" + dtpNgayKhoiHanh.Text +
                "',SoNguoiDangKy='" + txtSoNguoiDK.Text + "',TongTien='" + txtTongTien.Text +
                "',DaKhoiHanh='" + khoiHanh+ "'where MaLichTour='" + cbMaLichTour.Text + "'");
            MessageBox.Show("Bạn đã sửa thành công");
            dgvLichTour.DataSource = dtBase.SelectData("Select * from LichTour where DaKhoiHanh='0'");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa chất liệu có mã là:" + cbMaLichTour.Text + " không?", "Thông báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                dtBase.UpdateData("delete LichTour where MaLichTour='" + cbMaLichTour.Text + "'");
                dgvLichTour.DataSource = dtBase.SelectData("Select * from LichTour where DaKhoiHanh='0'");

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ko?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbMaCongTy_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dtMaTour = dtBase.SelectData("Select MaTour from DanhMucTour where MaCongTy='" + cbMaCongTy.Text + "'");
            cbMaTour.DataSource = dtMaTour;
            cbMaTour.DisplayMember = "MaTour";

            DataTable dtMaHDV = dtBase.SelectData("Select MaHDV from HuongDanVien where MaCongTy='" + cbMaCongTy.Text + "'");
            cbMaHDV.DataSource = dtMaHDV;

            cbMaHDV.DisplayMember = "MaHDV";
        }

        
    }
}
