using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baithi
{
    public partial class DataMgrApp : Form
    {
        public static DataIn obj;
        private bool ChangeFlag = false;
        private int RowSelectedIndex = -1;
        private bool ExistId = false;
        private bool FindFlag = false;
        public DataMgrApp()
        {
            obj = new DataIn();
            InitializeComponent();
            dataGridView.DataSource = DataMgrApp.obj.GetData();
            status_TextChanged();
        }

        private void setDataDisplay(DataGridViewRow row)
        {
            goods_num.Text = row.Cells[0].Value.ToString();
            Exp.Text = row.Cells[1].Value.ToString();
            made_date.Text = row.Cells[2].Value.ToString();
            goods_type.Text = row.Cells[3].Value.ToString();
            goods_name.Text = row.Cells[4].Value.ToString();
            company.Text = row.Cells[5].Value.ToString();
            
        }

        private void row_selected(object sender, DataGridViewCellEventArgs e)
        {
            RowSelectedIndex = e.RowIndex;
            DataGridViewRow tmp_row = dataGridView.Rows[RowSelectedIndex];
            setDataDisplay(tmp_row);
            //processDataChanges();
        }

        private void processDataChanges()
        {
            if (System.Convert.ToBoolean(this.RowSelectedIndex >= 0))
            {
                if (goods_num.Modified)
                {
                    if (goods_num.Text != String.Empty)
                    {
                        if (obj.CheckExistNumID(Int16.Parse(goods_num.Text)))
                        {
                            int VisibleTime = 1000;  //in mili
                            ToolTip tt = new ToolTip();
                            tt.Show("Existing ID!!! Pls change it.", goods_num, 20, 0, VisibleTime);
                            this.ExistId = true;
                        }
                        else
                        {
                            ExistId = false;
                        }
                    }
                    ChangeFlag = true;
                }
                else if (Exp.Modified)
                {
                    ChangeFlag = true;
                }
                else if (made_date.Modified)
                {
                    ChangeFlag = true;
                }
                else if (goods_type.Modified)
                {
                    ChangeFlag = true;
                }
                else if (goods_name.Modified)
                {
                    ChangeFlag = true;
                }
                else if (company.Modified)
                {
                    ChangeFlag = true;
                }
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void goods_num_TextChanged(object sender, EventArgs e)
        {
            processDataChanges();
            if (goods_num.Text == String.Empty)
            {
                if (FindFlag)
                {
                    FindFlag = false;
                    resetAllWindows();
                }
            }
        }

        private void goods_name_TextChanged(object sender, EventArgs e)
        {
            processDataChanges();
            if (goods_num.Text == String.Empty)
            {
                if (FindFlag)
                {
                    FindFlag = false;
                    resetAllWindows();
                }
            }
        }

        private void Exp_TextChanged(object sender, EventArgs e)
        {
            processDataChanges();
            if (goods_num.Text == String.Empty)
            {
                if (FindFlag)
                {
                    FindFlag = false;
                    resetAllWindows();
                }
            }
        }

        private void company_TextChanged(object sender, EventArgs e)
        {
            processDataChanges();
            if (goods_num.Text == String.Empty)
            {
                if (FindFlag)
                {
                    FindFlag = false;
                    resetAllWindows();
                }
            }
        }

        private void made_date_TextChanged(object sender, EventArgs e)
        {
            processDataChanges();
            if (goods_num.Text == String.Empty)
            {
                if (FindFlag)
                {
                    FindFlag = false;
                    resetAllWindows();
                }
            }
        }

        private void goods_type_TextChanged(object sender, EventArgs e)
        {
            processDataChanges();
            if (goods_type.Text == String.Empty)
            {
                if (FindFlag)
                {
                    FindFlag = false;
                    resetAllWindows();
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            Data_ tmp = new Data_();
            if (goods_num.Text != String.Empty)
            {
                tmp.MaHang = Int32.Parse(goods_num.Text);
            }
            else
            {
                tmp.MaHang = -1;
            }
            tmp.TenMatHang = goods_name.Text;
            if (Exp.Text != String.Empty)
            {
                tmp.ExpireDate = Int32.Parse(Exp.Text);
            }
            else
            {
                tmp.ExpireDate = -1;
            }
            tmp.CtySX = company.Text;
            if (made_date.Text != String.Empty)
            {
                tmp.NamSX = Int16.Parse(made_date.Text);
            }
            else
            {
                tmp.NamSX = -1;
            }
            if (goods_type.Text != String.Empty)
            {
                tmp.LoaiHang = Int16.Parse(goods_type.Text);
            }
            else
            {
                tmp.LoaiHang = -1;
            }

            if ((tmp.MaHang != -1)&&(tmp.TenMatHang != String.Empty))
            {
                if (!obj.SetData(tmp))
                {
                    goods_num.ResetText();
                }
                else
                {
                    obj.isChanged = true;
                    resetAllWindows();
                }
            }
            else
            {
                MessageBox.Show("Ko có mã hàng hoặc tên hàng!!!");
                clearAllTextBox();
            }
        }

        private void resetAllWindows()
        {
            obj.UpdateDataTable();
            dataGridView.Refresh();
            clearAllTextBox();
            dataGridView.ClearSelection();
            status_TextChanged();
        }

        private void clearAllTextBox()
        {
            goods_type.Clear();
            made_date.Clear();
            company.Clear();
            Exp.Clear();
            goods_name.Clear();
            goods_num.Clear();
        }

        private void Savetmp_Click(object sender, EventArgs e)
        {
            if (ExistId)
            {
                MessageBox.Show("Mã hàng đã tồn tại!!!");
                return;
            }
            if (ChangeFlag)
            {
                Data_ row = new Data_();

                row.MaHang = Int16.Parse(goods_num.Text);
                row.ExpireDate = Int16.Parse(Exp.Text);
                row.NamSX = Int16.Parse(made_date.Text);
                row.LoaiHang = Int16.Parse(goods_type.Text);
                row.TenMatHang = goods_name.Text;
                row.CtySX = company.Text;

                obj.UpdateDataRow(row, RowSelectedIndex);
                obj.isChanged = true;
                ChangeFlag = false;
                RowSelectedIndex = -1;
                resetAllWindows();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (System.Convert.ToBoolean(this.RowSelectedIndex >= 0))
            {
                obj.isChanged = true;
                obj.DeleteDataRow(obj.checkDataList(Int16.Parse(goods_num.Text)));
                RowSelectedIndex = -1;
                resetAllWindows();
            }
        }

        private void find_Click(object sender, EventArgs e)
        {
            FindFlag = true;
            List<Data_> data = new List<Data_>();
            int a = -1;
            if (goods_num.Text != String.Empty)
            {
                a = obj.checkDataList(Int32.Parse(goods_num.Text));
                if (a==-1)
                {
                    MessageBox.Show("Mã hàng ko tồn tại nhé :)))!!");
                    clearAllTextBox();
                    return;
                }
                data.Add(obj.findObjDataList(a));
                if (goods_type.Text != String.Empty)
                {
                    data = obj.findListData(data, Int32.Parse(goods_type.Text), 0);
                    if (data.Count == 0)
                    {
                        MessageBox.Show("Dữ liệu ko tồn tại nhé :)))!!");
                        clearAllTextBox();
                        return;
                    }
                    obj.SetToDataTable(data);
                    dataGridView.Refresh();
                }
                if (made_date.Text != String.Empty)
                {
                    data = obj.findListData(data, Int32.Parse(made_date.Text), 1);
                    if (data.Count == 0)
                    {
                        MessageBox.Show("Dữ liệu ko tồn tại nhé :)))!!");
                        clearAllTextBox();
                        return;
                    }
                    obj.SetToDataTable(data);
                    dataGridView.Refresh();
                }
                if (Exp.Text != String.Empty)
                {
                    data = obj.findListData(data, Int32.Parse(Exp.Text), 2);
                    if (data.Count == 0)
                    {
                        MessageBox.Show("Dữ liệu ko tồn tại nhé :)))!!");
                        clearAllTextBox();
                        return;
                    }
                    obj.SetToDataTable(data);
                    dataGridView.Refresh();
                }
                if (goods_name.Text != String.Empty)
                {
                    data = obj.findListData(data, goods_name.Text, 0);
                    if (data.Count == 0)
                    {
                        MessageBox.Show("Dữ liệu ko tồn tại nhé :)))!!");
                        clearAllTextBox();
                        return;
                    }
                    obj.SetToDataTable(data);
                    dataGridView.Refresh();
                }
                if (company.Text != String.Empty)
                {
                    data = obj.findListData(data, company.Text, 1);
                    if (data.Count == 0)
                    {
                        MessageBox.Show("Dữ liệu ko tồn tại nhé :)))!!");
                        clearAllTextBox();
                        return;
                    }
                    obj.SetToDataTable(data);
                    dataGridView.Refresh();
                }
                obj.SetToDataTable(data);
                dataGridView.Refresh();
            }
            else
            {
                data = obj.getData();
                if (goods_type.Text != String.Empty)
                {
                    data = obj.findListData(data, Int32.Parse(goods_type.Text), 0);
                    if (data.Count == 0)
                    {
                        MessageBox.Show("Dữ liệu ko tồn tại nhé :)))!!");
                        clearAllTextBox();
                        return;
                    }
                    obj.SetToDataTable(data);
                    dataGridView.Refresh();
                }
                if (made_date.Text != String.Empty)
                {
                    data = obj.findListData(data, Int32.Parse(made_date.Text), 1);
                    if (data.Count == 0)
                    {
                        MessageBox.Show("Dữ liệu ko tồn tại nhé :)))!!");
                        clearAllTextBox();
                        return;
                    }
                    obj.SetToDataTable(data);
                    dataGridView.Refresh();
                }
                if (Exp.Text != String.Empty)
                {
                    data = obj.findListData(data, Int32.Parse(Exp.Text), 2);
                    if (data.Count == 0)
                    {
                        MessageBox.Show("Dữ liệu ko tồn tại nhé :)))!!");
                        clearAllTextBox();
                        return;
                    }
                    obj.SetToDataTable(data);
                    dataGridView.Refresh();
                }
                if (goods_name.Text != String.Empty)
                {
                    data = obj.findListData(data, goods_name.Text, 0);
                    if (data.Count == 0)
                    {
                        MessageBox.Show("Dữ liệu ko tồn tại nhé :)))!!");
                        clearAllTextBox();
                        return;
                    }
                    obj.SetToDataTable(data);
                    dataGridView.Refresh();
                }
                if (company.Text != String.Empty)
                {
                    data = obj.findListData(data, company.Text, 1);
                    if (data.Count == 0)
                    {
                        MessageBox.Show("Dữ liệu ko tồn tại nhé :)))!!");
                        clearAllTextBox();
                        return;
                    }
                    obj.SetToDataTable(data);
                    dataGridView.Refresh();
                }
            }
            
            if ((goods_num.Text != String.Empty)&& (goods_type.Text != String.Empty)&& (made_date.Text != String.Empty)
                           && (Exp.Text != String.Empty)&& (goods_name.Text != String.Empty)&& (company.Text != String.Empty))
                MessageBox.Show("Xin hãy nhập thông tin tìm kiếm :)))!!");
            return;
        }

        private void find_MouseEnter(object sender, EventArgs e)
        {
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.find, "Chọn dự liệu để tìm kiếm :<");
        }

        private void accept_Click(object sender, EventArgs e)
        {
            obj.write_data();
            obj.isChanged = false;
            ChangeFlag = false;
            resetAllWindows();
            status_TextChanged();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            obj.reset_changes();
            obj.isChanged = false;
            ChangeFlag = false;
            resetAllWindows();
            status_TextChanged();
        }

        private void status_TextChanged()
        {
            if (obj.isChanged)
            {
                status.Text = "Có thay đổi @@";
            }
            else
            {
                status.Text = "Ko thay đổi @@";
            }
        }

        private void clear_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.clear, "Chọn sp trên bảng để xóa :))");
        }

        private void Savetmp_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.Savetmp, "Lưu thay đổi dữ liệu tạm thời :))");
        }

        private void accept_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.accept, "Ghi dữ liệu xuống database :))");
        }

        private void cancel_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.cancel, "Ko ghi dữ liệu xuống database\n data trở về ban đầu chưa thay đổi :))");
        }
    }
}
