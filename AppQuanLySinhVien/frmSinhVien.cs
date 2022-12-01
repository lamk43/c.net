using AppQuanLySinhVien.Model;
using AppQuanLySinhVien.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLySinhVien
{
    public partial class frmSinhVien : Form
    {
        SinhVienViewModel sinhvien;
        public frminhVien(SinhVienViewModel sinhvien= null)
        {
            InitializeComponent();
            NapDSLopHoc();
            this.sinhvien = sinhvien;
            if (sinhvien != null)
            {
                cbmLopHoc.SelectedValue = sinhvien.IDLopHoc;
                txtMaSinhVien.Text = sinhvien.MaSinhVien;
                txtHoDem.Text = sinhvien.HoDem;
                txtTen.Text = sinhvien.Ten;
                dtpNgaySinh.Value = sinhvien.NgaySinh ?? DateTime.Now;
                if (sinhvien.GioiTinh == 0)
                    rdbNam.Checked = true;
                else if (sinhvien.GioiTinh == 1)
                    rdbNu.Checked = true;
                else
                    rdbKhac.Checked = true;
            }
        }

        public LopHocViewModel selectedLopHoc
        {
            get
            {
                return cbmLopHoc.SelectedItem as LopHocViewModel;
            }
        }
        
        void NapDSLopHoc()
        {
            var ls = LopHocViewModel.GetList();
            cbmLopHoc.DataSource = ls;
            cbmLopHoc.DisplayMember = "TenLop";
        }

        private void btnDongY_Click(object sender, EventArgs e)
        
            if (this.sinhvien ==null)
        {
            var sv = new SinhVien
            {
                HoDem = txtHoDem.Text,
                Ten = txtTen.Text,
                QueQuan = txtQueQuan.Text,
                NgaySinh = txtNgaySinh.Value,
                MaSinhVien = txtMaSinhVien.Text,
                IDLopHoc = selectedLopHoc.ID,
                GioiTinh = (rdbNam.Checked?0:rdbNu.Checked?1:2),
            };
            if
            SinhVienViewModel.AddSinhVien(sinhvien);
            DialogResult = DialogResult.OK;
        }
    }
}
