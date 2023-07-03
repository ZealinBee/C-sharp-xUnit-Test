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
        public void PauseAudio_Pause_PauseAudio()
        {
            var audio = new Audio("file name", "file path", TimeSpan.FromSeconds(10), 1);
            audio.Play();
            audio.Pause();
            Assert.False(audio.IsPlaying);
        }

        [Fact]
        public void SetSpeedAudio_SetSpeed_SetSpeed()
        {
            var audio = new Audio("file name", "file path", TimeSpan.FromSeconds(10), 1);
            audio.Speed = 2;
            Assert.Equal(2, audio.Speed);
        }

        [Fact]
        public void SetSpeedAudio_SetInvalidSpeed_ThrowError()
        {
            var audio = new Audio("file name", "file path", TimeSpan.FromSeconds(10), 1);
            Assert.Throws<ArgumentException>(() => audio.Speed = 0);
        }



    }
}