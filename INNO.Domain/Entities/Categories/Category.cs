using INNO.Domain.Commons;

namespace INNO.Domain.Entities.Categories;
public class Category : Auditable
{
    public long CategoryId { get; set; }

    public string Title { get; set; }

}
