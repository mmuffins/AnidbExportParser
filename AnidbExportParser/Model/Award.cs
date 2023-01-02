using System.Xml.Serialization;

namespace AnidbExportParser.Model
{
    [XmlRoot(ElementName = "award")]
    public class Award
    {
        public int AnimeID { get; set; }
        public int AwardID { get; set; }
        public string AwardName { get; set; }
        public int AwardType { get; set; }
        public string AwardURL { get; set; }

        public override string ToString()
        {
            return AwardName;
        }
    }
}
