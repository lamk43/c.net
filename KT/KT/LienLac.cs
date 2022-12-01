using KT.Model;
using KT.Services;
using KT.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KT

{
    public partial class LienLac : Form
    {
        public LienLac()
        {
            InitializeComponent();
            NapDSNhom();
        }

        public TenNhomViewModel selectedNhom
        {
            get
            {
                return cbbNhom.SelectedItem as TenNhomViewModel;
            }
        }

        void NapDSNhom()
        {
            var ls = TenNhomViewModel.GetList();
            cbbNhom.DataSource = ls;
            cbbNhom.DisplayMember = "TenNhom";
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
           
            var TG = new TenGoi
            {
                DiaChi = txtDiaChi.Text,
                Email = txtEmail.Text,
                ID = int.Parse(txtMSV.Text),
                Sodienthoai= txtSoDienThoai.Text,
                TenGoi1= txtHoTen.Text,
                ID_Nhom =selectedNhom.ID
            };
            if (TenGoiService.AddTenGoi(TG) == KetQua.ThanhCong)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Mã sinh viên trùng", "Thông báo");
                txtMSV.Focus();
            }
         

        }

        private void cbbNhom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
