using System.Xml.Serialization;

namespace AnidbExportParser.Model
{
    [XmlRoot(ElementName = "my_anime_list")]
    public class my_anime_list
    {
        [XmlElement(ElementName = "anime_category")]
        public List<AnimeCategory> AnimeCategory { get; set; }

        [XmlElement(ElementName = "award")]
        public List<Award> Award { get; set; }

        [XmlElement(ElementName = "award_type")]
        public List<AwardType> AwardType { get; set; }

        [XmlElement(ElementName = "category")]
        public List<Category> Category { get; set; }

        [XmlElement(ElementName = "company")]
        public List<Company> Companies { get; set; }

        [XmlElement(ElementName = "episode_title")]
        public List<EpisodeTitle> EpisodeTitle { get; set; }

        [XmlElement(ElementName = "file")]
        public List<Model.File> File { get; set; }

        [XmlElement(ElementName = "title")]
        public List<Title> Titles { get; set; }

        [XmlElement(ElementName = "user_info")]
        public List<UserInfo> UserInfo { get; set; }

        public my_anime_list()
        {
            AnimeCategory = new List<AnimeCategory>();
            Award = new List<Award>();
            AwardType = new List<AwardType>();
            Category = new List<Category>();
            Companies = new List<Company>();
            EpisodeTitle = new List<EpisodeTitle>();
            File = new List<Model.File>();
            Titles = new List<Title>();
            UserInfo = new List<UserInfo>();
        }
    }
}
