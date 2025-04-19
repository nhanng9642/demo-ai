# nmlt

 - Họ tên sinh viên: Lê Khắc Mẫn
 - Mã số sinh viên:  20880050
 - Khoá:             2020 K1

# Chú giải  bài làm
Thưa thầy. Em xin trình bày tổng quan về phần bài làm của em.
            
## Lưu trữ

- Data đuợc nguời dùng nhập vào từ console sẽ đuợc lưu trữ vào các variables trong code (vùng nhớ trên RAM) và sẽ tự mất đi khi thoát chương trình
- `Category` và `Product` database extends class `service/Store.cs` để kế thừa CRUD operations (Create Read Update Delete)

## Giao diện tương tác

- Nguời dùng tương tác qua Console bằng cách nhập các số tương ứng với từng tác vụ cần dùng.

Ví dụ:

Màn hình Console hiện ra
```
Please select operation:
1. List all tables
2. Edit Product
3. Edit Category
```
Nhập số `1` và gõ phím `Enter` để xem data của tất cả các table trong database
```
1
```
Chương trình sẽ xuất ra Console
```
# Products
ID: 0 | Name: T-Shirt | Category: 0 | Producer: Addas | Mfg: 1/1/0001 12:00:00 am | Exp: 1/1/0001 12:00:00 am
ID: 1 | Name: Pants | Category: 0 | Producer: guci | Mfg: 1/1/0001 12:00:00 am | Exp: 1/1/0001 12:00:00 am
# Categories
ID: 0 | Name: Clothing
```
- Các hàm `switch/case` trong `main` đóng vai trò như `Controllers` trong web applications.

## Hạn chế

- `Product.CategoryId` trong Product table không ràng buộc với `Category.Id` trong Category table
- Input đầu vào từ nguời dùng không đuợc kiểm tra truớc khi xử lý.

## Đề bài

DEADLINE: 6:00 PM, 12/12/2020
Viết phần mềm quản lý cửa hàng với các chức năng sau:
* Thêm, xóa, sửa và tìm kiếm các mặt hàng (mã, tên hàng, hạn dùng, công ty sản xuất, năm sản xuất, loại hàng).
* Thêm, xóa, sửa và tìm kiếm các loại hàng.

Chú ý:
* Làm với giao diện console hoặc windows form
* Các dữ liệu không cần lưu trữ lại
* Khai báo biến, kiểu dữ liệu
* IF, FOR, WHILE, DO WHILE
* Hàm
* Mảng 1 chiều
* Mảng 2 chiều
* Kiểu dữ liệu tự định nghĩa
* Window form
