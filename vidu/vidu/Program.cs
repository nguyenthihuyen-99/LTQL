using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidu
{
    class Program
    {
        static void Main(string[] args)
        {
            //gan gtri cho bien i
            //int i = 0;
            //Console.WriteLine(i)
                //khai bao bien x,y,b
            int x = 10, y = 20;
            bool b = true;
            // in ra x,y,b
            Console.Write("gia tri bien x{0}, y{1},b{2}", x, y, b);
            //dung man hinh
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 9; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            long l;
            // nhap gia tri l
            Console.Write("nhap gia tri kieu long = ");
            l = long.Parse(Console.ReadLine());
            l = l * l;
            //in ra
            //parse - dinh dang kieu
            //console.readline()- nhap vao tu ban phim
            Console.WriteLine(" gia tri kieu long l = {0}", l);
            //khai bao bien s nhap tu ban phim
            string s = Console.ReadLine();
            //in ra bien s
            Console.WriteLine(s);
            //khai bao bang so nguyen
            int[] a = { 1, 2, 3, 4, 5 };
            foreach(int i in a)
            {
                Console.WriteLine("gia tri phan tu = {0}", i);

            }
                Console.Read();
        }
    }
}
