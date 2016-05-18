using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using askPetMDReporting.Models;

namespace askPetMDReporting.Controllers
{
    public class JanrainLookup
    {
        public static string _start;
        public static string _end;
        public static Report UserCount()
        {
            var client = new RestClient("https://petmd.us.janraincapture.com/entity.count?client_id=b6ggz2hnm8w7eg6pgpwqbs7apvqehdmr&client_secret=e8u4fwqdkfqcgyw3cbhg37dbqzm6axx4");
            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddParameter("type_name", "user");
            request.AddParameter("filter", "created>='" + _start + "' and created<'" + _end + "'");
            //request.AddParameter("filter", "created>'2016-05-04'");
            //request.AddUrlSegment("id", 123);
            //request.AddHeader("header", "value");
            var response = client.Execute(request);
            var report = JsonConvert.DeserializeObject<Report>(response.Content);
            var count = report.Count.ToString();
          

            return report;
        }

        public static Report PetCount()
        {
           
            var client = new RestClient("https://petmd.us.janraincapture.com/entity.count?client_id=b6ggz2hnm8w7eg6pgpwqbs7apvqehdmr&client_secret=e8u4fwqdkfqcgyw3cbhg37dbqzm6axx4");
            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddParameter("type_name", "user");
            request.AddParameter("filter", "created>='" + _start + "' and created<'" + _end + "' and Pets.Name!='null'");
            //request.AddHeader("header", "value");
            var response = client.Execute(request);
            var report = JsonConvert.DeserializeObject<Report>(response.Content);
            var count = report.Count.ToString();

            return report;
        }

    }
}
