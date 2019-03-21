using System;
using Xunit;

namespace Company.VendingMachine.Tests
{
    public class VendingMachinTests
    {
        private readonly VendingMachine _vendingMachine;
        private readonly Coin _penny = new Coin(2, 2);
        private readonly Coin _nickle = new Coin(3, 3);
        private readonly Coin _dime = new Coin(1, 1);
        private readonly Coin _quarter = new Coin(4, 4);

        public VendingMachinTests()
        {
            _vendingMachine = new VendingMachine();
        }

        #region Accept Coins

        [Fact]
        public void ValidCoinPenny()
        {
            Assert.False(_vendingMachine.ValidCoin(_penny));
        }

        [Fact]
        public void ValidCoinNickle()
        {
            Assert.True(_vendingMachine.ValidCoin(_nickle));
        }

        [Fact]
        public void ValidCoinDime()
        {
            Assert.True(_vendingMachine.ValidCoin(_dime));
        }

        [Fact]
        public void ValidCoinQuarter()
        {
            Assert.True(_vendingMachine.ValidCoin(_quarter));
        }


        [Fact]
        public void CoinValuePenny()
        {
            Assert.Equal(0.01M, _vendingMachine.CoinValue(_penny));
        }

        [Fact]
        public void CoinValueNickel()
        {
            Assert.Equal(0.05M, _vendingMachine.CoinValue(_nickle));
        }

        [Fact]
        public void CoinValueDime()
        {
            Assert.Equal(0.10M, _vendingMachine.CoinValue(_dime));
        }

        [Fact]
        public void CoinValueQuarter()
        {
            Assert.Equal(0.25M, _vendingMachine.CoinValue(_quarter));
        }

        [Fact]
        public void AddAmountPennyPlusPenny()
        {
            _vendingMachine.InsertCoin(_penny);
            _vendingMachine.InsertCoin(_penny);
            Assert.Equal(0.00M, _vendingMachine.Amount);
        }

        [Fact]
        public void AddAmountPennyPlusNickle()
        {
            _vendingMachine.InsertCoin(_penny);
            _vendingMachine.InsertCoin(_nickle);
            Assert.Equal(0.05M, _vendingMachine.Amount);
        }

        [Fact]
        public void AddAmountPennyPlusDime()
        {
            _vendingMachine.InsertCoin(_penny);
            _vendingMachine.InsertCoin(_dime);
            Assert.Equal(0.10M, _vendingMachine.Amount);
        }

        [Fact]
        public void AddAmountPennyPlusQuarter()
        {
            _vendingMachine.InsertCoin(_penny);
            _vendingMachine.InsertCoin(_quarter);
            Assert.Equal(0.25M, _vendingMachine.Amount);
        }

        [Fact]
        public void AddAmountNicklePlusNickle()
        {
            _vendingMachine.InsertCoin(_nickle);
            _vendingMachine.InsertCoin(_nickle);
            Assert.Equal(0.10M, _vendingMachine.Amount);
        }

        [Fact]
        public void AddAmountNicklePlusDime()
        {
            _vendingMachine.InsertCoin(_nickle);
            _vendingMachine.InsertCoin(_dime);
            Assert.Equal(0.15M, _vendingMachine.Amount);
        }

        [Fact]
        public void AddAmountNicklePlusQuarter()
        {
            _vendingMachine.InsertCoin(_nickle);
            _vendingMachine.InsertCoin(_quarter);
            Assert.Equal(0.30M, _vendingMachine.Amount);
        }

        [Fact]
        public void AddAmountDimePlusDime()
        {
            _vendingMachine.InsertCoin(_dime);
            _vendingMachine.InsertCoin(_dime);
            Assert.Equal(0.20M, _vendingMachine.Amount);
        }

        [Fact]
        public void AddAmountDimePlusQuarter()
        {
            _vendingMachine.InsertCoin(_dime);
            _vendingMachine.InsertCoin(_quarter);
            Assert.Equal(0.35M, _vendingMachine.Amount);
        }

        [Fact]
        public void AddAmountQuarterPlusQuarter()
        {
            _vendingMachine.InsertCoin(_quarter);
            _vendingMachine.InsertCoin(_quarter);
            Assert.Equal(0.50M, _vendingMachine.Amount);
        }

        [Fact]
        public void DisplayInsetCoinNoCoin()
        {
            Assert.Equal("INSERT COIN", _vendingMachine.Display(Convert.ToDecimal(_vendingMachine.Amount)));
        }

        [Fact]
        public void DisplayInsetCoinNicklePlusDimePlusQuarter()
        {
            _vendingMachine.InsertCoin(_nickle);
            _vendingMachine.InsertCoin(_dime);
            _vendingMachine.InsertCoin(_quarter);
            Assert.Equal("0.40", _vendingMachine.Display(Convert.ToDecimal(_vendingMachine.Amount)));
        }

        [Fact]
        public void CoinReturn()
        {
            _vendingMachine.InsertCoin(_penny);
            Assert.True(_vendingMachine.CoinReturn());
        }
        #endregion
    }
}
