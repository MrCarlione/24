using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLHelper
{
    /// <summary>
    /// This class is being serialized to .xml
    /// </summary>
    [Serializable]
    [XmlRoot("doctors"), XmlType("doctors")]
    public class XMLReader
    {

    }
}
