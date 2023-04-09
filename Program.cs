using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTLN2C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int h,c,t=0,s;
            Console.WriteLine("Nhập số hàng");
            h=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập sô cột");
            c=int.Parse(Console.ReadLine());
            int[,] so = new int[h,c];
            for (int i = 0; i < h; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    Console.WriteLine("Nhập giá trị của phần tử có vị trí :" +i +" "+ j);
                    so[i,j]=int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Mảng vừa tạo: ");
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(so[i,j] +"\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (so[i, j] > t)
                    {
                        t= so[i,j];
                    }
                }
             }
            Console.WriteLine("Số lớn nhất trong mảng là :"+t);

            Console.ReadLine();
        }
    }
}
