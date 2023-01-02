using System.Xml.Serialization;

namespace AnidbExportParser.Model
{
    [XmlRoot(ElementName = "my_anime_list")]
    public class my_anime_list
    {
        [XmlElement(ElementName = "category")]
        public List<Category> Category { get; set; }

        [XmlElement(ElementName = "company")]
        public List<Company> Companies { get; set; }

        [XmlElement(ElementName = "title")]
        public List<Title> Titles { get; set; }

        [XmlElement(ElementName = "user_info")]
        public List<UserInfo> UserInfo { get; set; }


        //public UserInfo UserInfo { get; set; }

        public my_anime_list()
        {
            Category = new List<Category>();
            Companies = new List<Company>();
            Titles = new List<Title>();
            UserInfo = new List<UserInfo>();
        }
    }
}
