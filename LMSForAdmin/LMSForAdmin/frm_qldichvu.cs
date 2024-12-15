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
    public partial class frm_qldichvu : DevExpress.XtraEditors.XtraForm
    {
        public frm_qldichvu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvDichVu.Rows.Add("", "", "", "", "", "", "", "");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvDichVu.SelectedRows.Count > 0)
            {
                // Hỏi người dùng có chắc chắn muốn xóa không
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này không?",
                                                       "Xác nhận xóa",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Xóa hàng được chọn
                    foreach (DataGridViewRow row in dgvDichVu.SelectedRows)
                    {
                        if (!row.IsNewRow) // Không cho phép xóa dòng mới (trống)
                        {
                            dgvDichVu.Rows.Remove(row);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox và DateTimePicker
            string tenKH = txtTenKH.Text;
            string maDatPhong = txtMaDatPhong.Text;
            string phongSo = txtPhongSo.Text;
            string loaiHinhDichVu = txtLoaiHinhDichVu.Text;
            string chiTietYeuCau = txtChiTietYeuCau.Text;
            string giaTien = txtGiaTien.Text;
            string ghiChu = txtGhiChu.Text;
            string thoiGianYeuCau = dtpThoiGianYeuCau.Value.ToString("dd/MM/yyyy");

            // Kiểm tra xem các trường đã được nhập đầy đủ chưa
            if (string.IsNullOrWhiteSpace(tenKH) || string.IsNullOrWhiteSpace(maDatPhong) || string.IsNullOrWhiteSpace(phongSo) ||
                string.IsNullOrWhiteSpace(loaiHinhDichVu) || string.IsNullOrWhiteSpace(chiTietYeuCau) || string.IsNullOrWhiteSpace(giaTien))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng lặp
            

            // Thêm mới một hàng vào DataGridView
            dgvDichVu.Rows.Add(tenKH, phongSo, maDatPhong, loaiHinhDichVu, chiTietYeuCau, giaTien, ghiChu, thoiGianYeuCau);
            MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Xóa trắng các TextBox sau khi thêm
            ClearFields();
        }
        private void ClearFields()
        {
            // Xóa trắng tất cả các TextBox
            txtTenKH.Clear();
            txtPhongSo.Clear();
            txtMaDatPhong.Clear();
            txtLoaiHinhDichVu.Clear();
            txtChiTietYeuCau.Clear();
            txtGiaTien.Clear();
            txtGhiChu.Clear();
            dtpThoiGianYeuCau.Value = DateTime.Now;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một hàng chưa
            if (dgvDichVu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hàng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin từ các TextBox và DateTimePicker
            string tenKH = txtTenKH.Text;
            string maDatPhong = txtMaDatPhong.Text;
            string phongSo = txtPhongSo.Text;
            string loaiHinhDichVu = txtLoaiHinhDichVu.Text;
            string chiTietYeuCau = txtChiTietYeuCau.Text;
            string giaTien = txtGiaTien.Text;
            string ghiChu = txtGhiChu.Text;
            string thoiGianYeuCau = dtpThoiGianYeuCau.Value.ToString("dd/MM/yyyy");

            // Kiểm tra xem các trường đã được nhập đầy đủ chưa
            if (string.IsNullOrWhiteSpace(tenKH) || string.IsNullOrWhiteSpace(maDatPhong) || string.IsNullOrWhiteSpace(phongSo) ||
                string.IsNullOrWhiteSpace(loaiHinhDichVu) || string.IsNullOrWhiteSpace(chiTietYeuCau) || string.IsNullOrWhiteSpace(giaTien))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cập nhật thông tin hàng đã chọn
            DataGridViewRow selectedRow = dgvDichVu.SelectedRows[0];
            selectedRow.Cells["TenKH"].Value = tenKH;
            selectedRow.Cells["PhongSo"].Value = phongSo;
            selectedRow.Cells["MaDatPhong"].Value = maDatPhong;
            selectedRow.Cells["LoaiHinhDichVu"].Value = loaiHinhDichVu;
            selectedRow.Cells["ChiTietYeuCau"].Value = chiTietYeuCau;
            selectedRow.Cells["GiaTien"].Value = giaTien;
            selectedRow.Cells["GhiChu"].Value = ghiChu;
            selectedRow.Cells["ThoiGianYeuCau"].Value = thoiGianYeuCau;

            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Xóa trắng các TextBox sau khi cập nhật
            ClearFields();
        }
        private void dgvDichVu_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một hàng hợp lệ hay chưa
            if (dgvDichVu.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn từ DataGridView
                DataGridViewRow selectedRow = dgvDichVu.SelectedRows[0];

                // Đưa dữ liệu từ hàng lên các trường nhập
                txtTenKH.Text = selectedRow.Cells["TenKH"].Value?.ToString();
                txtPhongSo.Text = selectedRow.Cells["PhongSo"].Value?.ToString();
                txtMaDatPhong.Text = selectedRow.Cells["MaDatPhong"].Value?.ToString();
                txtLoaiHinhDichVu.Text = selectedRow.Cells["LoaiHinhDichVu"].Value?.ToString();
                txtChiTietYeuCau.Text = selectedRow.Cells["ChiTietYeuCau"].Value?.ToString();
                txtGiaTien.Text = selectedRow.Cells["GiaTien"].Value?.ToString();
                txtGhiChu.Text = selectedRow.Cells["GhiChu"].Value?.ToString();

                // Hiển thị giá trị trong DateTimePicker
                if (DateTime.TryParse(selectedRow.Cells["ThoiGianYeuCau"].Value?.ToString(), out DateTime thoiGianYeuCau))
                {
                    dtpThoiGianYeuCau.Value = thoiGianYeuCau;
                }
                else
                {
                    dtpThoiGianYeuCau.Value = DateTime.Now; // Nếu không parse được, đặt mặc định là ngày hiện tại
                }
            }
        }

        private void frm_qldichvu_Load(object sender, EventArgs e)
        {
            dgvDichVu.CellClick += dgvDichVu_SelectionChanged;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (dgvDichVu.SelectedRows.Count > 0)
            {
                // Hỏi người dùng có chắc chắn muốn xóa không
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này không?",
                                                       "Xác nhận xóa",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Xóa hàng được chọn
                    foreach (DataGridViewRow row in dgvDichVu.SelectedRows)
                    {
                        if (!row.IsNewRow) // Không cho phép xóa dòng mới (trống)
                        {
                            dgvDichVu.Rows.Remove(row);
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