namespace LMSForAdmin
{
    partial class frm_qldsphongtrong
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
            this.dgvPhongTrong = new System.Windows.Forms.DataGridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaPhong = new DevExpress.XtraEditors.TextEdit();
            this.txtGiaTien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtLoaiPhong = new DevExpress.XtraEditors.TextEdit();
            this.txtTinhTrang = new DevExpress.XtraEditors.TextEdit();
            this.txtSoPhong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongTrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTinhTrang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhongTrong
            // 
            this.dgvPhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongTrong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhong,
            this.LoaiPhong,
            this.GiaTien,
            this.TinhTrang,
            this.MaPhong});
            this.dgvPhongTrong.Location = new System.Drawing.Point(7, 208);
            this.dgvPhongTrong.Name = "dgvPhongTrong";
            this.dgvPhongTrong.RowHeadersWidth = 51;
            this.dgvPhongTrong.RowTemplate.Height = 24;
            this.dgvPhongTrong.Size = new System.Drawing.Size(680, 251);
            this.dgvPhongTrong.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(466, 126);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(133, 67);
            this.simpleButton1.TabIndex = 105;
            this.simpleButton1.Text = "Xoá";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(65, 126);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(136, 67);
            this.simpleButton4.TabIndex = 104;
            this.simpleButton4.Text = "Thêm mới";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(258, 126);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(133, 67);
            this.simpleButton5.TabIndex = 103;
            this.simpleButton5.Text = "Cập nhật";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(354, 46);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(200, 22);
            this.txtMaPhong.TabIndex = 101;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(354, 6);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(200, 22);
            this.txtGiaTien.TabIndex = 96;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 16);
            this.labelControl1.TabIndex = 95;
            this.labelControl1.Text = "Số phòng :";
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Location = new System.Drawing.Point(85, 80);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(158, 22);
            this.txtLoaiPhong.TabIndex = 94;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(85, 45);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(158, 22);
            this.txtTinhTrang.TabIndex = 93;
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Location = new System.Drawing.Point(85, 12);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(158, 22);
            this.txtSoPhong.TabIndex = 92;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(258, 12);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(56, 16);
            this.labelControl7.TabIndex = 91;
            this.labelControl7.Text = "Giá tiền : ";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(258, 49);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 16);
            this.labelControl5.TabIndex = 89;
            this.labelControl5.Text = "Mã phòng :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(7, 88);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 16);
            this.labelControl4.TabIndex = 88;
            this.labelControl4.Text = "Loại phòng : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 49);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 16);
            this.labelControl3.TabIndex = 87;
            this.labelControl3.Text = "Tình trạng : ";
            // 
            // SoPhong
            // 
            this.SoPhong.HeaderText = "Số phòng";
            this.SoPhong.MinimumWidth = 6;
            this.SoPhong.Name = "SoPhong";
            this.SoPhong.Width = 125;
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.HeaderText = "Loại phòng";
            this.LoaiPhong.MinimumWidth = 6;
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.Width = 125;
            // 
            // GiaTien
            // 
            this.GiaTien.HeaderText = "Giá tiền";
            this.GiaTien.MinimumWidth = 6;
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.Width = 125;
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 125;
            // 
            // MaPhong
            // 
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Width = 125;
            // 
            // frm_qldsphongtrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 462);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtLoaiPhong);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.txtSoPhong);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.dgvPhongTrong);
            this.Name = "frm_qldsphongtrong";
            this.Text = "DS Phòng trống";
            this.Load += new System.EventHandler(this.frm_qldsphongtrong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongTrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTinhTrang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhongTrong;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.TextEdit txtMaPhong;
        private DevExpress.XtraEditors.TextEdit txtGiaTien;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtLoaiPhong;
        private DevExpress.XtraEditors.TextEdit txtTinhTrang;
        private DevExpress.XtraEditors.TextEdit txtSoPhong;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
    }
}