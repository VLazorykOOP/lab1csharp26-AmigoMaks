using System;

public class CombinedTasks
{
    static void Main()
    {
        RunTask1_Trapezoid();
        RunTask2_Digits();
        RunTask3_PointRegion();
        RunTask4_AgeCategory();
        RunTask5_SquareOfProduct();
        RunTask6_Expression();
    }

    static void RunTask1_Trapezoid()
    {
        Console.WriteLine("\nTASK 1");
        try
        {
            Console.Write("Enter larger base (a): ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter smaller base (b): ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the angle at the larger base in degrees: ");
            double angleDegrees = Convert.ToDouble(Console.ReadLine());

            double angleRadians = angleDegrees * Math.PI / 180.0;
            double x = (a - b) / 2;
            double h = x * Math.Tan(angleRadians);

            if (h > 0 && a > b)
            {
                double area = ((a + b) / 2) * h;
                Console.WriteLine($"Result: Height = {h:F2}, Area = {area:F2}");
            }
            else
            {
                Console.WriteLine("Invalid data");
            }
        }
        catch { Console.WriteLine("Enter numbers"); }
    }

    static void RunTask2_Digits()
    {
        Console.WriteLine("\nTASK 2");
        try
        {
            Console.Write("Enter a 3-digit number: ");
            int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

            if (num < 100 || num > 999)
            {
                Console.WriteLine("The number is not 3 digits long");
                return;
            }

            int secondDigit = (num / 10) % 10;
            int lastDigit = num % 10;

            Console.WriteLine($"Second digit: {secondDigit}, Last digit: {lastDigit}");

            if (secondDigit > lastDigit)
                Console.WriteLine("The second digit is larger");
            else if (lastDigit > secondDigit)
                Console.WriteLine("The last digit is larger");
            else
                Console.WriteLine("Both digits are equal");
        }
        catch { Console.WriteLine("Invalid input"); }
    }

    static void RunTask3_PointRegion()
    {
        Console.WriteLine("\nTASK 3");
        try
        {
            Console.Write("Enter X coordinate: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Y coordinate: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double eps = 1e-6;
            double distanceSq = x * x + y * y;

            bool inCircle = distanceSq <= 100 + eps;
            bool rightOfY = x >= -eps;
            bool aboveLine = (x + y) >= -eps;

            bool strictlyInCircle = distanceSq < 100 - eps;
            bool strictlyRightOfY = x > eps;
            bool strictlyAboveLine = (x + y) > eps;

            bool isInside = strictlyInCircle && strictlyRightOfY && strictlyAboveLine;
            bool isInOrOn = inCircle && rightOfY && aboveLine;

            if (isInside)
            {
                Console.WriteLine("Yes");
            }
            else if (isInOrOn)
            {
                Console.WriteLine("On border");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        catch { Console.WriteLine("Invalid input."); }
    }

    static void RunTask4_AgeCategory()
    {
        Console.WriteLine("\nTASK 4");
        try
        {
            Console.Write("Enter age in years: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 0) Console.WriteLine("Age cannot be negative.");
            else if (age < 1) Console.WriteLine("baby");
            else if (age >= 1 && age <= 11) Console.WriteLine("child");
            else if (age >= 12 && age <= 15) Console.WriteLine("teen");
            else if (age >= 16 && age <= 25) Console.WriteLine("lad");
            else if (age >= 26 && age <= 70) Console.WriteLine("man");
            else Console.WriteLine("old");
        }
        catch { Console.WriteLine("Enter integer."); }
    }

    static void RunTask5_SquareOfProduct()
    {
        Console.WriteLine("\nTASK 5");
        try
        {
            Console.Write("Enter first real number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second real number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = CalculateSquareOfProduct(num1, num2);
            Console.WriteLine($"Result: {result:F4}");
        }
        catch { Console.WriteLine("Invalid input"); }
    }

    public static double CalculateSquareOfProduct(double a, double b)
    {
        double product = a * b;
        return product * product;
    }

    static void RunTask6_Expression()
    {
        Console.WriteLine("\nTASK 6");
        try
        {
            Console.Write("Enter integer n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter integer m: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int denominator = n + m * m;

            if (denominator == 0)
            {
                Console.WriteLine("Division by zero");
            }
            else
            {
                double result = (5.0 / denominator) * (m + n) + (n * n);
                Console.WriteLine($"Result: {result:F4}");
            }
        }
        catch { Console.WriteLine("Enter integers"); }
    }
}
