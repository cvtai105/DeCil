using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Interface;
using App.Models.DTOs;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

namespace App.Services
{
    public class CloudinaryService : ICloudImageService
    {

        private readonly string _cloudName;
        private readonly string _apiKey;
        private readonly string _apiSecret;

        private readonly Cloudinary _cloudinary;

        public CloudinaryService(string cloudName, string apiKey, string apiSecret)
        {
            _cloudName = cloudName;
            _apiKey = apiKey;
            _apiSecret = apiSecret;
            _cloudinary = new Cloudinary(new Account(_cloudName, _apiKey, _apiSecret));
            _cloudinary.Api.Secure = true;
        }

        public async Task<IEnumerable<UploadImageResult>> UploadImages(IEnumerable<IFormFile> files)
        {
            var uploadTasks = files.Select(file => UploadImageAsync(file));
            return await Task.WhenAll(uploadTasks);
        }

        public async Task<UploadImageResult> UploadImageAsync(IFormFile image)
        {
            if(image.Length == 0)
            {
                throw new Exception("File is empty");
            }
            using var stream = image.OpenReadStream();
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(image.FileName, stream),
            };
            var result =  await _cloudinary.UploadAsync(uploadParams);
            
            return new UploadImageResult
            {
                Url = result.Url.ToString(),
                PublicId = result.PublicId,
                DeleteToken = result.DeleteToken,
                Name = image.FileName
            };
        }

        public Task<IEnumerable<UploadImageResult>> UploadImagesAsync(IFormFile[] images)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteImageAsync(string imageUrl)
        {
            throw new NotImplementedException();
        }
    }
}