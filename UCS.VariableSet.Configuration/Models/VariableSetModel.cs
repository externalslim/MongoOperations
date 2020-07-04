using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace UCS.VariableSet.Configuration.Models
{
    public class VariableSetModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public List<Body> Body { get; set; }

        public VariableSetModel()
        {
            Body = new List<Body>();
        }
    }
}