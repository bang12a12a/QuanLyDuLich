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
    public partial class BC_TongTien : Form
    {
        KetNoi_Database dtBase = new KetNoi_Database();
        public BC_TongTien()
        {
            InitializeComponent();
        }

        private void BC_TongTien_Load(object sender, EventArgs e)
        {
            dgvDoanhThu.DataSource = dtBase.SelectData("select TenCongTy as 'Tên Công Ty', sum(TongTien) as 'Tổng Tiền' " +
                "from CongTy,LichTour where CongTy.MaCongTy = LichTour.MaCongTy group by TenCongTy");
            dgvDoanhThu.Columns[0].Width = 160;

        }
    }
}
