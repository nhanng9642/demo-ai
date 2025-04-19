using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Cua_Hang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sản Phẩm

        private void XuatGiaoDien1()
        {
            txtMa.Text = "";
            txtTenHang.Text = "";
            txtHanDung.Text = "";
            txtCongtysanxuat.Text = "";
            txtNamsanxuat.Text = "";
            comboBoxLH.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dataGridViewKho.Rows.Count; i ++ )
            
            {              
                DataGridViewRow row1 = dataGridViewKho.Rows[i];
                if (row1.Cells[i] != null && row1.Cells[i].Value != null && txtMa.Text == row1.Cells[i].Value.ToString())
                {
                    MessageBox.Show("Trùng mã sản phẩm, vui lòng nhập lại");
                    return;
                }
                
            }            


            if (txtMa.Text != "" && txtTenHang.Text != "" && txtHanDung.Text != "" && txtCongtysanxuat.Text != "" && txtNamsanxuat.Text != "" && comboBoxLH.Text != "")
            {
                try
                {
                    int namsanxuat = Convert.ToInt32(txtNamsanxuat.Text);
                    dataGridViewKho.Rows.Add(txtMa.Text, txtTenHang.Text, txtHanDung.Text, txtCongtysanxuat.Text, txtNamsanxuat.Text, comboBoxLH.Text);
                    XuatGiaoDien1();
                }


                catch (FormatException)
                {
                    MessageBox.Show("Nhập sai dữ liệu năm");
                }

            }

            else
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin của hàng hóa");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int vitri = dataGridViewKho.CurrentCell.RowIndex;
            if (dataGridViewKho.CurrentCell.ColumnIndex == 5)
            {
                MessageBox.Show("Không thể sửa phân loại sản phẩm");
            }

            else
            {
                dataGridViewKho[0, vitri].Value = txtMa.Text;
                dataGridViewKho[1, vitri].Value = txtTenHang.Text;
                dataGridViewKho[2, vitri].Value = txtHanDung.Text;
                dataGridViewKho[3, vitri].Value = txtCongtysanxuat.Text;
                dataGridViewKho[4, vitri].Value = txtNamsanxuat.Text;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int vitri = dataGridViewKho.CurrentCell.RowIndex;
            if(MessageBox.Show("Bạn có muốn xóa mặt hàng này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridViewKho.Rows.RemoveAt(vitri);
            }    
        }

        private void dataGridViewKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewKho.SelectedCells.Count != 0)
            {
                DataGridViewRow row = dataGridViewKho.Rows[dataGridViewKho.CurrentCell.RowIndex];
                txtMa.Text = row.Cells[0].Value.ToString();
                txtTenHang.Text = row.Cells[1].Value.ToString();
                txtHanDung.Text = row.Cells[2].Value.ToString();
                txtCongtysanxuat.Text = row.Cells[3].Value.ToString();
                txtNamsanxuat.Text = row.Cells[4].Value.ToString();
                comboBoxLH.Text = row.Cells[5].Value.ToString();

            }
        }

        private void dataGridViewLoaiHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewLoaiHang.SelectedCells.Count != 0)
            {
                DataGridViewRow row = dataGridViewLoaiHang.Rows[dataGridViewLoaiHang.CurrentCell.RowIndex];
                txtMaLoaiHang.Text = row.Cells[1].Value.ToString();
                txtTenLoaiHang.Text = row.Cells[0].Value.ToString();
            }
        }

        //Tìm kiếm

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dataGridViewTimkiem.Rows.Clear();
                for (int i = 0; i < dataGridViewKho.Rows.Count - 1; i++)
                {
                    if (dataGridViewKho[0, i].Value.ToString() == txtMa1.Text)
                    {
                        dataGridViewTimkiem.Rows.Add(dataGridViewKho[0, i].Value, dataGridViewKho[1, i].Value, dataGridViewKho[2, i].Value, dataGridViewKho[3, i].Value, dataGridViewKho[4, i].Value, dataGridViewKho[5, i].Value);
                    }
                }
            }

            if (checkBox2.Checked)
            {
                dataGridViewTimkiem.Rows.Clear();
                for (int i = 0; i < dataGridViewKho.Rows.Count - 1; i++)
                {
                    if (dataGridViewKho[1, i].Value.ToString() == txtTenHang1.Text)
                    {
                        dataGridViewTimkiem.Rows.Add(dataGridViewKho[0, i].Value, dataGridViewKho[1, i].Value, dataGridViewKho[2, i].Value, dataGridViewKho[3, i].Value, dataGridViewKho[4, i].Value, dataGridViewKho[5, i].Value);
                    }
                }
            }

            if (checkBox3.Checked)
            {
                dataGridViewTimkiem.Rows.Clear();
                for (int i = 0; i < dataGridViewKho.Rows.Count - 1; i++)
                {
                    if (dataGridViewKho[2, i].Value.ToString() == txtHanDung1.Text)
                    {
                        dataGridViewTimkiem.Rows.Add(dataGridViewKho[0, i].Value, dataGridViewKho[1, i].Value, dataGridViewKho[2, i].Value, dataGridViewKho[3, i].Value, dataGridViewKho[4, i].Value, dataGridViewKho[5, i].Value);
                    }
                }
            }

            if (checkBox4.Checked)
            {
                dataGridViewTimkiem.Rows.Clear();
                for (int i = 0; i < dataGridViewKho.Rows.Count - 1; i++)
                {
                    if (dataGridViewKho[3, i].Value.ToString() == txtCongtysanxuat1.Text)
                    {
                        dataGridViewTimkiem.Rows.Add(dataGridViewKho[0, i].Value, dataGridViewKho[1, i].Value, dataGridViewKho[2, i].Value, dataGridViewKho[3, i].Value, dataGridViewKho[4, i].Value, dataGridViewKho[5, i].Value);
                    }
                }
            }


            if (checkBox5.Checked)
            {
                dataGridViewTimkiem.Rows.Clear();
                for (int i = 0; i < dataGridViewKho.Rows.Count - 1; i++)
                {
                    if (dataGridViewKho[4, i].Value.ToString() == txtNamsanxuat1.Text)
                    {
                        dataGridViewTimkiem.Rows.Add(dataGridViewKho[0, i].Value, dataGridViewKho[1, i].Value, dataGridViewKho[2, i].Value, dataGridViewKho[3, i].Value, dataGridViewKho[4, i].Value, dataGridViewKho[5, i].Value);
                    }
                }
            }


            if (checkBox6.Checked)
            {
                dataGridViewTimkiem.Rows.Clear();
                for (int i = 0; i < dataGridViewKho.Rows.Count - 1; i++)
                {
                    if (dataGridViewKho[5, i].Value.ToString() == txtLoaiHang1.Text)
                    {
                        dataGridViewTimkiem.Rows.Add(dataGridViewKho[0, i].Value, dataGridViewKho[1, i].Value, dataGridViewKho[2, i].Value, dataGridViewKho[3, i].Value, dataGridViewKho[4, i].Value, dataGridViewKho[5, i].Value);
                    }
                }
            }
        }

        // Loại Hàng
        
        public class Emp
        {
            
            public string LoaiHang { get; set; }
            public string Maloaihang { get; set; }
          
            public Emp(string maloaihang, string loaihang)
            {
                
                this.LoaiHang = loaihang;
                this.Maloaihang = maloaihang;
       
            }
        }
     
        List<Emp> dataS = new List<Emp>();
   
        private void btnThemLH_Click_1(object sender, EventArgs e)
        {
            foreach (Emp emp in dataS)
            {
                if (emp.LoaiHang == txtTenLoaiHang.Text || emp.LoaiHang == txtMaLoaiHang.Text)
                {
                    MessageBox.Show("Trùng Mã/Tên Sản phẩm, vui lòng nhập lại");
                    return;
                }

            }

            if (txtTenLoaiHang.Text != "" && txtMaLoaiHang.Text != "")
            {

                dataS.Add(new Emp(txtMaLoaiHang.Text, txtTenLoaiHang.Text));
                dataGridViewLoaiHang.DataSource = new BindingList<Emp>(dataS);
                comboBoxLH.DataSource = new BindingList<Emp>(dataS);
                comboBoxLH.DisplayMember = "LoaiHang";
                comboBoxLH.Refresh();

            }

            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }


        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewLoaiHang.DataSource = new BindingList<Emp>(dataS);
            comboBoxLH.DataSource = new BindingList<Emp>(dataS);
            comboBoxLH.DisplayMember = "LoaiHang";
          
        }

        private void btnXoaLH_Click(object sender, EventArgs e)
        {
            int vitri = dataGridViewLoaiHang.CurrentCell.RowIndex;
            if (MessageBox.Show("Bạn có muốn xóa Loại hàng này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridViewLoaiHang.Rows.RemoveAt(vitri);
                comboBoxLH.DataSource = new BindingList<Emp>(dataS);
                comboBoxLH.ResetText();

            }
        }

        private void btnSuaLH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa Loại hàng này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int vitri = dataGridViewLoaiHang.CurrentCell.RowIndex;
                dataGridViewLoaiHang[0, vitri].Value = txtTenLoaiHang.Text;
                comboBoxLH.DataSource = new BindingList<Emp>(dataS);
                comboBoxLH.ResetText();

            }
        }

    }
}
