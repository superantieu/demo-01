namespace demo_web.Models
{
    public class LaiSuat
    {
        public int TienGui { get; set; }
        public int LaiSuatGui { get; set; }
        public int KyHan { get; set; }
        public double  TienLai { get; set; }
        public double TongTien { get; set; }

        public LaiSuat() { }

        public LaiSuat(int tiengui, int laisuatgui, int kyhan)
        {
            this.TienGui = tiengui;
            this.LaiSuatGui = laisuatgui;
            this.KyHan= kyhan;
            this.TienLai = TinhTienLai(tiengui, laisuatgui, kyhan);
            this.TongTien = this.TienLai + tiengui;


        }

        private static double TinhTienLai(int tiengui,int laisuatgui, int kyhan)
        {
            return tiengui * (laisuatgui / 100) * (kyhan / 12);
            
          
        }


    }
}
