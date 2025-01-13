namespace BotanicalApp.Models
{
    public class Auditable : Base
    {
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool isDeleted { get; set; }
    }
}
