using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace AnidbExportParser.Model
{
    [XmlRoot(ElementName = "tag")]
    public class Tag
    {
        [XmlIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long EntityId { get; private set; }

        public int AnimeID { get; set; }
        public int TagID { get; set; }
        public string TagName { get; set; }
        public long TagDate { get; set; }
        
        public override string ToString()
        {
            return TagName;
        }
    }
}
