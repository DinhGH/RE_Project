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
    public partial class frm_xpcdd : DevExpress.XtraEditors.XtraForm
    {
        public frm_xpcdd()
        {
            InitializeComponent();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frm_tpcdd frm_Tpcdd = new frm_tpcdd();
            frm_Tpcdd.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_xuapcdd frm_Xuapcdd = new frm_xuapcdd();
            frm_Xuapcdd.Show();
        }
    }
}