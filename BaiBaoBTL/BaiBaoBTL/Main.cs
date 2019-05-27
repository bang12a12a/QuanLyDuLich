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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void đăngKíTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangKyTour dangKyTour = new DangKyTour();
            dangKyTour.Show();
        }

        private void lịchTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LichTour lichTour = new LichTour();
            lichTour.Show();
        }

        private void hướngDẫnViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDanVien huongDanVien = new HuongDanVien();
            huongDanVien.Show();
        }

        private void hướngDẫnViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tim_HDV tim_HDV = new Tim_HDV();
            tim_HDV.Show();
        }

        private void tourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimTour timTour = new TimTour();
            timTour.Show();
        }

        private void tourChưaĐiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BC_TourChuaDi bC_TourChuaDi = new BC_TourChuaDi();
            bC_TourChuaDi.Show();
        }

        private void tổngTiềnTheoCôngTyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BC_TongTien bC_TongTien = new BC_TongTien();
            bC_TongTien.Show();
        }

        private void top5TourNhiềuNgườiĐăngKíNhấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BC_5Tour bC_5Tour = new BC_5Tour();
            bC_5Tour.Show();
        }
    }
}
