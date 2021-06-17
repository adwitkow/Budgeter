using System.Xml.Serialization;

namespace Budgeter.Core.Data.XmlData.PKO
{
	[XmlRoot(ElementName = "operation")]
	public class PkoOperation
	{
		[XmlElement(ElementName = "exec-date")]
		public string ExecutionDate { get; set; }
		[XmlElement(ElementName = "order-date")]
		public string OrderDate { get; set; }
		[XmlElement(ElementName = "type")]
		public string Type { get; set; }
		[XmlElement(ElementName = "description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "amount")]
		public Amount Amount { get; set; }
		[XmlElement(ElementName = "ending-balance")]
		public EndingBalance EndingBalance { get; set; }
	}
}
