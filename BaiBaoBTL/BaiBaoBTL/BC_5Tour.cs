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
    public partial class BC_5Tour : Form
    {
        KetNoi_Database dtBase = new KetNoi_Database();
        public BC_5Tour()
        {
            InitializeComponent();
        }

        private void BC_5Tour_Load(object sender, EventArgs e)
        {
            dgv5Tour.DataSource = dtBase.SelectData("select top(5) TenTour,sum( SoLuongDangKy) " +
                "as 'Tổng số đăng kí',MaPhamVi,DonGia,MaMua,SoNgay from DanhMucTour,LichTour" +
                ",DangKyTour where DanhMucTour.MaTour = LichTour.MaTour and  Lich" +
                "Tour.MaLichTour = DangKyTour.MaLichTour  group by TenTour,MaPhamVi,DonGia,MaMua,SoNgay");
        }
    }
}
