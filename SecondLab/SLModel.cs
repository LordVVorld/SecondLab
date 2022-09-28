using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace SecondLab
{
    public class SLModel
    {
        [XmlRoot("shipOrder")]
        public class Order
        {
            [XmlElement("shipTo")]
            public OrderAdress Adress { get; set; }
            [XmlElement("items")]
            public ItemList List { get; set; }

            public override string ToString()
            {
                string result = string.Format("Customer Name: {0} \n", Adress.Name);
                result += string.Format("   Shipping Address: {0}, {1}, {2} \n", Adress.Street, Adress.Address, Adress.Country);
                result += "Ordered goods: ";
                foreach (var item in List.Items)
                {
                    result += string.Format("       {0} ({1} pieces) for {2} \n", item.Title, item.Quantity, item.Price);
                }
                return result;
            }
        }

        public class ItemList
        {
            [XmlElement("item")]
            public List<OrderItem> Items { get; set; }
        }

        public class OrderAdress
        {
            [XmlElement("name")]
            public string Name { get; set; }

            [XmlElement("street")]
            public string Street { get; set; }

            [XmlElement("address")]
            public string Address { get; set; }

            [XmlElement("country")]
            public string Country { get; set; }
        }

        public class OrderItem
        {
            [XmlElement("title")]
            public string Title { get; set; }

            [XmlElement("quantity")]
            public string Quantity { get; set; }

            [XmlElement("price")]
            public string Price { get; set; }
        }

        public static string StreamFile(FileStream stream) => new StreamReader(stream).ReadToEnd();

        public static Order DeserializeXML(FileStream stream) => (Order)new XmlSerializer(typeof(Order)).Deserialize(stream);
    }
}
