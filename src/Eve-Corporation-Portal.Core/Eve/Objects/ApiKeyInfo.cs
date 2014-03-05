using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eve_Corporation_Portal.Core.Eve.Objects
{
    public class ApiKeyInfo
    {
        public int KeyId { get; set; }
        public string VCode { get; set; }

        public IDictionary<string, string> ToDictionary()
        {
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("keyid", KeyId.ToString());
            dictionary.Add("vcode", VCode);
            return dictionary;
        }
    }
}
