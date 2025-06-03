using Xunit;
using Exercises;

namespace Tests;
public class TinyEncryption_Tests
{
    [Fact]
    public void ShiftCipher_Simple() {
        Assert.Equal("Uifsf", TinyEncryption.ShiftCipher("There", 1));
    }
} 