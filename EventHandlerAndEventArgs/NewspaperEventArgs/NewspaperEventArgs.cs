using System;

namespace NewspaperFactory
{
    internal class NewspaperEventArgs : EventArgs
    {
        public INewspaper Newspaper { get; set; }
        public NewspaperEventArgs(INewspaper newspaper)
        {
            Newspaper = newspaper;
        }
    }
}
