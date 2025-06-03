using Xunit;
using Exercises;

namespace Tests;
public class GradeAverage_Tests
{
    [Fact] public void Average_Basic(){
        Assert.Equal(75.0, GradeAverage.Average(new int[]{60,90}), 3);
    }
    [Fact] public void Average_Empty(){
        Assert.Equal(-1.0, GradeAverage.Average(new int[]{}), 3);
    }
} 