using Xunit;
using Exercises;

namespace Tests;
public class SimpleDungeonCrawler_Tests
{
    [Fact]
    public void Basic()
    {
        string[] a = { "hit", "potion", "hit", "hit" };
        Assert.Equal(4, SimpleDungeonCrawler.Simulate(a));
    }
} 