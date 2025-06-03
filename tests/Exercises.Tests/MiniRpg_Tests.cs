using Xunit;
using Exercises;

namespace Tests;
public class MiniRpg_Tests
{
    [Fact]
    public void Battle_Simple() {
        var hero = new MiniRpg.Character("Hero", 10, 4);
        var monster = new MiniRpg.Character("Goblin", 8, 3);
        string winner = MiniRpg.Battle(hero, monster);
        Assert.Equal("Hero", winner);
        Assert.True(hero.IsAlive());
        Assert.False(monster.IsAlive());
    }
} 