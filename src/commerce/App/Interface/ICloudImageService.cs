using App.Models.DTOs;

namespace App.Interface
{
    public interface ICloudImageService
    {
        Task<UploadImageResult> UploadImageAsync(IFormFile image);
        Task<IEnumerable<UploadImageResult>> UploadImagesAsync(IFormFile[] images);
        Task<string> DeleteImageAsync(string imageUrl);


    }
}