using Budgeter.Core.Data.XmlData.PKO;
using System;
using System.Xml;
using System.Xml.Serialization;

namespace Budgeter.ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
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
