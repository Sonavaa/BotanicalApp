namespace BotanicalApp.Models
{
    public class Product : Auditable
    {
        public string Name { get; set; } = null!;
        public int Price { get; set; } = default!;
        public int? DiscountedPrice { get; set; }
        public string? Description { get; set; }
        public string ProductCode { get; set; } = null!;
        public int Quantity { get; set; }
        public List<ProductImages> Images { get; set; } = new List<ProductImages>();
        public string MainImageUrl => Images?.FirstOrDefault(img => img.isMain)?.imgUrl ?? "~/client/assets/images/default.jpg";
    }
}
