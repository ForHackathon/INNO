using INNO.Data.IRepositories;
using INNO.Domain.Entities.Attachments;
using INNO.Service.Helpers;
using INNO.Service.Interfaces.IExtantions;
using Microsoft.AspNetCore.Http;

namespace INNO.Service.Services
{
    public class FileService : IFileService
    {
        private readonly IGenericRepository<Attachment> _repository;

        public FileService(IGenericRepository<Attachment> repository)
        {
            _repository = repository;
        }

        public async Task<Attachment> CreateAsync(IFormFile file)
        {
            var result = await FileHelper.SaveAsync(file, false);

            var res = await _repository.CreateAsync(
                new()
                {
                    Name = result.fileName,
                    Path = Path.Combine(EnvironmentHelper.Attachment, result.fileName),
                    CreatAt = DateTime.UtcNow
                }) ?? new();

            await _repository.SaveChangesAsync();

            return res;
        }

        public Task RemoveAsync(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}