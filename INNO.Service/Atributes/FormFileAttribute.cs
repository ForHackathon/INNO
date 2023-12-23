using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace INNO.Service.Atributes;

public class FormFileAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is IFormFile file)
        {
            string[] extensions = new string[] { ".png", ".jpg", ".mp3", ".mp4", ".mkv", ".pptx", ".ppt", ".doc", ".docx" };
            var extension = Path.GetExtension(file.FileName);

            if (!extensions.Contains(extension.ToLower()))
            {
                return new ValidationResult("This photo extension is not allowed!");
            }
        }
        return ValidationResult.Success;
    }
}
