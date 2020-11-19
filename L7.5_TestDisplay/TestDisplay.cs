using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7._5_TestDisplay
{
	class Coordinate : IPrintable
	{
		private double x;
		private double y;

		public Coordinate()
		{
			x = 0.0;
			y = 0.0;
		}

		public Coordinate(double px, double py)
		{
			x = px;
			y = py;
		}

		public void Print()
		{
			Console.WriteLine("({0},{1})", x, y);
		}
	}
	interface IPrintable
    {
        void Print();
    }
    class TestDisplay
    {
		public static void Display(object item)
		{
			IPrintable ip;

			ip = (item as IPrintable);

			if (ip != null)
				ip.Print();
			else
				Console.WriteLine(item.ToString());
		}
		static void Main(string[] args)
        {
			int num = 65;
			string msg = "A String";
			Coordinate c = new Coordinate(21.0, 68.0);

			Display(num);
			Display(msg);
			Display(c);

			Console.ReadKey();
        }
    }
}
