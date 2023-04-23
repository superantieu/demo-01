using System;
using System.Collections.Generic;
using System.Linq;
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


            const int A = 20;
            Console.WriteLine("So A la: {0}", A);
            Console.Write("Nhap so B: ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Tong cua A và b la {0}", A + B);
            Console.ReadKey();
        }
    }
}
