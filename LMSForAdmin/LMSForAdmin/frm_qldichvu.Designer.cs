namespace LMSForAdmin
{
    partial class frm_qldichvu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPhongSo = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDatPhong = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtLoaiHinhDichVu = new DevExpress.XtraEditors.TextEdit();
            this.dtpThoiGianYeuCau = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtChiTietYeuCau = new DevExpress.XtraEditors.TextEdit();
            this.txtGiaTien = new DevExpress.XtraEditors.TextEdit();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDatPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiHinhDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTietYeuCau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianYeuCau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhongSo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDatPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiHinhDichVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChiTietYeuCau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenKH,
            this.PhongSo,
            this.MaDatPhong,
            this.LoaiHinhDichVu,
            this.ChiTietYeuCau,
            this.GiaTien,
            this.GhiChu,
            this.ThoiGianYeuCau});
            this.dgvDichVu.Location = new System.Drawing.Point(2, 214);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.RowTemplate.Height = 24;
            this.dgvDichVu.Size = new System.Drawing.Size(1053, 281);
            this.dgvDichVu.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 16);
            this.labelControl1.TabIndex = 59;
            this.labelControl1.Text = "Tên KH :";
            // 
            // txtPhongSo
            // 
            this.txtPhongSo.Location = new System.Drawing.Point(79, 80);
            this.txtPhongSo.Name = "txtPhongSo";
            this.txtPhongSo.Size = new System.Drawing.Size(148, 22);
            this.txtPhongSo.TabIndex = 56;
            // 
            // txtMaDatPhong
            // 
            this.txtMaDatPhong.Location = new System.Drawing.Point(102, 42);
            this.txtMaDatPhong.Name = "txtMaDatPhong";
            this.txtMaDatPhong.Size = new System.Drawing.Size(125, 22);
            this.txtMaDatPhong.TabIndex = 55;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(69, 9);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(158, 22);
            this.txtTenKH.TabIndex = 54;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(240, 9);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(104, 16);
            this.labelControl7.TabIndex = 53;
            this.labelControl7.Text = "Loại hình dịch vụ :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(240, 83);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(52, 16);
            this.labelControl6.TabIndex = 52;
            this.labelControl6.Text = "Giá tiền :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(240, 45);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(101, 16);
            this.labelControl5.TabIndex = 51;
            this.labelControl5.Text = "Chi tiết yêu cầu : ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 85);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 16);
            this.labelControl4.TabIndex = 50;
            this.labelControl4.Text = "Phòng số :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 45);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 16);
            this.labelControl3.TabIndex = 49;
            this.labelControl3.Text = "Mã đặt phòng :";
            // 
            // txtLoaiHinhDichVu
            // 
            this.txtLoaiHinhDichVu.Location = new System.Drawing.Point(360, 3);
            this.txtLoaiHinhDichVu.Name = "txtLoaiHinhDichVu";
            this.txtLoaiHinhDichVu.Size = new System.Drawing.Size(200, 22);
            this.txtLoaiHinhDichVu.TabIndex = 61;
            // 
            // dtpThoiGianYeuCau
            // 
            this.dtpThoiGianYeuCau.Location = new System.Drawing.Point(714, 41);
            this.dtpThoiGianYeuCau.Name = "dtpThoiGianYeuCau";
            this.dtpThoiGianYeuCau.Size = new System.Drawing.Size(200, 23);
            this.dtpThoiGianYeuCau.TabIndex = 58;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(585, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 16);
            this.labelControl2.TabIndex = 62;
            this.labelControl2.Text = "Thời gian yêu cầu";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(585, 6);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(51, 16);
            this.labelControl8.TabIndex = 63;
            this.labelControl8.Text = "Ghi chú :";
            this.labelControl8.Click += new System.EventHandler(this.labelControl8_Click);
            // 
            // txtChiTietYeuCau
            // 
            this.txtChiTietYeuCau.Location = new System.Drawing.Point(360, 40);
            this.txtChiTietYeuCau.Name = "txtChiTietYeuCau";
            this.txtChiTietYeuCau.Size = new System.Drawing.Size(200, 22);
            this.txtChiTietYeuCau.TabIndex = 64;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(360, 82);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(200, 22);
            this.txtGiaTien.TabIndex = 65;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(714, 0);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(200, 22);
            this.txtGhiChu.TabIndex = 66;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(448, 141);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(133, 67);
            this.simpleButton1.TabIndex = 69;
            this.simpleButton1.Text = "Xoá";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(47, 141);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(136, 67);
            this.simpleButton4.TabIndex = 68;
            this.simpleButton4.Text = "Thêm mới";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(240, 141);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(133, 67);
            this.simpleButton5.TabIndex = 67;
            this.simpleButton5.Text = "Cập nhật";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // TenKH
            // 
            this.TenKH.HeaderText = "Tên KH";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 125;
            // 
            // PhongSo
            // 
            this.PhongSo.HeaderText = "Phòng số";
            this.PhongSo.MinimumWidth = 6;
            this.PhongSo.Name = "PhongSo";
            this.PhongSo.Width = 125;
            // 
            // MaDatPhong
            // 
            this.MaDatPhong.HeaderText = "Mã đặt phòng";
            this.MaDatPhong.MinimumWidth = 6;
            this.MaDatPhong.Name = "MaDatPhong";
            this.MaDatPhong.Width = 125;
            // 
            // LoaiHinhDichVu
            // 
            this.LoaiHinhDichVu.HeaderText = "Loại hình dịch vụ";
            this.LoaiHinhDichVu.MinimumWidth = 6;
            this.LoaiHinhDichVu.Name = "LoaiHinhDichVu";
            this.LoaiHinhDichVu.Width = 125;
            // 
            // ChiTietYeuCau
            // 
            this.ChiTietYeuCau.HeaderText = "Chi tiết yêu cầu";
            this.ChiTietYeuCau.MinimumWidth = 6;
            this.ChiTietYeuCau.Name = "ChiTietYeuCau";
            this.ChiTietYeuCau.Width = 125;
            // 
            // GiaTien
            // 
            this.GiaTien.HeaderText = "Giá tiền";
            this.GiaTien.MinimumWidth = 6;
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.Width = 125;
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Width = 125;
            // 
            // ThoiGianYeuCau
            // 
            this.ThoiGianYeuCau.HeaderText = "Thời gian yêu cầu";
            this.ThoiGianYeuCau.MinimumWidth = 6;
            this.ThoiGianYeuCau.Name = "ThoiGianYeuCau";
            this.ThoiGianYeuCau.Width = 125;
            // 
            // frm_qldichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 498);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.txtChiTietYeuCau);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtLoaiHinhDichVu);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtpThoiGianYeuCau);
            this.Controls.Add(this.txtPhongSo);
            this.Controls.Add(this.txtMaDatPhong);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.dgvDichVu);
            this.Name = "frm_qldichvu";
            this.Text = "DS Dịch vụ";
            this.Load += new System.EventHandler(this.frm_qldichvu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhongSo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDatPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiHinhDichVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChiTietYeuCau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDichVu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPhongSo;
        private DevExpress.XtraEditors.TextEdit txtMaDatPhong;
        private DevExpress.XtraEditors.TextEdit txtTenKH;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtLoaiHinhDichVu;
        private System.Windows.Forms.DateTimePicker dtpThoiGianYeuCau;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtChiTietYeuCau;
        private DevExpress.XtraEditors.TextEdit txtGiaTien;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDatPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiHinhDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiTietYeuCau;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianYeuCau;
    }
}