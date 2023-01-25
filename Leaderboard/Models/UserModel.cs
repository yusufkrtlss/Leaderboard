using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Leaderboard.Models
{
    public class UserModel
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public bool IsApproved { get; set; }
        public ObjectId UserId { get; set; }
        public int TotalPoint { get; set; }
    }
}
