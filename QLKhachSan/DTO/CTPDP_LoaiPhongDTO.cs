namespace QLKhachSan.DTO
{
    public class CTPDP_LoaiPhongDTO
    {
        string maCTPPDP_loaiphong, maphieudatphong, maloaiphong;
        int soluong;
        public CTPDP_LoaiPhongDTO(string maCTPPDP_loaiphong, string maphieudatphong, string maloaiphong, int soluong)
        {
            this.maCTPPDP_loaiphong = maCTPPDP_loaiphong;
            this.maphieudatphong = maphieudatphong;
            this.maloaiphong = maloaiphong;
            this.soluong = soluong;
        }
        public CTPDP_LoaiPhongDTO()
        {

        }
        public string MaCTPDP_loaiphong
        {
            get { return maCTPPDP_loaiphong; }
            set { maCTPPDP_loaiphong = value; }
        }
        public string Maphieudatphong
        {
            get { return maphieudatphong; }
            set { maphieudatphong = value; }
        }
        public string Maloaiphong
        {
            get { return maloaiphong; }
            set { maloaiphong = value; }
        }
        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
    }
}
