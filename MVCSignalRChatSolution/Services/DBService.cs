using MVCSignalRChatSolution.Data;
using MVCSignalRChatSolution.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSignalRChatSolution.Services
{
    public class DBService
    {
        public List<User> GetUsers()
        {
            using (var _dbContext = new DatabaseContext())
            {
                return _dbContext.Users.ToList();
            }
        }

        public User GetUser(string id)
        {
            using (var _dbContext = new DatabaseContext())
            {
                var _user = _dbContext.Users.SingleOrDefault(x => x.UserId == new Guid(id));
                return _user;
            }
        }

        public bool SetUser(User user)
        {
            using (var _dbContext = new DatabaseContext())
            {
                _dbContext.Users.Add(user);
                if (_dbContext.SaveChanges() != 0)
                    return true;
                else
                    return false; 
            }
        }

        public bool UpdateUser(User user)
        {
            using (var _dbContext = new DatabaseContext())
            {
                var _original = _dbContext.Users.Find(user.UserId);
                if (_original != null)
                {
                    _original.UserName = user.UserName;
                    _original.ConnectionId = user.ConnectionId;
                }
                if (_dbContext.SaveChanges() > 0)
                    return true;
                else
                    return false;                
            }                
        }

        public bool DeleteUser(User user)
        {
            using (var _dbContext = new DatabaseContext())
            {
                var _original = _dbContext.Users.Find(user.UserId);
                if (_original != null)
                {
                    _dbContext.Users.Remove(_original);
                    if (_dbContext.SaveChanges() != 0)
                        return true;
                    else
                        return false;
                }
                else
                {
                    return false;
                }
            }
        }

        public async void DeleteAllUsers()
        {
            using (var _dbContext = new DatabaseContext())
            {
                await _dbContext.Database.ExecuteSqlCommandAsync(@"DELETE FROM Users");
            }
        }

        public bool FindUserByName(string userName)
        {
            using (var _dbContext = new DatabaseContext())
            {
                var _user = _dbContext.Users.SingleOrDefault(x => x.UserName == userName);
                if (_user == null)
                    return false;
                else
                {
                    return true;
                }
            }
        }
    }
}