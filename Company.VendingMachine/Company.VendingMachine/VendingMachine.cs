using System;
using System.ComponentModel;

namespace Company.VendingMachine
{
    public class VendingMachine
    {
        private const decimal V = 1.00M;
        public readonly Coin Penny = new Coin(2,2);
        public readonly Coin Nickle = new Coin(3, 3);
        public readonly Coin Dime = new Coin(1, 1);
        public readonly Coin Quarter = new Coin(4, 4);


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
            if (coin.Weight != Penny.Weight || coin.Size != Penny.Size)
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
                if (coin.Weight != Penny.Weight && coin.Size != Penny.Size)
                {
                    if (coin.Weight == Nickle.Weight && coin.Size == Nickle.Size)
                    {
                        _coinValue = 0.05M;
                    }
                    else if (coin.Weight == Dime.Weight && coin.Size == Dime.Size)
                    {
                        _coinValue = 0.10M;
                    }
                    else if (coin.Weight == Quarter.Weight && coin.Size == Quarter.Size)
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

        public bool Dispense(decimal amount)
        {
            if(amount == 1.00M)
            {
                Display(1.00M);
                return true;
            }
            return false;
        }



        public string Display(decimal amount)
        {
            if(amount == 1.00M)
            {
                return "THANK YOU";
            }
            return amount != 0.00M ? Amount.ToString() : "INSERT COIN";
        }
    }
}
