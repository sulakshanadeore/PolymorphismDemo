using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolymorphismLibrary;
namespace PolymorphismDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculator c=new Calculator();
            //double fno=3424.34d, sno=23423.3d;
            //double ans=c.Add(fno, sno);
            //Console.WriteLine(ans);

            //Shopping sh = new Shopping();
            //sh.Pay()

            Circle c = new Circle();
            c.BaseOfTriangle = 2;
            c.CalculateArea();

            Console.ReadLine();
        }
    }
}
