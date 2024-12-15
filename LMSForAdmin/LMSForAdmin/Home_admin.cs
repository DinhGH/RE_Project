using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace LMSForAdmin
{
    public partial class Home_admin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private frm_dschecked_in frmCheckIn;
        private frm_dsdatphong frmDSDatPhong;
        private frm_dscheck_out frmCheckOut;
        private frm_qldichvu frmQldichvu;
        private frm_qldsphongdat frmQlPhongdat;
        private frm_qldsphongtrong frmQlPhongtrong;
        private frm_inhoadon frm_Inhoadon;
        private frm_kiemtramdp frmKtraMDP;
        public Home_admin()
        {
            InitializeComponent();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = this;
            frm_sodophong frm_Sodophong = new frm_sodophong();
            frm_Sodophong.MdiParent = this;
            frm_Sodophong.Show();
        }
        private void OpenOrActivateForm<T>(ref T formInstance) where T : Form, new()
        {
            if (formInstance == null || formInstance.IsDisposed)
            {
                // Tạo mới nếu form chưa tồn tại hoặc đã bị đóng
                formInstance = new T { MdiParent = this };
                formInstance.Show();
            }
            else
            {
                // Nếu đã mở, kích hoạt lại
                formInstance.Activate();
            }
        }
        private void Home_admin_Load(object sender, EventArgs e)
        {

        }

        private void imageEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = this;
            frm_phongcandondep frm_Phongcandondep = new frm_phongcandondep();
            frm_Phongcandondep.MdiParent = this;
            frm_Phongcandondep.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = this;
            frm_nvqlycdvckh frm_Dsycdv = new frm_nvqlycdvckh();
            frm_Dsycdv.MdiParent = this;
            frm_Dsycdv.Show();

        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = this;
            frm_nvqlbcsc frm_Quanlibcsc = new frm_nvqlbcsc();
            frm_Quanlibcsc.MdiParent = this;
            frm_Quanlibcsc.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = this;
            frm_xk frm_Xuathang = new frm_xk();
            frm_Xuathang.MdiParent = this;
            frm_Xuathang.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = this;
            frm_nvnk frm_Nhaphang = new frm_nvnk();
            frm_Nhaphang.MdiParent = this;
            frm_Nhaphang.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {

            OpenOrActivateForm(ref frmKtraMDP);
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenOrActivateForm(ref frmDSDatPhong);

            if (frmCheckIn == null || frmCheckIn.IsDisposed)
            {
                frmCheckIn = new frm_dschecked_in();
                frmCheckIn.MdiParent = this;
                frmCheckIn.Show();
            }
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {

            OpenOrActivateForm(ref frmCheckIn);
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {

            OpenOrActivateForm(ref frmCheckOut);

        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            
            OpenOrActivateForm(ref frmQlPhongtrong);
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {

            OpenOrActivateForm(ref frmQlPhongdat);
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            
            OpenOrActivateForm(ref frmQldichvu);
        }

        private void I_ItemClick(object sender, ItemClickEventArgs e)
        {

            OpenOrActivateForm(ref frm_Inhoadon);
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

    }
}