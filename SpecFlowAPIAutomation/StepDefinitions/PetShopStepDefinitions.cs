using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;

[assembly: CollectionBehavior(DisableTestParallelization = true)]
namespace SpecFlowAPIAutomation.StepDefinitions
{
    [Binding]
    public class PetShopStepDefinitions
    {
        RestClient restClient;
        RestRequest restRequest;
        RestResponse restResponse;
        
        [Given(@"I have base url '([^']*)' and resource '([^']*)'")]
        public void GivenIHaveBaseUrlAndResource(string baseUrl, string resource)
        {
            restClient = new RestClient(baseUrl + resource);
        }

        [When(@"I do the Get request")]
        public void WhenIDoTheGetRequest()
        {
            restRequest = new RestRequest();
            restResponse = restClient.Execute(restRequest);
        }

        [Then(@"I should get the response as (.*)")]
        public void ThenIShouldGetTheResponseAs(int expectedStatusCode)
        {
            int actualStatusCode = (int)restResponse.StatusCode;
            Assert.Equal(expectedStatusCode, actualStatusCode);
        }

        [Then(@"I should get the message as '([^']*)'")]
        public void ThenIShouldGetTheMessageAs(string expectedMessage)
        {
            string actualResponse = restResponse.Content;
            Assert.Contains(expectedMessage, actualResponse);
        }

        [Then(@"I should get the pet details in json format")]
        public void ThenIShouldGetThePetDetailsInJsonFormat()
        {
        }

        [Given(@"I need api_key '([^']*)' in the header")]
        public void GivenINeedApi_KeyInTheHeader(string apiKey)
        {
            restClient.AddDefaultHeader("api_key", apiKey);
        }

        [When(@"I do the delete request")]
        public void WhenIDoTheDeleteRequest()
        {
            restRequest = new RestRequest("", Method.Delete);
            restResponse = restClient.Execute(restRequest);
        }


    }
}
