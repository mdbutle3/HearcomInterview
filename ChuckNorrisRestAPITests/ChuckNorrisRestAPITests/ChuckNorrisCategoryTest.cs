using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using NUnit.Framework;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Linq;

namespace ChuckNorrisRestAPITests
{
    class ChuckNorrisCategoryTest
    {
        [Test]
        public void CategoryTest()
        {
            IRestClient client = new RestClient();
            IRestRequest request = new RestRequest("https://api.chucknorris.io/jokes/categories");
            IRestResponse<List<String>> response = client.Get<List<String>>(request);
            if (response.IsSuccessful)
            {
                IRestResponse<List<String>> response2 = client.Get<List<String>>(request);
                if (response2.IsSuccessful)
                {
                    Assert.AreEqual(response.Data, response2.Data);
                }
            }


        }

    }
}
