using Xunit;
using Exercises;

namespace Tests;
public class EvenOddGame_Tests
{
    [Fact] public void Even() => Assert.Equal("wizard", EvenOddGame.Classify(4));
    [Fact] public void Odd()  => Assert.Equal("orc",    EvenOddGame.Classify(7));
} 