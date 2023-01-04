using ExtensionMethods;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace AnidbExportParser.Model
{
    [XmlRoot(ElementName = "episode")]
    public class Episode
    {
        [XmlIgnore]
        public ICollection<Model.File> Files { get; set; }

        [XmlIgnore]
        public Anime Anime { get; set; }
        // Foreign Key for Anime
        public int AnimeID { get; set; }

        public int EpID { get; set; }
        public string EpNo { get; set; }
        public string EpName { get; set; }
        public string? EpNameRomaji { get; set; }
        public string? EpNameKanji { get; set; }
        public int EpLength { get; set; }

        [XmlIgnore]
        public DateTime? EpAired { get; set; }

        [NotMapped]
        [XmlElement("EpAired")]
        public string? EpAiredString
        {
            get { return EpAired.HasValue ? EpAired.Value.ToString("yyyy-MM-dd HH:mm:ss") : null; }
            set { EpAired = value.ParseAniDbDateTime(); }
        }

        [XmlIgnore]
        public DateTime? EpDate { get; set; }

        [NotMapped]
        [XmlElement("EpDate")]
        public string? EpDateString
        {
            get { return EpDate.HasValue ? EpDate.Value.ToString("yyyy-MM-dd HH:mm:ss") : null; }
            set { EpDate = value.ParseAniDbDateTime(); }
        }

        [XmlIgnore]
        public DateTime? EpUpdate { get; set; }

        [NotMapped]
        [XmlElement("EpUpdate")]
        public string? EpUpdateString
        {
            get { return EpUpdate.HasValue ? EpUpdate.Value.ToString("yyyy-MM-dd HH:mm:ss") : null; }
            set { EpUpdate = value.ParseAniDbDateTime(); }
        }

        public string? EpOther { get; set; }
        public int? EpState { get; set; }
        public int? EpStateSpecial { get; set; }
        public int? EpStateRecap { get; set; }
        public int? EpStateOp { get; set; }
        public int? EpStateEnd { get; set; }

        [XmlIgnore]
        public decimal? EpRating { get; set; }

        [NotMapped]
        [XmlElement("EpRating")]
        public string EpRatingString
        {
            get { return EpRating.ToString(); }
            set { EpRating = value.ParseAniDbDecimal(); }
        }

        public int? EpVotes { get; set; }


        [XmlIgnore]
        public decimal? EpMyVote { get; set; }

        [NotMapped]
        [XmlElement("EpMyVote")]
        public string EpMyVoteString
        {
            get { return EpMyVote.ToString(); }
            set { EpMyVote = value.ParseAniDbDecimal(); }
        }

        [XmlIgnore]
        public DateTime? EpMyVoteDate { get; set; }

        [NotMapped]
        [XmlElement("EpMyVoteDate")]
        public string? EpMyVoteDateString
        {
            get { return EpMyVoteDate.HasValue ? EpMyVoteDate.Value.ToString("yyyy-MM-dd HH:mm:ss") : null; }
            set { EpMyVoteDate = value.ParseAniDbDateTime(); }
        }


        [XmlIgnore]
        public int? MyEpWatched { get; set; }

        [NotMapped]
        [XmlElement("MyEpWatched")]
        public string? MyEpWatchedString
        {
            get { return MyEpWatched.HasValue ? MyEpWatched.ToString() : ""; }
            set { MyEpWatched = value.ParseAniDbInt32(); }
        }

        public int? MyEpState { get; set; }
        public string? MyEpStateString { get; set; }
        public string? MyEpStateIcon { get; set; }



        public override string ToString()
        {
            return EpID.ToString();
        }
    }
}
