namespace Lesson
{
    public interface ILinkFormatter
    {
        string FormatLink(Order order, string orderHash);
    }
}