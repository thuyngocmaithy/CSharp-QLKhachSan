using iTextSharp.text;
using iTextSharp.text.pdf;
using QLKhachSan.DTO;
using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace QLKhachSan.BUS
{
    public class printPDFHoaDon
    {

        HoaDonDTO hd = new HoaDonDTO();
        ThietLapKhacDTO tlk = new ThietLapKhacDTO();
        MenuBUS menuBUS = new MenuBUS();
        HoaDon_MenuBUS hoaDon_MenuBUS = new HoaDon_MenuBUS();
        BaseFont bf = BaseFont.CreateFont("C:/Windows/Fonts/arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
        Document doc = new Document(PageSize.A4, 36, 72, 108, 180);
        public printPDFHoaDon(HoaDonDTO hd, ThietLapKhacDTO tlk)
        {

            this.hd = hd;
            this.tlk = tlk;
        }

        public void print()
        {
        FileStream fs = new FileStream(hd.Mahoadon + ".pdf", System.IO.FileMode.OpenOrCreate);

            //tạo pdf writer
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            //Tạo line *****
            string uderline = "-";
            string line = "";
            Rectangle pageSize = doc.PageSize;
            for (int i = 0; i < pageSize.Width / 5; i++)
            {
                line += uderline;
            }
            //GHI
            Paragraph l = new Paragraph(line);
            l.Alignment = 1;
            Paragraph xuongdong = new Paragraph("\n");
            xuongdong.Alignment = 1;    
            //
            doc.Open();
            Paragraph paraTenkhachsan = new Paragraph(tlk.Tenkhachsan, new Font(bf, 35));
            doc.Add(paraTenkhachsan);
            doc.Add(l);
            Paragraph paraInfokhachsan = new Paragraph(
                "Địa chỉ: " + tlk.Diachi +
                "\nSố điện thoại: " + tlk.Sdt, new Font(bf, 15));
            doc.Add(paraInfokhachsan);

            //header
            Paragraph header = new Paragraph("HÓA ĐƠN", new Font(bf, 35));
            header.Alignment = 1;
            doc.Add(header);
            //Body
            doc.Add(xuongdong);
            PdfPTable tbThongTinPhong = taoTableThongTinPhong();
            doc.Add(tbThongTinPhong);
            doc.Add(l);
            //HEADER MENU        
            PdfPTable tbMenu = taoTableMenu();
            doc.Add(tbMenu);
            doc.Add(l);
            //BODY TIỀN PHÒNG
            PdfPTable tbTienPhong = taoTableTienPhong();
            doc.Add(tbTienPhong);
            doc.Add(l);
            //TỔNG TIỀN
             taoTableTongTien();

            doc.Add(l);

           

            System.Diagnostics.Process.Start(hd.Mahoadon + ".pdf");



            doc.Close();
        }
        private PdfPTable taoTableMenu()
        {
            PdfPTable table = new PdfPTable(3);
            table.HorizontalAlignment = 0;
            PdfPCell cell;
            cell = new PdfPCell(new Phrase("Tên menu", new Font(bf, 15)));
            cell.BorderColor = BaseColor.WHITE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("SL", new Font(bf, 15)));
            cell.BorderColor = BaseColor.WHITE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Thành tiền", new Font(bf, 15)));
            cell.BorderColor = BaseColor.WHITE;
            table.AddCell(cell);

            DataTable dtMenu = hoaDon_MenuBUS.GetHoaDon_Menu(
                "SELECT TenMenu, SL, Format((replace(convert(varchar, cast(REPLACE(mn.GiaBan,',','.') as money), 1), '.00', '') * SL), 'c', 'vi-VN') AS ThanhTien " +
                "FROM HoaDon_Menu hdmn, Menu mn " +
                "WHERE hdmn.MaMenu = mn.MaMenu " +
                "AND MaHoaDon = '" + hd.Mahoadon + "'");
            if(dtMenu.Rows.Count > 0)
            {
                foreach (DataRow R in dtMenu.Rows)

                {
                    foreach (DataColumn C in dtMenu.Columns)
                    {
                        cell = new PdfPCell(new Phrase(R[C].ToString(), new Font(bf, 15)));
                        cell.BorderColor = BaseColor.WHITE;
                        table.AddCell(cell);
                    }
                }
            }    
            else
            {
                cell = new PdfPCell(new Phrase("\nKhông có menu sử dụng", new Font(bf, 15)));
                cell.Colspan = 3;
                cell.BorderColor = BaseColor.WHITE;
                table.AddCell(cell);
            }    
            return table;

        }
        private PdfPTable taoTableThongTinPhong()
        {
            DateTime dateNgaynhan = DateTime.Parse(hd.Thoigianbatdau, CultureInfo.CreateSpecificCulture("en-US"));
            DateTime dateNgaytra = DateTime.Parse(hd.Thoigianketthuc, CultureInfo.CreateSpecificCulture("en-US"));
            TimeSpan diff = dateNgaytra - dateNgaynhan;
            string thoigian = "";
            if (diff.Days > 0)
            {
                thoigian += diff.Days + " ngày ";
                if (diff.Hours > 0)
                {
                    thoigian += diff.Hours + " giờ ";
                    if (diff.Minutes > 0)
                    {
                        thoigian += diff.Minutes + " phút";

                    }
                }

            }
            else if (diff.Hours > 0)
            {
                thoigian += diff.Hours + " giờ ";
                if (diff.Minutes > 0)
                {
                    thoigian += diff.Minutes + " phút";

                }
            }
            else if (diff.Minutes > 0)
            {
                thoigian = +diff.Minutes + " phút";

            }
            PdfPTable table = new PdfPTable(2);
            table.HorizontalAlignment = 0;
            PdfPCell cell;
            cell = new PdfPCell(new Phrase("Phòng:", new Font(bf, 15)));
            cell.BorderColor = BaseColor.WHITE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase(hd.Maphong, new Font(bf, 15)));
            cell.BorderColor = BaseColor.WHITE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Giờ vào:", new Font(bf, 15)));
            cell.BorderColor = BaseColor.WHITE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase(hd.Thoigianbatdau, new Font(bf, 15)));
            cell.BorderColor = BaseColor.WHITE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Giờ ra:", new Font(bf, 15)));
            cell.BorderColor = BaseColor.WHITE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase(hd.Thoigianketthuc, new Font(bf, 15)));
            cell.BorderColor = BaseColor.WHITE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Thời gian:", new Font(bf, 15)));
            cell.BorderColor = BaseColor.WHITE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase(thoigian, new Font(bf, 15)));
            cell.BorderColor = BaseColor.WHITE;
            table.AddCell(cell);



            return table;
        }
        private PdfPTable taoTableTienPhong()
        {
            PdfPTable table = new PdfPTable(2);
            table.HorizontalAlignment = 0;
            PdfPCell cell;
            cell = new PdfPCell(new Phrase("Tiền phòng:", new Font(bf, 15)));
            cell.BorderColor = BaseColor.WHITE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase(hd.Tienphong, new Font(bf, 15)));
            cell.BorderColor = BaseColor.WHITE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Phụ thu:", new Font(bf, 15)));
            cell.BorderColor = BaseColor.WHITE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase(hd.Phuthu, new Font(bf, 15)));
            cell.BorderColor = BaseColor.WHITE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Tiền menu:", new Font(bf, 15)));
            cell.BorderColor = BaseColor.WHITE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase(hd.Tienmenu, new Font(bf, 15)));
            cell.BorderColor = BaseColor.WHITE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Thu giảm trừ khác:", new Font(bf, 15)));
            cell.BorderColor = BaseColor.WHITE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase(hd.Thugiamtrukhac, new Font(bf, 15)));
            cell.BorderColor = BaseColor.WHITE;
            table.AddCell(cell);


            return table;
        }
        private void taoTableTongTien()
        {
            int tienmenu = 0;
            if (hd.Tienmenu != "")
            {
                tienmenu = int.Parse(hd.Tienmenu, NumberStyles.AllowThousands, new CultureInfo("en-au"));

            }
            int tienphong = int.Parse(hd.Tienphong, NumberStyles.AllowThousands, new CultureInfo("en-au"));
            int tienphuthu = 0;
            if (hd.Phuthu != "")
            {
                tienphuthu = int.Parse(hd.Phuthu, NumberStyles.AllowThousands, new CultureInfo("en-au"));

            }
            int thugiamtru = 0;
            if (hd.Thugiamtrukhac != "")
            {
                thugiamtru = int.Parse(hd.Thugiamtrukhac, NumberStyles.AllowThousands, new CultureInfo("en-au"));

            }
            int tientratruoc = 0;
            if (hd.Tratruoc != "")
            {
                tientratruoc = int.Parse(hd.Tratruoc, NumberStyles.AllowThousands, new CultureInfo("en-au"));
            }
            int tongtien = tienmenu + tienphong + tienphuthu + thugiamtru;
            int tienthanhtoan = tongtien - tientratruoc;
            PdfPTable table = new PdfPTable(2);
            table.HorizontalAlignment = 0;
            PdfPCell cell;
            cell = new PdfPCell(new Phrase("Tổng tiền:", new Font(bf, 15)));
            cell.BorderColor = BaseColor.WHITE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase(String.Format("{0:n0}", tongtien) , new Font(bf, 15)));
            cell.BorderColor = BaseColor.WHITE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Tiền trả trước:", new Font(bf, 15)));
            cell.BorderColor = BaseColor.WHITE;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase(hd.Tratruoc, new Font(bf, 15)));
            cell.BorderColor = BaseColor.WHITE;
            table.AddCell(cell);

            Paragraph paraThanhToan = new Paragraph(
                         "Thanh toán: " + String.Format("{0:n0}", tienthanhtoan), new Font(bf, 20));
            doc.Add(table);
            paraThanhToan.Alignment = 2;
            doc.Add(paraThanhToan);
        }
    }
}
