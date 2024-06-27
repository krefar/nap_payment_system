namespace Lesson
{
    public class Order
    {
        private readonly int _id;
        private readonly int _amount;

        public Order(int id, int amount)
        {
            if (id == 0)
                throw new ArgumentOutOfRangeException(nameof(amount));

            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount));

            _id = id;
            _amount = amount;
        }

        public int ID => _id;
        public int Amount => _amount;
    }
}