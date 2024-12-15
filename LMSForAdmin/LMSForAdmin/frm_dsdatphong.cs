﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private int selectedRowIndex = -1;
        private frm_dschecked_in formCheckedIn; // Biến lưu form checked-in
        public frm_dsdatphong()
        {
            InitializeComponent();
        }
        
     
       

        private void frm_dsdatphong_Load_1(object sender, EventArgs e)
        {
            dgvDanhSachDatPhong.CellClick += dgvDanhSachDatPhong_CellClick;

        }
        private void dgvDanhSachDatPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng chọn một hàng hợp lệ
            if (e.RowIndex >= 0) // Đảm bảo không chọn vào tiêu đề
            {
                // Lấy hàng được chọn từ DataGridView
                selectedRowIndex = e.RowIndex;
                DataGridViewRow selectedRow = dgvDanhSachDatPhong.Rows[selectedRowIndex];

                // Đưa dữ liệu từ hàng lên các trường nhập
                textEdit1.Text = selectedRow.Cells[0].Value?.ToString();
                textEdit2.Text = selectedRow.Cells[1].Value?.ToString();
                textEdit3.Text = selectedRow.Cells[2].Value?.ToString();

                // Hiển thị giá trị Ngày đặt phòng và Ngày trả phòng
                if (DateTime.TryParse(selectedRow.Cells[3].Value?.ToString(), out DateTime ngayDatPhong))
                {
                    dateTimePicker1.Value = ngayDatPhong;
                }

                if (DateTime.TryParse(selectedRow.Cells[4].Value?.ToString(), out DateTime ngayTraPhong))
                {
                    dateTimePicker2.Value = ngayTraPhong;
                }

                // Xử lý CheckComboBoxEdit (Tình trạng thanh toán)
                string tinhTrangThanhToan = selectedRow.Cells[5].Value?.ToString();
                if (!string.IsNullOrEmpty(tinhTrangThanhToan))
                {
                    // Bỏ chọn tất cả mục trước
                    for (int i = 0; i < checkedComboBoxEdit1.Properties.Items.Count; i++)
                    {
                        checkedComboBoxEdit1.Properties.Items[i].CheckState = CheckState.Unchecked;
                    }

                    // Chọn các mục tương ứng trong CheckComboBoxEdit
                    string[] selectedItems = tinhTrangThanhToan.Split(',');
                    foreach (var item in selectedItems)
                    {
                        for (int i = 0; i < checkedComboBoxEdit1.Properties.Items.Count; i++)
                        {
                            if (checkedComboBoxEdit1.Properties.Items[i].Description.Trim() == item.Trim())
                            {
                                checkedComboBoxEdit1.Properties.Items[i].CheckState = CheckState.Checked;
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một hàng chưa
            if (dgvDanhSachDatPhong.CurrentRow != null)
            {
                // Lấy hàng được chọn
                var selectedRow = dgvDanhSachDatPhong.CurrentRow;
                string tenKH = selectedRow.Cells["TenKH"].Value?.ToString();
                string maDP = selectedRow.Cells["MaDatPhong"].Value?.ToString();
                string soCCCD = selectedRow.Cells["SoCCCD"].Value?.ToString();
                DateTime ngayDatPhong = DateTime.Parse(selectedRow.Cells["NgayDatPhong"].Value?.ToString());
                DateTime ngayTraPhong = DateTime.Parse(selectedRow.Cells["NgayTraPhong"].Value?.ToString());
                string tinhTrang = selectedRow.Cells["TinhTrangThanhToan"].Value?.ToString();

                // Mở form checked-in nếu chưa mở
                if (formCheckedIn == null || formCheckedIn.IsDisposed)
                {
                    formCheckedIn = new frm_dschecked_in();
                }

                // Hiển thị form
                formCheckedIn.Show();

                // Chuyển dữ liệu sang form checked-in
                formCheckedIn.AddCheckedInRow(tenKH, maDP, soCCCD, ngayDatPhong, ngayTraPhong, tinhTrang);

                // Xóa hàng khỏi danh sách hiện tại (nếu cần)
                dgvDanhSachDatPhong.Rows.Remove(selectedRow);

                // Thông báo chuyển thành công
                MessageBox.Show("Đã chuyển dữ liệu vào danh sách checked-in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để chuyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra nếu có hàng đang được chọn
            if (selectedRowIndex >= 0 && selectedRowIndex < dgvDanhSachDatPhong.Rows.Count)
            {
                // Lấy hàng đang được chọn
                DataGridViewRow selectedRow = dgvDanhSachDatPhong.Rows[selectedRowIndex];

                // Cập nhật dữ liệu từ các trường nhập vào hàng đã chọn
                selectedRow.Cells[0].Value = textEdit1.Text;
                selectedRow.Cells[1].Value = textEdit2.Text;
                selectedRow.Cells[2].Value = textEdit3.Text;
                selectedRow.Cells[3].Value = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                selectedRow.Cells[4].Value = dateTimePicker2.Value.ToString("dd/MM/yyyy");
                selectedRow.Cells[5].Value = checkedComboBoxEdit1.Properties.GetCheckedItems().ToString();

                // Hiển thị thông báo cập nhật thành công
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Thông báo nếu không có hàng nào được chọn
                MessageBox.Show("Vui lòng chọn một hàng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachDatPhong.SelectedRows.Count > 0)
            {
                // Hỏi người dùng có chắc chắn muốn xóa không
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này không?",
                                                       "Xác nhận xóa",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Xóa hàng được chọn
                    foreach (DataGridViewRow row in dgvDanhSachDatPhong.SelectedRows)
                    {
                        if (!row.IsNewRow) // Không cho phép xóa dòng mới (trống)
                        {
                            dgvDanhSachDatPhong.Rows.Remove(row);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các textbox
             string tenKH = textEdit1.Text;
            string maDatPhong = textEdit2.Text;
            string soCCCD = textEdit3.Text;
            DateTime ngayDatPhong = dateTimePicker1.Value;
            DateTime ngayTraPhong = dateTimePicker2.Value;
            string tinhTrangThanhToan = checkedComboBoxEdit1.Properties.GetCheckedItems().ToString();

            // Kiểm tra nếu các trường cần thiết bị bỏ trống
            if (string.IsNullOrWhiteSpace(tenKH) || string.IsNullOrWhiteSpace(maDatPhong) || string.IsNullOrWhiteSpace(soCCCD))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm thông tin vào DataGridView
            dgvDanhSachDatPhong.Rows.Add(tenKH, maDatPhong, soCCCD, ngayDatPhong.ToString("dd/MM/yyyy"), ngayTraPhong.ToString("dd/MM/yyyy"), tinhTrangThanhToan);

            // Xóa trắng các trường sau khi thêm
            textEdit1.Clear();
            textEdit2.Clear();
            textEdit3.Clear();
            for (int i = 0; i < checkedComboBoxEdit1.Properties.Items.Count; i++)
            {
                checkedComboBoxEdit1.Properties.Items[i].CheckState = CheckState.Unchecked;
            }
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;

            // Hiển thị thông báo
            MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    }