namespace QLKhachSan.DTO
{
    public class HoaDonDTO
    {
        string mahoadon, maphong, thoigianbatdau, thoigianketthuc, macachthue, tienphong,
            phuthu, tratruoc, thugiamtrukhac, tienmenu, ghichu, taikhoannhanphong, taikhoantraphong;

        public HoaDonDTO()
        {
        }
        public HoaDonDTO(string mahoadon, string thoigianbatdau, string tratruoc, string ghichu)
        {
            this.Mahoadon = mahoadon;
            this.Thoigianbatdau = thoigianbatdau;
            this.Tratruoc = tratruoc;
            this.Ghichu = ghichu;
        }

        public HoaDonDTO(string mahoadon, string maphong, string thoigianbatdau, string thoigianketthuc, string macachthue, string tienphong, string phuthu, string tratruoc, string thugiamtrukhac, string tienmenu, string ghichu, string taikhoannhanphong, string taikhoantraphong) 
        {
            this.Mahoadon = mahoadon;
            this.Maphong = maphong;
            this.Thoigianbatdau = thoigianbatdau;
            this.Thoigianketthuc = thoigianketthuc;
            this.Macachthue = macachthue;
            this.Tienphong = tienphong;
            this.Phuthu = phuthu;
            this.Tratruoc = tratruoc;
            this.Thugiamtrukhac = thugiamtrukhac;
            this.Tienmenu = tienmenu;
            this.Ghichu = ghichu;
            this.Taikhoannhanphong = taikhoannhanphong;
            this.Taikhoantraphong = taikhoantraphong;
        }

        public string Mahoadon { get => mahoadon; set => mahoadon = value; }
        public string Maphong { get => maphong; set => maphong = value; }
        public string Thoigianbatdau { get => thoigianbatdau; set => thoigianbatdau = value; }
        public string Thoigianketthuc { get => thoigianketthuc; set => thoigianketthuc = value; }
        public string Macachthue { get => macachthue; set => macachthue = value; }
        public string Tienphong { get => tienphong; set => tienphong = value; }
        public string Phuthu { get => phuthu; set => phuthu = value; }
        public string Tratruoc { get => tratruoc; set => tratruoc = value; }
        public string Thugiamtrukhac { get => thugiamtrukhac; set => thugiamtrukhac = value; }
        public string Tienmenu { get => tienmenu; set => tienmenu = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public string Taikhoannhanphong { get => taikhoannhanphong; set => taikhoannhanphong = value; }
        public string Taikhoantraphong { get => taikhoantraphong; set => taikhoantraphong = value; }
    }
}
