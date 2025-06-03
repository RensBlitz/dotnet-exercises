using Xunit;
using Exercises;
using System.Collections.Generic;

namespace Tests;
public class CinemaRowRearrange_Tests
{
    [Fact]
    public void Rearrange_Basic() {
        var outList = CinemaRowRearrange.Rearrange(new List<int>{20,15,30,12});
        Assert.Equal(new List<int>{15,12,20,30}, outList);
    }
} 