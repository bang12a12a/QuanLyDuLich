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
    public partial class Tim_HDV : Form
    {
        KetNoi_Database dtBase = new KetNoi_Database();
        public Tim_HDV()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvHDV.DataSource = dtBase.SelectData("select *  " +
                "from HuongDanVien where TenHDV LIKE N'%" + cbTen.Text + "%' " +
                "and  MaCongTy LIKE N'%" + cbMaCT.Text + "%' and MaTruongDT LIKE '%" + cbMaTruong.Text + "%'");
        }

        private void Tim_HDV_Load(object sender, EventArgs e)
        {
            DataTable dtTen = dtBase.SelectData("Select TenHDV from HuongDanVien");
            cbTen.DataSource = dtTen;
            cbTen.DisplayMember = "TenHDV";

            DataTable dtCT = dtBase.SelectData("Select MaCongTy from CongTy");
            cbMaCT.DataSource = dtCT;
            cbMaCT.DisplayMember = "MaCongTy";

            DataTable dtMaTruong = dtBase.SelectData("Select MaTruongDT from TruongDaoTao");
            cbMaTruong.DataSource = dtMaTruong;
            cbMaTruong.DisplayMember = "MaTruongDT";
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
