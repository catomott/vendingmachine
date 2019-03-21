using System;
using System.ComponentModel;

namespace Company.VendingMachine
{
    public class VendingMachine
    {
        private readonly Coin _penny = new Coin(2,2);
        private readonly Coin _nickle = new Coin(3, 3);
        private readonly Coin _dime = new Coin(1, 1);
        private readonly Coin _quarter = new Coin(4, 4);

        private decimal _coinValue;
        public decimal Amount { get; set; }


        public decimal InsertCoin(Coin coin)
        {
            var amount = !ValidCoin(coin) ? 0.00M : CoinValue(coin);

            try
            {
                AddAmount(amount);
                Display(Amount);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error on InsertCoin. Exception:" + e);
            }
          
            return amount;
        }

        public bool ValidCoin(Coin coin)
        {
            if (coin.Weight != _penny.Weight || coin.Size != _penny.Size)
            {
                return true;
            }
            CoinReturn();
            return false;
        }

        public decimal CoinValue(Coin coin)
        {
            try
            {
                if (coin.Weight != _penny.Weight && coin.Size != _penny.Size)
                {
                    if (coin.Weight == _nickle.Weight && coin.Size == _nickle.Size)
                    {
                        _coinValue = 0.05M;
                    }
                    else if (coin.Weight == _dime.Weight && coin.Size == _dime.Size)
                    {
                        _coinValue = 0.10M;
                    }
                    else if (coin.Weight == _quarter.Weight && coin.Size == _quarter.Size)
                    {
                        _coinValue = 0.25M;
                    }
                    else
                    {
                        _coinValue = 0.00M;
                    }
                }
                else
                {
                    _coinValue = 0.01M;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error on CoinValue. Exception:" + e);
            }

            return _coinValue;
        }

        public bool CoinReturn()
        {
            return true;
        }

        public void AddAmount(decimal amount)
        {
            Amount += amount;
        }

        public string Display(decimal amount)
        {
            return amount != 0.00M ? Amount.ToString() : "INSERT COIN";
        }
    }
}
