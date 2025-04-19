using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NMLT_QLCH_WindowsFormsApp.Models;

namespace NMLT_QLCH_WindowsFormsApp
{
    public partial class FormQuanLy : Form
    {
        private const string DefaultDateFormat = "dd/MM/yyyy";
        private ArrayList lstSanPham;
        private ArrayList lstLoaiHang;

        public FormQuanLy()
        {
            InitializeComponent();
            lstSanPham = new ArrayList();
            lstLoaiHang = new ArrayList();




            btnXoa.Visible = btnUndo.Visible = btnSave.Visible = false;
            pnlThongTinHang.Enabled = false;

            btnXoaLoaiHang.Visible = btnUndoLoaiHang.Visible = btnSaveLoaiHang.Visible = false;
            pnlThongTinLoaiHang.Enabled = false;


            ResetPanelSanPham();
            ResetPanelLoaiHang();
        }



        #region SanPham
        private SanPham SanPham_SelectedItem => lstvHang.SelectedItems.Count > 0 ? (SanPham)lstvHang.SelectedItems[0].Tag : new SanPham() { IsNullStruct = true };
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                Utilities.ShowErrorBox($"Xin nhập Tên mặt hàng cần tìm");
                return;
            }

            ArrayList lstResult = new ArrayList();
            string textToSearch = txtSearch.Text.Trim();
            foreach (SanPham sp in lstSanPham)
            {
                if (sp.Ten.ToLowerInvariant().Contains(textToSearch.ToLowerInvariant()))
                {
                    lstResult.Add(
                        sp
                    //    new SanPham
                    //{
                    //    MaHang = sp.MaHang,
                    //    Ten = sp.Ten,
                    //    NoiSanXuat = sp.NoiSanXuat,
                    //    LoaiHang = sp.LoaiHang,
                    //    NgaySanXuat = sp.NgaySanXuat,
                    //    HanDungTheoNgay = sp.HanDungTheoNgay
                    //}
                    );
                    ;
                }
            }
            if (lstResult.Count == 0)
            {
                Utilities.ShowInfoBox($"Không tìm thấy mặt hàng nào chứa '{textToSearch}'");
                return;
            }

