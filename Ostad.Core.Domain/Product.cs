namespace Ostad.Core.Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }
        public string Brand { get; set; }
        public List<Media> Medias { get; set; }
        public int? MediaId { get; set; }
        public DateTime InseretTime { get; set; }
    }
}