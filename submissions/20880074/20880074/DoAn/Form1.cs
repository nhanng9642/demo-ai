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
        //khai báo enum. 
        enum FormEditState { Them,Sua }
        // nếu ko muốn dùng enum có thể khai báo là: string fES;
        FormEditState fES;
        public Form1()
        {
            InitializeComponent();
            // Thêm dữ liệu cho datagridview. cột nào ko muốn điền dữ liệu thì ghi null.
            dataGridView1.Rows.Add("001", "Cafe Trung Nguyen", "Trung Nguyen", "Thực Phẩm", null, null);
            dataGridView1.Rows.Add("002", "Kem Danh Rang P/S", "P/S", "My Pham", null, null);
            dataGridView1.Rows.Add("003", "Laptop", "Phong Vu", "Dien Tu", null, null);
            dataGridView1.Rows.Add("004", "Tu Lanh", "Nguyen Kim", "Dien Tu", null, null);
            // ko cho edit datagridview.
            dataGridView1.ReadOnly = true;
            // chỉnh trạng thái cho button
            ChangeButtonState(true); 
            // chỉ có thể select 1 row hoặc cell tại 1 thời điểm.
            dataGridView1.MultiSelect = false;
        }
        //mỗi khi select 1 dòng trong datagridview. textbox sẽ hiển thị dòng tương ứng.
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // lấy index của dòng đang dc select trong datagridview.
            var cr = dataGridView1==null? null: dataGridView1.CurrentRow;
            int rowIndex = cr == null ? -1 : cr.Index;


            bool allowchanged = !(btnOK.Enabled && btnOK.Visible);
            if (rowIndex >=0 && allowchanged )
            {
                // gán các giá trị của dòng hiện tại trong datagridview vào textbox
                txtMaHH.Text = dataGridView1[0, rowIndex].Value?.ToString();
                txtTenHH.Text = dataGridView1[1, rowIndex].Value?.ToString();
                txtCty.Text = dataGridView1[2, rowIndex].Value?.ToString();
                txtLH.Text = dataGridView1[3, rowIndex].Value?.ToString();
                txtNSX.Text = dataGridView1[4, rowIndex].Value?.ToString();
                txtHSD.Text = dataGridView1[5, rowIndex].Value?.ToString();
            }

        }
        // xóa dữ liệu trong textbox
        private void ResetTextBox()
        {
            txtMaHH.Text = string.Empty;
            txtTenHH.Text = string.Empty;
            txtCty.Text = string.Empty;
            txtLH.Text = string.Empty;
            txtNSX.Text = string.Empty;
            txtHSD.Text = string.Empty;
        }
        // chuẩn bị để thêm dữ liệu
        private void btnThem_Click(object sender, EventArgs e)
        {
            ChangeButtonState(false);
            // gán thuộc tính fES = them. nếu fES là string thì gán fES = "them".
            fES = FormEditState.Them;
            ResetTextBox();
        }
        // chuẩn bị để sửa dữ liệu
        private void btnSua_Click(object sender, EventArgs e)
        {
            ChangeButtonState(false);
            fES = FormEditState.Sua;
            dataGridView1.Enabled = false;
        }
       
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // try catch để xử lý lỗi.Nếu ko có try catch, trong trường hợp cậu lệnh trong khối try bị lỗi, sẽ khiến chương trình bị dừng. Khi có try catch
            // chương trình vẫn tiếp tục chạy và bỏ qua lỗi đó. Những lệnh trong catch sẽ dc chạy khi có lỗi xảy ra.
            try
            {
                //show 1 cái thông điệp hỏi user có muốn xóa ko? 
                var result = MessageBox.Show("Bạn có muốn xóa ko?", "Thông báo", MessageBoxButtons.YesNo);
                if (result== DialogResult.Yes)
                {
                    // xóa dòng hiện tại của datagridview
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                }
                //Nếu ko muốn hỏi user thì xóa hết đoạn message trên và dữ lại mỗi dòng: dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index); là đủ .

            }
            catch (Exception)
            {
                // show 1 cái thông điệp báo lỗi. Thông điệp này ko quan trọng có thể bỏ đi và để catch rỗng mà chẳng ảnh hưởng gì. 
                MessageBox.Show("Ko thể xóa nữa");
            }
           
        }
        // hủy việc thêm hoặc sửa.
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ChangeButtonState(true);
            // hiển thị nội dung của dòng hiện tại trong datagridview lên từng textbox tương ứng.
            dataGridView1_SelectionChanged(null, null);
            // cho phép select datagridview.
            dataGridView1.Enabled = true;
        }
        // enabble = true: button có thể click dc. Visible = false: ko hiển thị button. readonly =true: textbox ko thể bị edit.
        private void ChangeButtonState(bool check)
        {
            btnThoat.Enabled = check;
            btnSua.Enabled = check;
            btnXoa.Enabled = check;
            btnThem.Enabled = check;
            btnHuy.Visible = !check;
            btnOK.Visible = !check;

            txtMaHH.ReadOnly = check;
            txtTenHH.ReadOnly = check;
            txtCty.ReadOnly = check;
            txtLH.ReadOnly = check;
            txtNSX.ReadOnly = check;
            txtHSD.ReadOnly = check;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DateTime nsx;
            DateTime hsd;
            string nsxString = string.Empty;
            string hsdString = string.Empty;
            // kiểm tra xem text box có bị rỗng ko
            if (!string.IsNullOrWhiteSpace(txtNSX.Text))
            {
                //convert text thành kiểu datetime. Nếu ko convert dc check =false.
                bool check = DateTime.TryParse(txtNSX.Text, out nsx);
                if (check )
                    //convert kiểu datetime thành kiểu string, "d" là định dạng short date (là định dạng ko có giờ)
                    nsxString = nsx.ToString("d");
            }
            
            if (!string.IsNullOrWhiteSpace(txtHSD.Text))
            {
                bool check = DateTime.TryParse(txtHSD.Text, out hsd);
                if (check)
                    hsdString = hsd.ToString("d");
            }
            //  thêm dữ liệu vào datagridview. nếu dùng string thì fES =="them";
            if (fES == FormEditState.Them)
            {
                dataGridView1.Rows.Add(txtMaHH.Text, txtTenHH.Text, txtCty.Text, txtLH.Text,nsxString,hsdString);
            }
            // sửa dữ liệu. nếu dùng string thì fES ="sua";
            if (fES == FormEditState.Sua)
            {
                // lấy ra row hiện tại.
                var row= dataGridView1.CurrentRow;
                // update dữ liệu = giá trị của textbox . 0 là cột đầu tiên và 1 là cột tiếp theo ....
                row.Cells[0].Value = txtMaHH.Text;
                row.Cells[1].Value = txtTenHH.Text;
                row.Cells[2].Value = txtCty.Text;
                row.Cells[3].Value = txtLH.Text;
                row.Cells[4].Value = nsxString;
                row.Cells[5].Value = hsdString;
            }
            dataGridView1.Enabled = true;
            ChangeButtonState(true);
            dataGridView1_SelectionChanged(null, null);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            // thoát chương trình
            Application.Exit();
        }
    }
    
}
