namespace INNO.Domain.Commons
{
    public class Auditable
    {
        public long Id { get; set; }
        public DateTime CreatAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdateAt { get; set; } = null;

    }
}
