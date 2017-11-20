using System.IO;
using System.Reflection;
using System.Xml.Linq;

namespace MFIAlertApp.Helpers
{
    /// <summary>
    /// Get Configuration service. Read from Config.xml file.
    /// </summary>
    public static class ConfigurationService
    {
        public static string GetConfigurationValue(string ConfigValue)
        {
            string result;
            var assembly = typeof(MFIAlertApp.App).GetTypeInfo().Assembly;
            var resourceName = "MFIAlertApp.config.xml";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))

            using (StreamReader reader = new StreamReader(stream))
            {
                var doc = XDocument.Parse(reader.ReadToEnd());
                result = doc.Element("config").Element(ConfigValue).Value;
            }

            return result;
        }
    }
}
