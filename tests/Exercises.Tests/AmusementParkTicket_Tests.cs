using Xunit;
using Exercises;

namespace Tests;
public class AmusementParkTicket_Tests
{
    [Fact] public void ChildFree()  => Assert.Equal(0, AmusementParkTicket.ComputePrice(10, 25));
    [Fact] public void AdultPays()  => Assert.Equal(25, AmusementParkTicket.ComputePrice(30, 25));
    [Fact] public void SeniorFree() => Assert.Equal(0, AmusementParkTicket.ComputePrice(70, 25));
} 