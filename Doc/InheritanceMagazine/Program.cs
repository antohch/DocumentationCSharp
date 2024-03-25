
namespace InheritanceMagazine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var publication = new Publication("Tiddlywinks for Experts", "Fun and Games", PublicationType.Book);
            var book = new Book("the Tempest", "0971655819", "Shakespeare, William", "Public Domain Press");
            ShowPublicationInfo(book);
        }

        private static void ShowPublicationInfo(Publication pub)
        {
            string pubDate = pub.GetPublicationDate();
            Console.WriteLine($"{pub.Title}, "+
                $"{(pubDate == "NYP" ? "Not Yet Published" : "published on " + pubDate):d} by {pub.Publisher}");
        }
    }
}
