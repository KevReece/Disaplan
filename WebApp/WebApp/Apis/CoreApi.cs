using System.Configuration;
using Disaplan.WebApp.Apis.Dtos;
using RestSharp;

namespace Disaplan.WebApp.Apis
{
    public class CoreApi
    {
        public UserDto GetUser(string userId)
        {
            const string userResourceName = "User";
            return GetResource(userResourceName, userId);
        }

        private static UserDto GetResource(string resourceName, string id)
        {
            var restRequest = new RestRequest(resourceName + "/" + id);
            var coreApiRootUrl = BuildCoreApiRootUrl();
            return new RestClient(coreApiRootUrl).Get<UserDto>(restRequest).Data;
        }

        private static string BuildCoreApiRootUrl()
        {
            var environment = GetEnvironment();
            var environmentUrlSuffix = environment == Environments.Production ? "azurewebsites.net" : "localhost";
            return ConfigurationManager.AppSettings["CoreApiUrl"].Replace("$EnvironmentUrlSuffix$", environmentUrlSuffix);
        }

        private static Environments GetEnvironment()
        {
            var environment = Environments.Development;
            if (ConfigurationManager.AppSettings["Environment"] == "Production")
            {
                environment = Environments.Production;
            }
            return environment;
        }
    }
}