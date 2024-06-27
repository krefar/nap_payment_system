namespace Lesson
{
    public class HashGeneratorByIdAndAmount : IHashGenerator
    {
        private readonly IHashService _hashServices;

        public HashGeneratorByIdAndAmount(IHashService hashServices)
        {
            _hashServices = hashServices ?? throw new ArgumentNullException(nameof(hashServices));
        }

        public string GenerateHash(Order order)
        {
            return _hashServices.GetHash(order.ID + order.Amount);
        }
    }
}