namespace Company.VendingMachine
{
    public class VendingMachine
    {
        private Coin _penny = new Coin(2,2);
        private Coin _nickle = new Coin(3, 3);
        private Coin _dime = new Coin(1, 1);
        private Coin _quarter = new Coin(4, 4);

        public bool InsertCoin(Coin coin)
        {
            return coin != _penny;
        }
    }
}
