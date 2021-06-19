﻿using System.Xml.Serialization;

namespace Budgeter.Core.Data.XmlData.PKO
{
    [XmlRoot(ElementName = "amount")]
    public class Amount
    {
        [XmlAttribute(AttributeName = "curr")]
        public string Currency { get; set; }
        [XmlText]
        public decimal Text { get; set; }
    }
}