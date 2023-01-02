using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace AnidbExportParser.Model
{
    [XmlRoot(ElementName = "title")]
    public class Title
    {
        [XmlIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long EntityId { get; private set; }
        public int AnimeID { get; set; }
        public int TitleTypeID { get; set; }
        public string TitleTypeName { get; set; }
        public string Name { get; set; }
        public int LanguageID { get; set; }
        public string LanguageName { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
