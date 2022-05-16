using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace Bulochnaya.Class
{
    public class Izdelia
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        protected string Name;
        protected string Description;
        protected double Cost;
        protected byte[] Image;

        public Izdelia(string v1, string v2, double v3, byte[] v4)
        {
            this.Name = v1;
            this.Description = v2;
            this.Cost = v3;
            this.Image = v4;
        }

        public Izdelia()
        {
        }

        public string _name { get => Name; set => Name = value; }
        [BsonElement]
        public string _description { get => Description; set => Description = value; }
        [BsonElement]
        public double _cost { get => Cost; set => Cost = value; }
        [BsonElement]
        public byte[] _image { get => Image; set => Image = value; }




        public void Add(Izdelia us)
        {
            MongoClient client = new MongoClient();
            var abase = client.GetDatabase("111");
            var b = abase.GetCollection<Izdelia>("111");
            b.InsertOne(us);
        }
    }
}
