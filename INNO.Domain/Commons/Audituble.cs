namespace INNO.Domain.Commons
{
    public class Audituble
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; } = DateTime.UtcNow;
        public DateTime? UpdateAt { get; set; } = null;

    }
}
