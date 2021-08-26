using System;
using Xunit;

namespace Calculations.Tests
{
    public class NamesFixture
    {
        public Names Names = new Names();
    }
    public class NamesTest : IClassFixture<NamesFixture>
    {
        private readonly NamesFixture _namesFixture;

        public NamesTest(NamesFixture namesFixture)
        {
            _namesFixture = namesFixture;
        }

        [Fact]
        [Trait("Category", "Names")]
        public void MakeFullNameTest()
        {
            var names = _namesFixture.Names;
            var result = names.MakeFullName("Carlos", "Zazueta");
            // Assert.Equal("Carlos Zazueta", result, ignoreCase: true);
            //Assert.Contains("carlos", result, StringComparison.InvariantCultureIgnoreCase);
            //Assert.StartsWith("carlos", result, StringComparison.InvariantCultureIgnoreCase);
            //Assert.EndsWith("Zazueta", result);
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result);
        }

        [Fact]
        [Trait("Category", "Names")]
        public void NickName_MustBeNull()
        {
            var names = _namesFixture.Names;
            names.NickName = "ClementeJacks";

            Assert.NotNull(names.NickName);
        }

        [Fact]
        [Trait("Category", "Names")]
        public void MakeFullName_AlwaysReturnValue()
        {
            var names = _namesFixture.Names;
            var result = names.MakeFullName("Clemente", "Zazueta");

            //Assert.NotNull(result);
            //Assert.NotEmpty(result);
            Assert.False(string.IsNullOrEmpty(result));
        }
    }
}
