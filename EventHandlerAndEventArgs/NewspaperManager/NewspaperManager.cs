using System;

namespace NewspaperFactory

{
    internal class NewspaperManager : INewspaperManager
    {
        public INewspaperFactory NewspaperFactory { get; set; }

        public NewspaperManager(INewspaperFactory newspaperFactory)
        {
            NewspaperFactory = newspaperFactory;
            NewspaperFactory.NewspaperPrinted += NewspaperFactory_NewspaperPrinted;
            (Log.GetInstance()).Write("Manager Created");
        }

        public void NewspaperFactory_NewspaperPrinted(object sender, NewspaperEventArgs e)
        {
            PublishNewspaper(e);
        }

        public event EventHandler<NewspaperEventArgs> NewsPaperPublished;

        
        public void PublishNewspaper(NewspaperEventArgs newspaperEventArgs)
        {
            (Log.GetInstance()).Write("Newspaper Published");
            NewsPaperPublished.Invoke(this, newspaperEventArgs);
        }
    }
}
