using Moq;

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
            _mediaRepositoryMock = new Mock<IMediaRepository>();
            _mediaService = new MediaService(_mediaRepositoryMock.Object);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}