using System;

class Task1 : Tasks
{
    public override void Execute()
    {
        int[] numbers = { 2, 19, 8 };
        int rangeLimit = 10 + 8;
        Console.WriteLine("Task 1:");
        Console.WriteLine("Numbers in range [1, {0}]:", rangeLimit);

        foreach (int number in numbers)
        {
            if (number >= 1 && number <= rangeLimit)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine("\n");
    }
}