namespace Company.VendingMachine
{
    public class Coin
    { 
        public Coin(int weight, int size)
        {
            Weight = weight;
            Size = size;
        }

        public int Weight { get; }
        public int Size { get; }
    }
}
