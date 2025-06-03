using Xunit;
using Exercises;

namespace Tests;
public class Course_Tests
{
    [Fact]
    public void EnrolDrop_Flow() {
        var c = new Course("Dotnet 101");
        Assert.True(c.Enrol("Alice"));
        Assert.False(c.Enrol("Alice"));   // already enrolled
        Assert.Equal(1, c.GetEnrolmentCount());
        Assert.True(c.Drop("Alice"));
        Assert.Equal(0, c.GetEnrolmentCount());
    }
} 