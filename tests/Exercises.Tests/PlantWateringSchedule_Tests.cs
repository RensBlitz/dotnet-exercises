using Xunit;
using Exercises;

namespace Tests;
public class PlantWateringSchedule_Tests
{
    [Fact] public void MondayTrue() => Assert.True (PlantWateringSchedule.ShouldWater("Monday"));
    [Fact] public void FridayFalse()=> Assert.False(PlantWateringSchedule.ShouldWater("Friday"));
} 