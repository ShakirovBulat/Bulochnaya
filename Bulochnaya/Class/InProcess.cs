﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace Bulochnaya.Class
{
    public class InProcess
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        protected string NameUser;
        protected string Email;
        protected string NameTovar;
        protected double CostTovar;
        protected double Phone;
        protected string Role;

        public InProcess(string v1, string v2, string v3, double v4, double v5, string v6)
        {
            this.NameUser = v1;
            this.Email = v2;
            this.NameTovar = v3;
            this.CostTovar = v4;
            this.Phone = v5;
            this.Role = v6;
        }

        public InProcess()
        {
        }

        public string _name { get => NameUser; set => NameUser = value; }
        [BsonElement]
        public string _email { get => Email; set => Email = value; }
        [BsonElement]
        public string _nametovar { get => NameTovar; set => NameTovar = value; }
        [BsonElement]
        public double _costtovar { get => CostTovar; set => CostTovar = value; }
        [BsonElement]
        public double _phone { get => Phone; set => Phone = value; }
        [BsonElement]
        public string _role { get => Role; set => Role = value; }


        public void Add(InProcess us)
        {
            MongoClient client = new MongoClient();
            var abase = client.GetDatabase("111");
            var b = abase.GetCollection<InProcess>("InProcessing");
            b.InsertOne(us);
        }
    }
}
