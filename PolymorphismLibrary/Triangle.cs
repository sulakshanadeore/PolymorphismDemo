using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismLibrary
{
    public class Triangle
    {
        public Triangle() { }
		private int _base;

		public int BaseOfTriangle
		{
			get { return _base; }
			set { _base = value; }
		}

		private int _height;

		public int HeightOfTriangle
		{
			get { return _height; }
			set { _height = value; }
		}

		public virtual void CalculateArea()
		{
			double area= (BaseOfTriangle * HeightOfTriangle) / 2;
            Console.WriteLine(area);
        }

		public  void CalculatePerimeter()
		{ 
		
		}

	}

	public class Circle : Triangle
	{

		public new void CalculatePerimeter()
		{ 
		
		
		}

		public override void CalculateArea()
		{
			double area = 3.14 * base.BaseOfTriangle * base.BaseOfTriangle;
            Console.WriteLine(area);
        }


	}
}
