namespace Area_Calculator_HW_Y10
{
	internal class Program
	{
		static void CalculateCircleArea()
		{
			Console.WriteLine("Enter the radius of the circle:");
			double r = Convert.ToDouble(Console.ReadLine());
			double CircArea = (r * r * Math.PI);

			Console.WriteLine("Area of circle with radius " + r + " is " + CircArea + " units²");
		}

		static void CalculateRectangleArea()
		{
			Console.WriteLine("Enter the length of the rectangle:");
			double l = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter the width of the rectangle:");
			double w = Convert.ToDouble(Console.ReadLine());
			double RectArea = Math.Round((l * w), 10);
			Console.WriteLine("Area of rectangle with length " + l + " and width " + w + " is " + RectArea + " units²");
		}

		static void CalculateTriangleArea()
		{
			Console.WriteLine("Enter the base of the triangle:");
			double b = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter the height of the triangle:");
			double h = Convert.ToDouble(Console.ReadLine());
			double TriArea = Math.Round((0.5 * b * h), 10);
			Console.WriteLine("Area of triangle with base " + b + " and height " + h + " is " + TriArea + " units²");
		}

		static void CalculateTrapeziumArea()
		{
			Console.WriteLine("Enter the length of the first parallel side of the trapezium:");
			double a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter the length of the second parallel side of the trapezium:");
			double b = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter the height of the trapezium:");
			double h = Convert.ToDouble(Console.ReadLine());
			double TrapArea = Math.Round((0.5 * (a + b) * h), 10);
			Console.WriteLine("Area of trapezium with sides " + a + " and " + b + " and height " + h + " is " + TrapArea + " units²");
		}

		static void CalculateParallelogramArea()
		{
			Console.WriteLine("Enter the base of the parallelogram:");
			double b = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter the height of the parallelogram:");
			double h = Convert.ToDouble(Console.ReadLine());
			double ParaArea = Math.Round((b * h), 10);
			Console.WriteLine("Area of parallelogram with base " + b + " and height " + h + " is " + ParaArea + " units²");
		}

		static void CalculateSquareArea()
		{
			Console.WriteLine("Enter the side length of the square:");
			double s = Convert.ToDouble(Console.ReadLine());
			double SquareArea = Math.Round((s * s), 10);
			Console.WriteLine("Area of square with side length " + s + " is " + SquareArea + " units²");
		}

		static void CalculateEllipseArea()
		{
			Console.WriteLine("Enter the semi-major axis of the ellipse:");
			double a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter the semi-minor axis of the ellipse:");
			double b = Convert.ToDouble(Console.ReadLine());
			double EllipseArea = Math.Round((Math.PI * a * b), 10);
			Console.WriteLine("Area of ellipse with semi-major axis " + a + " and semi-minor axis " + b + " is " + EllipseArea + " units²");
		}



		static void Main(string[] args)
		{
			string usershapewanted;
			bool validshapechosen = false;

			Console.WriteLine("==========================================");
			Console.WriteLine("            AREA CALCULATOR");
			Console.WriteLine("==========================================");


			while (validshapechosen == false)
			{
				Console.WriteLine("Choose 1 for Circle");
				Console.WriteLine("Choose 2 for Rectangle");
				Console.WriteLine("Choose 3 for Triangle");
				Console.WriteLine("Choose 4 for Trapezium");
				Console.WriteLine("Choose 5 for Parallelogram");
				Console.WriteLine("Choose 6 for Square");
				Console.WriteLine("Choose 7 for Ellipse");
				Console.WriteLine();
				usershapewanted = Console.ReadLine();

				if (usershapewanted == "1")
				{
					CalculateCircleArea();
					validshapechosen = true;
				}
				else if (usershapewanted == "2")
				{
					CalculateRectangleArea();
					validshapechosen = true;
				}
				else if (usershapewanted == "3")
				{
					CalculateTriangleArea();
					validshapechosen = true;
				}
				else if (usershapewanted == "4")
				{
					CalculateTrapeziumArea();
					validshapechosen = true;
				}
				else if (usershapewanted == "5")
				{
					CalculateParallelogramArea();
					validshapechosen = true;
				}
				else if (usershapewanted == "6")
				{
					CalculateSquareArea();
					validshapechosen = true;
				}
				else if (usershapewanted == "7")
				{
					CalculateEllipseArea();
					validshapechosen = true;
				}
				else
				{
					Console.WriteLine("Invalid input. Please choose a number between 1 and 7.");
					Console.WriteLine();
				}
			}
		}
	}
}
