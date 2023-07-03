using Xunit;
using MediaPlayerWithTest.Domain.src.Core;

namespace MediaPlayerWithTest.Tests.src
{
    public class MediaFileTest
    {
        [Fact]
        public void CreateMediaFile_ValidData_CreateNewAudio()
        {
            var audio = new Audio("file name", "file path", TimeSpan.FromSeconds(10), 1);
            Assert.Equal("file name", audio.FileName);
            Assert.Equal("file path", audio.FilePath);
            Assert.Equal(TimeSpan.FromSeconds(10), audio.Duration);
            Assert.Equal(1, audio.Speed);
        }
    }
}