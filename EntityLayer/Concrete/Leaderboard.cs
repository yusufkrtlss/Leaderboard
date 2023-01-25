using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Leaderboard
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public int Month { get; set; }
        public int Rank { get; set; }
        public User User { get; set; }
    }
}
