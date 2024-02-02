using System.Collections.Generic;
using System.Xml.Serialization;
using System;

namespace API.Models
{
    [XmlRoot(ElementName = "Item")]
    public class ItemHDDT
    {
        [XmlElement(ElementName = "index")]
        public string Index { get; set; }

        [XmlElement(ElementName = "cusCode")]
        public string CusCode { get; set; }

        [XmlElement(ElementName = "invToken")]
        public string InvToken { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "publishDate")]
        public string PublishDate { get; set; }

        [XmlElement(ElementName = "signStatus")]
        public string SignStatus { get; set; }

        [XmlElement(ElementName = "pattern")]
        public string Pattern { get; set; }

        [XmlElement(ElementName = "serial")]
        public string Serial { get; set; }

        [XmlElement(ElementName = "invNum")]
        public string InvNum { get; set; }

        [XmlElement(ElementName = "amount")]
        public string Amount { get; set; }

        [XmlElement(ElementName = "total")]
        public string Total { get; set; }

        [XmlElement(ElementName = "vatAmount")]
        public string VatAmount { get; set; }

        [XmlElement(ElementName = "status")]
        public string Status { get; set; }

        [XmlElement(ElementName = "cusname")]
        public string Cusname { get; set; }

        [XmlElement(ElementName = "payment")]
        public string Payment { get; set; }

        [XmlElement(ElementName = "fkey")]
        public string Fkey { get; set; }

        [XmlElement(ElementName = "type")]
        public string Type { get; set; }

        [XmlElement(ElementName = "kindOfService")]
        public string KindOfService { get; set; }
    }

    [XmlRoot(ElementName = "Data")]
    public class DataHDDT
    {

        [XmlElement(ElementName = "Item")]
        public List<ItemHDDT> ListItem { get; set; }
    }

    public class VATModel
    {
        public string Html { get; set; }
    }


}
