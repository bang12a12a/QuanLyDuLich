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
    public partial class BC_TourChuaDi : Form
    {
        KetNoi_Database dtBase = new KetNoi_Database();
        public BC_TourChuaDi()
        {
            InitializeComponent();
        }

        private void BC_TourChuaDi_Load(object sender, EventArgs e)
        {
            dgvTour.DataSource = dtBase.SelectData("select PhamVi.TenPhamVi,TenTour,MaMua,SoNgay,DonGia,GhiChu " +
                "from DanhMucTour,PhamVi,LichTour where DanhMucTour.MaTour = LichTour.MaTour and" +
                " PhamVi.MaPhamVi = DanhMucTour.MaPhamVi and  LichTour.DaKhoiHanh = '0'");
            dgvTour.Columns[0].HeaderText = "Tên phạm vi ";
            dgvTour.Columns[1].HeaderText = "Tên Tour";
            dgvTour.Columns[2].HeaderText = "Mã Mùa";
            dgvTour.Columns[3].HeaderText = "Số ngày";
            dgvTour.Columns[4].HeaderText = "Đơn giá";
            dgvTour.Columns[5].HeaderText = "Ghi Chú";
            
        }
    }
}
