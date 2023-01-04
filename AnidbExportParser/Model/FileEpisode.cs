using ExtensionMethods;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace AnidbExportParser.Model
{
    [XmlRoot(ElementName = "file_episode")]
    public class FileEpisode
    {
        [XmlIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long EntityId { get; private set; }
        public int FID { get; set; }
        public int EpID { get; set; }
        public int StartPercent { get; set; }
        public int EndPercent { get; set; }

        public override string ToString()
        {
            return FID.ToString();
        }
    }
}
