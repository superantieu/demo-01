//Tạo class lãi suất LaiSuat


namespace demo_web.Models

{
    public class LaiSuat
    {

        //Tạo thuộc tính (attribute)
        public int TienGui { get; set; }
        public int LaiSuatGui { get; set; }
        public int KyHan { get; set; }
        public double TienLai { get; set; }
        public double TongTien { get; set; }

        //Tạo constructor
        public LaiSuat() { }
        //Dùng tính chất overload để ghi đè lại hàm constructor
        //Biến bên class đặt tùy sở thích, cần minh bạch dễ hiểu
        public LaiSuat(int gui, int laigui, int kyhan)
        {
            this.TienGui = gui;
            this.LaiSuatGui = laigui;
            this.KyHan= kyhan;
            this.TienLai = TinhTienLai(gui, laigui, kyhan);
            this.TongTien = this.TienLai + gui;


        }
        //Biến trong hàm đặt tùy sở thích, cần minh bạch dễ hiểu
        private static double TinhTienLai(int a, int b, int c)
        {
            return (a * b / 100) * c / 12;
          


        }
        //Sau đó sang controller để gọi class

    }
}
