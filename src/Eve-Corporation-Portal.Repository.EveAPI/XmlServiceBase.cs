using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eve_Corporation_Portal.Repository.EveAPI.EveApiObjects;
using JSIStudios.SimpleRESTServices.Client;
using JSIStudios.SimpleRESTServices.Client.Json;

namespace Eve_Corporation_Portal.Repository.EveAPI
{
    public abstract class XmlServiceBase
    {
        private static readonly RequestSettings EveRequestSettings = new RequestSettings()
            {
                ContentType = "application/x-www-form-urlencoded"
            };

        private Response<T> Post<T>(string url, IDictionary<string, string> bodyArguments)
        {
            var bodyArgs = bodyArguments != null && bodyArguments.Any()
                               ? bodyArguments.Select(x => string.Format("{0}={1}", x.Key, x.Value)).ToList()
                               : new List<string>();
            
            IRestService rs = new JsonRestServices(null, new RequestRetryLogic(), new UrlBuilder(), new XmlStringSerializer());
            Response<T> response = rs.Execute<T>(url, HttpMethod.POST, string.Join("&", bodyArgs), settings: EveRequestSettings);
            return response;
        }

        protected Response<eveapi> Post(string url, IDictionary<string, string> bodyArguments)
        {
            return Post<eveapi>(url, bodyArguments);
        }
    }
}
