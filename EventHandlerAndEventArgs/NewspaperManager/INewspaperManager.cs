using System;

namespace NewspaperFactory
{
    internal interface INewspaperManager
    {
        event EventHandler<NewspaperEventArgs> NewsPaperPublished;

        void PublishNewspaper(NewspaperEventArgs newspaperEventArgs);
        INewspaperFactory NewspaperFactory { get; set; }
    }
}
