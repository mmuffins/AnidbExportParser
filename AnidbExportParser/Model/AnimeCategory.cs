using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace AnidbExportParser.Model
{
    [XmlRoot(ElementName = "anime_category")]
    public class AnimeCategory
    {
        [XmlIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long EntityId { get; private set; }
        public int AnimeID { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int CategoryParentID { get; set; }
        public int CategoryHentai { get; set; }
        public int CategoryWeight { get; set; }

        public override string ToString()
        {
            return CategoryName;
        }
    }
}
