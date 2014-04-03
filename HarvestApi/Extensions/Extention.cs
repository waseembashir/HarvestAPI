using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace HarvestApi.Extensions
{
    public static class Extensions
    {
        public static XElement ToXElement<T>(this T obj)
        {
            var emptyNamespace = new XmlSerializerNamespaces();
            emptyNamespace.Add(String.Empty, String.Empty);
            var xmlSerializer = new XmlSerializer(typeof(T));
            var writerSettings = new XmlWriterSettings();
            writerSettings.OmitXmlDeclaration = true;
            var stringWriter = new StringWriter();
            using (var xmlWriter = XmlWriter.Create(stringWriter, writerSettings))
            {
                xmlSerializer.Serialize(xmlWriter, obj, emptyNamespace);
            }
            return XElement.Parse(stringWriter.ToString());
        }
    }
}
