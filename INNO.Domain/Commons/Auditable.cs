namespace INNO.Domain.Commons
{
    public class Auditable
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; } = DateTime.UtcNow;
        public DateTime? UpdateAt { get; set; } = null;

    }
}
