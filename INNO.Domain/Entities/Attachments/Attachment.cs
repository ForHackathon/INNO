using INNO.Domain.Commons;

namespace INNO.Domain.Entities.Attachments;

public  class Attachment : Auditable
{
    public string Path {  get; set; }
}
