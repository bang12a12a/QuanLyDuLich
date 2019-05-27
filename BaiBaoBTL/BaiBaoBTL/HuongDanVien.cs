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
    public partial class HuongDanVien : Form
    {
        KetNoi_Database dtBase = new KetNoi_Database();
        public HuongDanVien()
        {
            InitializeComponent();
        }

        private void HuongDanVien_Load(object sender, EventArgs e)
        {
            DataTable dtHDV = dtBase.SelectData("Select * from HuongDanVien");
            dgvHuongDanVien.DataSource = dtHDV;
            dgvHuongDanVien.Columns[0].HeaderText = "Mã HDV";
            dgvHuongDanVien.Columns[1].HeaderText = "Tên HDV";
            dgvHuongDanVien.Columns[2].HeaderText = "Mã CT";
            dgvHuongDanVien.Columns[3].HeaderText = "Ngày Sinh";
            dgvHuongDanVien.Columns[4].HeaderText = "Giới Tính";
            dgvHuongDanVien.Columns[5].HeaderText = "Mã Tỉnh";
            dgvHuongDanVien.Columns[6].HeaderText = "Mã Trình Độ";
            dgvHuongDanVien.Columns[7].HeaderText = "Mã Trường DT";
            dgvHuongDanVien.Columns[8].HeaderText = "Ngày vào CT";


            DataTable dtCT = dtBase.SelectData("Select MaCongTy from CongTy");
            cbMaCT.DataSource = dtCT;
            cbMaCT.DisplayMember = "MaCongTy";

            DataTable dtTinh = dtBase.SelectData("Select MaTinh from Tinh");
            cbMaTinh.DataSource = dtTinh;
            cbMaTinh.DisplayMember = "MaTinh";

            DataTable dtTD = dtBase.SelectData("Select MaTrinhDo from TrinhDo");
            cbMaTrinhDo.DataSource = dtTD;
            cbMaTrinhDo.DisplayMember = "MaTrinhDo";

            DataTable dtTDT = dtBase.SelectData("Select MaTruongDT from TruongDaoTao");
            cbMaTruongDT.DataSource = dtTDT;
            cbMaTruongDT.DisplayMember = "MaTruongDT";
        }

        private void dgvHuongDanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbMaHDV.Text = dgvHuongDanVien.CurrentRow.Cells[0].Value.ToString();
            txtTenHDV.Text = dgvHuongDanVien.CurrentRow.Cells[1].Value.ToString();
            cbMaCT.Text = dgvHuongDanVien.CurrentRow.Cells[2].Value.ToString();
            dtpNgaySinh.Text = dgvHuongDanVien.CurrentRow.Cells[3].Value.ToString();
            txtGioiTinh.Text = dgvHuongDanVien.CurrentRow.Cells[4].Value.ToString();
            cbMaTinh.Text = dgvHuongDanVien.CurrentRow.Cells[5].Value.ToString();
            cbMaTrinhDo.Text = dgvHuongDanVien.CurrentRow.Cells[6].Value.ToString();
            cbMaTruongDT.Text = dgvHuongDanVien.CurrentRow.Cells[7].Value.ToString();
            dtpNgayVaoCT.Text = dgvHuongDanVien.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cbMaHDV.Text = null;
            txtTenHDV.Text = null;
            cbMaCT.Text = null;
            dtpNgaySinh.Text = null;
            txtGioiTinh.Text = null;
            cbMaTinh.Text = null;
            dtpNgayVaoCT.Text = null;
            cbMaTrinhDo.Text = null;
            cbMaTruongDT.Text = null;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            dtBase.UpdateData("insert into HuongDanVien values('" + cbMaHDV.Text + "',N'"
                + txtTenHDV.Text + "',N'" + cbMaCT.Text + "',N'"
               + dtpNgaySinh.Text + "',N'" + txtGioiTinh.Text + "',N'" + cbMaTinh.Text + "',N'"
               + cbMaTrinhDo.Text + "',N'" + cbMaTruongDT.Text + "','" + dtpNgayVaoCT.Text + "')");
            MessageBox.Show("Bạn đã thêm mới thành công");
            dgvHuongDanVien.DataSource = dtBase.SelectData("Select * from HuongDanVien");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dtBase.UpdateData("update HuongDanVien set NgayVaoCongTy=N'" + dtpNgayVaoCT.Text + "',TenHDV='" +
                "" + txtTenHDV.Text + "',MaCongTy=N'" + cbMaCT.Text + "',NgaySinh='" + dtpNgaySinh.Text +
                "',GioiTinh='" + txtGioiTinh.Text + "',MaTinh='" + cbMaTinh.Text +
                 "',MaTrinhDo='" + cbMaTrinhDo.Text + "',MaTruongDT='" + cbMaTruongDT.Text +
                 "'where MaHDV='" + cbMaHDV.Text + "'");
            MessageBox.Show("Bạn đã sửa thành công");
            dgvHuongDanVien.DataSource = dtBase.SelectData("Select * from HuongDanVien");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa chất liệu có mã là:" + cbMaHDV.Text + " không?", "Thông báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                dtBase.UpdateData("delete HuongDanVien where MaHDV='" + cbMaHDV.Text + "'");
                dgvHuongDanVien.DataSource = dtBase.SelectData("Select * from HuongDanVien ");               
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ko?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvHuongDanVien.DataSource = dtBase.SelectData("select *  " +
                "from HuongDanVien where TenHDV LIKE N'%" + txtTenHDV.Text + "%' " +
                "and  MaCongTy LIKE N'%" + cbMaCT.Text + "%' and MaTruongDT LIKE '%" + cbMaTruongDT.Text + "%'");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dgvHuongDanVien.DataSource = dtBase.SelectData("Select * from HuongDanVien ");
        }
    }
}
