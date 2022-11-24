using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace SecondLab
{
    public class SLModel
    {
        public abstract class XMLContent
        {
            public abstract string Read();
        }

        [XmlRoot("shipOrder")]
        public class Order : XMLContent
        {
            [XmlElement("shipTo")]
            public OrderAdress Adress { get; set; }
            [XmlElement("items")]
            public ItemList Items { get; set; }

            public override string Read() => Adress.Read() + Items.Read();

            public override string ToString() => this.Read();
        }

        public class ItemList : XMLContent
        {
            [XmlElement("item")]
            public List<OrderItem> Items { get; set; }

            public override string Read()
            {
                string result = "Ordered goods:\n    ";
                foreach (var item in Items)
                {
                    result += item.Read();
                    result += "\n    ";
                }
                return result;
            }
        }

        public class OrderAdress : XMLContent
        {
            [XmlElement("name")]
            public string Name { get; set; }

            [XmlElement("street")]
            public string Street { get; set; }

            [XmlElement("address")]
            public string Address { get; set; }

            [XmlElement("country")]
            public string Country { get; set; }

            public override string Read()
            {
                string result = string.Format("Customer Name:\n    {0} \n", Name);
                result += string.Format("Shipping Address:\n    {0}, {1}, {2} \n", Street, Address, Country);
                return result;
            }
        }

        public class OrderItem : XMLContent
        {
            [XmlElement("title")]
            public string Title { get; set; }

            [XmlElement("quantity")]
            public string Quantity { get; set; }

            [XmlElement("price")]
            public string Price { get; set; }

            public override string Read() => string.Format("{0} ({1} pieces) for {2}", Title, Quantity, Price);
        }

        public static string StreamFile(string xmlFilePath)
        {
            using (FileStream stream = new FileStream(xmlFilePath, FileMode.Open))
            {
                return new StreamReader(stream).ReadToEnd();
            }
        }

        public static Order DeserializeXML(string xmlFilePath)
        {
            using (FileStream stream = new FileStream(xmlFilePath, FileMode.Open))
            {
                return (Order)new XmlSerializer(typeof(Order)).Deserialize(stream);
            }
        }
    }
}
