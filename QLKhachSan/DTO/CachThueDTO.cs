namespace QLKhachSan.DTO
{
    internal class CachThueDTO
    {
        string macachthue, tencachthue, giatheocachthue, gionhanphong, giotraphong;

        public CachThueDTO()
        {
        }

        public CachThueDTO(string macachthue, string tencachthue, string giatheocachthue, string gionhanphong, string giotraphong)
        {
            this.Macachthue = macachthue;
            this.Tencachthue = tencachthue;
            this.Giatheocachthue = giatheocachthue;
            this.Gionhanphong = gionhanphong;
            this.Giotraphong = giotraphong;
        }

        public string Macachthue { get => macachthue; set => macachthue = value; }
        public string Tencachthue { get => tencachthue; set => tencachthue = value; }
        public string Giatheocachthue { get => giatheocachthue; set => giatheocachthue = value; }
        public string Gionhanphong { get => gionhanphong; set => gionhanphong = value; }
        public string Giotraphong { get => giotraphong; set => giotraphong = value; }
    }
}
