using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace PolymorphismLibrary
{
    public class Calculator
    {
        //Add method has 4 overloads
        public int Add(int x, int y) 
        {
            Console.WriteLine("Calling Add(int x, int y) ");
            return x + y; 
        }
        public double Add(double x, double y) 
        {
            Console.WriteLine("Calling  Add(double x, double y)");
            return x + y;
        }
        public double Add(double x, double y, float p) 
        {
            Console.WriteLine("Calling  Add(double x, double y,float p)");
            return x + y; 
        }


        public double Add(double x, double y,int i) { return x + y + i; }
        public double Add(int i,double x, double y) { return i + x + y; }

        public double Add(double x, double y,int i,int j) { return x + y + i + j; }

        public double Add(float x, double y, int i, int j) { return x + y + i + j; }
        public double Add(double x, int j, double y, int i) { return x + j + y + i; }

    }
}
