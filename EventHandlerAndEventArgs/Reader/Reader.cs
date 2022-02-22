using System.Collections.Generic;

namespace NewspaperFactory
{
    internal class Reader : IReader
    {
        public INewspaperManager newspaperManager { get; set; }
        public List<INewspaper> NewspapersAlreadyRead { get; set; } = new();

        public Reader()
        {
            (Log.GetInstance()).Write("ReaderCreated");
        }
        public void Subscribe(INewspaperManager manager)
        {
            newspaperManager = manager;
            newspaperManager.NewsPaperPublished += Read;
            (Log.GetInstance()).Write("Reader Subscribet to Manager");
        }

        public void Read(object sender, NewspaperEventArgs e)
        {
            NewspapersAlreadyRead.Add(e.Newspaper);
            (Log.GetInstance()).Write("Reader has read a newspaper");

        }
    }
}
