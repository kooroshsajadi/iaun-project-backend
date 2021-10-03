using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IaunProject.Models;
using MongoDB.Driver;

namespace IaunProject.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _users;

        public UserService(IVakilHouseDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _users = database.GetCollection<User>(settings.UsersCollectionName);
        }

        public List<User> Get()
        {
            return _users.Find(user => true).ToList();
        }

        public User Get(string id)
        {
            return _users.Find<User>(user => user.Id == id).FirstOrDefault();
        }

        public User Create(User book)
        {
            _users.InsertOne(book);
            return book;
        }

        public void Update(string id, User bookIn)
        {
            _users.ReplaceOne(user => user.Id == id, bookIn);
        }

        public void Remove(User bookIn)
        {
            _users.DeleteOne(user => user.Id == bookIn.Id);
        }

        public void Remove(string id)
        {
            _users.DeleteOne(user => user.Id == id);
        }
    }
}
