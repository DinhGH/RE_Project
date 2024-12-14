using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LMSForAdmin
{
    public partial class frm_inhoadon : DevExpress.XtraEditors.XtraForm
    {
        public frm_inhoadon()
        {
            InitializeComponent();
        }
        public class KhachHang
        {
            public string Ten { get; set; }
            public int TongSoYeuCauDichVu { get; set; }
            public decimal TongTienDichVu { get; set; }
            public DateTime NgayDat { get; set; }
            public DateTime NgayTra { get; set; }
            public decimal TienPhong { get; set; }
            public decimal TongTienPhaiTra { get; set; }
        }

        private Dictionary<string, KhachHang> danhSachKhachHang = new Dictionary<string, KhachHang>
{
    { "MDP001", new KhachHang { Ten = "Nguyễn Văn A", TongSoYeuCauDichVu = 5, TongTienDichVu = 200000, NgayDat = DateTime.Now.AddDays(-3), NgayTra = DateTime.Now, TienPhong = 500000, TongTienPhaiTra = 700000 } }
};

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string maDatPhong = textEdit1.Text.Trim(); // Lấy mã đặt phòng từ ô nhập

            if (string.IsNullOrEmpty(maDatPhong))
            {
                MessageBox.Show("Vui lòng nhập mã đặt phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                groupTTKH.Visible = false; // Ẩn nhóm thông tin khách hàng
                return;
            }

            if (danhSachKhachHang.TryGetValue(maDatPhong, out KhachHang khachHang))
            {
                // Hiển thị thông tin khách hàng
                textEdit4.Text = khachHang.Ten;
                textEdit2.Text = khachHang.TongSoYeuCauDichVu.ToString();
                textEdit3.Text = khachHang.TongTienDichVu.ToString("N0");
                dateTimeOffsetEdit1.EditValue = khachHang.NgayDat;
                dateTimeOffsetEdit2.EditValue = khachHang.NgayTra;
                checkedComboBoxEdit1.EditValue = "Đã thanh toán";
                textEdit5.Text = khachHang.TongTienPhaiTra.ToString("N0");

                groupTTKH.Visible = true; // Hiện nhóm thông tin khách hàng
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupTTKH.Visible = false; // Ẩn nhóm thông tin khách hàng nếu không tìm thấy
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string maDatPhong = textEdit1.Text.Trim();

            if (string.IsNullOrEmpty(maDatPhong))
            {
                MessageBox.Show("Vui lòng tìm kiếm trước khi cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (danhSachKhachHang.TryGetValue(maDatPhong, out KhachHang khachHang))
            {
                // Cập nhật thông tin khách hàng
                khachHang.Ten = textEdit4.Text.Trim();
                khachHang.TongSoYeuCauDichVu = int.Parse(textEdit2.Text);
                khachHang.TongTienDichVu = decimal.Parse(textEdit3.Text);
                khachHang.NgayDat = Convert.ToDateTime(dateTimeOffsetEdit1.EditValue);
                khachHang.NgayTra = Convert.ToDateTime(dateTimeOffsetEdit2.EditValue);  
                khachHang.TienPhong = decimal.Parse(checkedComboBoxEdit1.Text);
                khachHang.TongTienPhaiTra = decimal.Parse(textEdit5.Text);

                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void groupTTKH_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_inhoadon_Load(object sender, EventArgs e)
        {
            groupTTKH.Visible = false;
        }
    }
}