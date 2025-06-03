using Xunit;
using Exercises;

namespace Tests;
public class ClassroomScores_Tests
{
    [Fact]
    public void Analyse_Basic() {
        double[] r = ClassroomScores.Analyse(new int[]{70, 80, 90});
        Assert.Equal(70, r[0], 3);
        Assert.Equal(90, r[1], 3);
        Assert.Equal(80, r[2], 3);
    }
} 