using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace AnidbExportParser.Model
{
    [XmlRoot(ElementName = "filefile")]
    public class FileFile
    {
        [XmlIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long EntityId { get; private set; }
        public int FID1 { get; set; }
        public int FID2 { get; set; }
        public string RelationType { get; set; }
        public override string ToString()
        {
            return $"{FID1}-{FID2}";
        }
    }
}
