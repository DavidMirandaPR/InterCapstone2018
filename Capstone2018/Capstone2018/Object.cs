using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Capstone2018
{
    [XmlRoot("Object")]
    public class Object
    {
        [XmlElement("Shape")]
        public string Shape { get; set; }
    }
}
