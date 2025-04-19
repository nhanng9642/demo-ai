using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class Form2 : Form
    {
        public BindingSource bd = new BindingSource();
        public Form2()
        {
            InitializeComponent();
            bd.DataSource = Form1.lhList;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bd;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool[] checks = new bool[Form1.lhList.Count];
            foreach (var item in Form1.hhList)
            {
                string s = item.LH;
                for (int i = 0; i < Form1.lhList.Count; i++)
                {
                    if (Form1.lhList[i].MaLH == s)
                    {
                        checks[i] = true;
                    }
                }
            }
            if (checks[dataGridView1.CurrentRow.Index])
            {
                MessageBox.Show("Không thể xóa loại hàng này");
                return;
            }
            var index = dataGridView1.CurrentRow.Index;
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && index >= 0)
            {
                Form1.lhList.RemoveAt(index);
                bd.ResetBindings(false);
            }
        }

        private void btnLHTim_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.IsNewRow)
                {
                    continue;
                }
                if (item.Cells[1].Value.ToString().Contains(txtLHTim.Text))
                {
                    item.Visible = true;
                }
                else
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                    currencyManager1.SuspendBinding();
                    item.Visible = false;
                    currencyManager1.ResumeBinding();
                }
            }
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            bool[] checks = new bool[Form1.lhList.Count];
            foreach (var item in Form1.hhList)
            {
                string s = item.LH;
                for (int i = 0; i < Form1.lhList.Count; i++)
                {
                    if (Form1.lhList[i].MaLH == s)
                    {
                        checks[i] = true;
                    }
                }
            }
            if (checks[dataGridView1.CurrentRow.Index])
            {
                MessageBox.Show("Không thể sửa mã loại hàng này");
                e.Cancel = true;
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.EditingControl is TextBox)
            {
                var tb = (TextBox)dataGridView1.EditingControl;
                for (int i = 0; i < Form1.lhList.Count; i++)
                {
                    if (e.RowIndex ==i)
                    {
                        continue;
                    }
                    if (tb.Text == Form1.lhList[i].MaLH)
                    {
                        MessageBox.Show("Ma loai hang bi trung");
                        e.Cancel = true;
                    }
                }
            }
        }

        private void txtLHTim_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
