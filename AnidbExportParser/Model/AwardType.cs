using System.Xml.Serialization;

namespace AnidbExportParser.Model
{
    [XmlRoot(ElementName = "award_type")]
    public class AwardType
    {
        public int AnimeID { get; set; }
        public int AwardTypeID { get; set; }
        public string AwardTypeName { get; set; }
        public string AwardTypeImage { get; set; }

        public override string ToString()
        {
            return AwardTypeName;
        }
    }
}
