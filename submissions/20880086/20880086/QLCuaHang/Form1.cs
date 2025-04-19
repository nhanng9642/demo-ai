using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHang
{
    public partial class Form1 : Form
    {      

        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSuaMH.Enabled = false;
            btnSuaLH.Enabled = false;
            try
            {
                CheckLH();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
                
        //--- Quan ly Mat hang -- 

        private void btnClearMH_Click(object sender, EventArgs e)
        {
            ClearFormMH();
            btnThemMH.Enabled = true;
            btnSuaMH.Enabled = false;
        }
        private void btnTimMH_Click(object sender, EventArgs e)
        {
            if(radioMH.Checked)
            {
                ClearFormMH();
                int index = TimMa(dataMH, txtTimMH.Text);
                if (index >= 0)
                {
                    PopulateMH(index);
                    btnSuaMH.Enabled = true;
                    btnThemMH.Enabled = false;
                }
                else
                {
                    MessageBox.Show($"Khong tim thay mat hang theo ma MH: {txtTimMH.Text}");
                }

            }
            else if(radioTH.Checked)
            {
                ClearFormMH();
                indexSuaMH = TimTen(dataMH, txtTimMH.Text);
                if (indexSuaMH >= 0)
                {
                    PopulateMH(indexSuaMH);
                    btnSuaMH.Enabled = true;
                    btnThemMH.Enabled = false;
                }
                else
                {
                    MessageBox.Show($"Khong tim thay mat hang theo ten MH: {txtTimMH.Text}");
                }
            }
        }

        private void btnThemMH_Click(object sender, EventArgs e)
        {
            try
            {
                CheckLH();
                if (txtMH.Text != "" && txtTH.Text != "" && txtCty.Text != "" && cbLH.Text != "")
                {
                    try
                    {
                        int MH = Convert.ToInt32(txtMH.Text);
                        try
                        {
                            CheckMH();
                            try
                            {
                                CheckNSX();
                                dataMH.Rows.Add(txtMH.Text, txtTH.Text, dateHanDung.Text, txtCty.Text, dateNamSX.Text, cbLH.Text);
                                ClearFormMH();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Du lieu Ma Hang phai la so!");
                    }
                }
                else
                {
                    MessageBox.Show("Nhap day du thong tin");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int indexSuaMH = -1;
        private void dataMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            if(dataMH.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == dataMH.Columns.Count - 1 && !dataMH.Rows[e.RowIndex].IsNewRow)
            {
                dataMH.Rows.Remove(dataMH.Rows[e.RowIndex]);
                MessageBox.Show("Xoa thanh cong!");
            }

            if (dataMH.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == dataMH.Columns.Count - 2 && !dataMH.Rows[e.RowIndex].IsNewRow)
            {
                PopulateMH(e.RowIndex);
                indexSuaMH = e.RowIndex;
                btnSuaMH.Enabled = true;
                btnThemMH.Enabled = false;
            }
        }

        private void btnSuaMH_Click(object sender, EventArgs e)
        {
            try
            {
                CheckChonLH();
                dataMH[0, indexSuaMH].Value = txtMH.Text;
                dataMH[1, indexSuaMH].Value = txtTH.Text;
                dataMH[2, indexSuaMH].Value = dateHanDung.Value;
                dataMH[3, indexSuaMH].Value = txtCty.Text;
                dataMH[4, indexSuaMH].Value = dateNamSX.Value;
                dataMH[5, indexSuaMH].Value = cbLH.Text;

                btnSuaMH.Enabled = false;
                btnThemMH.Enabled = true;
                ClearFormMH();
                MessageBox.Show("Sua thanh cong!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }       
        private void ClearFormMH()
        {
            txtMH.Text = "";
            txtTH.Text = "";
            txtCty.Text = "";
            cbLH.Text = "";
        }
       
        private void PopulateMH(int i)
        {
            txtMH.Text = dataMH[0, i].Value.ToString();
            txtTH.Text = dataMH[1, i].Value.ToString();
            dateHanDung.Value = Convert.ToDateTime(dataMH[2, i].Value);
            txtCty.Text = dataMH[3, i].Value.ToString();
            dateNamSX.Value = Convert.ToDateTime(dataMH[4, i].Value);            
            cbLH.SelectedItem = dataMH[5, i].Value.ToString(); 
        }
        //Check Ma la so va khong co trong data
        private void CheckMH()
        {
            int index = TimMa(dataMH, txtMH.Text);
            if(index >= 0)
            {
                throw new Exception("Ma MH da ton tai. Vui long chon ma khac!");
            }
        }
        //Check Ngay SX < HSD
        private void CheckNSX()
        {
            if(dateNamSX.Value > dateHanDung.Value)
            {
                throw new Exception("Mat hang phai duoc san xuat truoc han su dung!");
            }
        }
        private void CheckLH()
        {
            if(cbLH.Items.Count == 0)
            {
                throw new Exception("Vui long them loai hang o trang Quan ly Loai Hang truoc khi su dung!");
            }
        }

        private void CheckChonLH()
        {
            if (cbLH.SelectedIndex == -1)
            {
                throw new Exception("Vui long chon loai hang!");
            }
        }
        // --- Quan ly Loai Hang     

        private void btnClearLH_Click(object sender, EventArgs e)
        {
            ClearFormLH();
            btnThemLH.Enabled = true;
            btnSuaLH.Enabled = false;
        }

        private void btnTimLH_Click(object sender, EventArgs e)
        {
            if (radioMaLH.Checked)
            {
                ClearFormLH();
                int index = TimMa(dataLH, txtTimLH.Text);
                if (index >= 0)
                {
                    PopulateLH(index);
                    btnSuaLH.Enabled = true;
                    btnThemLH.Enabled = false;
                }
                else
                {
                    MessageBox.Show($"Khong tim thay loai hang theo ma LH: {txtTimLH.Text}");
                }

            }
            else if (radioTenLH.Checked)
            {
                ClearFormLH();
                indexSuaLH = TimTen(dataLH, txtTimLH.Text);
                if (indexSuaLH >= 0)
                {
                    PopulateLH(indexSuaLH);
                    btnSuaLH.Enabled = true;
                    btnThemLH.Enabled = false;
                }
                else
                {
                    MessageBox.Show($"Khong tim thay mat hang theo ten LH: {txtTimLH.Text}");
                }
            }
        }
                
        private void btnThemLH_Click(object sender, EventArgs e)
        {
            if(txtMaLH.Text != "" && txtTenLH.Text != "")
            {
                try
                {
                    int ma = Convert.ToInt32(txtMaLH.Text);
                    try
                    {
                        CheckMaLH();
                        dataLH.Rows.Add(txtMaLH.Text, txtTenLH.Text);
                        UpdateLH();
                        ClearFormLH();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch(FormatException)
                {
                    MessageBox.Show("Ma LH phai la so!");
                }
            }
        }

        private void PopulateLH(int i)
        {
            txtMaLH.Text = dataLH[0, i].Value.ToString();
            txtTenLH.Text = dataLH[1, i].Value.ToString();
        }
        private void ClearFormLH()
        {
            txtMaLH.Text = "";
            txtTenLH.Text = "";
        }

        private void CheckMaLH()
        {
            if(TimMa(dataLH, txtMaLH.Text) >= 0)
            {
                throw new Exception("Ma LH da ton tai. Vui long chon Ma LH khac!");
            }
        }
        private int indexSuaLH = -1;
        private void dataLH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataLH.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == dataLH.Columns.Count - 1 && !dataLH.Rows[e.RowIndex].IsNewRow)
            {
                try
                {
                    CheckXoaLH(e.RowIndex);
                    dataLH.Rows.Remove(dataLH.Rows[e.RowIndex]);
                    UpdateLH();
                    MessageBox.Show("Xoa thanh cong!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (dataLH.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == dataLH.Columns.Count - 2 && !dataLH.Rows[e.RowIndex].IsNewRow)
            {
                PopulateLH(e.RowIndex);
                indexSuaLH = e.RowIndex;
                btnSuaLH.Enabled = true;
                btnThemLH.Enabled = false;
            }
        }
        private void btnSuaLH_Click(object sender, EventArgs e)
        {
                UpdateSuaLH(indexSuaLH);

                dataLH[0, indexSuaLH].Value = txtMaLH.Text;
                dataLH[1, indexSuaLH].Value = txtTenLH.Text;

                btnSuaLH.Enabled = false;
                btnThemLH.Enabled = true;                
                ClearFormLH();
                UpdateLH();
                MessageBox.Show("Sua thanh cong!");            
        }
        private void UpdateLH()
        {
            cbLH.Items.Clear();
            for(int i = 0; i < dataLH.Rows.Count - 1; i++)
            {
                cbLH.Items.Add(dataLH[1, i].Value.ToString());
            }
        }

        private void CheckXoaLH(int index)
        {
            for(int i = 0; i < dataMH.Rows.Count - 1; i++)
            {
                if(dataMH[5, i].Value.ToString() == dataLH[1, index].Value.ToString())
                {
                    throw new Exception("Khong the xoa Loai Hang dang duoc su dung o Mat Hang!");
                }
            }
        }

        private void UpdateSuaLH(int index)
        {
            for(int i = 0; i < dataMH.Rows.Count - 1; i++)
            {
                if (dataMH[5, i].Value.ToString() == dataLH[1, index].Value.ToString())
                {
                    dataMH[5, i].Value = txtTenLH.Text;
                }
            }
        }
        // --- Dung chung
        //Search
        private int TimMa(DataGridView dg, string m)
        {
            for (int i = 0; i < dg.Rows.Count - 1; i++)
            {
                if (dg[0, i].Value.ToString() == m)
                {
                    return i;
                }
            }
            return -1;
        }

        private int TimTen(DataGridView dg, string t)
        {
            for (int i = 0; i < dg.Rows.Count - 1; i++)
            {
                if (dg[1, i].Value.ToString() == t)
                {
                    return i;
                }
            }
            return -1;
        }
    }  

}
