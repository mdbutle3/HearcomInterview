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

        // does 2 API requests and compares the returned data. Makes sure they match.
        [Test]
        public void CategoryTest()
        {
            IRestClient client = new RestClient();
            IRestRequest request = new RestRequest("https://api.chucknorris.io/jokes/categories");
            //submit API request
            IRestResponse<List<String>> response = client.Get<List<String>>(request);
            if (response.IsSuccessful)
            {
                //if the first response is successful do another request of the same paramters
                IRestResponse<List<String>> response2 = client.Get<List<String>>(request);
                if (response2.IsSuccessful)
                {
                    //make sure the 2 results are the same
                    Assert.AreEqual(response.Data, response2.Data);
                }
                else
                {
                    //if request fails fail
                    Assert.Fail();
                }
            }
            else
            {
                //if request fails fail
                Assert.Fail();
            }


        }

    }
}
