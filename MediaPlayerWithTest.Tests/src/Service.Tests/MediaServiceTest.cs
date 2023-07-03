using Moq;
using Xunit;

using MediaPlayerWithTest.Domain.src.Core;
using MediaPlayerWithTest.Business.src.Service;
using MediaPlayerWithTest.Business.src.ServiceInterface;


namespace MediaPlayerWithTest.Tests.src.Service.Tests
{
    public class MediaServiceTest
    {
        [Fact]
        public void CreateNewFile_ValidData_CreateNewFileInMediaService()
        {
            var mock = new Mock<IMediaService>();

        }
    }
}