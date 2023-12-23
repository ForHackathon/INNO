using Microsoft.AspNetCore.Http;

namespace INNO.Service.Helpers
{
    public static class FileHelper
    {
        public static async Task<(string fileName, string filePath)> SaveAsync(IFormFile file, bool isExist = false)
        {
            // genarate file destination
            string fileName = Guid.NewGuid().ToString("N") + "-" + file.FileName.Replace(" ", "-");
            string filePath = Path.Combine(EnvironmentHelper.AttachmentPath, fileName);

            // copy image to the destination as stream 
            FileStream fileStream = File.OpenWrite(filePath);
            await file.CopyToAsync(fileStream);

            // clear
            await fileStream.FlushAsync();
            fileStream.Close();

            return (fileName, Path.Combine(EnvironmentHelper.AttachmentPath, fileName));
        }

        /// <summary>
        /// This founction for remove file from wwwroot by given static path which is given by function parametr
        /// </summary>
        /// <param name="staticPath">file static path</param>
        /// <returns>if file is exists and deleted successfully return true else false</returns>
        public static bool Remove(string staticPath)
        {
            string fullPath = Path.Combine(EnvironmentHelper.WebRootPath, staticPath);

            if (!File.Exists(fullPath))
                return false;

            File.Delete(fullPath);
            return true;
        }
    }
}
