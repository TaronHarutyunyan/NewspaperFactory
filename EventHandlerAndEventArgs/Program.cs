using System;
using System.Threading;

namespace NewspaperFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INewspaperFactory Factory = new NewspaperFactory();
            IReader Reader = new Reader();
            INewspaperManager Manager = new NewspaperManager(Factory);
            Reader.Subscribe(Manager);

            for (int i = 0; i < 10; i++)
            {
               Thread.Sleep(1000);
               Factory.PrintNewspaper();                
            }
            foreach (var item in Reader.NewspapersAlreadyRead)
            {
                Console.WriteLine(item.Title + " " + item.PageCount);
            }
        }
    }
}
