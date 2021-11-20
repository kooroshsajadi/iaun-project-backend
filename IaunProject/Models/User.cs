﻿using System;
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
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public PersonalInformation PersonalInfo { get; set; }
        public ContactInformation ContactInfo { get; set; }
        public AddressInformation AddressInfo { get; set; }
        public class PersonalInformation
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDate { get; set; }
            public string Religion { get; set; }
            public string Occupation { get; set; }
        }
        public class ContactInformation
        {
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
        }
        public class AddressInformation
        {
            [BsonElement("Country")]
            public string Country { get; set; }

            public string City { get; set; }
        } 
    }
}
