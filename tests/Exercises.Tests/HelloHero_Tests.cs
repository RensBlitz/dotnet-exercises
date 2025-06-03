using Xunit;
using Exercises;

namespace Tests;
public class HelloHero_Tests
{
    [Fact] public void Basic() =>
        Assert.Equal("Welcome, Alex!", HelloHero.Greet("Alex"));
} 