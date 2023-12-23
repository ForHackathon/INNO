namespace INNO.Domain.Commons
{
    public class Auditable
    {
        public long Id { get; set; }
        public DateTime DateTime { get; set; } = DateTime.UtcNow;
        public DateTime? UpdateAt { get; set; } = null;

    }
}
