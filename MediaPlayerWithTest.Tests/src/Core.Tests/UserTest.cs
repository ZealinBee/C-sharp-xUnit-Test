using Xunit;
using MediaPlayerWithTest.Domain.src.Core;

namespace MediaPlayerWithTest.Tests.src
{

    public class UserTest
    {
        [Fact]
        public void CreateUser_ValidData_CreateNewUser()
        {
            var user = User.Instance;
            Assert.Equal(string.Empty, user.Name);
            Assert.True(user.GetId > -1);
        }

        [Fact]
        public void AddNewList_ValidData_AddNewList()
        {
            var user = User.Instance;
            var playlist = new PlayList("playlist name", 1);
            user.AddNewList(playlist);
            Assert.Equal(playlist, user.GetAllLists()[0]);
        }

        [Fact]
        public void GetAllList_ValidData_ListHigherThanZero()
        {
            var user = User.Instance;
            var playlist = new PlayList("playlist name", 1);
            user.AddNewList(playlist);
            Assert.True(user.GetAllLists().Count > 0);
        }

        [Fact]
        public void RemoveOneList_ValidData_RemoveOneList()
        {
            var user = User.Instance;
            var playlist = new PlayList("playlist name", 1);
            user.AddNewList(playlist);
            user.RemoveOneList(playlist);
            Assert.Empty(user.GetAllLists());
        }

        [Fact]
        public void RemoveAllLists_ValidData_RemoveAllLists()
        {
            var user = User.Instance;
            var playlist = new PlayList("playlist name", 1);
            user.AddNewList(playlist);
            user.RemoveAllLists();
            Assert.Empty(user.GetAllLists());
        }

    }
}