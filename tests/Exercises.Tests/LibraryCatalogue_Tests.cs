using Xunit;
using Exercises;

namespace Tests;
public class LibraryCatalogue_Tests
{
    [Fact]
    public void AddLookupRemove_Cycle() {
        var lib = new LibraryCatalogue();
        lib.AddBook("123","Dune");
        Assert.Equal("Dune", lib.Lookup("123"));
        Assert.True( lib.RemoveBook("123"));
        Assert.Null( lib.Lookup("123"));
    }
} 