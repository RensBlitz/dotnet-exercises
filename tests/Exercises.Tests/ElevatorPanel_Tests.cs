using Xunit;
using Exercises;

namespace Tests;
public class ElevatorPanel_Tests
{
    [Fact] public void Negative() => Assert.False(ElevatorPanel.IsValidFloor(-1));
    [Fact] public void Ground()   => Assert.True (ElevatorPanel.IsValidFloor(0));
    [Fact] public void TooHigh()  => Assert.False(ElevatorPanel.IsValidFloor(21));
} 