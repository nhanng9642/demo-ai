using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnMatHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnLoaiHang_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild!=null)
            {
                ActiveMdiChild.Close();
            }
            frLoaiHang fr = new frLoaiHang();
            fr.MdiParent = this;
            fr.Show();
        }

        private void mnMatHang_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild!=null)
            {
                ActiveMdiChild.Close();
            }
            frMatHang fr = new frMatHang();
            fr.MdiParent = this;
            fr.Show();
        }
    }
}
