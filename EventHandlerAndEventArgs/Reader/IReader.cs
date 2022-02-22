using System.Collections.Generic;

namespace NewspaperFactory
{
    internal interface IReader
    {
        List<INewspaper> NewspapersAlreadyRead { get; set; }

        INewspaperManager newspaperManager { get; set; }
        void Subscribe(INewspaperManager manager);
    }
}
