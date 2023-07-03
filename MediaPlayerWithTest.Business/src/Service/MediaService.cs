using MediaPlayerWithTest.Domain.src.RepositoryInterface;
using MediaPlayerWithTest.Business.src.ServiceInterface;
using MediaPlayerWithTest.Domain.src.Core;

namespace MediaPlayerWithTest.Business.src.Service
{
    public class MediaService : IMediaService
    {
        private readonly IMediaRepository _mediaRepository;

        public MediaService(IMediaRepository mediaRepository)
        {
            _mediaRepository = mediaRepository;
        }

        public MediaFile CreateNewFile(string fileName, string filePath, TimeSpan duration)
        {
            return _mediaRepository.CreateNewFile(fileName, filePath, duration);
        }

        public bool DeleteFileById(int id)
        {
            var foundFile = _mediaRepository.GetFileById(id);
            if (foundFile == null)
            {
                throw new Exception("ID not valid");
            }
            _mediaRepository.DeleteFileById(id);
            return true;
        }

        public IEnumerable<MediaFile> GetAllFiles()
        {
            return _mediaRepository.GetAllFiles();
        }

        public MediaFile GetFileById(int id)
        {
            return _mediaRepository.GetFileById(id);
        }
    }
}