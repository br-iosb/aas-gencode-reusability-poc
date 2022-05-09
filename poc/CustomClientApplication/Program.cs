using System;
using AAS.OpenApi.Client.Client;
using AAS.OpenApi.Client.Api;
using System.Net;
using RestSharp;

namespace CustomClientApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello API Client!");
            var clientWithConfig = new ApiClient(new Configuration());

            //customize underlying RestClient, e.g. Proxy
            clientWithConfig.RestClient.Proxy = new WebProxy();

            //can I modify underlying RestClient from the outside?
            var myCustomConfig = new Configuration();
            myCustomConfig.ApiClient.RestClient = new RestSharp.RestClient();

            //passing configuration is valid, passing client is not valid
            var fileServerApi = new AASXFileServerInterfaceApi(new Configuration());
            byte[] result = fileServerApi.GetAASXByPackageId("mypackageid");


            //delegate file writers for e.g. progress bar
            //new FileParameter { Writer = new Action<System.IO.Stream>() { Method } }
        }
    }
}
