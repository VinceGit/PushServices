using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestMongo.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            var url = new MongoUrl("mongodb://test:user@localhost:27017");
            var settings = MongoClientSettings.FromUrl(url);
            var adminCredentials = new MongoCredentials("dev", "dev", false);
            settings.CredentialsStore.AddCredentials("myTestDb", adminCredentials);

            var client = new MongoClient(settings);

            MongoServer server = client.GetServer();
            MongoDatabase test = server.GetDatabase("myTestDb");

            List<string> result = new List<string>();

            using (server.RequestStart(test))
            {
                MongoCollection<BsonDocument> books =
                    test.GetCollection<BsonDocument>("myColl");

                var query = Query.EQ("name", "mongo");
                foreach (BsonDocument book in books.Find(query))
                {
                    result.Add((string)book["name"]);
                }

                return result;

                //var a = from b in books.AsQueryable<string>()
                //        select b.ToString();
                //foreach (var item in a)
                //{

                //}
                //return a;
            }
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}