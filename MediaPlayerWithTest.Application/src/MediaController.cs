using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MediaPlayerWithTest.Business.src.ServiceInterface;
using MediaPlayerWithTest.Domain.src.Core;

namespace MediaPlayerWithTest.Application.src
{
    public class MediaController
    {
        private readonly IMediaService _mediaService;

        public MediaController(IMediaService mediaService)
        {
            _mediaService = mediaService;
        }

        public MediaFile CreateNewFile(string fileName, string filePath, TimeSpan duration)
        {
            return _mediaService.CreateNewFile(fileName, filePath, duration);
        }

        public bool DeleteFileById(int id)
        {
            var foundFile = _mediaService.GetFileById(id);
            if (foundFile == null)
            {
                throw new Exception("ID not valid");
            }
            _mediaService.DeleteFileById(id);
            return true;
        }

        public IEnumerable<MediaFile> GetAllFiles()
        {
            return _mediaService.GetAllFiles();
        }

        public MediaFile GetFileById(int id)
        {
            return _mediaService.GetFileById(id);
        }
    }
}