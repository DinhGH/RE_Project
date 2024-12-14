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
    public partial class frm_dsdatphong : DevExpress.XtraEditors.XtraForm
    {
        private frm_dschecked_in frmCheckIn;
        public frm_dsdatphong(frm_dschecked_in checkInForm)
        {
            InitializeComponent();
            frmCheckIn = checkInForm ?? new frm_dschecked_in(new frm_dscheck_out());


        }
        public frm_dsdatphong()
        {
            InitializeComponent();
        }
        public void SetInitialData()
        {
            // Kiểm tra nếu bảng có ít nhất 1 dòng
            if (dataGridViewDSDat.Rows.Count == 0)
            {
                // Thêm một dòng mới vào DataGridView nếu bảng chưa có dữ liệu
                dataGridViewDSDat.Rows.Add();
            }

            // Gán giá trị mặc định cho ô đầu tiên của hàng đầu tiên
            var firstRow = dataGridViewDSDat.Rows[0];

            firstRow.Cells["TenKH"].Value = "Nguyễn Văn A";  // Tên khách hàng
            firstRow.Cells["MaDatPhong"].Value = "MDP001";   // Mã đặt phòng
            firstRow.Cells["SoCCCD"].Value = "123456789";     // Số CCCD
            firstRow.Cells["NgayDatPhong"].Value = DateTime.Now.ToShortDateString();  // Ngày đặt phòng
            firstRow.Cells["NgayTraPhong"].Value = DateTime.Now.AddDays(1).ToShortDateString();  // Ngày trả phòng
            firstRow.Cells["TinhTrangThanhToan"].Value = "Đã thanh toán";  // Tình trạng thanh toán
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (frmCheckIn == null || frmCheckIn.IsDisposed)
            {
                frmCheckIn = new frm_dschecked_in(new frm_dscheck_out());
                frmCheckIn.MdiParent = this.MdiParent; // Đảm bảo nó thuộc về MDI Parent
                frmCheckIn.Show();
            }

            if (dataGridViewDSDat.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewDSDat.SelectedRows[0];
                string tenKH = selectedRow.Cells["TenKH"].Value?.ToString();
                string maDP = selectedRow.Cells["MaDatPhong"].Value?.ToString();
                string soCCCD = selectedRow.Cells["SoCCCD"].Value?.ToString();
                DateTime ngayDat = DateTime.Parse(selectedRow.Cells["NgayDatPhong"].Value?.ToString());
                DateTime ngayTra = DateTime.Parse(selectedRow.Cells["NgayTraPhong"].Value?.ToString());
                string tinhTrang = selectedRow.Cells["TinhTrangThanhToan"].Value?.ToString();

                frmCheckIn.AddCheckedInRow(tenKH, maDP, soCCCD, ngayDat, ngayTra, tinhTrang);
                dataGridViewDSDat.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để chuyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LoadSampleData()
        {
            // Thêm các cột vào DataGridView nếu chưa được thêm
            if (dataGridViewDSDat.Columns.Count == 0)
            {
                dataGridViewDSDat.Columns.Add("TenKH", "Tên KH");
                dataGridViewDSDat.Columns.Add("MaDatPhong", "Mã đặt phòng");
                dataGridViewDSDat.Columns.Add("SoCCCD", "Số CCCD");
                dataGridViewDSDat.Columns.Add("NgayDatPhong", "Ngày đặt phòng");
                dataGridViewDSDat.Columns.Add("NgayTraPhong", "Ngày trả phòng");
                dataGridViewDSDat.Columns.Add("TinhTrangThanhToan", "Tình trạng thanh toán");
            }

            // Thêm dữ liệu mẫu
            dataGridViewDSDat.Rows.Add("Nguyễn Văn A", "MDP001", "123456789", DateTime.Now.ToShortDateString(), DateTime.Now.AddDays(1).ToShortDateString(), "Đã thanh toán");
            dataGridViewDSDat.Rows.Add("Trần Thị B", "MDP002", "987654321", DateTime.Now.ToShortDateString(), DateTime.Now.AddDays(2).ToShortDateString(), "Chưa thanh toán");
            dataGridViewDSDat.Rows.Add("Lê Văn C", "MDP003", "456789123", DateTime.Now.ToShortDateString(), DateTime.Now.AddDays(3).ToShortDateString(), "Đã thanh toán");
        }
        private void frm_dsdatphong_Load(object sender, EventArgs e)
        {
            // Gọi phương thức để thêm dữ liệu mẫu
            LoadSampleData();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            // Tạo một dòng mới trong DataGridView
            int rowIndex = dataGridViewDSDat.Rows.Add();

            // Lấy dòng vừa thêm
            DataGridViewRow newRow = dataGridViewDSDat.Rows[rowIndex];

            // Thiết lập giá trị mặc định (nếu cần)
            newRow.Cells["TenKH"].Value = ""; // Tên khách hàng (bỏ trống để nhập)
            newRow.Cells["MaDatPhong"].Value = ""; // Mã đặt phòng
            newRow.Cells["SoCCCD"].Value = ""; // Số CCCD
            newRow.Cells["NgayDatPhong"].Value = DateTime.Now.ToShortDateString(); // Ngày đặt phòng
            newRow.Cells["NgayTraPhong"].Value = DateTime.Now.AddDays(1).ToShortDateString(); // Ngày trả phòng
            newRow.Cells["TinhTrangThanhToan"].Value = "Chưa thanh toán"; // Tình trạng thanh toán
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (dataGridViewDSDat.SelectedRows.Count > 0)
            {
                // Hỏi người dùng có chắc chắn muốn xóa không
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này không?",
                                                       "Xác nhận xóa",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Xóa hàng được chọn
                    foreach (DataGridViewRow row in dataGridViewDSDat.SelectedRows)
                    {
                        if (!row.IsNewRow) // Không cho phép xóa dòng mới (trống)
                        {
                            dataGridViewDSDat.Rows.Remove(row);
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