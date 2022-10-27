namespace QLKhachSan.DTO
{
    public class HoaDonDTO
    {
        string mahoadon, maphong, thoigianbatdau, thoigianketthuc, macachthue, tienphong,
            phuthu, tratruoc, thugiamtrukhac, tienmenu, ghichu;

        public HoaDonDTO()
        {
        }
        public HoaDonDTO(string mahoadon, string thoigianbatdau, string tratruoc, string ghichu)
        {
            this.mahoadon = mahoadon;
            this.thoigianbatdau = thoigianbatdau;
            this.tratruoc = tratruoc;
            this.ghichu = ghichu;
        }

   

        public HoaDonDTO(string mahoadon, string maphong, string thoigianbatdau, string thoigianketthuc, string macachthue, string tienphong, string phuthu, string tratruoc, string thugiamtrukhac, string tienmenu, string ghichu)
        {
            this.mahoadon = mahoadon;
            this.maphong = maphong;
            this.thoigianbatdau = thoigianbatdau;
            this.thoigianketthuc = thoigianketthuc;
            this.macachthue = macachthue;
            this.tienphong = tienphong;
            this.phuthu = phuthu;
            this.tratruoc = tratruoc;
            this.Thugiamtrukhac = thugiamtrukhac;
            this.tienmenu = tienmenu;
            this.ghichu = ghichu;
        }

        public string Mahoadon { get => mahoadon; set => mahoadon = value; }
        public string Maphong { get => maphong; set => maphong = value; }
        public string Thoigianbatdau { get => thoigianbatdau; set => thoigianbatdau = value; }
        public string Thoigianketthuc { get => thoigianketthuc; set => thoigianketthuc = value; }
        public string Macachthue { get => macachthue; set => macachthue = value; }
        public string Tienphong { get => tienphong; set => tienphong = value; }
        public string Phuthu { get => phuthu; set => phuthu = value; }
        public string Tratruoc { get => tratruoc; set => tratruoc = value; }
        public string Tienmenu { get => tienmenu; set => tienmenu = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public string Thugiamtrukhac { get => thugiamtrukhac; set => thugiamtrukhac = value; }
    }
}
