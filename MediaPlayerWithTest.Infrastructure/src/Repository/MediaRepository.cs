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
        public MediaFile CreateNewFile(string fileName, string filePath, TimeSpan duration)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFileById(int fileId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MediaFile> GetAllFiles()
        {
            throw new NotImplementedException();
        }

        public MediaFile GetFileById(int fileId)
        {
            throw new NotImplementedException();
        }

        public void Pause(int fileId)
        {
            throw new NotImplementedException();
        }

        public void Play(int fileId)
        {
            throw new NotImplementedException();
        }

        public void Stop(int fileId)
        {
            throw new NotImplementedException();
        }
    }
}