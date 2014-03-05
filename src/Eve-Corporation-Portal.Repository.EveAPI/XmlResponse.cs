using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eve_Corporation_Portal.Core;
using JSIStudios.SimpleRESTServices.Client;

namespace Eve_Corporation_Portal.Repository.EveAPI
{
    public class XmlResponse<T>
    {
        public XmlResponse(Response<object> response)
        {
            Response = new Response<T>(response, Utility.FromXml<T>(response.Data.ToString()));
        }

        public Response<T> Response { get; private set; }
    }
}
