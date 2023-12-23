using INNO.Data.IRepositories;
using INNO.Domain.Entities.Attachments;
using INNO.Service.Helpers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INNO.Service.Services
{
    public class FileService
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
    }
}