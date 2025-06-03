using Xunit;
using Exercises;

namespace Tests;
public class PizzaPlanner_Tests
{
    [Fact]
    public void PizzasNeeded_Example() {
        Assert.Equal(3, PizzaPlanner.PizzasNeeded(7, 3)); // 21 slices → 3 pizzas
    }
} 