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

namespace LMSForAdmin
{
    public partial class Home_admin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
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
            frm_dsycdv frm_Dsycdv = new frm_dsycdv();
            frm_Dsycdv.MdiParent = this;
            frm_Dsycdv.Show();

        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = this;
            frm_quanlibcsc frm_Quanlibcsc = new frm_quanlibcsc();
            frm_Quanlibcsc.MdiParent = this;
            frm_Quanlibcsc.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = this;
            frm_xuathang frm_Xuathang = new frm_xuathang();
            frm_Xuathang.MdiParent = this;
            frm_Xuathang.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = this;
            frm_nhaphang frm_Nhaphang = new frm_nhaphang();
            frm_Nhaphang.MdiParent = this;
            frm_Nhaphang.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_kiemtramdp frm_Kiemtramdp = new frm_kiemtramdp();
            frm_Kiemtramdp.Show(); 
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_dsdatphong frm_Dsdatphong = new frm_dsdatphong(); 
            frm_Dsdatphong.Show();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_dschecked_in frm_Dschecked_In = new frm_dschecked_in(); 
            frm_Dschecked_In.Show();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_dscheck_out frm_Dscheck_Out = new frm_dscheck_out();
            frm_Dscheck_Out.Show();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_qldsphongtrong frm_Qldsphongtrong = new frm_qldsphongtrong();
            frm_Qldsphongtrong.Show();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_qldsphongdat frm_Qldsphongdat = new frm_qldsphongdat();
            frm_Qldsphongdat.Show();
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_qldichvu frm_Qldichvu = new frm_qldichvu();
            frm_Qldichvu.Show();
        }

        private void I_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_inhoadon frm_Inhoadon = new frm_inhoadon();
            frm_Inhoadon.Show();   
        }
    }
}