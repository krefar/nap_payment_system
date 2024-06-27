namespace Lesson
{
    public class HashGeneratorById : IHashGenerator
    {
        private readonly IHashService _hashServices;

        public HashGeneratorById(IHashService hashServices)
        {
            _hashServices = hashServices ?? throw new ArgumentNullException(nameof(hashServices));
        }

        public string GenerateHash(Order order)
        {
            return _hashServices.GetHash(order.ID);
        }
    }
}