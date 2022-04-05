using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Bulochnaya.Class
{
    class Users
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        protected string Name;
        protected string Email;
        protected string Password;
        protected double Phone;
        private string v1;
        private string v2;
        private string v3;
        private double v4;

        public Users(string v1, string v2, string v3, double v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        public Users(string v1, string v3)
        {
            this.v1 = v1;
            this.v3 = v3;
        }

        public string _name { get => v1; set => Name = value; }
        [BsonElement]
        public string _email { get => v2; set => Email = value; }
        [BsonElement]
        public string _password{ get => v3; set => Password = value; }
        [BsonElement]
        public double _phone { get => v4; set => Phone = value; }




        public void Add(Users us)
        {
            MongoClient client = new MongoClient();
            var abase = client.GetDatabase("111");
            var b = abase.GetCollection<Users>("Shakirov_DB");
            b.InsertOne(us);
        }
        public void FindFrom(Users us)
        {
            MongoClient client = new MongoClient();
            var abase = client.GetDatabase("111");
            var b = abase.GetCollection<Users>("Shakirov_DB");
            var listPerson = b.Find(Bulochnaya => us._name == "").ToList();
            var listPersonP = b.Find(Bulochnaya => us._password == "").ToList();
            foreach (Users us1 in listPerson)
            {
                MessageBox.Show($"{us._name}" + $"{us._password}");
            }
        }
    }
}
