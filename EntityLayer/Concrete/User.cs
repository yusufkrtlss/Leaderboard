using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public bool IsApproved { get; set; }
        public ObjectId UserId { get; set; }
        public int TotalPoint { get; set; }
        public ICollection<Leaderboard> leaderboards { get; set; }
    }
}
