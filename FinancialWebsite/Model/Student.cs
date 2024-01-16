using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FinancialWebsite.Model
{
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId MyProperty { get; set; }
        public string Name { get; set; }
        public string Address {  get; set; }
        public string Phone_No { get; set; }

    }
}
