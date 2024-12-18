using System;

class TaskController
{
    private readonly Tasks[] tasks;

    public TaskController(Tasks[] tasks)
    {
        this.tasks = tasks;
    }

    public void RunAllTasks()
    {
        foreach (var task in tasks)
        {
            task.Execute();
        }
    }
}