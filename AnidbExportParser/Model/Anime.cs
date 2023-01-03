using ExtensionMethods;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AnidbExportParser.Model
{
    [XmlRoot(ElementName = "anime")]
    public class Anime
    {
        public int AnimeID { get; set; }
        public string Name { get; set; }
        public string? NameKanji { get; set; }
        public string? NameEnglish { get; set; }
        public string Year { get; set; }
        public string? URL { get; set; }
        public string? AnimeDescription { get; set; }

        [XmlIgnore]
        public DateTime? Date { get; set; }

        [NotMapped]
        [XmlElement("Date")]
        public string? DateString {
            get { return Date.HasValue ? Date.Value.ToString("yyyy-MM-dd HH:mm:ss") : null; }
            set { Date = value.ParseAniDbDateTime(); }
        }
        public int Update { get; set; }

        [XmlIgnore]
        public DateOnly? StartDate { get; set; }

        [NotMapped]
        [XmlElement("StartDate")]
        public string? StartDateString {
            get { return StartDate.HasValue ? StartDate.Value.ToString("yyyy-MM-dd") : null; }
            set { StartDate = value.ParseAniDbDateOnly(); }
        }

        [XmlIgnore]
        public DateOnly? EndDate { get; set; }

        [NotMapped]
        [XmlElement("EndDate")]
        public string? EndDateString
        {
            get { return EndDate.HasValue ? EndDate.Value.ToString("yyyy-MM-dd") : null; }
            set { EndDate = value.ParseAniDbDateOnly(); }
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
        public decimal? TempRating { get; set; }

        [NotMapped]
        [XmlElement("TempRating")]
        public string TempRatingString
        {
            get { return TempRating.ToString(); }
            set { TempRating = value.ParseAniDbDecimal(); }
        }

        public int TempVotes { get; set; }

        [XmlIgnore]
        public decimal? ReviewRating { get; set; }

        [NotMapped]
        [XmlElement("ReviewRating")]
        public string ReviewRatingString
        {
            get { return ReviewRating.ToString(); }
            set { ReviewRating = value.ParseAniDbDecimal(); }
        }

        public int Reviews { get; set; }

        [XmlIgnore]
        public int? MyVote { get; set; }

        [NotMapped]
        [XmlElement("MyVote")]
        public string? MyVoteString
        {
            get { return MyVote.HasValue ? MyVote.ToString() : ""; }
            set { MyVote = value.ParseAniDbInt32(); }
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

        public string? MyTempVote { get; set; }
        public string? MyTempVoteDate { get; set; }
        public int TypeID { get; set; }
        public string TypeName { get; set; }
        public int NFOID { get; set; }
        public string? NFOID2 { get; set; }
        public string? NFOURL { get; set; }
        public string? NFOURLName { get; set; }
        public int ANNID { get; set; }
        public string? ANNURL { get; set; }
        public int AllCinemaID { get; set; }
        public string? AllCinemaURL { get; set; }
        public string? AnimePlanetURL { get; set; }
        public int Eps { get; set; }
        public int EpsSpecial { get; set; }
        public int EpsTotal { get; set; }
        public int MyEps { get; set; }
        public int MyEpsSpecial { get; set; }
        public int MyEpsTotal { get; set; }
        public int WatchedEps { get; set; }
        public int WatchedSpecial { get; set; }
        public int WatchedTotal { get; set; }
        public int UnWatchedEps { get; set; }
        public int UnWatchedSpecial { get; set; }
        public int UnWatchedTotal { get; set; }
        public string? ByteCount { get; set; }
        public string? MyWishlistType { get; set; }
        public string? MyWishlistTypeName { get; set; }
        public string? MyWishlistPriority { get; set; }
        public string? MyWishlistPriorityName { get; set; }
        public string? MyWishlistComment { get; set; }
        public int Hentai { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}