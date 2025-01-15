namespace BotanicalApp.Models
{
    public class ProductImages : Auditable
    {
        internal string? imageUrl;

        public string? imgUrl { get; set; }
        public bool isMain { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
