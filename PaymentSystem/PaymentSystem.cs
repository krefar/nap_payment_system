namespace Lesson
{
    public class PaymentSystem : IPaymentSystem
    {
        private readonly ILinkFormatter _linkFormatter;
        private readonly IHashGenerator _hashGenerator;

        public PaymentSystem(ILinkFormatter linkFormatter, IHashGenerator hashGenerator)
        {
            _linkFormatter = linkFormatter ?? throw new ArgumentNullException(nameof(linkFormatter));
            _hashGenerator = hashGenerator ?? throw new ArgumentNullException(nameof(hashGenerator));
        }

        public string GetPayingLink(Order order)
        {
            return _linkFormatter.FormatLink(order, _hashGenerator.GenerateHash(order));
        }
    }
}