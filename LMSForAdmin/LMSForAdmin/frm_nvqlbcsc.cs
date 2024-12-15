﻿using DevExpress.XtraEditors;
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
    public partial class frm_nvqlbcsc : DevExpress.XtraEditors.XtraForm
    {
        public frm_nvqlbcsc()
        {
            InitializeComponent();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_xembc Xembc = new frm_xembc();
            Xembc.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frm_tbc tbc = new frm_tbc();
            tbc.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frm_xoabc xoabc = new frm_xoabc();
            xoabc.Show();
        }
    }
}