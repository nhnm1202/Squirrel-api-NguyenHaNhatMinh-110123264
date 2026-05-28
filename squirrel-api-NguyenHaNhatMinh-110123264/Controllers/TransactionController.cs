using Microsoft.AspNetCore.Mvc;
using SquirrelApi.Models;

namespace SquirrelApi.Controllers;

[ApiController]
[Route("api/giaodich")]
public class TransactionController : ControllerBase
{
    private static readonly List<LichSuGiaoDich> danhSach = new List<LichSuGiaoDich>
    {
        new LichSuGiaoDich { Id = 1, SoTaiKhoan = "1023456789", SoTien = 500000, LoaiGiaoDich = "Nap tien" },
        new LichSuGiaoDich { Id = 2, SoTaiKhoan = "1023456789", SoTien = 200000, LoaiGiaoDich = "Rut tien" },
        new LichSuGiaoDich { Id = 3, SoTaiKhoan = "1098765432", SoTien = 1000000, LoaiGiaoDich = "Nap tien" },
        new LichSuGiaoDich { Id = 4, SoTaiKhoan = "1098765432", SoTien = 150000, LoaiGiaoDich = "Rut tien" },
        new LichSuGiaoDich { Id = 5, SoTaiKhoan = "1055566677", SoTien = 300000, LoaiGiaoDich = "Nap tien" }
    };

    [HttpGet]
    public IActionResult Get()
    {
        var ketQua = danhSach
            .Where(x => x.LoaiGiaoDich == "Nap tien")
            .ToList();

        return Ok(ketQua);
    }
}
