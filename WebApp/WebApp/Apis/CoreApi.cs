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
            var coreApiRootUrl = ConfigurationManager.AppSettings["CoreApiUrl"];
            return new RestClient(coreApiRootUrl).Get<UserDto>(restRequest).Data;
        }
    }
}