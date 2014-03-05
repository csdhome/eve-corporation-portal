using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eve_Corporation_Portal.Core.Eve.Objects;
using Eve_Corporation_Portal.Repository.EveAPI.EveApiObjects;

namespace Eve_Corporation_Portal.Repository.EveAPI.Repos
{
    public class GeneralRepo : XmlServiceBase
    {
        public eveapi GetCharacters(ApiKeyInfo apiKeyInfo)
        {
            var url = "https://api.eveonline.com/account/Characters.xml.aspx";
            return Post(url, apiKeyInfo.ToDictionary()).Data;
        }
    }
}
