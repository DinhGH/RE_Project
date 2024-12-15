using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSForAdmin
{
    public partial class frm_xemycdv : DevExpress.XtraEditors.XtraForm
    {
        public frm_xemycdv()
        {
            InitializeComponent();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            frm_sycdv frm_Sycdv = new frm_sycdv();
            frm_Sycdv.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frm_tycdv dv = new frm_tycdv();
            dv.Show();
        }
    }
}