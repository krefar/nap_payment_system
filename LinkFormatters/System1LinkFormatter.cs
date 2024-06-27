namespace Lesson
{
    public class System1LinkFormatter : ILinkFormatter
    {
        private readonly string _linkTemplate;
        private readonly string _currency;

        public System1LinkFormatter(string linkTemplate, string currency)
        {
            _linkTemplate = linkTemplate;
            _currency = currency;
        }

        public string FormatLink(Order order, string orderHash)
        {
            return string.Format(_linkTemplate, $"{order.Amount}{_currency}", orderHash);
        }
    }
}