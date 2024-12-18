using System;

class Task4 : Tasks
{
    public override void Execute()
    {
        Random random = new Random();
        int[] array = new int[18];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-50, 50);
        }
        int M = 13;

        var filtered = array.Where(x => Math.Abs(x) > M).ToArray();

        Console.WriteLine("Task 4:");
        Console.WriteLine($"Threshold (M): {M}\nOriginal Array: {string.Join(", ", array)}\nFiltered Array: {string.Join(", ", filtered)}\n");
    }
}