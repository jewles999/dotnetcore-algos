using System;
using Xunit;
using DS;

namespace DS.Tests
{
    public class PrimeServiceTest
    {
        private readonly PrimeService primeService;
        public PrimeServiceTest()
        {
            primeService = new PrimeService();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(0)]
        [InlineData(-1)]
        public void ReturnFalseIf_LessThan_1(int val)
        {
            var result = primeService.IsPrime(val);
            Assert.False(result, $"{1} is not prime {val}");
        }

        [Theory]
        [InlineData(60)]
        [InlineData(4)]
        public void ReturnFalseIf_Mod2(int val)
        {
            var result = primeService.IsPrime(val);
            Assert.False(result, "Divides by 2");
        }

        [Theory]
        [InlineData(9)]
        [InlineData(6)]
        public void ReturnFalseIf_Mod3(int val)
        {
            var result = primeService.IsPrime(val);
            Assert.False(result, "Divides by 3");
        }

        [Theory]
        [InlineData(15)]
        [InlineData(85)]
        public void ReturnFalseIf_Mod5(int val)
        {
            var result = primeService.IsPrime(val);
            Assert.False(result, "Divides by 5");
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(13)]
        [InlineData(227)]
        [InlineData(1000000007)]
        [InlineData(10007)]
        public void ReturnTrueIf_ModItself_AndNotOthers(int val)
        {
            var result = primeService.IsPrime(val);
            Assert.True(result, "Is prime");
        }
    }
}