            BindSanPhamListView(lstResult.ToArray());
            ResetPanelSanPham();
            TooggleSaveButton();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            BindSanPhamListView(this.lstSanPham.ToArray());
            ResetPanelSanPham();
            TooggleSaveButton();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetPanelSanPham();
            TooggleSaveButton(true);
            btnXoa.Visible = false;
            txtMaHang.Focus();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (SanPham_SelectedItem.IsNullStruct)
            {
                Utilities.ShowErrorBox($"Xin chọn mặt hàng cần xóa");
                return;
            }
            if (Utilities.ShowConfirmBox($"Bạn có muốn xóa Mặt hàng có Mã sau '{SanPham_SelectedItem.MaHang}' hay không?") == DialogResult.Yes)
            {
                //remove selected item
                int foundIndex = FindSanPhamIndex(SanPham_SelectedItem.MaHang);
                var lh = (SanPham)this.lstSanPham[foundIndex];
                this.lstSanPham.RemoveAt(foundIndex);
                Utilities.ShowInfoBox($"Xóa mặt hàng có Mã sau: '{lh.MaHang}', {Environment.NewLine}và tên: '{lh.Ten}' thành công");
                BindSanPhamListView(this.lstSanPham.ToArray());
                ResetPanelSanPham();
                TooggleSaveButton();
            }
        }
        private void btnUndo_Click(object sender, EventArgs e)
        {
            ResetPanelSanPham();
            TooggleSaveButton();
            lstvHang.SelectedItems.Clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHang.Text))
            {
                Utilities.ShowErrorBox($"Xin nhập Mã Hàng");
                return;
            }

            SanPham newItem = new SanPham
            {
                MaHang = txtMaHang.Text.Trim(),
                Ten = txtTenHang.Text.Trim(),
                HanDungTheoNgay = (int)numHanDungTheoNgay.Value,
                NgaySanXuat = dtpNgaySanXuat.Value,
                NoiSanXuat = txtNoiSanXuat.Text,
                LoaiHang = (LoaiHang)(cbbLoaiHang.SelectedItem != null ? cbbLoaiHang.SelectedItem : new LoaiHang() { IsNullStruct = true })
            };
            var id = SanPham_SelectedItem.IsNullStruct ? newItem.MaHang : SanPham_SelectedItem.MaHang;

            int foundIndex = FindSanPhamIndex(id);
            if (SanPham_SelectedItem.IsNullStruct && foundIndex > -1)
            {
                Utilities.ShowErrorBox($"Mã hàng '{newItem.MaHang}' đã tồn tại, xin nhập mã khác hoặc chọn loại hàng trong danh sách hàng để cập nhật");
                return;
            }

            if (foundIndex > -1)
            {
                //update
                this.lstSanPham.RemoveAt(foundIndex);
                this.lstSanPham.Insert(foundIndex, newItem);
            }
            else
            {
                //add new
                this.lstSanPham.Add(newItem);
            }

            BindSanPhamListView(this.lstSanPham.ToArray());
            Utilities.ShowInfoBox($"Lưu mặt hàng có Mã sau: '{newItem.MaHang}', {Environment.NewLine}và tên: '{newItem.Ten}' thành công");
            ResetPanelSanPham();
            TooggleSaveButton();
            txtSearch.Clear();
            txtSearch.Focus();
        }
        private void lstvHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!SanPham_SelectedItem.IsNullStruct && !string.IsNullOrEmpty(SanPham_SelectedItem.MaHang))
            {
                txtMaHang.Text = SanPham_SelectedItem.MaHang;
                txtTenHang.Text = SanPham_SelectedItem.Ten;
                txtNoiSanXuat.Text = SanPham_SelectedItem.NoiSanXuat;
                cbbLoaiHang.SelectedValue = SanPham_SelectedItem.LoaiHang.Id;
                dtpNgaySanXuat.Value = SanPham_SelectedItem.NgaySanXuat;
                numHanDungTheoNgay.Value = SanPham_SelectedItem.HanDungTheoNgay;
                dtpNgayHetHan.Value = SanPham_SelectedItem.NgayHetHan;

                btnThem.Visible = false;
                btnXoa.Visible = btnUndo.Visible = btnSave.Visible = true;

                pnlThongTinHang.Enabled = true;
            }
            else
            {
                btnXoa.Visible = btnUndo.Visible = btnSave.Visible = false;
            }
        }

        private int FindSanPhamIndex(string maHang)
        {
            var foundIndex = -1;
            for (int i = 0; i < this.lstSanPham.Count; i++)
            {
                SanPham item = (SanPham)this.lstSanPham[i];
                if (maHang.Equals(item.MaHang))
                {
                    foundIndex = i;
                    break;
                }
            }
            return foundIndex;
        }

        private void BindSanPhamListView(object[] lstSP)
        {
            lstvHang.Items.Clear();
            foreach (SanPham hang in lstSP)
            {
                var item = new ListViewItem(new string[] { hang.MaHang, hang.Ten, hang.NoiSanXuat, hang.LoaiHang.Ten, hang.NgaySanXuat.ToString(DefaultDateFormat), hang.HanDungTheoNgay.ToString(), hang.NgayHetHan.ToString(DefaultDateFormat) });
                item.Tag = hang;
                lstvHang.Items.Add(item);
            }
        }

        private void TooggleSaveButton(bool isShow = false)
        {
            var invertOthers = !isShow;
            btnXoa.Visible = btnUndo.Visible = btnSave.Visible = isShow;
            pnlThongTinHang.Enabled = isShow;

            btnThem.Visible = invertOthers;
        }

        private void ResetPanelSanPham()
        {
            if (cbbLoaiHang.Items.Count > 0)
            {
                cbbLoaiHang.SelectedIndex = 0;
            }
            dtpNgaySanXuat.Value = DateTime.Today;
            numHanDungTheoNgay.Value = 1;
            dtpNgayHetHan.Value = dtpNgaySanXuat.Value.AddDays((int)numHanDungTheoNgay.Value);
            txtNoiSanXuat.Clear();
            txtTenHang.Clear();
            txtMaHang.Clear();
            txtMaHang.Focus();
        }

        #endregion

        #region Loai Hang

        private LoaiHang LoaiHang_SelectedItem => lstvLoaiHang.SelectedItems.Count > 0 ? (LoaiHang)lstvLoaiHang.SelectedItems[0].Tag : new LoaiHang() { IsNullStruct = true };

        private void btnSearchLoaiHang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchLoaiHang.Text))
            {
                Utilities.ShowErrorBox($"Xin nhập Tên loại hàng cần tìm");
                return;
            }

            ArrayList lstLoaiHangResult = new ArrayList();
            string textToSearch = txtSearchLoaiHang.Text.Trim();
            foreach (LoaiHang loaihang in lstLoaiHang)
            {
                if (loaihang.Ten.ToLowerInvariant().Contains(textToSearch.ToLowerInvariant()))
                {
                    lstLoaiHangResult.Add(loaihang
                    //    new LoaiHang
                    //{
                    //    Id = loaihang.Id,
                    //    Ten = loaihang.Ten
                    //}
                        );
                }
            }
            if (lstLoaiHangResult.Count == 0)
            {
                Utilities.ShowInfoBox($"Không tìm thấy loại hàng nào chứa '{textToSearch}'");
                return;
            }

            BindLoaiHangListView(lstLoaiHangResult.ToArray());
            ResetPanelLoaiHang();
            TooggleSaveLoaiHangButton();
        }
        private void btnRefreshLoaihang_Click(object sender, EventArgs e)
        {
            txtSearchLoaiHang.Clear();
            BindLoaiHangListView(this.lstLoaiHang.ToArray());
            ResetPanelLoaiHang();
            TooggleSaveLoaiHangButton();
        }
        private void btnThemLoaiHang_Click(object sender, EventArgs e)
        {
            TooggleSaveLoaiHangButton(true);
            ResetPanelLoaiHang();
            btnXoaLoaiHang.Visible = false;
        }
        private void btnXoaLoaiHang_Click(object sender, EventArgs e)
        {
            if (LoaiHang_SelectedItem.IsNullStruct)
            {
                Utilities.ShowErrorBox($"Xin chọn loại hàng cần xóa");
                return;
            }

            if (IsInUse(LoaiHang_SelectedItem.Id))
            {
                Utilities.ShowErrorBox($"Không thể xóa! {Environment.NewLine}Loại hàng cần xóa vẫn còn đang được sử dụng đến ở 1 số sản phẩm.");
                return;
            }

            if (Utilities.ShowConfirmBox($"Bạn có muốn xóa Loại hàng có Mã sau '{LoaiHang_SelectedItem.Id}' hay không?") == DialogResult.Yes)
            {
                int foundIndex = FindLoaiHangIndex(LoaiHang_SelectedItem.Id);
                var lh = (LoaiHang)this.lstLoaiHang[foundIndex];
                this.lstLoaiHang.RemoveAt(foundIndex);
                Utilities.ShowInfoBox($"Xóa loại hàng có Mã sau: '{lh.Id}', và tên: '{lh.Ten}' thành công");
                BindLoaiHangListView(this.lstLoaiHang.ToArray());
                ResetPanelLoaiHang();
                TooggleSaveLoaiHangButton();
            }
        }

        private bool IsInUse(string id)
        {
            foreach (SanPham item in this.lstSanPham)
            {
                if (!item.IsNullStruct && !item.LoaiHang.IsNullStruct && item.LoaiHang.Id.Equals(id, StringComparison.InvariantCultureIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnUndoLoaiHang_Click(object sender, EventArgs e)
        {
            ResetPanelLoaiHang();
            TooggleSaveLoaiHangButton();
            lstvLoaiHang.SelectedItems.Clear();
        }
        private void btnSaveLoaiHang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLoaiHang.Text))
            {
                Utilities.ShowErrorBox($"Xin nhập Mã loại hàng");
                return;
            }

            LoaiHang newItem = new LoaiHang
            {
                Id = txtMaLoaiHang.Text.Trim(),
                Ten = txtTenLoaiHang.Text.Trim()
            };
            var id = LoaiHang_SelectedItem.IsNullStruct ? newItem.Id : LoaiHang_SelectedItem.Id;

            int foundIndex = FindLoaiHangIndex(id);
            if (LoaiHang_SelectedItem.IsNullStruct && foundIndex > -1)
            {
                Utilities.ShowErrorBox($"Mã loại hàng '{newItem.Id}' đã tồn tại, xin nhập mã khác hoặc chọn loại hàng trong danh sách loại hàng để cập nhật");
                return;
            }
            if (IsInUse(id))
            {
                if (newItem.Id != LoaiHang_SelectedItem.Id)
                {
                    Utilities.ShowErrorBox($"Không thể lưu! {Environment.NewLine}Mã loại hàng cần lưu vẫn còn đang được sử dụng đến ở 1 số sản phẩm.");
                    return;
                }
                else
                {
                    var tmpSP = new ArrayList();
                    for (int i = 0; i < this.lstSanPham.Count; i++)
                    {
                        SanPham item = (SanPham)this.lstSanPham[i];
                        if (!item.IsNullStruct && !item.LoaiHang.IsNullStruct && item.LoaiHang.Id.Equals(id, StringComparison.InvariantCultureIgnoreCase))
                        {
                            item.LoaiHang = newItem;
                        }
                        tmpSP.Add(item);
                    }
                    if (tmpSP.Count > 0)
                    {
                        this.lstSanPham = tmpSP;
                    }
                }
            }

            if (foundIndex > -1)
            {
                //update
                this.lstLoaiHang.RemoveAt(foundIndex);
                this.lstLoaiHang.Insert(foundIndex, newItem);
            }
            else
            {
                //add new
                this.lstLoaiHang.Add(newItem);
            }

            BindLoaiHangListView(this.lstLoaiHang.ToArray());
            Utilities.ShowInfoBox($"Lưu loại hàng có Mã sau: '{newItem.Id}', {Environment.NewLine}và tên: '{newItem.Ten}' thành công");
            ResetPanelLoaiHang();
            TooggleSaveLoaiHangButton();
            txtSearchLoaiHang.Clear();
            txtSearchLoaiHang.Focus();
        }
        private void lstvLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!LoaiHang_SelectedItem.IsNullStruct && !string.IsNullOrEmpty(LoaiHang_SelectedItem.Id))
            {
                txtMaLoaiHang.Text = LoaiHang_SelectedItem.Id;
                txtTenLoaiHang.Text = LoaiHang_SelectedItem.Ten;

                btnThemLoaiHang.Visible = false;
                btnXoaLoaiHang.Visible = btnUndoLoaiHang.Visible = btnSaveLoaiHang.Visible = true;

                pnlThongTinLoaiHang.Enabled = true;
            }
            else
            {
                btnXoaLoaiHang.Visible = btnUndoLoaiHang.Visible = btnSaveLoaiHang.Visible = false;
            }
        }

        private int FindLoaiHangIndex(string textToSearch)
        {
            var foundIndex = -1;
            for (int i = 0; i < this.lstLoaiHang.Count; i++)
            {
                LoaiHang loaihang = (LoaiHang)this.lstLoaiHang[i];
                if (textToSearch.Equals(loaihang.Id))
                {
                    foundIndex = i;
                    break;
                }
            }
            return foundIndex;
        }
        private void BindLoaiHangListView(object[] lstLoaihang)
        {
            lstvLoaiHang.Items.Clear();
            foreach (LoaiHang loaihang in lstLoaihang)
            {
                var item = new ListViewItem(new string[] { loaihang.Id.ToString(), loaihang.Ten });
                item.Tag = loaihang;
                lstvLoaiHang.Items.Add(item);
            }
        }


        private void TooggleSaveLoaiHangButton(bool isShow = false)
        {
            var invertOthers = !isShow;
            btnXoaLoaiHang.Visible = btnUndoLoaiHang.Visible = btnSaveLoaiHang.Visible = isShow;
            pnlThongTinLoaiHang.Enabled = isShow;

            btnThemLoaiHang.Visible = invertOthers;
        }

        private void ResetPanelLoaiHang()
        {
            txtTenLoaiHang.Clear();
            txtMaLoaiHang.Clear();

            txtMaLoaiHang.Focus();
        }

        #endregion

        private void BindComboBoxLoaiHang(LoaiHang[] lstLoaiHang)
        {
            cbbLoaiHang.DataSource = null;
            cbbLoaiHang.Items.Clear();

            if (lstLoaiHang?.Length > 0)
            {
                cbbLoaiHang.DisplayMember = "Ten";
                cbbLoaiHang.ValueMember = "Id";
                cbbLoaiHang.DataSource = lstLoaiHang;
                cbbLoaiHang.SelectedValue = ((LoaiHang)lstLoaiHang[0]).Id;
            }
            ////get display name of loai hang when ten loai hang changed
            //ArrayList tmpSP = new ArrayList();
            //for (int i = 0; i < this.lstSanPham.Count; i++)
            //{
            //    SanPham item = (SanPham)this.lstSanPham[i];
            //    for (int j = 0; j < this.lstLoaiHang.Count; j++)
            //    {
            //        var lh = (LoaiHang)this.lstLoaiHang[j];
            //        if (!item.IsNullStruct && !item.LoaiHang.IsNullStruct && item.LoaiHang.Id.Equals(lh.Id, StringComparison.InvariantCultureIgnoreCase))
            //        {                        
            //            item.LoaiHang = lh;                        
            //        }                    
            //    }
            //    tmpSP.Add(item);
            //}
            //this.lstSanPham = tmpSP;
        }
        private void tabApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabApp.SelectedIndex == 0)
            {
                //Changes from 1 to 0
                //rebind data
                BindComboBoxLoaiHang(lstLoaiHang.Cast<LoaiHang>().ToArray());
                BindSanPhamListView(this.lstSanPham.ToArray());
            }
        }

        private void numHanDungTheoNgay_ValueChanged(object sender, EventArgs e)
        {
            if (numHanDungTheoNgay.Value > 0)
            {
                dtpNgayHetHan.Value = dtpNgaySanXuat.Value.AddDays((double)numHanDungTheoNgay.Value);
            }
        }

        private void dtpNgaySanXuat_ValueChanged(object sender, EventArgs e)
        {
            if (numHanDungTheoNgay.Value > 0)
            {
                dtpNgayHetHan.Value = dtpNgaySanXuat.Value.AddDays((double)numHanDungTheoNgay.Value);
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utilities.ShowConfirmBox("Bạn có chắc chắn muốn thoát khỏi phần mềm không?") == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void thôngTinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Utilities.ShowInfoBox($"Họ Tên: Liên Kim Phong {Environment.NewLine}Mã SV: 20810018{Environment.NewLine}Dồ án: Quản lý của hàng (NMLT)");
        }
    }
}
