using System.Xml.Serialization;

namespace AnidbExportParser.Model
{
    [XmlRoot(ElementName = "user_info")]
    public class UserInfo
    {
        public string UserName { get; set; }
        public int UserID { get; set; }
        public string ExportDate { get; set; }
        public int MyAnimeCount { get; set; }
        public int MyEpisodeCount { get; set; }
        public int MyFileCount { get; set; }
        public string MyByteCount { get; set; }
        public int MyAnimesAdded { get; set; }
        public int MyEpisodesAdded { get; set; }
        public int MyFilesAdded { get; set; }
        public int MyGroupsAdded { get; set; }
        public string MyLameFiles { get; set; }
        public string MyLameFilesPercent { get; set; }
        public int MyIndependencePercent { get; set; }
        public int MyLeechPercent { get; set; }
        public int MyReviews { get; set; }
        public int MyVotes { get; set; }
        public int MyTotalViewedPercent { get; set; }
        public int MyTotalOwnedPercent { get; set; }
        public int MyOwnViewedPercent { get; set; }
        public int MyViewedEpisodeCount { get; set; }
        public string AniDBURL { get; set; }

        public override string ToString()
        {
            return UserName;
        }
    }

}
