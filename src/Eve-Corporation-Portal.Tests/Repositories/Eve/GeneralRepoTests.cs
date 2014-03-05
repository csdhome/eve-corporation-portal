using System;
using Eve_Corporation_Portal.Core.Eve.Objects;
using Eve_Corporation_Portal.Repository.EveAPI.Repos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eve_Corporation_Portal.Tests.Repositories.Eve
{
    [TestClass]
    public class GeneralRepoTests
    {
        [TestMethod]
        public void GetCharacters()
        {
            var apiKeyInfo = new ApiKeyInfo() 
            {
                KeyId = 2979031,
                VCode = "jb25Tppy5VgfEE3SR8ghVSNz33TfLNWmE2o3Jhcn8I2hJM34bm4buizVS80CAFwf"
            };

            var info = new GeneralRepo().GetCharacters(apiKeyInfo);

            Assert.IsNotNull(info.result);
        }
    }
}
