using System.Xml.Serialization;

namespace AnidbExportParser.Model
{
    [XmlRoot(ElementName = "category")]
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int CategoryParentID { get; set; }
        public int CategoryHentai { get; set; }
    }
}
