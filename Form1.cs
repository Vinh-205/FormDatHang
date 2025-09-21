using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDatHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lstSanPham.Items.Add("Doraemon");
            lstSanPham.Items.Add("Kinh Van Hoa");
            lstSanPham.Items.Add("Harry Potter");

            cboThanhToan.Items.Add("Tiền mặt");
            cboThanhToan.Items.Add("ATM");
            cboThanhToan.Items.Add("Ví điện tử");
            cboThanhToan.SelectedIndex = 0;
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            string tenKH = txtKhachHang.Text;
            string dienThoai = txtDienThoai.Text;
            string thanhToan = cboThanhToan.SelectedItem.ToString();

            string sanPham = "";
            foreach (var item in lstSanPham.SelectedItems)
            {
                sanPham += "- " + item.ToString() + Environment.NewLine;
            }

            txtThongTinDonHang.Text =
                "Thông tin đặt hàng:" + Environment.NewLine +
                "Khách hàng: " + tenKH + Environment.NewLine +
                "Điện thoại: " + dienThoai + Environment.NewLine +
                "Sản phẩm đặt mua:" + Environment.NewLine + sanPham +
                "Cách thanh toán: " + thanhToan;
        }
    }
}
