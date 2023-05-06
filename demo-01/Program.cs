using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace demo_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //console.writeline("nhap ho va ten:");
            //string name = console.readline();
            //console.writeline("ho va ten la: " + name);
            //console.writeline("cam on");


            //int tuoi = 20;
            //int nam = 2000;
            //console.writeline("tuoi cua toi la {0}, nam sinh cua toi la {1}", tuoi, nam);
            //tuoi = tuoi + 2;
            //console.writeline("2 nam sau tuoi cua toi la {0}", tuoi);

            //console.writeline("10 nam sau nua tuoi cua toi la {0}", tuoi + 12);
            //console.readkey();

            //double a = 8;
            //int b = 3;
            //double c = a % b;
            //Console.WriteLine(c);
            //Console.ReadKey();


            //const int A = 20;
            //Console.WriteLine("So A la: {0}", A);
            //Console.Write("Nhap so B: ");
            //int B = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tong cua A và b la {0}", A + B);
            //Console.ReadKey();

            //Console.WriteLine("nhap vao so nguyen: ");
            //int soNguyen = int.Parse(Console.ReadLine());
            //string x = "so le";
            //if (soNguyen % 2 == 0)
            //{ x = "so chan"; }
            // Console.WriteLine("so ban vua nhap la {0}", x);
            //Console.ReadKey();
            Console.WriteLine("nhap vao thang ban muon kiem tra: ");
            int soThang = int.Parse(Console.ReadLine());
            switch (soThang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:

                    Console.WriteLine("Thang {0} co 31 ngay", soThang);
                    break;
                case 2:
                    Console.WriteLine("Thang {0} co 28 ngay", soThang);
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Thang {0} co 30 ngay", soThang);
                    break;
                default:
                    Console.WriteLine("Thang ban nhap khong hop le");
                    break;
                    


            }
            Console.ReadKey();
        }
    }
}
