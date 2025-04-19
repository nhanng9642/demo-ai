using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMLT_QLCH_WindowsFormsApp
{
    public static class Utilities
    {
        private const string InforTitle = "Thông tin";
        private const string ConfirmTitle = "Xác nhận";
        private const string ErrorTitle = "Lỗi";

        public static void ShowInfoBox(string mess)
        {
            MessageBox.Show(mess, InforTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult ShowConfirmBox(string mess)
        {
            return MessageBox.Show(mess, ConfirmTitle,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
        }
        public static void ShowErrorBox(string mess)
        {
            MessageBox.Show(mess, ErrorTitle,
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
