﻿using Karaoke.NguyenLieu;
using Karaoke.QuanLySanPham;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karaoke
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void suaSanPham_Click(object sender, EventArgs e)
        {
            frmSamPham samPham = new frmSamPham();
            samPham.ShowDialog();
        }

        private void suaNguyenLieu_Click(object sender, EventArgs e)
        {
            frmNguyenLieu nguyenLieu = new frmNguyenLieu();
            nguyenLieu.ShowDialog();
        }

        private void nhapKho_Click(object sender, EventArgs e)
        {
            frmNhapNguyenLieu nhapNguyenLieu= new frmNhapNguyenLieu();
            nhapNguyenLieu.ShowDialog();
        }

        private void nhapKhoSanPham_Click(object sender, EventArgs e)
        {
            frmNhapSanPham nhapSanPham = new frmNhapSanPham();
            nhapSanPham.ShowDialog();
        }

        private void baoCaoTonKho_Click(object sender, EventArgs e)
        {
            frmBaoCaoTonKho frmBaoCao = new frmBaoCaoTonKho();
            frmBaoCao.ShowDialog();
        }

        private void baoCaoDoanhThu_Click(object sender, EventArgs e)
        {

        }
    }
}
