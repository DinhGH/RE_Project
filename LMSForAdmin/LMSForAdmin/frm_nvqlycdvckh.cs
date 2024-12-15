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
    public partial class frm_nvqlycdvckh : DevExpress.XtraEditors.XtraForm
    {
        public frm_nvqlycdvckh()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_xemycdv frm_Xemycdv = new frm_xemycdv();
            frm_Xemycdv.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frm_tycdv dv = new frm_tycdv();
            dv.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            frm_sycdv frm_Sycdv = new frm_sycdv();
            frm_Sycdv.Show();
        }
    }
}