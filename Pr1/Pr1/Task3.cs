using System;

class Task3 : Tasks
{
    public override void Execute()
    {
        Random random = new Random();
        int[] array = new int[18];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-50, 50);
        }

        int min = int.MaxValue;
        int max = int.MinValue;

        foreach (int number in array)
        {
            if (number < min) min = number;
            if (number > max) max = number;
        }

        Console.WriteLine("Task 3:");
        Console.WriteLine($"Array: {string.Join(", ", array)}\nMin: {min}, Max: {max}\n");
    }
}
