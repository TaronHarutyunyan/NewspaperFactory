namespace NewspaperFactory
{
    internal class Newspaper : INewspaper
    {
        public Newspaper(int pageCount, string title)
        {
            PageCount = pageCount;
            Title = title;
        }

        public int PageCount { get; set; }
        public string Title { get; set; }
    }
}
