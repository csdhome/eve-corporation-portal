using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Eve_Corporation_Portal.Core
{
    public static class Utility
    {
        public static T FromXml<T>(string strXml)
        {
            T returnedXmlClass = default(T);

            try
            {
                using (TextReader reader = new StringReader(strXml))
                {
                    try
                    {
                        returnedXmlClass = (T)new XmlSerializer(typeof(T)).Deserialize(reader);
                    }
                    catch (InvalidOperationException)
                    {
                        // String passed is not XML, simply return defaultXmlClass
                    }
                }
            }
            catch (Exception)
            {
                //Ignore the exception and return the default constructed class to the caller.
            }

            return returnedXmlClass;  
        }

        public static string ToXml<T>(T itemToSerialize)
        {
            var sb = new StringBuilder();
            try
            {
                using (var xmlWriter = XmlWriter.Create(sb))
                {
                    new XmlSerializer(typeof(T)).Serialize(xmlWriter, itemToSerialize);
                }
            }
            catch (Exception)
            {
                //Ignore the exception and return the empty string to the caller.
            }
            return sb.ToString();
        }
    }
}
