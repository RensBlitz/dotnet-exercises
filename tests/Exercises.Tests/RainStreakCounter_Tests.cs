using Xunit;
using Exercises;

namespace Tests;
public class RainStreakCounter_Tests
{
    [Fact]
    public void SampleWeek()
    {
        bool[] w = { true,true,false,true,true,true,false };
        Assert.Equal(3, RainStreakCounter.LongestStreak(w));
    }
} 