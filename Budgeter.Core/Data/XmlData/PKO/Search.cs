using System.Xml.Serialization;

namespace Budgeter.Core.Data.XmlData.PKO
{
    [XmlRoot(ElementName = "search")]
	public class Search
	{
		[XmlElement(ElementName = "account")]
		public string Account { get; set; }
		[XmlElement(ElementName = "date")]
		public SearchDate Date { get; set; }
		[XmlElement(ElementName = "filtering")]
		public string Filtering { get; set; }
	}
}
