using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLHelper.External.Models
{
    /// <summary>
    /// This class is being serialized to .xml
    /// </summary>
    [Serializable]
    [XmlRoot("doctors"), XmlType("doctors")]
    public class Doctors
    {
        public string Name { get; set; }
        public int Cabinet { get; set; }
        public string Work { get; set; }
        public string Work_Th { get; set; }
    }
}
