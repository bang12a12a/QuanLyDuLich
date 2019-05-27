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
    public partial class DangKyTour : Form
    {
        KetNoi_Database dtBase = new KetNoi_Database();
        public DangKyTour()
        {
            InitializeComponent();
        }

        private void DangKyTour_Load(object sender, EventArgs e)
        {
            DataTable dtDangKyTour = dtBase.SelectData("Select * from DangKyTour");
            dgvDangKyTour.DataSource = dtDangKyTour;
            dgvDangKyTour.Columns[0].HeaderText = "Mã đăng ký";
            dgvDangKyTour.Columns[1].HeaderText = "Mã khách hàng";
            dgvDangKyTour.Columns[2].HeaderText = "Mã lịch tour";
            dgvDangKyTour.Columns[3].HeaderText = "Ngày đăng ký";
            dgvDangKyTour.Columns[4].HeaderText = "Số lượng đăng ký";
            dgvDangKyTour.Columns[5].HeaderText = "Thành tiền";
           
           
            DataTable dtKhachHang = dtBase.SelectData("Select MaKhach from KhachHang");
            cbMaKhach.DataSource = dtKhachHang;
            cbMaKhach.DisplayMember = "MaKhach";

            DataTable dtLichTour = dtBase.SelectData("Select MaLichTour from LichTour");
            cbMaLichTour.DataSource = dtLichTour;

            cbMaLichTour.DisplayMember = "MaLichtour";
        }

        private void dgvDangKyTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbMaDangKy.Text = dgvDangKyTour.CurrentRow.Cells[0].Value.ToString();
            cbMaKhach.Text = dgvDangKyTour.CurrentRow.Cells[1].Value.ToString();
            cbMaLichTour.Text = dgvDangKyTour.CurrentRow.Cells[2].Value.ToString();
            dtpNgayDangKy.Text = dgvDangKyTour.CurrentRow.Cells[3].Value.ToString();
            txtSoLuongDK.Text = dgvDangKyTour.CurrentRow.Cells[4].Value.ToString();
            txtThanhTien.Text = dgvDangKyTour.CurrentRow.Cells[5].Value.ToString();
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cbMaDangKy.Text = null;
            cbMaKhach.Text = null;
            cbMaLichTour.Text = null;
            dtpNgayDangKy.Text = null;
            txtSoLuongDK.Text = null;
            txtThanhTien.Text = null;
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            dtBase.UpdateData("insert into DangKyTour values('" + cbMaDangKy.Text + "',N'"
                + cbMaKhach.Text + "',N'" + cbMaLichTour.Text + "',N'"
               + dtpNgayDangKy.Text +
                        "',N'" + txtSoLuongDK.Text + "','" + txtThanhTien.Text +  "')");
            MessageBox.Show("Bạn đã thêm mới thành công");
            dgvDangKyTour.DataSource = dtBase.SelectData("Select * from DangKyTour");
            dtBase.UpdateData("update LichTour set TongTien = (select Sum(ThanhTien) from DangKyTour )" +
                " where MaLichTour = '" + cbMaLichTour.Text + "'");
            dtBase.UpdateData("update LichTour set SoNguoiDangKy = (select Sum(SoLuongDangKy) from DangKyTour )" +
                " where MaLichTour = '" + cbMaLichTour.Text + "'");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dtBase.UpdateData("update DangKyTour set MaDangKy=N'" + cbMaDangKy.Text + "',MaKhach='" +
                "" + cbMaKhach.Text + "',MaLichTour=N'" + cbMaLichTour.Text + "',NgayDangKy='" + dtpNgayDangKy.Text +
                "',SoLuongDangKy='" + txtSoLuongDK.Text + "',ThanhTien='" + txtThanhTien.Text +
                 "'where MaDangKy='" + cbMaDangKy.Text + "'");
            MessageBox.Show("Bạn đã sửa thành công");
            dgvDangKyTour.DataSource = dtBase.SelectData("Select * from DangKyTour");
            dtBase.UpdateData("update LichTour set TongTien = (select Sum(ThanhTien) from DangKyTour )" +
               " where MaLichTour = '" + cbMaLichTour.Text + "'");
            dtBase.UpdateData("update LichTour set SoNguoiDangKy = (select Sum(SoLuongDangKy) from DangKyTour )" +
                " where MaLichTour = '" + cbMaLichTour.Text + "'");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa chất liệu có mã là:" + cbMaDangKy.Text + " không?", "Thông báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                dtBase.UpdateData("delete DangKytour where MaDangKy='" + cbMaDangKy.Text + "'");
                dgvDangKyTour.DataSource = dtBase.SelectData("Select * from DangKyTour ");
                dtBase.UpdateData("update LichTour set TongTien = (select Sum(ThanhTien) from DangKyTour )" +
               " where MaLichTour = '" + cbMaLichTour.Text + "'");
                dtBase.UpdateData("update LichTour set SoNguoiDangKy = (select Sum(SoLuongDangKy) from DangKyTour )" +
                    " where MaLichTour = '" + cbMaLichTour.Text + "'");

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ko?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
