using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Xml.Serialization;

namespace baithi
{
    public class Serializer
    {
        public Data_ customer;
        public List<T> Deserialize<T>(string input) where T : class
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(List<T>));

            using (StringReader sr = new StringReader(input))
            {
                return (List<T>)ser.Deserialize(sr);
            }
        }

        public string Serialize<T>(List<T> ObjectToSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(ObjectToSerialize.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, ObjectToSerialize);
                return textWriter.ToString();
            }
        }

        public void temp()
        {
            Serializer ser = new Serializer();
            string path = string.Empty;
            string xmlInputData = string.Empty;
            string xmlOutputData = string.Empty;

            // EXAMPLE 1
            path = Directory.GetCurrentDirectory() + @"\data.xml";
            xmlInputData = File.ReadAllText(path);

            //customer = ser.Deserialize<Data_>(xmlInputData);
            //xmlOutputData = ser.Serialize<Data_>(customer);
        }
    }

    public class Data_
    {
        [System.ComponentModel.DisplayName("Mã hàng")]
        public int MaHang { get; set; }
        [System.ComponentModel.DisplayName("Hạn dùng")]
        public int ExpireDate { get; set; }
        [System.ComponentModel.DisplayName("Năm sx")]
        public int NamSX { get; set; }
        [System.ComponentModel.DisplayName("Loại sp")]
        public int LoaiHang { get; set; }
        [System.ComponentModel.DisplayName("Tên hàng")]
        public string TenMatHang { get; set; }
        [System.ComponentModel.DisplayName("Công ty")]
        public string CtySX { get; set; }

        public object[] all
        {
            get { return new object[] { MaHang, ExpireDate, NamSX, LoaiHang, TenMatHang, CtySX }; }
            set
            {
                MaHang = (int)value[0];
                ExpireDate = (int)value[1];
                NamSX = (int)value[2];
                LoaiHang = (int)value[3];
                TenMatHang = (string)value[4];
                CtySX = (string)value[5];
            }
        }

        public Data_ deepCopy()
        {
            Data_ tmp = (Data_)this.MemberwiseClone();
            tmp.MaHang = this.MaHang;
            tmp.ExpireDate = this.ExpireDate;
            tmp.NamSX = this.NamSX;
            tmp.LoaiHang = this.LoaiHang;
            tmp.TenMatHang = this.TenMatHang;
            tmp.CtySX = this.CtySX;
            return tmp;
        }

        public void reset()
        {
            MaHang = -1;
            ExpireDate = -1;
            NamSX = -1;
            LoaiHang = -1;
            TenMatHang = "";
            CtySX = "";
        }
    }
    public partial class DataIn
    {
        private List<Data_> lstType = new List<Data_>();
        public DataTable dt = new DataTable();
        public bool isChanged = false;
        public string filePath = String.Empty;

        public DataIn()
        {
            //DataTable dt = new DataTable();

            DataColumn uniqueColumn = new DataColumn("MaHang");
            uniqueColumn.DataType = System.Type.GetType("System.Int32");
            uniqueColumn.Unique = true;

            dt.Columns.Add(uniqueColumn);
            dt.Columns.Add("ExpireDate", typeof(int));
            dt.Columns.Add("NamSX", typeof(int));
            dt.Columns.Add("LoaiHang", typeof(int));
            dt.Columns.Add("TenMatHang", typeof(string));
            dt.Columns.Add("CtySX", typeof(string));


            dt.Columns["MaHang"].ColumnName = "Mã hàng";
            dt.Columns["ExpireDate"].ColumnName = "Hạn dùng";
            dt.Columns["NamSX"].ColumnName = "Năm sx";
            dt.Columns["LoaiHang"].ColumnName = "Loại sp";
            dt.Columns["TenMatHang"].ColumnName = "Tên hàng";
            dt.Columns["CtySX"].ColumnName = "Công ty";

            string path = Directory.GetCurrentDirectory();
            path += "\\..\\..";
            if (!Directory.Exists(path))
            {
                path = Directory.GetCurrentDirectory();
            }
            filePath = path + "\\data.xml";
            load_data();
        }

        public List<Data_> getData()
        {
            return lstType;
        }

        private void load_data()
        {
            try
            {

                lstType = loadDataFromFile();
                if (lstType.Count == 0)
                {
                    Data_ a = new Data_();
                    a.MaHang = 1;
                    a.ExpireDate = 6;
                    a.LoaiHang = 1;
                    a.NamSX = 1996;
                    a.TenMatHang = "abc";
                    a.CtySX = "bca";
                    lstType.Add(a);
                    write_data();
                }
                foreach (Data_ ts in lstType)
                {
                    dt.Rows.Add(ts.all);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public List<Data_> loadDataFromFile()
        {
            Serializer ser = new Serializer();
            string xmlInputData = string.Empty;

            if (!File.Exists(filePath))
            {
                StreamWriter sw = File.CreateText(filePath);
                sw.Close();
                return new List<Data_>();
            }
            xmlInputData = File.ReadAllText(filePath);

            return ser.Deserialize<Data_>(xmlInputData);
        }

        public void write_data()
        {
            try
            {
                Serializer ser = new Serializer();
                string xmlOutputData = string.Empty;
                xmlOutputData = ser.Serialize<Data_>(lstType);

                File.WriteAllText(filePath, xmlOutputData);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ko thể lưu xuống database!!!");
            }
        }

        public void reset_changes()
        {
            lstType = loadDataFromFile();
            UpdateDataTable();
        }

        public void UpdateDataRow(Data_ new_data_row, int numRow)
        {
            try
            {
                lstType.RemoveAt(numRow);
                lstType.Insert(numRow, new_data_row);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void AddDataRow(Data_ new_data_row)
        {
            try
            {
                lstType.Add(new_data_row);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void DeleteDataRow(int numRow)
        {
            try
            {
                lstType.RemoveAt(numRow);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void UpdateDataTable()
        {
            try
            {
                dt.Clear();
                foreach (Data_ ts in lstType)
                {
                    dt.Rows.Add(ts.all);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public DataTable GetData()
        {
            return dt;
        }

        public bool SetData(Data_ data)
        {
            if (lstType.Exists(x => x.MaHang == data.MaHang))
            {
                MessageBox.Show("Mã hàng đã tồn tại!!!");
                return false;
            }
            else
            {
                lstType.Add(data);
            }
            return true;
        }

        public Data_ findObjDataList(int index)
        {
            Data_ row = lstType[index];
            return row;
        }

        public int checkDataList(int productID)
        {
            return lstType.FindIndex(x => x.MaHang == productID);
        }
        public bool CheckExistNumID(int a)
        {
            if (lstType.Exists(x => x.MaHang == a))
            {
                return true;
            }
            return false;
        }

        public void SetToDataTable(List<Data_> a)
        {
            dt.Clear();
            foreach (Data_ ts in a)
            {
                dt.Rows.Add(ts.all);
            }
        }

        public List<Data_> findListData(List<Data_> tmp, int num, int id)
        {
            List<Data_> a = tmp;
            return a.FindAll(
                delegate(Data_ xx)
                {
                    if (id == 0)
                        return xx.LoaiHang == num;
                    else if (id == 1)
                        return xx.NamSX == num;
                    else if (id == 2)
                        return xx.ExpireDate == num;
                    return false;
                }
                );
        }
        public List<Data_> findListData(List<Data_> tmp, string text, int id)
        {
            List<Data_> a = tmp;
            return a.FindAll(
                delegate (Data_ xx)
                {
                    if (id == 0)
                        return xx.TenMatHang == text;
                    else if (id == 1)
                        return xx.CtySX == text;
                    return false;
                }
                );
        }
    }
}
