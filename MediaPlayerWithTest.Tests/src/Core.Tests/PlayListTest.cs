using Xunit;
using MediaPlayerWithTest.Domain.src.Core;

namespace MediaPlayerWithTest.Tests.src
{
    public class PlayListTests
    {
        [Fact]
        public void AddPlayList_ValidData_AddNewPlayList()
        {
            var playlist = new PlayList("playlist name", 1);
            Assert.Equal("playlist name", playlist.ListName);
            Assert.True(playlist.GetId > -1);
        }

        [Fact]
        public void AddNewFile_ValidData_AddNewFileToPlayList()
        {
            var playlist = new PlayList("playlist name", 1);
            var audio = new Audio("file name", "file path", TimeSpan.FromSeconds(10), 1);
            MediaFile addedFile = playlist.AddNewFile(audio, 1);
            Assert.Equal(audio, addedFile);
        }
    }
}