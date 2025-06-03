using Xunit;
using Exercises;
using System;

namespace Tests;
public class TodoItem_Tests
{
    [Fact]
    public void Overdue_And_Toggle() {
        var t = new TodoItem("Finish report", DateTime.Now.AddDays(-1));
        Assert.True(t.IsOverdue(DateTime.Now));
        t.ToggleCompleted();
        Assert.True(t.IsCompleted());
    }
} 