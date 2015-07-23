using MongoDB.Bson.Serialization.Attributes;
using System;
using MongoDB.Bson.Serialization.IdGenerators;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pay_Invoice_BO
{
    public class Consultant
    {
       
        public int Consultant_id { get; set; }

        [BsonElement("FirstName")]
        public string FirstName { get; set; }

        [BsonElement("LasttName")]
        public string LasttName { get; set; }

        [BsonElement("Email")]
        public string Email { get; set; }

        [BsonElement("Employer_ID")]
        public int Employer_ID { get; set; }

        [BsonElement("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [BsonElement("Address")]
        public string Address { get; set; }

        [BsonElement("SSN")]
        public string SSN { get; set; }

        [BsonElement("DateAdded")]
        public DateTime DateAdded { get; set; }
    }


}