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
    public partial class frm_nvnk : DevExpress.XtraEditors.XtraForm
    {
        public frm_nvnk()
        {
            InitializeComponent();
        }
        private void labelControl5_Click(object sender, EventArgs e)
        {

        }
frm_qlk frm_Qlk = new frm_qlk();
            frm_Qlk.Show();
        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            
        }
    }
}