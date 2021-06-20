// This file is part of Budgeter project <https://github.com/adwitkow/Budgeter>
// Copyright (C) 2021  Adam Witkowski <https://github.com/adwitkow/>
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <https://www.gnu.org/licenses/>.

using System.Collections.Generic;
using System.Xml.Serialization;

namespace Budgeter.Core.XmlData.PKO
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
