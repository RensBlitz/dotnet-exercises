using Xunit;
using Exercises;
using System.Collections.Generic;

namespace Tests;
public class Leaderboard_Tests
{
    [Fact]
    public void TopThree_Basic() {
        var players = new List<Dictionary<string,object>>{
            new(){{"name","A"},{"points",90}},
            new(){{"name","B"},{"points",70}},
            new(){{"name","C"},{"points",80}},
            new(){{"name","D"},{"points",95}}
        };
        var top = Leaderboard.TopThree(players);
        Assert.Equal("1. D (95)", top[0]);
        Assert.Equal(3, top.Count);
    }
} 