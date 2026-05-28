-- Thiết kế CSDL: Lịch sử giao dịch
-- Bảng: LichSuGiaoDich

CREATE TABLE LichSuGiaoDich (
    Id INTEGER PRIMARY KEY,
    SoTaiKhoan TEXT NOT NULL,
    SoTien REAL NOT NULL,
    LoaiGiaoDich TEXT NOT NULL
);

INSERT INTO LichSuGiaoDich (Id, SoTaiKhoan, SoTien, LoaiGiaoDich) VALUES
(1, '1023456789', 500000, 'Nap tien'),
(2, '1023456789', 200000, 'Rut tien'),
(3, '1098765432', 1000000, 'Nap tien'),
(4, '1098765432', 150000, 'Rut tien'),
(5, '1055566677', 300000, 'Nap tien');
