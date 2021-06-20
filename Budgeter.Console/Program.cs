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

using System;
using System.Xml;
using System.Xml.Serialization;
using Budgeter.Core.Data.XmlData.PKO;

namespace Budgeter.ConsoleProject
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var path = @"C:\Users\u001702\Downloads\history_20210524_194832.xml";
            var serializer = new XmlSerializer(typeof(AccountHistory));
            var history = (AccountHistory)serializer.Deserialize(XmlReader.Create(path));

            foreach (var operation in history.Operations)
            {
                Console.WriteLine($"{operation.OrderDate} {operation.Type,30} {operation.Amount.Text} {operation.Amount.Currency}");
            }
        }
    }
}
