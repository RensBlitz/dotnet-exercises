using Xunit;
using Exercises;

namespace Tests;
public class Pet_Tests
{
    [Fact]
    public void Speak_Dog() {
        Assert.Equal("Woof!", new Pet("Rex","dog",2).Speak());
    }
    [Fact]
    public void Speak_Unknown() {
        Assert.Equal("...", new Pet("Mystery","dragon",500).Speak());
    }
} 