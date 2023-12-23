using INNO.Domain.Entities.Attachments;
using Microsoft.AspNetCore.Http;

namespace INNO.Service.Interfaces.IExtantions
{
    public interface IFileService
    {

        Task<Attachment> CreateAsync(IFormFile file);
        Task RemoveAsync(string fileName);

    }
}
