namespace BotanicalApp.Models
{
    public class Settings : Auditable
    {
        public string? Key { get; set; }
        public string? Value { get; set; }
    }
}
