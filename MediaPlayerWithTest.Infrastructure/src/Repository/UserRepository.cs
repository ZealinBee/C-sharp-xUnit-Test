using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaPlayerWithTest.Domain.src.Core;
using MediaPlayerWithTest.Domain.src.RepositoryInterface;

namespace MediaPlayerWithTest.Infrastructure.src.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users;
        private readonly List<PlayList> _playLists;
        public UserRepository(List<PlayList> playlists)
        {
            _users = new List<User>();
            _playLists = playlists;
        }

        public void AddNewList(string name, int userId)
        {
            var foundUser = _users.Find(x => x.GetId == userId);
            if (foundUser == null)
            {
                throw new Exception("ID not valid");
            }
            var newList = new PlayList(name, userId);
            foundUser.AddNewList(newList);
        }

        public void EmptyOneList(int listId, int userId)
        {
            var foundUser = _users.Find(x => x.GetId == userId);
            if (foundUser == null)
            {
                throw new Exception("ID not valid");
            }
            var emptyList = _playLists.Find(x => x.GetId == listId);
            foundUser.EmptyOneList(emptyList);
        }

        public void GetAllList(int userId)
        {
            var foundUser = _users.Find(x => x.GetId == userId);
            if (foundUser == null)
            {
                throw new Exception("ID not valid");
            }
            var list = _playLists;

        }

        public void GetListById(int listId)
        {
            var foundList = _playLists.Find(x => x.GetId == listId);
            if (foundList == null)
            {
                throw new Exception("ID not valid");
            }
        }

        public void RemoveAllLists(int userId)
        {
            var foundUser = _users.Find(x => x.GetId == userId);
            if (foundUser == null)
            {
                throw new Exception("ID not valid");
            }
            foundUser.RemoveAllLists();
        }

        public void RemoveOneList(int listId, int userId)
        {
            var foundUser = _users.Find(x => x.GetId == userId);
            if (foundUser == null)
            {
                throw new Exception("ID not valid");
            }
            var removeList = _playLists.Find(x => x.GetId == listId);
            foundUser.RemoveOneList(removeList);
        }

    }
}