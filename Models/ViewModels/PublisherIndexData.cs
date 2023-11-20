using Dora_Tarcsafalvi_Lab2.Models;
namespace Dora_Tarcsafalvi_Lab2.Models.ViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
