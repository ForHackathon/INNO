using INNO.Domain.Commons;

namespace INNO.Domain.Entities.Application;
public class Category : Auditable
{
    public long CategoryId { get; set; }

    public string Title { get; set; }

}
