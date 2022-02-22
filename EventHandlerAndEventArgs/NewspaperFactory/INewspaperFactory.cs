using System;

namespace NewspaperFactory
{
    internal interface INewspaperFactory
    {
        INewspaperManager NewspaperManager { get; set; }
        INewspaper PrintNewspaper();
        event EventHandler<NewspaperEventArgs> NewspaperPrinted;
    }
}
