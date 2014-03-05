using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eve_Corporation_Portal.Core;
using JSIStudios.SimpleRESTServices.Client;

namespace Eve_Corporation_Portal.Repository.EveAPI
{
    public class XmlStringSerializer : IStringSerializer
    {
        public T Deserialize<T>(string content)
        {
            return Utility.FromXml<T>(content);
        }

        public string Serialize<T>(T obj)
        {
            return Utility.ToXml(obj);
        }
    }
}
