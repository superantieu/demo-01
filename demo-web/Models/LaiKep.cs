//Tạo class lãi suất LaiKep


namespace demo_web.Models

{
    public class LaiKep
    {

        //Tạo thuộc tính (attribute)
        public double TienGui { get; set; }
        public double LaiSuatGui { get; set; }
        public double KyHan { get; set; }
        public double SoLanDong { get; set; }
        
        public string TienLai { get; set; }
        public string TongTien { get; set; }

        //Tạo constructor
        public LaiKep() { }
        //Dùng tính chất overload để ghi đè lại hàm constructor
        //Biến bên class đặt tùy sở thích, cần minh bạch dễ hiểu
        public LaiKep(double gui, double laigui, double kyhan, double soLanDong)
        {
            this.TienGui = gui;
            this.LaiSuatGui = laigui;
            this.KyHan = kyhan;
            this.SoLanDong = soLanDong;
            this.TongTien = TinhTienLai(gui, laigui, kyhan, soLanDong).ToString("N0");
            this.TienLai = (double.Parse(this.TongTien) - gui).ToString("N0");


        }
        //Biến trong hàm đặt tùy sở thích, cần minh bạch dễ hiểu
        private double TinhTienLai(double gui, double laigui, double kyhan, double solandong)
        {
            var a = 1 + laigui / solandong / 100;
            var b = kyhan * solandong;
            var test = this.SoLanDong;
            return Math.Round(gui * Math.Pow(a, b), 0);



        }
        //Sau đó sang controller để gọi class

    }
}
