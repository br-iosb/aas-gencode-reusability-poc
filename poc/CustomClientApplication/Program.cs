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

            //USECASE PROXY
            //customize underlying RestClient, e.g. Proxy
            clientWithConfig.RestClient.Proxy = new WebProxy();

            //USECASE Client Certificate
            clientWithConfig.RestClient.ClientCertificates = null;

            //can I modify underlying RestClient from the outside?
            var myCustomConfig = new Configuration();
            myCustomConfig.ApiClient.RestClient = new RestSharp.RestClient();

            //passing configuration is valid, passing client is not valid
            var fileServerApi = new AASXFileServerInterfaceApi(new Configuration());
            byte[] result = fileServerApi.GetAASXByPackageId("mypackageid");

            //USECASE UPLOAD
            //(1) delegate file writers for e.g. progress bar for upload
            //new FileParameter { Writer = new Action<System.IO.Stream>() { Method } }

            //USECASE DOWNLOAD
            //(2) intercept IRestRequest with ResponseWriter and handle output to file incl. progress
            //new RestRequest().ResponseWriter


        }
    }
    /*
     * Rules for Partial Classes
All the partial class definitions must be in the same assembly and namespace.
All the parts must have the same accessibility like public or private, etc.
If any part is declared abstract, sealed or base type then the whole class is declared of the same type.
Different parts can have different base types and so the final class will inherit all the base types.
The Partial modifier can only appear immediately before the keywords class, struct, or interface.
Nested partial types are allowed.
    ==> not applicable outside the assembly
    public class WithInterceptApiClient : ApiClient
    {
        public override void InterceptRequest(IRestRequest request) { }
        //hint partial method

        /// <summary>
        /// Allows for extending response processing for <see cref="ApiClient"/> generated code.
        /// </summary>
        /// <param name="request">The RestSharp request object</param>
        /// <param name="response">The RestSharp response object</param>
        public override void InterceptResponse(IRestRequest request, IRestResponse response) { } //
    }*/
}
