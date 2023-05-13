using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 3, 7, 15 };
            //int sum = 0;
            //int sum = numbers.Sum();
            //Console.WriteLine("Cac gia tri cua mang la: ");
            //foreach (int no in numbers)
            //{
            //    Console.Write("{0} ", no);
            //    sum += no;
            //}
            //Console.WriteLine();
            //Console.WriteLine("Tong cua mang la : {0}", sum);
            int max = numbers.Max();
            int min = numbers.Min();
            double avg = (double)numbers.Average();
            Array.Sort(numbers);
            Array.Reverse(numbers);
            foreach (int no in numbers)
            {
                Console.Write("{0} ", no);
            }
            Console.WriteLine();
            Console.WriteLine("Gia tri trung binh cua mang la: {0}", avg);
            Console.WriteLine("Gia tri lon nhat cua mang la: {0}",max);
            Console.WriteLine("Gia tri nho nhat cua mang la: {0}",min);
            Console.ReadKey();

        }
    }
}
