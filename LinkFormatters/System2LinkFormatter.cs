namespace Lesson
{
    public class System2LinkFormatter : ILinkFormatter
    {
        private readonly string _linkTemplate;

        public System2LinkFormatter(string linkTemplate)
        {
            _linkTemplate = linkTemplate;
        }

        public string FormatLink(Order order, string orderHash)
        {
            return string.Format(_linkTemplate, orderHash);
        }
    }
}