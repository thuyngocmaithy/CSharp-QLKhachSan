
using GemBox.Spreadsheet;
using System;
using System.Data;
using System.Windows;

namespace QLKhachSan.BUS
{
    public class ExportExcelLichSu : DBConnect
    {
        HoaDonBUS hoaDonBUS = new HoaDonBUS();

        public ExportExcelLichSu()
        {


        }
        public void ExportExcelDatabase()
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            var workbook = new ExcelFile();
            var worksheet = workbook.Worksheets.Add("LỊCH SỬ THUÊ PHÒNG");

            DataTable dataTable = hoaDonBUS.GetHoaDon(
                "SELECT MaHoaDon, MaPhong, FORMAT(ThoiGianBatDau, 'yyyy-MM-dd HH:mm') AS ThoiGianBatDau, FORMAT(ThoiGianKetThuc, 'yyyy-MM-dd HH:mm') AS ThoiGianKetThuc, TenCachThue, TienPhong, " +
                "PhuThu, TraTruoc, ThuGiamTruKhac, TienMenu, GhiChu " +
                "FROM HoaDon, CachThue " +
                "WHERE HoaDon.MaCachThue = CachThue.MaCachThue");

            worksheet.Cells[0, 0].Value = "LỊCH SỬ THUÊ PHÒNG";


            // Insert DataTable to an Excel worksheet.
            worksheet.InsertDataTable(dataTable,
                new InsertDataTableOptions()
                {
                    ColumnHeaders = true,
                    StartRow = 2
                });

            workbook.Save("lstp" + DateTime.Now.ToString("yyyyMMddHHmm") + ".xlsx");


            MessageBox.Show("Xuất file excel thành công");


        }

    }
}
