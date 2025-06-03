using Xunit;
using Exercises;

namespace Tests;
public class WeatherSensor_Tests
{
    [Fact]
    public void AverageTemp_Basic() {
        var w = new WeatherSensor();
        w.Record(10); w.Record(14); w.Record(16);
        Assert.Equal(40/3.0, w.AverageTemp(), 3);
    }
} 