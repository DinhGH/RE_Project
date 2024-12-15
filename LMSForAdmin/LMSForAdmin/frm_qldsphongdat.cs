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
    public partial class frm_qldsphongdat : DevExpress.XtraEditors.XtraForm
    {
        public frm_qldsphongdat()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvPhongDaDat.Rows.Add("", "", "", "", "", "", "", "");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvPhongDaDat.SelectedRows.Count > 0)
            {
                // Hỏi người dùng có chắc chắn muốn xóa không
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này không?",
                                                       "Xác nhận xóa",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Xóa hàng được chọn
                    foreach (DataGridViewRow row in dgvPhongDaDat.SelectedRows)
                    {
                        if (!row.IsNewRow) // Không cho phép xóa dòng mới (trống)
                        {
                            dgvPhongDaDat.Rows.Remove(row);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các trường nhập liệu
            string soPhong = txtSoPhong.Text;
            string loaiPhong = txtLoaiPhong.Text;
            string giaTien = txtGiaTien.Text;
            string tinhTrang = txtTinhTrang.Text;
            string maPhong = txtMaPhong.Text;
            string nguoiDat = txtNguoiDat.Text;
            string maDatPhong = txtMaDatPhong.Text;
            string tinhTrangThanhToan = cmbTinhTrangThanhToan.EditValue?.ToString()?.Trim();
            if (string.IsNullOrEmpty(tinhTrangThanhToan))
            {
                MessageBox.Show("Vui lòng chọn tình trạng thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Kiểm tra nhập đầy đủ thông tin
            if (string.IsNullOrWhiteSpace(soPhong.Trim()) || string.IsNullOrWhiteSpace(loaiPhong.Trim()) ||
    string.IsNullOrWhiteSpace(giaTien.Trim()) || string.IsNullOrWhiteSpace(tinhTrang.Trim()) ||
    string.IsNullOrWhiteSpace(maPhong.Trim()) || string.IsNullOrWhiteSpace(nguoiDat.Trim()) ||
    string.IsNullOrWhiteSpace(maDatPhong.Trim()) || string.IsNullOrEmpty(tinhTrangThanhToan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng lặp
            foreach (DataGridViewRow row in dgvPhongDaDat.Rows)
            {
                if (row.Cells["MaDatPhong"].Value?.ToString() == maDatPhong)
                {
                    MessageBox.Show("Hàng với mã đặt phòng này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Thêm mới một hàng vào DataGridView
            dgvPhongDaDat.Rows.Add(soPhong, loaiPhong, giaTien, tinhTrang, maPhong, nguoiDat, maDatPhong, tinhTrangThanhToan);
            MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Xóa trắng các trường sau khi thêm
            ClearFields();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một hàng hay chưa
            if (dgvPhongDaDat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hàng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu từ các trường nhập liệu
            string soPhong = txtSoPhong.Text;
            string loaiPhong = txtLoaiPhong.Text;
            string giaTien = txtGiaTien.Text;
            string tinhTrang = txtTinhTrang.Text;
            string maPhong = txtMaPhong.Text;
            string nguoiDat = txtNguoiDat.Text;
            string maDatPhong = txtMaDatPhong.Text;
            string tinhTrangThanhToan = cmbTinhTrangThanhToan.EditValue?.ToString();


            // Kiểm tra nhập đầy đủ thông tin
            if (string.IsNullOrWhiteSpace(soPhong) || string.IsNullOrWhiteSpace(loaiPhong) ||
                string.IsNullOrWhiteSpace(giaTien) || string.IsNullOrWhiteSpace(tinhTrang) ||
                string.IsNullOrWhiteSpace(maPhong) || string.IsNullOrWhiteSpace(nguoiDat) ||
                string.IsNullOrWhiteSpace(maDatPhong) || string.IsNullOrEmpty(tinhTrangThanhToan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cập nhật thông tin hàng đã chọn
            DataGridViewRow selectedRow = dgvPhongDaDat.SelectedRows[0];
            selectedRow.Cells["SoPhong"].Value = soPhong;
            selectedRow.Cells["LoaiPhong"].Value = loaiPhong;
            selectedRow.Cells["GiaTien"].Value = giaTien;
            selectedRow.Cells["TinhTrang"].Value = tinhTrang;
            selectedRow.Cells["MaPhong"].Value = maPhong;
            selectedRow.Cells["NguoiDat"].Value = nguoiDat;
            selectedRow.Cells["MaDatPhong"].Value = maDatPhong;
            selectedRow.Cells["TinhTrangThanhToan"].Value = tinhTrangThanhToan;

            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Xóa trắng các trường sau khi cập nhật
            ClearFields();
        }
        private void dgvPhongDaDat_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dgvPhongDaDat.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPhongDaDat.SelectedRows[0];

                // Đưa dữ liệu từ hàng được chọn lên các trường nhập
                txtSoPhong.Text = selectedRow.Cells["SoPhong"].Value?.ToString();
                txtLoaiPhong.Text = selectedRow.Cells["LoaiPhong"].Value?.ToString();
                txtGiaTien.Text = selectedRow.Cells["GiaTien"].Value?.ToString();
                txtTinhTrang.Text = selectedRow.Cells["TinhTrang"].Value?.ToString();
                txtMaPhong.Text = selectedRow.Cells["MaPhong"].Value?.ToString();
                txtNguoiDat.Text = selectedRow.Cells["NguoiDat"].Value?.ToString();
                txtMaDatPhong.Text = selectedRow.Cells["MaDatPhong"].Value?.ToString();
                string tinhTrangThanhToan = selectedRow.Cells["TinhTrangThanhToan"].Value?.ToString();
                if (!string.IsNullOrEmpty(tinhTrangThanhToan) &&
                    cmbTinhTrangThanhToan.Properties.Items.Cast<DevExpress.XtraEditors.Controls.CheckedListBoxItem>()
                    .Any(item => item.Description == tinhTrangThanhToan))
                {
                    cmbTinhTrangThanhToan.SetEditValue(tinhTrangThanhToan);
                }
                else
                {
                    cmbTinhTrangThanhToan.EditValue = null; // Nếu không có giá trị phù hợp, bỏ chọn
                }
            }
        }

        // Hàm xóa trắng các trường nhập liệu
        private void ClearFields()
        {
            txtSoPhong.Clear();
            txtLoaiPhong.Clear();
            txtGiaTien.Clear();
            txtTinhTrang.Clear();
            txtMaPhong.Clear();
            txtNguoiDat.Clear();
            txtMaDatPhong.Clear();
            cmbTinhTrangThanhToan.EditValue = null; // Xóa trạng thái CheckedComboBoxEdit
        }

        private void frm_qldsphongdat_Load(object sender, EventArgs e)
        {
            dgvPhongDaDat.CellClick += dgvPhongDaDat_SelectionChanged;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (dgvPhongDaDat.SelectedRows.Count > 0)
            {
                // Hỏi người dùng có chắc chắn muốn xóa không
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này không?",
                                                       "Xác nhận xóa",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Xóa hàng được chọn
                    foreach (DataGridViewRow row in dgvPhongDaDat.SelectedRows)
                    {
                        if (!row.IsNewRow) // Không cho phép xóa dòng mới (trống)
                        {
                            dgvPhongDaDat.Rows.Remove(row);
                        }
                    }
                }
            }
        }
    }
}