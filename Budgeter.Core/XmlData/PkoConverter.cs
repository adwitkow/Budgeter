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
using System.Text.RegularExpressions;
using Budgeter.Core.Entities;
using Budgeter.Core.XmlData.PKO;

namespace Budgeter.Core.XmlData
{
    public class PkoConverter
    {
        private static readonly string CardPaymentType = "Płatność kartą";
        private static readonly Regex TitleRegex = new Regex(@"Tytuł: (?<Title>.*)$", RegexOptions.Multiline);
        private static readonly string TitleGroup = "Title";
        private static readonly Regex AddressRegex = new Regex(@"Adres: (?<Title>.*)$", RegexOptions.Multiline);

        public IEnumerable<Transaction> Convert(PkoAccountHistory accountHistory)
        {
            var results = new List<Transaction>();

            // TODO: Map accountHistory.Search.Account to identify the source
            foreach (var operation in accountHistory.Operations)
            {
                this.ConvertOperation(results, operation);
            }

            return results;
        }

        private void ConvertOperation(ICollection<Transaction> results, PkoOperation operation)
        {
            var transaction = new Transaction
            {
                Timestamp = operation.OrderDate,

                /* TODO:
                 * Transaction.Category
                 * Transaction.Location
                 * Transaction.Source
                 */

                Description = this.ConvertDescription(operation),
                Amount = operation.Amount.Text,
                Currency = operation.Amount.Currency,
            };

            results.Add(transaction);
        }

        private string ConvertDescription(PkoOperation operation)
        {
            if (CardPaymentType.Equals(operation.Type))
            {
                return this.ExtractTitle(operation.Description, AddressRegex);
            }
            else
            {
                return this.ExtractTitle(operation.Description, TitleRegex);
            }
        }

        private string ExtractTitle(string input, Regex regex)
        {
            var match = regex.Match(input);
            var group = match.Groups[TitleGroup];

            if (group.Success)
            {
                return group.Value;
            }
            else
            {
                return input;
            }
        }
    }
}
