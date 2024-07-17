using System;
namespace Module1Review;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a shape to calculate the area:");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Triangle");
            Console.WriteLine("3. Rectangle");
            Console.WriteLine("4. Square");
            Console.Write("Enter the number of your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the radius of the circle: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    double circleArea = CalculateCircleArea(radius);
                    Console.WriteLine($"The area of the circle is: {circleArea}");
                    break;
                case 2:
                    Console.Write("Enter the base length of the triangle: ");
                    double baseLength = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the height of the triangle: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    double triangleArea = CalculateTriangleArea(baseLength, height);
                    Console.WriteLine($"The area of the triangle is: {triangleArea}");
                    break;
                case 3:
                    Console.Write("Enter the length of the rectangle: ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the width of the rectangle: ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    double rectangleArea = CalculateRectangleArea(length, width);
                    Console.WriteLine($"The area of the rectangle is: {rectangleArea}");
                    break;
                case 4:
                    Console.Write("Enter the side length of the square: ");
                    double side = Convert.ToDouble(Console.ReadLine());
                    double squareArea = CalculateSquareArea(side);
                    Console.WriteLine($"The area of the square is: {squareArea}");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please restart the program and choose a valid option.");
                    break;
            }
    }

    static double CalculateCircleArea(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }
    
    static double CalculateTriangleArea(double baseLength, double height)
    {
        return 0.5 * baseLength * height;
    }
    
    static double CalculateRectangleArea(double length, double width)
    {
        return length * width;
    }
    
    static double CalculateSquareArea(double side)
    {
        return Math.Pow(side, 2);
    }
}