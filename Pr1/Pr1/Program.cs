using System;

class Program
{
    static void Main(string[] args)
    {
        Tasks[] tasks = { new Task1(), new Task2(), new Task3(), new Task4() };
        var controller = new TaskController(tasks);

        controller.RunAllTasks();
    }
}
