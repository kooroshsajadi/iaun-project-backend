using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace IaunProject.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Role { get; set; }
        class PersonalInfo
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDate { get; set; }
            public string Religion { get; set; }
            public string Occupation { get; set; }
        }
        class ContactInfo
        {
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
        }
        class Address
        {
            [BsonElement("Country")]
            public string Country { get; set; }

            public string City { get; set; }
        } 
    }
}
