using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eve_Corporation_Portal.Bootstrapper
{
    public static class Bootstrap
    {
        public static void Setup(BootstrapSettings settings)
        {

        }

        public static BootstrapSettings GetBootstrapSettings()
        {
            return new BootstrapSettings()
                {
                    EveApiBase = ConfigurationManager.AppSettings["EveApiBase"]
                };
        }
    }
}
