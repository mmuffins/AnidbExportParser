using System.Xml.Serialization;

namespace AnidbExportParser.Model
{
    [XmlRoot(ElementName = "episode_title")]
    public class EpisodeTitle
    {
        public int AnimeID { get; set; }

        // Foreign key for Episodes
        public int EpID { get; set; }
        [XmlIgnore]
        public Episode Episode { get; set; }

        public string Name { get; set; }
        public int LanguageID { get; set; }
        public string LanguageName { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
