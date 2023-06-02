namespace demo_web.Models
{
    public class SanPham
    {
        //Tạo biến
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int TamTinh { get; set; }


        //Tạo hàm trống
        public SanPham() { }
        //Tạo hàm để tính toán
        public SanPham(string tenSanPham, int soLuong, int gia)
        {
            TenSanPham = tenSanPham;
            SoLuong = soLuong;
            DonGia = gia;
            TamTinh = soLuong * gia;
        }
    }
}
