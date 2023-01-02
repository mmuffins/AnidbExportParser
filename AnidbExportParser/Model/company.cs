using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace AnidbExportParser.Model
{
    [XmlRoot(ElementName = "company")]
    public class Company
    {
        [XmlIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long EntityId { get; private set; }
        public int AnimeID { get; set; }
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyShortName { get; set; }
        public string CompanyOtherName { get; set; }
        public int CompanyTypeID { get; set; }
        public string CompanyTypeName { get;}
        public string CompanyURL { get; set; }
        public string CompanyPicURL { get; set; }
        public int CompanyApTypeID { get; set; }
        public string CompanyApTypeName { get; set; }

        public override string ToString()
        {
            return CompanyName;
        }
    }
}
