using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaPlayerWithTest.Domain.src.RepositoryInterface;
using MediaPlayerWithTest.Domain.src.Core;

namespace MediaPlayerWithTest.Infrastructure.src.Repository
{
    public class MediaRepository : IMediaRepository
    {
        private readonly List<MediaFile> _mediaFiles;

        public MediaRepository()
        {
            _mediaFiles = new List<MediaFile>();
        }
        public MediaFile CreateNewFile(string fileName, string filePath, TimeSpan duration)
        {
            var newMediaFile = CreateNewFile(fileName, filePath, duration);
            _mediaFiles.Add(newMediaFile);
            return newMediaFile;
        }

        public bool DeleteFileById(int fileId)
        {
            var foundFile = GetFileById(fileId);
            if (foundFile == null)
            {
                throw new Exception("ID not valid");
            }
            _mediaFiles.Remove(foundFile);
            return true;
        }

        public IEnumerable<MediaFile> GetAllFiles()
        {
            return _mediaFiles;
        }

        public MediaFile GetFileById(int fileId)
        {
            return _mediaFiles.Find(x => x.GetId == fileId);
        }

        public void Pause(int fileId)
        {
            var foundFile = GetFileById(fileId);
            if (foundFile == null)
            {
                throw new Exception("ID not valid");
            }
            foundFile.Pause();
        }

        public void Play(int fileId)
        {
            var foundFile = GetFileById(fileId);
            if (foundFile == null)
            {
                throw new Exception("ID not valid");
            }
            foundFile.Play();
        }

        public void Stop(int fileId)
        {
            var foundFile = GetFileById(fileId);
            if (foundFile == null)
            {
                throw new Exception("ID not valid");
            }
            foundFile.Stop();
        }


    }
}