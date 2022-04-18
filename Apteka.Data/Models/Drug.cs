namespace Apteka.Data.Models
{
    public class Drug
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime Deadline { get; set; }
    }
}
