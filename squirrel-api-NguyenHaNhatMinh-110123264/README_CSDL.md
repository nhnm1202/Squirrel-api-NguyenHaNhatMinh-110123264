# Thiết kế CSDL - Lịch sử giao dịch

Bảng dữ liệu: `LichSuGiaoDich`

| Tên trường | Kiểu dữ liệu | Ghi chú |
|---|---|---|
| Id | INTEGER | Khóa chính |
| SoTaiKhoan | TEXT | Số tài khoản |
| SoTien | REAL | Số tiền giao dịch |
| LoaiGiaoDich | TEXT | Loại giao dịch: Nap tien / Rut tien |

File SQL thiết kế CSDL: `CSDL_LichSuGiaoDich.sql`.

Theo yêu cầu đề bài, dữ liệu mẫu vẫn được khởi tạo cứng trong mã nguồn tại `TransactionController.cs`.
