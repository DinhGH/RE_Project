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
    public partial class frm_dscheck_out : DevExpress.XtraEditors.XtraForm
    {
        public frm_dscheck_out()
        {
            InitializeComponent();
        }

        private void frm_dscheck_out_Load(object sender, EventArgs e)
        {

        }
        public void AddRowToCheckOut(string tenKH, string maDP, string soCCCD, string ngayDatPhong, string ngayTraPhong, string tinhTrang)
        {
            // Kiểm tra nếu cột chưa được tạo thì tạo cột
            if (dataGridViewCheckOut.Columns.Count == 0)
            {
                dataGridViewCheckOut.Columns.Add("TenKH", "Tên KH");
                dataGridViewCheckOut.Columns.Add("MaDatPhong", "Mã đặt phòng");
                dataGridViewCheckOut.Columns.Add("SoCCCD", "Số CCCD");
                dataGridViewCheckOut.Columns.Add("NgayDatPhong", "Ngày đặt phòng");
                dataGridViewCheckOut.Columns.Add("NgayTraPhong", "Ngày trả phòng");
                dataGridViewCheckOut.Columns.Add("TinhTrangThanhToan", "Tình trạng thanh toán");
            }

            // Thêm dữ liệu vào DataGridView
            dataGridViewCheckOut.Rows.Add(tenKH, maDP, soCCCD, ngayDatPhong, ngayTraPhong, tinhTrang);
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewCheckOut.Rows.Add();
        }

        private void dataGridViewCheckOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (dataGridViewCheckOut.SelectedRows.Count > 0)
            {
                // Hỏi người dùng có chắc chắn muốn xóa không
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này không?",
                                                       "Xác nhận xóa",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Xóa hàng được chọn
                    foreach (DataGridViewRow row in dataGridViewCheckOut.SelectedRows)
                    {
                        if (!row.IsNewRow) // Không cho phép xóa dòng mới (trống)
                        {
                            dataGridViewCheckOut.Rows.Remove(row);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}