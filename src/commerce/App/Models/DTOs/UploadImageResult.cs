using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudinaryDotNet.Actions;

namespace App.Models.DTOs
{
    public class UploadImageResult
    {
        public string Url { get; set; } = null!;
        public string PublicId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? DeleteToken { get; set; }  //use when upload data to database failed, so we can delete the image from third party service
    }
}