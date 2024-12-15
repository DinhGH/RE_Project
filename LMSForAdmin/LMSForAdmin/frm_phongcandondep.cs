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
    public partial class frm_phongcandondep : DevExpress.XtraEditors.XtraForm
    {
        public frm_phongcandondep()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_xpcdd frm_Xpcdd = new frm_xpcdd();
            frm_Xpcdd.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frm_tpcdd frm_Tpcdd = new frm_tpcdd();
            frm_Tpcdd.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            frm_xuapcdd frm_Xuapcdd = new frm_xuapcdd();
            frm_Xuapcdd.Show();
        }
    }
}