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
    public partial class frm_qldsphongtrong : DevExpress.XtraEditors.XtraForm
    {
        public frm_qldsphongtrong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvPhongTrong.Rows.Add("", "", "", "", "");

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvPhongTrong.SelectedRows.Count > 0)
            {
                // Hỏi người dùng có chắc chắn muốn xóa không
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này không?",
                                                       "Xác nhận xóa",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Xóa hàng được chọn
                    foreach (DataGridViewRow row in dgvPhongTrong.SelectedRows)
                    {
                        if (!row.IsNewRow) // Không cho phép xóa dòng mới (trống)
                        {
                            dgvPhongTrong.Rows.Remove(row);
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
            // Lấy dữ liệu từ các TextBox
            string soPhong = txtSoPhong.Text.Trim();
            string loaiPhong = txtLoaiPhong.Text.Trim();
            string giaTien = txtGiaTien.Text.Trim();
            string tinhTrang = txtTinhTrang.Text.Trim();
            string maPhong = txtMaPhong.Text.Trim();

            // Kiểm tra nhập đầy đủ thông tin
            if (string.IsNullOrWhiteSpace(soPhong) || string.IsNullOrWhiteSpace(loaiPhong) ||
                string.IsNullOrWhiteSpace(giaTien) || string.IsNullOrWhiteSpace(tinhTrang) ||
                string.IsNullOrWhiteSpace(maPhong))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng lặp số phòng
            foreach (DataGridViewRow row in dgvPhongTrong.Rows)
            {
                if (row.Cells["SoPhong"].Value?.ToString() == soPhong)
                {
                    MessageBox.Show("Số phòng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Thêm mới một hàng vào DataGridView
            dgvPhongTrong.Rows.Add(soPhong, loaiPhong, giaTien, tinhTrang, maPhong);
            MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Xóa trắng các trường nhập liệu
            ClearFields();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một hàng hay chưa
            if (dgvPhongTrong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hàng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu từ các TextBox
            string soPhong = txtSoPhong.Text.Trim();
            string loaiPhong = txtLoaiPhong.Text.Trim();
            string giaTien = txtGiaTien.Text.Trim();
            string tinhTrang = txtTinhTrang.Text.Trim();
            string maPhong = txtMaPhong.Text.Trim();

            // Kiểm tra nhập đầy đủ thông tin
            if (string.IsNullOrWhiteSpace(soPhong) || string.IsNullOrWhiteSpace(loaiPhong) ||
                string.IsNullOrWhiteSpace(giaTien) || string.IsNullOrWhiteSpace(tinhTrang) ||
                string.IsNullOrWhiteSpace(maPhong))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cập nhật thông tin hàng đã chọn
            DataGridViewRow selectedRow = dgvPhongTrong.SelectedRows[0];
            selectedRow.Cells["SoPhong"].Value = soPhong;
            selectedRow.Cells["LoaiPhong"].Value = loaiPhong;
            selectedRow.Cells["GiaTien"].Value = giaTien;
            selectedRow.Cells["TinhTrang"].Value = tinhTrang;
            selectedRow.Cells["MaPhong"].Value = maPhong;

            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Xóa trắng các trường nhập liệu
            ClearFields();
        }
        private void dgvPhongTrong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhongTrong.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPhongTrong.SelectedRows[0];

                // Đưa dữ liệu từ hàng được chọn lên các trường nhập liệu
                txtSoPhong.Text = selectedRow.Cells["SoPhong"].Value?.ToString();
                txtLoaiPhong.Text = selectedRow.Cells["LoaiPhong"].Value?.ToString();
                txtGiaTien.Text = selectedRow.Cells["GiaTien"].Value?.ToString();
                txtTinhTrang.Text = selectedRow.Cells["TinhTrang"].Value?.ToString();
                txtMaPhong.Text = selectedRow.Cells["MaPhong"].Value?.ToString();
            }
        }
        private void ClearFields()
        {
            txtSoPhong.Clear();
            txtLoaiPhong.Clear();
            txtGiaTien.Clear();
            txtTinhTrang.Clear();
            txtMaPhong.Clear();
        }

        private void frm_qldsphongtrong_Load(object sender, EventArgs e)
        {
            dgvPhongTrong.CellClick += dgvPhongTrong_SelectionChanged;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (dgvPhongTrong.SelectedRows.Count > 0)
            {
                // Hỏi người dùng có chắc chắn muốn xóa không
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này không?",
                                                       "Xác nhận xóa",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Xóa hàng được chọn
                    foreach (DataGridViewRow row in dgvPhongTrong.SelectedRows)
                    {
                        if (!row.IsNewRow) // Không cho phép xóa dòng mới (trống)
                        {
                            dgvPhongTrong.Rows.Remove(row);
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