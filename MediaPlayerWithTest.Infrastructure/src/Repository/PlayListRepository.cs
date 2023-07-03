using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaPlayerWithTest.Domain.src.RepositoryInterface;
using MediaPlayerWithTest.Domain.src.Core;

namespace MediaPlayerWithTest.Infrastructure.src.Repository
{
    public class PlayListRepository : IPlayListRepository
    {
        private readonly List<PlayList> _playLists;
        private readonly List<MediaFile> _mediaFiles;
        public PlayListRepository(List<MediaFile> mediaFiles)
        {
            _playLists = new List<PlayList>();
            _mediaFiles = mediaFiles;
        }
        public void AddNewFile(int playListId, int fileId, int userId)
        {
            var foundPlayList = _playLists.Find(x => x.GetId == playListId);
            var foundFile = _mediaFiles.Find(x => x.GetId == fileId);
            if (foundPlayList == null || foundFile == null)
            {
                throw new Exception("ID not valid");
            }
            foundPlayList.AddNewFile(foundFile, userId);
        }

        public void EmptyList(int playListId, int userId)
        {
            var foundPlayList = _playLists.Find(x => x.GetId == playListId);
            if (foundPlayList == null)
            {
                throw new Exception("ID not valid");
            }
            foundPlayList.EmptyList(userId);
        }

        public void RemoveFile(int playListId, int fileId, int userId)
        {
            var foundPlayList = _playLists.Find(x => x.GetId == playListId);
            var foundFile = _mediaFiles.Find(x => x.GetId == fileId);
            if (foundPlayList == null || foundFile == null)
            {
                throw new Exception("ID not valid");
            }
            foundPlayList.RemoveFile(foundFile, userId);
        }
    }
}