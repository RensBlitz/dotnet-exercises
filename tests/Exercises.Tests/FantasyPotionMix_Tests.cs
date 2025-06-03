using Xunit;
using Exercises;

namespace Tests;

public class FantasyPotionMix_Tests
{
    [Fact]
    public void Volumes_750() =>
        Assert.Equal(new[] {225, 375, 150}, FantasyPotionMix.IngredientVolumes(750));
} 