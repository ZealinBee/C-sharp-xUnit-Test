using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MediaPlayerWithTest.Domain.src.Core;

namespace MediaPlayerWithTest.Domain.src.RepositoryInterface
{
    public interface IMediaRepository
    {
        void Play(int fileId);
        void Pause(int fileId);
        void Stop(int fileId);
        MediaFile CreateNewFile(string fileName, string filePath, TimeSpan duration);
        bool DeleteFileById(int fileId);
        IEnumerable<MediaFile> GetAllFiles();
        MediaFile GetFileById(int fileId);
    }
}