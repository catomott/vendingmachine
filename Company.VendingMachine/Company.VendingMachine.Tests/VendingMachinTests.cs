using Xunit;

namespace Company.VendingMachine.Tests
{
    public class VendingMachinTests
    {
        private VendingMachine _vendingMachine;

        public VendingMachinTests()
        {
            _vendingMachine = new VendingMachine();
        }

        [Fact]
        public void ValidCoin()
        {
            Coin dime = new Coin(1,1);

            Assert.Equal(true, _vendingMachine.InsertCoin(dime));
        }
    }
}
