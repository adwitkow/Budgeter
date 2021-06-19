using System.Collections.Generic;
using System.Xml.Serialization;

namespace Budgeter.Core.Data.XmlData.PKO
{
    [XmlRoot(ElementName = "account-history")]
	public class AccountHistory
	{
		[XmlElement(ElementName = "search")]
		public Search SearchFilter { get; set; }
		
		[XmlArray(ElementName = "operations")]
		[XmlArrayItem(ElementName = "operation")]
		public List<PkoOperation> Operations { get; set; }
	}
}
