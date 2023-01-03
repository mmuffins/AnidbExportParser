using ExtensionMethods;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace AnidbExportParser.Model
{
    [XmlRoot(ElementName = "anime_group")]
    public class AnimeGroup
    {
        public int AnimeID { get; set; }
        public int GID { get; set; }
        public int AGID { get; set; }
        public string GName { get; set; }
        public string GShortName { get; set; }
        public string State { get; set; }
        public string EpRange { get; set; }
        public int LastEp { get; set; }
        public int EpCount { get; set; }
        public int SpecialCount { get; set; }

        [XmlIgnore]
        public DateTime? Update { get; set; }

        [NotMapped]
        [XmlElement("Update")]
        public string? UpdateString
        {
            get { return Update.HasValue ? Update.Value.ToString("yyyy-MM-dd HH:mm:ss") : null; }
            set { Update = value.ParseAniDbDateTime(); }
        }

        [XmlIgnore]
        public decimal? Rating { get; set; }

        [NotMapped]
        [XmlElement("Rating")]
        public string RatingString
        {
            get { return Rating.ToString(); }
            set { Rating = value.ParseAniDbDecimal(); }
        }

        public int Votes { get; set; }

        [XmlIgnore]
        public decimal? MyVote { get; set; }

        [NotMapped]
        [XmlElement("MyVote")]
        public string MyVoteString
        {
            get { return MyVote.ToString(); }
            set { MyVote = value.ParseAniDbDecimal(); }
        }


        [XmlIgnore]
        public DateTime? MyVoteDate { get; set; }

        [NotMapped]
        [XmlElement("MyVoteDate")]
        public string? MyVoteDateString
        {
            get { return MyVoteDate.HasValue ? MyVoteDate.Value.ToString("yyyy-MM-dd HH:mm:ss") : null; }
            set { MyVoteDate = value.ParseAniDbDateTime(); }
        }

        public int Comments { get; set; }

        public override string ToString()
        {
            return GName;
        }
    }
}
