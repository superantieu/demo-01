namespace demo_web.Models
{
    public class SanPham
    {
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int TamTinh { get; set; }
        public SanPham() { }
        public SanPham(string tenSanPham, int soLuong, int gia)
        {
            TenSanPham = tenSanPham;
            SoLuong = soLuong;
            DonGia = gia;
            TamTinh = soLuong * gia;
        }
    }
}
