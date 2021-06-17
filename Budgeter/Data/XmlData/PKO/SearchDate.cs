using System.Xml.Serialization;

namespace Budgeter.Core.Data.XmlData.PKO
{
	[XmlRoot(ElementName = "date")]
	public class SearchDate
	{
		[XmlAttribute(AttributeName = "since")]
		public string Since { get; set; }
		[XmlAttribute(AttributeName = "to")]
		public string To { get; set; }
	}
}
