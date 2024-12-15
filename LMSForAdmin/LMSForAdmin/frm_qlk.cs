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
    public partial class frm_qlk : DevExpress.XtraEditors.XtraForm
    {
        public frm_qlk()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_nvnk nk = new frm_nvnk();
            nk.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frm_xk xk = new frm_xk();
            xk.Show();
        }
    }
}