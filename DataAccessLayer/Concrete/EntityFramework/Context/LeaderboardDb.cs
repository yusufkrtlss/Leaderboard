using CoreLayer.Settings;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework.Context
{
    public class LeaderboardDb : Microsoft.EntityFrameworkCore.DbContext
    {
        private readonly IMongoDatabase _database;
        public DbSet<User> Users { get; set; }
        public DbSet<Leaderboard> Leaderboards { get; set; }

        public LeaderboardDb(IOptions<MongoSettings> settings)
        {
            var client = new MongoClient("mongodb+srv://yusufkrtlss:Yusuf147258@leaderboard.rtehcnw.mongodb.net/?retryWrites=true&w=majority");
            _database = client.GetDatabase("LeaderboardDb");
        }
        public IMongoCollection<TEntity> GetCollection<TEntity>()
        {
            return _database.GetCollection<TEntity>(typeof(TEntity).Name.Trim());
        }
        public IMongoDatabase GetDatabase()
        {
            return _database;
        }
    }
}
