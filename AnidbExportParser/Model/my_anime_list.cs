using System.Xml.Serialization;

namespace AnidbExportParser.Model
{
    [XmlRoot(ElementName = "my_anime_list")]
    public class my_anime_list
    {
        [XmlElement(ElementName = "title")]
        public List<Title> titles { get; set; }

        [XmlElement(ElementName = "company")]
        public List<Company> companies { get; set; }

        [XmlElement(ElementName = "user_info")]
        public List<user_info> user_info { get; set; }

        //public user_info user_info { get; set; }

        public my_anime_list()
        {
            titles = new List<Title>();
            companies = new List<Company>();
            user_info = new List<user_info>();
        }
    }
}
