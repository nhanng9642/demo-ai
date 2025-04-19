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
    public partial class Form1 : Form
    {
        public static List<LoaiHang> lhList = new List<LoaiHang>() { new LoaiHang { MaLH = "lh1", LH = "Xe so" }, 
            new LoaiHang { MaLH = "lh2", LH = "Xe tay ga" },
            new LoaiHang { MaLH = "lh3", LH = "Xe tay con" } };
        public static List<HangHoa> hhList = new List<HangHoa> { new HangHoa {MaHH="hh1",TenHH="WaveAnpha", CongTy="Honda",LH="lh1",NSX="01/01/2020", HSD="31/12/2041" },
         new HangHoa {MaHH="hh2",TenHH="Airblade", CongTy="Honda", LH="lh2",NSX="01/01/2018", HSD="31/12/2038" }, 
         new HangHoa {MaHH="hh3",TenHH="Exciter150", CongTy="Yamaha", LH="lh3",NSX="01/01/2019", HSD="31/12/2039" }};
        public BindingSource bd = new BindingSource();
        public BindingSource hhBD = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            bd.DataSource = lhList;
            this.LoaiHang.DataSource = bd;
            this.LoaiHang.DisplayMember ="LH";
            this.LoaiHang.ValueMember = "MaLH";
            hhBD.DataSource = hhList;
            dataGridView1.DataSource = hhBD;
        }

        private void btnThemLH_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.IsNewRow)
                {
                    continue;
                }
                if (item.Cells["TenHH"].Value.ToString().Contains(txtHHTim.Text))
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = dataGridView1.CurrentRow.Index;
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && index >= 0)
            {
                hhList.RemoveAt(index);
                hhBD.ResetBindings(false);
            }
        }

        private void txtHHTim_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class HangHoa
    {
        public string MaHH { get; set; }
        public string TenHH { get; set; }
        public string CongTy { get; set; }
        public string LH { get; set; }
        public string NSX { get; set; }
        public string HSD { get; set; }
    }
    public class LoaiHang
    {
        public string MaLH { get; set; }
        public string LH { get; set; }
    }
    
}
