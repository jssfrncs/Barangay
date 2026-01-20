namespace Barangay_API.Core.Files
{
    public interface IFileSystem
    {
        Task<string> Move(IFormFile file, string destFile);

        Task<string> Move(Stream stream, string destFile);

        Task<Stream> Get(string location);

        Task Remove(string location);
    }
}
