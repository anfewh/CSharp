using System;

class Task2 : Tasks
{
    public override void Execute()
    {
        double a = 4, b = 4, c = 5; 

        if (a + b > c && a + c > b && b + c > a)
        {
            double perimeter = a + b + c;
            double s = perimeter / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            string type = (a == b && b == c) ? "Equilateral" :
                          (a == b || b == c || a == c) ? "Isosceles" :
                          "Scalene";

            Console.WriteLine("Task 2:");
            Console.WriteLine($"Perimeter: {perimeter}, Area: {area:F2}, Type: {type}\n");
        }
        else
        {
            Console.WriteLine("Task 2:\nInvalid triangle sides provided.\n");
        }
    }
}
