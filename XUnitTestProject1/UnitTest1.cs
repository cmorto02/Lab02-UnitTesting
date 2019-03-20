using System;
using Xunit;
using static Lab02_UnitTesting.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ICanWithdrawFromTheBalance()
        {
            decimal mockBalance = 2400.00M;
            decimal mockWithdraw = 60.00M;

            decimal result = Withdraw(mockBalance, mockWithdraw);

            Assert.Equal(2340.00M, result);
        }
    }
}
