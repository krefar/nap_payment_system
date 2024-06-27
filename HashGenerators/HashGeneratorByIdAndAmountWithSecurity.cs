namespace Lesson
{
    public class HashGeneratorByIdAndAmountWithSecurity : IHashGenerator
    {
        private readonly int _securityKey;
        private readonly IHashService _hashServices;

        public HashGeneratorByIdAndAmountWithSecurity(IHashService hashServices)
        {
            _hashServices = hashServices ?? throw new ArgumentNullException(nameof(hashServices));
            _securityKey = SecurityRepository.GetSecurityKeyForHash();
        }

        public string GenerateHash(Order order)
        {
            return _hashServices.GetHash(order.ID + order.Amount + _securityKey);
        }
    }
}