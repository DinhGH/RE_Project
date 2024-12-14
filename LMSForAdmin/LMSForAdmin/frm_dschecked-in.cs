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
    public partial class frm_dschecked_in : DevExpress.XtraEditors.XtraForm
    {
        private frm_dscheck_out frmCheckOut; // Biến tham chiếu đến form Check-out

        public frm_dschecked_in(frm_dscheck_out checkOutForm)
        {
            InitializeComponent();

            frmCheckOut = checkOutForm ?? new frm_dscheck_out();

        }
        public frm_dschecked_in()
{
    InitializeComponent();
    frmCheckOut = new frm_dscheck_out(); // Tạo mới Check-out mặc định
}

        public void AddCheckedInRow(string tenKH, string maDP, string soCCCD, DateTime ngayDat, DateTime ngayTra, string tinhTrang)
        {
            // Kiểm tra DataGridView trong form Check-in
            if (dataGridViewCheckIn.Columns.Count == 0)
            {
                dataGridViewCheckIn.Columns.Add("TenKH", "Tên KH");
                dataGridViewCheckIn.Columns.Add("MaDatPhong", "Mã đặt phòng");
                dataGridViewCheckIn.Columns.Add("SoCCCD", "Số CCCD");
                dataGridViewCheckIn.Columns.Add("NgayDatPhong", "Ngày đặt phòng");
                dataGridViewCheckIn.Columns.Add("NgayTraPhong", "Ngày trả phòng");
                dataGridViewCheckIn.Columns.Add("TinhTrangThanhToan", "Tình trạng thanh toán");
            }

            // Thêm dữ liệu vào DataGridView
            dataGridViewCheckIn.Rows.Add(tenKH, maDP, soCCCD, ngayDat.ToShortDateString(), ngayTra.ToShortDateString(), tinhTrang);
        }
        private void frm_dschecked_in_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewCheckin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (frmCheckOut == null || frmCheckOut.IsDisposed)
            {
                frmCheckOut = new frm_dscheck_out();
                frmCheckOut.MdiParent = this.MdiParent; // Đảm bảo nó thuộc về MDI Parent
                frmCheckOut.Show();
            }

            if (dataGridViewCheckIn.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewCheckIn.SelectedRows[0];
                string tenKH = selectedRow.Cells["TenKH"].Value?.ToString();
                string maDP = selectedRow.Cells["MaDatPhong"].Value?.ToString();
                string soCCCD = selectedRow.Cells["SoCCCD"].Value?.ToString();
                string ngayDatPhong = selectedRow.Cells["NgayDatPhong"].Value?.ToString();
                string ngayTraPhong = selectedRow.Cells["NgayTraPhong"].Value?.ToString();
                string tinhTrang = selectedRow.Cells["TinhTrangThanhToan"].Value?.ToString();

                frmCheckOut.AddRowToCheckOut(tenKH, maDP, soCCCD, ngayDatPhong, ngayTraPhong, tinhTrang);
                dataGridViewCheckIn.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để chuyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (dataGridViewCheckIn.SelectedRows.Count > 0)
            {
                // Hỏi người dùng có chắc chắn muốn xóa không
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này không?",
                                                       "Xác nhận xóa",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Xóa hàng được chọn
                    foreach (DataGridViewRow row in dataGridViewCheckIn.SelectedRows)
                    {
                        if (!row.IsNewRow) // Không cho phép xóa dòng mới (trống)
                        {
                            dataGridViewCheckIn.Rows.Remove(row);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewCheckIn.Rows.Add();
        }
    }
}