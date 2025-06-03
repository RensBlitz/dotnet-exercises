namespace Exercises;
using System;

public class TodoItem
{
    private readonly string title;
    private readonly DateTime dueDate;
    private bool completed;

    public TodoItem(string title, DateTime dueDate)
    {
        // TODO
        throw new NotImplementedException();
    }
    public void ToggleCompleted()
    {
        // TODO
        throw new NotImplementedException();
    }
    public bool IsCompleted() => completed;

    public bool IsOverdue(DateTime now)
    {
        // TODO
        throw new NotImplementedException();
    }
} 