using Xunit;
using MediaPlayerWithTest.Domain.src.Core;

namespace MediaPlayerWithTest.Tests.src
{
    public class MediaFileTest
    {
        [Fact]
        public void CreateAudio_ValidData_CreateNewAudio()
        {
            var audio = new Audio("file name", "file path", TimeSpan.FromSeconds(10), 1);
            Assert.Equal("file name", audio.FileName);
            Assert.Equal("file path", audio.FilePath);
            Assert.Equal(TimeSpan.FromSeconds(10), audio.Duration);
            Assert.Equal(1, audio.Speed);
        }
        public void CreateNewVideo_ValidData_CreateNewVideo()
        {
            var video = new Video("file name", "file path", TimeSpan.FromSeconds(10), 1);
            Assert.Equal("file name", video.FileName);
            Assert.Equal("file path", video.FilePath);
            Assert.Equal(TimeSpan.FromSeconds(10), video.Duration);
            Assert.Equal(1, video.Speed);
        }

        [Fact]
        public void CreateAudio_InvalidData_ThrowError()
        {
            Assert.Throws<ArgumentException>(() => new Audio("", "file path", TimeSpan.FromSeconds(10), 1));
        }

        [Fact]
        public void PlayAudio_StartAudio_PlayAudio()
        {
            var audio = new Audio("file name", "file path", TimeSpan.FromSeconds(10), 1);
            audio.Play();
            Assert.True(audio.IsPlaying);
        }

        [Fact]

        public void StopAudio_StopAudio_StopAudio()
        {
            var audio = new Audio("file name", "file path", TimeSpan.FromSeconds(10), 1);
            audio.Play();
            audio.Stop();
            Assert.False(audio.IsPlaying);
        }

        [Fact]
        public void PauseAudio_Pause_PauseAudio()
        {
            var audio = new Audio("file name", "file path", TimeSpan.FromSeconds(10), 1);
            audio.Play();
            audio.Pause();
            Assert.False(audio.IsPlaying);
        }


        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void SetSpeedAudio_SetSpeed_SetSpeed(double speed)
        {
            var audio = new Audio("file name", "file path", TimeSpan.FromSeconds(10), 1);
            audio.Speed = speed;
            Assert.Equal(speed, audio.Speed);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void SetSpeedAudio_SetInvalidSpeed_ThrowError(double speed)
        {
            var audio = new Audio("file name", "file path", TimeSpan.FromSeconds(10), 1);
            Assert.Throws<ArgumentException>(() => audio.Speed = speed);
        }


    }
}