using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MediaPlayerWithTest.Domain.src.Core;

namespace MediaPlayerWithTest.Business.src.ServiceInterface
{
    public interface IMediaService
    {
        MediaFile CreateNewFile(string fileName, string filePath, TimeSpan duration);
        bool DeleteFileById(int id);
        IEnumerable<MediaFile> GetAllFiles();
        MediaFile GetFileById(int id);
    }
}