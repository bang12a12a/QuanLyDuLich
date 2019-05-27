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
    public partial class TimTour : Form
    {
        KetNoi_Database dtBase = new KetNoi_Database();
        public TimTour()
        {
            InitializeComponent();
        }

        private void Tour_Load(object sender, EventArgs e)
        {
            DataTable dtTenTour = dtBase.SelectData("Select TenTour from DanhMucTour");
            cbTenTour.DataSource = dtTenTour;
            cbTenTour.DisplayMember = "TenTour";

            DataTable dtPhamVi = dtBase.SelectData("Select MaPhamVi from DanhMucTour");
            cbMaPhamVi.DataSource = dtPhamVi;
            cbMaPhamVi.DisplayMember = "MaPhamVi";

            DataTable dtMaMua = dtBase.SelectData("Select MaMua from DanhMucTour");
            cbMaMua.DataSource = dtMaMua;
            cbMaMua.DisplayMember = "MaMua";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvTour.DataSource = dtBase.SelectData("select *  " +
                "from DanhMucTour where TenTour LIKE N'%" + cbTenTour.Text + "%' " +
                "and  MaPhamVi LIKE N'%" + cbMaPhamVi.Text + "%' and MaMua LIKE '%" + cbMaMua.Text + "%'");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ko?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
