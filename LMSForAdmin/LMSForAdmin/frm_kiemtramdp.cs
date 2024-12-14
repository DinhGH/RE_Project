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


    public partial class frm_kiemtramdp : DevExpress.XtraEditors.XtraForm
    {
        public frm_kiemtramdp()
        {
            InitializeComponent();
            groupControl2.Visible = false;
        }
        private Dictionary<string, (string SoCCCD, string MaDP, string TenKH, DateTimeOffset NgayDat, DateTimeOffset NgayTra, string TinhTrang)> bookingData = new Dictionary<string, (string,string, string, DateTimeOffset, DateTimeOffset, string)>
        {
            { "MDP001", ("123456789","MDP001" ,"Nguyễn Văn A", new DateTimeOffset(2024, 12, 10, 0, 0, 0, TimeSpan.Zero), new DateTimeOffset(2024, 12, 11, 0, 0, 0, TimeSpan.Zero), "Đã thanh toán") },
            { "MDP002", ("987654321", "MDP002" , "Trần Thị B", new DateTimeOffset(2024, 12, 9, 0, 0, 0, TimeSpan.Zero), new DateTimeOffset(2024, 12, 10, 0, 0, 0, TimeSpan.Zero), "Chưa thanh toán") }
        };
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string maDatPhong = textEdit1.Text.Trim();

            if (string.IsNullOrEmpty(maDatPhong))
            {
                MessageBox.Show("Vui lòng nhập mã đặt phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bookingData.ContainsKey(maDatPhong))
            {
                // Lấy thông tin khách hàng từ dữ liệu
                var info = bookingData[maDatPhong];
                textEdit3.Text = info.MaDP;
                textEdit2.Text = info.SoCCCD;
                textEdit4.Text = info.TenKH;
                dateTimeOffsetEdit1.DateTimeOffset = info.NgayDat;
                dateTimeOffsetEdit2.DateTimeOffset = info.NgayTra;
                checkedComboBoxEdit1.Text = info.TinhTrang;

                // Hiển thị thông tin khách hàng
                groupControl2.Visible = true;
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã đặt phòng!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Ẩn thông tin khách hàng nếu không tìm thấy
                groupControl2.Visible = false;
            }
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string maDatPhong = textEdit1.Text.Trim();

            // Kiểm tra mã đặt phòng
            

            // Lấy thông tin từ form
            String MaDP = textEdit1.Text.Trim();
            string soCCCD = textEdit2.Text.Trim();
            string tenKH = textEdit4.Text.Trim();
            DateTimeOffset ngayDat = dateTimeOffsetEdit1.DateTimeOffset;
            DateTimeOffset ngayTra = dateTimeOffsetEdit2.DateTimeOffset;
            string tinhTrang = checkedComboBoxEdit1.Text.Trim();

            // Kiểm tra các trường thông tin cần thiết
            if (string.IsNullOrEmpty(soCCCD) || string.IsNullOrEmpty(tenKH) || string.IsNullOrEmpty(tinhTrang))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cập nhật thông tin
            bookingData[maDatPhong] = (soCCCD,MaDP, tenKH, ngayDat, ngayTra, tinhTrang);

            MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cập nhật giao diện hoặc reset thông tin (tuỳ yêu cầu)

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            string maDatPhong = textEdit1.Text.Trim();
            ResetForm();
            bookingData.Remove(maDatPhong);

            // Reset form
            ResetForm();

            MessageBox.Show("Xoá mã đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void ResetForm()
        {
            textEdit3.Text = string.Empty;
            textEdit2.Text = string.Empty;
            textEdit4.Text = string.Empty;
            dateTimeOffsetEdit1.EditValue = DateTimeOffset.Now;
            dateTimeOffsetEdit2.EditValue = DateTimeOffset.Now;
            checkedComboBoxEdit1.EditValue = null;
            groupControl2.Visible = false; // Ẩn thông tin khách hàng
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            textEdit1.Text = string.Empty;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Giao phòng thành công! - Dữ liệu đã được cập nhật lên hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}