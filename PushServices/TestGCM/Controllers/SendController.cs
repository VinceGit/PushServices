using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace TestGCM.Controllers
{
    public class SendController : Controller
    {
        //
        // GET: /Send/

        public string Index(string id)
        {
            string deviceId = Common.GetDevice(Guid.Parse(id));

            string json = "{\"registration_ids\": [\"" + deviceId + "\"],\"collapse_key\":\"demo GCM\",\"data\":{\"key1\":\"value1\",\"key2\":\"value2\"}}";

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(@"https://android.googleapis.com/gcm/send");
            req.Method = "POST";
            req.ContentType = "application/json";
            req.Headers.Add("Authorization", "key=AIzaSyAHH2icz3msOytrDO9ERqX5ioSqlbs72Pw");
            byte[] bytes = Encoding.ASCII.GetBytes(json);
            req.ContentLength = bytes.Length;
            Stream reqStream = req.GetRequestStream();
            reqStream.Write(bytes, 0, bytes.Length);
            reqStream.Close();

            return "ok";
        }
    }
}
