using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class Form1 : Form
    {
        enum FormEditState { Them,Sua }
        FormEditState fES;
        public List<HangHoa> hangHoaList { get; set; }
        public BindingSource BS { get; set; }
        public Form1()
        {
            InitializeComponent();
            hangHoaList = new List<HangHoa>
            {
                new HangHoa{MaHH="hh1",TenHH="iphone X",Cty="apple",LH="dien thoai"},
                new HangHoa{MaHH="hh2",TenHH="iphone 6",Cty="apple",LH="dien thoai"},
                new HangHoa{MaHH="hh3",TenHH="iphone 7",Cty="apple",LH="dien thoai"},
            };
            BS = new BindingSource();
            BS.DataSource = hangHoaList;
            dataGridView1.DataSource = BS;
            dataGridView1.ReadOnly = true;
            btnHuy.Visible = false;
            btnOK.Visible = false;
        }

       

       
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var cr = dataGridView1==null? null: dataGridView1.CurrentRow;
            int rowIndex = cr == null ? -1 : cr.Index;
            bool allowchanged = !(btnOK.Enabled && btnOK.Visible);
            if (rowIndex >=0 && allowchanged )
            {
                txtMaHH.Text = dataGridView1[0, rowIndex].Value?.ToString();
                txtTenHH.Text = dataGridView1[1, rowIndex].Value?.ToString();
                txtCty.Text = dataGridView1[2, rowIndex].Value?.ToString();
                txtLH.Text = dataGridView1[3, rowIndex].Value?.ToString();
                txtNSX.Text = dataGridView1[4, rowIndex].Value?.ToString();
                txtHSD.Text = dataGridView1[5, rowIndex].Value?.ToString();
            }

        }
        private void ResetTextBox()
        {
            txtMaHH.Text = string.Empty;
            txtTenHH.Text = string.Empty;
            txtCty.Text = string.Empty;
            txtLH.Text = string.Empty;
            txtNSX.Text = string.Empty;
            txtHSD.Text = string.Empty;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ChangeButtonState(false);
            fES = FormEditState.Them;
            ResetTextBox();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ChangeButtonState(false);
            fES = FormEditState.Sua;
            dataGridView1.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var cr = dataGridView1 == null ? null : dataGridView1.CurrentRow;
            int rowIndex = cr == null ? -1 : cr.Index;
            if (rowIndex >-1)
            {
                hangHoaList.RemoveAt(rowIndex);
                BS.ResetBindings(false);
            }
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ChangeButtonState(true);
            dataGridView1_SelectionChanged(null, null);

        }
        private void ChangeButtonState(bool check)
        {
           
            btnSua.Enabled = check;
            btnXoa.Enabled = check;
            btnThem.Enabled = check;
            btnHuy.Visible = !check;
            btnOK.Visible = !check;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DateTime nsx;
            DateTime hsd;
            DateTime.TryParse(txtNSX.Text, out nsx);
            DateTime.TryParse(txtHSD.Text, out hsd);
            HangHoa hh = new HangHoa
            {
                MaHH = txtMaHH.Text,
                TenHH = txtTenHH.Text,
                Cty = txtCty.Text,
                LH = txtLH.Text,
                NSX = nsx,
                HSD = hsd
            };
            if (fES == FormEditState.Them)
            {
                hangHoaList.Add(hh);
                BS.ResetBindings(false);
            }
            if (fES == FormEditState.Sua)
            {
                int rowIndex = dataGridView1.CurrentRow.Index;
                hangHoaList[rowIndex] = hh;
                BS.ResetBindings(false);
            }
            ChangeButtonState(true);
            dataGridView1_SelectionChanged(null, null);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
    public class HangHoa
    {
        public string MaHH { get; set; }
        public string TenHH { get; set; }
        public string Cty { get; set; }
        public string LH { get; set; }
        public DateTime NSX { get; set; }
        public DateTime HSD { get; set; }
    }
}
