using CloudinaryDotNet.Actions;

namespace RunGroopWebApp.Interfaces
{
    public interface IPhotoService
    {
        Task<ImageUploadResult> AddPhotoASync(IFormFile file);
        Task<DeletionResult> DeletePhotoASync(string publicId);
    }
}
