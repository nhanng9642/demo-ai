/*
 * Đồ án: Nhập môn lập trình
 * Mã môn: CTT003 
 * MSSV: 20810003
 * */

namespace QuanLyCuaHang
{
    class IdGenerator
    {
        private int currentId = 1;

        public IdGenerator(int initial = 1)
        {
            currentId = initial;
        }

        public int Next()
        {
            return currentId++;
        }
    }
}
