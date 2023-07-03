using Moq;
using Xunit;

using MediaPlayerWithTest.Domain.src.RepositoryInterface;
using MediaPlayerWithTest.Business.src.ServiceInterface;
using MediaPlayerWithTest.Business.src.Service;

namespace MediaPlayerWithTest.Tests.Service.Tests
{
    public class MediaServiceTest
    {
        private Mock<IMediaRepository> _mediaRepositoryMock;

        private IMediaService _mediaService;

        public MediaServiceTest()
        {
            _mediaRepositoryMock = new();
            _mediaService = new MediaService(_mediaRepositoryMock.Object);
        }

        [Fact]
        public void CreateNewFile_ValidData_CreateNewFile()
        {

        }
    }
}