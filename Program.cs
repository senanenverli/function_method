//task 1
//static int Square(int number)
//{
//    return number * number;
//}
//int result = Square(5);

//Console.WriteLine(result);

////task 2
//using System;

//public class AreaCalculator
//{
//    public static double Area(double radius)
//    {
//        return Math.PI * Math.Pow(radius, 2);
//    }

//    public static double Area(double length, double width)
//    {
//        return length * width;
//    }

//    public static double Area(double radius, double side, double side1, double side2)
//    {
//        double per = (side + side1 + side2) / 2;
//        return per * radius;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        double circleArea = AreaCalculator.Area(5);
//        Console.WriteLine("Area of the circle: " + circleArea);

//        double rectangleArea = AreaCalculator.Area(4, 6);
//        Console.WriteLine("Area of the rectangle: " + rectangleArea);

//        double theCirleInTriangleArea=AreaCalculator.Area(4,5,6,7);
//        Console.WriteLine("Area of the Circle in Triangle: " + theCirleInTriangleArea);
//    }
//}

//task3
using System;

class Program
{
    static int SumNumbersUntilLimit(int limit)
    {
        int total = 0;
        int i = 1;
        while (total + i <= limit)
        {
            total += i;
            i++;
        }
        return total;
    }

    static void Main()
    {
        int givenInteger = 15;
        int result = SumNumbersUntilLimit(number);
        Console.WriteLine($"The sum of numbers until it's less than {number}");
    }
}






