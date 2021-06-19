using System;
using System.Xml.Serialization;

namespace Budgeter.Core.Data.XmlData.PKO
{
    [XmlRoot(ElementName = "date")]
    public class SearchDate
    {
        [XmlAttribute(AttributeName = "since")]
        public DateTime Since { get; set; }
        [XmlAttribute(AttributeName = "to")]
        public DateTime To { get; set; }
    }
}
