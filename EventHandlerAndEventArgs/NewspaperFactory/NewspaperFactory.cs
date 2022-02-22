using System;

namespace NewspaperFactory
{
    internal class NewspaperFactory : INewspaperFactory
    {
        public INewspaperManager NewspaperManager { get; set; }
        public NewspaperFactory()
        {
            (Log.GetInstance()).Write("Factory Created"); 
        }

        public event EventHandler<NewspaperEventArgs> NewspaperPrinted;

        public INewspaper PrintNewspaper()
        {
            INewspaper newspaper = new Newspaper(20, "Digitain Newspaper");
            (Log.GetInstance()).Write("Newspaper Printed");
            NewspaperPrinted.Invoke(this, new NewspaperEventArgs(newspaper));
            return newspaper;
        }

    }
}
