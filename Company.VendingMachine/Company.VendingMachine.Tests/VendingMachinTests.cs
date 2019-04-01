using System;
using Xunit;

namespace Company.VendingMachine.Tests
{
    public class VendingMachinTests
    {
        private readonly VendingMachine _vendingMachine;


        public VendingMachinTests()
        {
            _vendingMachine = new VendingMachine();
        }

        #region Accept Coins

        [Fact]
        public void ValidCoinPenny()
        {
            Assert.False(_vendingMachine.ValidCoin(_vendingMachine.Penny));
        }

        [Fact]
        public void ValidCoinNickle()
        {
            Assert.True(_vendingMachine.ValidCoin(_vendingMachine.Nickle));
        }

        [Fact]
        public void ValidCoinDime()
        {
            Assert.True(_vendingMachine.ValidCoin(_vendingMachine.Dime));
        }

        [Fact]
        public void ValidCoinQuarter()
        {
            Assert.True(_vendingMachine.ValidCoin(_vendingMachine.Quarter));
        }


        [Fact]
        public void CoinValuePenny()
        {
            Assert.Equal(0.01M, _vendingMachine.CoinValue(_vendingMachine.Penny));
        }

        [Fact]
        public void CoinValueNickel()
        {
            Assert.Equal(0.05M, _vendingMachine.CoinValue(_vendingMachine.Nickle));
        }

        [Fact]
        public void CoinValueDime()
        {
            Assert.Equal(0.10M, _vendingMachine.CoinValue(_vendingMachine.Dime));
        }

        [Fact]
        public void CoinValueQuarter()
        {
            Assert.Equal(0.25M, _vendingMachine.CoinValue(_vendingMachine.Quarter));
        }

        [Fact]
        public void AddAmountPennyPlusPenny()
        {
            _vendingMachine.InsertCoin(_vendingMachine.Penny);
            _vendingMachine.InsertCoin(_vendingMachine.Penny);
            Assert.Equal(0.00M, _vendingMachine.Amount);
        }

        [Fact]
        public void AddAmountPennyPlusNickle()
        {
            _vendingMachine.InsertCoin(_vendingMachine.Penny);
            _vendingMachine.InsertCoin(_vendingMachine.Nickle);
            Assert.Equal(0.05M, _vendingMachine.Amount);
        }

        [Fact]
        public void AddAmountPennyPlusDime()
        {
            _vendingMachine.InsertCoin(_vendingMachine.Penny);
            _vendingMachine.InsertCoin(_vendingMachine.Dime);
            Assert.Equal(0.10M, _vendingMachine.Amount);
        }

        [Fact]
        public void AddAmountPennyPlusQuarter()
        {
            _vendingMachine.InsertCoin(_vendingMachine.Penny);
            _vendingMachine.InsertCoin(_vendingMachine.Quarter);
            Assert.Equal(0.25M, _vendingMachine.Amount);
        }

        [Fact]
        public void AddAmountNicklePlusNickle()
        {
            _vendingMachine.InsertCoin(_vendingMachine.Nickle);
            _vendingMachine.InsertCoin(_vendingMachine.Nickle);
            Assert.Equal(0.10M, _vendingMachine.Amount);
        }

        [Fact]
        public void AddAmountNicklePlusDime()
        {
            _vendingMachine.InsertCoin(_vendingMachine.Nickle);
            _vendingMachine.InsertCoin(_vendingMachine.Dime);
            Assert.Equal(0.15M, _vendingMachine.Amount);
        }

        [Fact]
        public void AddAmountNicklePlusQuarter()
        {
            _vendingMachine.InsertCoin(_vendingMachine.Nickle);
            _vendingMachine.InsertCoin(_vendingMachine.Quarter);
            Assert.Equal(0.30M, _vendingMachine.Amount);
        }

        [Fact]
        public void AddAmountDimePlusDime()
        {
            _vendingMachine.InsertCoin(_vendingMachine.Dime);
            _vendingMachine.InsertCoin(_vendingMachine.Dime);
            Assert.Equal(0.20M, _vendingMachine.Amount);
        }

        [Fact]
        public void AddAmountDimePlusQuarter()
        {
            _vendingMachine.InsertCoin(_vendingMachine.Dime);
            _vendingMachine.InsertCoin(_vendingMachine.Quarter);
            Assert.Equal(0.35M, _vendingMachine.Amount);
        }

        [Fact]
        public void AddAmountQuarterPlusQuarter()
        {
            _vendingMachine.InsertCoin(_vendingMachine.Quarter);
            _vendingMachine.InsertCoin(_vendingMachine.Quarter);
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
            _vendingMachine.InsertCoin(_vendingMachine.Nickle);
            _vendingMachine.InsertCoin(_vendingMachine.Dime);
            _vendingMachine.InsertCoin(_vendingMachine.Quarter);
            Assert.Equal("0.40", _vendingMachine.Display(Convert.ToDecimal(_vendingMachine.Amount)));
        }

        [Fact]
        public void CoinReturn()
        {
            _vendingMachine.InsertCoin(_vendingMachine.Penny);
            Assert.True(_vendingMachine.CoinReturn());
        }
        #endregion

        #region SELECT PRODUCT
        [Fact]
        public void ColaPrice()
        {
            Assert.Equal(1.00M , Product.Cola);
        }

        [Fact]
        public void ChipsPrice()
        {
            Assert.Equal(0.50M , Product.Chips);
        }

        [Fact]
        public void CandyPrice()
        {
            Assert.Equal(0.65M , Product.Candy);
        }

        [Fact]
        public void ColaDispensed()
        {
            _vendingMachine.InsertCoin(_vendingMachine.Quarter);
            _vendingMachine.InsertCoin(_vendingMachine.Quarter);
            _vendingMachine.InsertCoin(_vendingMachine.Quarter);
            _vendingMachine.InsertCoin(_vendingMachine.Quarter);
            Assert.True(_vendingMachine.Dispense(_vendingMachine.Amount));
        }

        [Fact]
        public void DisplayThankYou()
        {
            Assert.Equal("THANK YOU", _vendingMachine.Display(1.00M));
        }
        
        #endregion
    }
}
