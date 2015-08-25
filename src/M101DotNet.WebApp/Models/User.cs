using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace M101DotNet.WebApp.Models
{
    public class User
    {
        // XXX WORK HERE
        // create an object suitable for insertion into the user collection
        // The homework instructions will tell you the schema that the documents 
        // must follow. Make sure to include Name and Email properties.
        public string Name { get; set; }
        public string Email { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}