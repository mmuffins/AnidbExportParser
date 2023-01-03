using ExtensionMethods;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace AnidbExportParser.Model
{
    [XmlRoot(ElementName = "file")]
    public class File
    {
        public long AnimeID { get; set; }
        public long EpID { get; set; }
        public long FID { get; set; }
        public long Size { get; set; }
        public int Length { get; set; }
        public int Generic { get; set; }

        // bug in source file, FileType property was provided multiple times
        [NotMapped]
        [XmlElement(ElementName = "FileType")]
        public List<string?> FileType { get; set; }

        public string? CRC { get; set; }
        public string? MD5 { get; set; }
        public string? SHA1 { get; set; }
        public string? TTH { get; set; }
        [XmlElement(ElementName = "ed2kName")]
        public string? Ed2kName { get; set; }
        [XmlElement(ElementName = "ed2kHash")]
        public string? Ed2kHash { get; set; }
        [XmlElement(ElementName = "ed2kLink")]
        public string? Ed2kLink { get; set; }
        public int GID { get; set; }
        public string? GName { get; set; }
        public string? GShortName { get; set; }

        [XmlIgnore]
        public DateTime? ReleaseDate { get; set; }

        [NotMapped]
        [XmlElement("ReleaseDate")]
        public string? ReleaseDateString
        {
            get { return ReleaseDate.HasValue ? ReleaseDate.Value.ToString("yyyy-MM-dd HH:mm:ss") : null; }
            set { ReleaseDate = value.ParseAniDbDateTime(); }
        }

        public int QualityID { get; set; }
        public string QualityName { get; set; }
        public string ResName { get; set; }
        public int VCount { get; set; }
        public int VAspectRatio { get; set; }
        public string VAspectRatioName { get; set; }
        public int VFPS { get; set; }
        public int VFlags { get; set; }
        public int VBitRate { get; set; }
        public int VCodecID { get; set; }
        public string? VCodecName { get; set; }
        public int ACount { get; set; }
        public int ABitRate { get; set; }
        public int ACodecID { get; set; }
        public string? ACodecName { get; set; }
        public int AChanType { get; set; }
        public string? AChanTypeName { get; set; }
        public int ALangID { get; set; }
        public string? ALangName { get; set; }
        public int AType { get; set; }
        public string? ATypeName { get; set; }
        public int ABitRate2 { get; set; }
        public int ACodecID2 { get; set; }
        public string? ACodecName2 { get; set; }
        public int AChanType2 { get; set; }
        public string? AChanTypeName2 { get; set; }
        public int ALangID2 { get; set; }
        public string? ALangName2 { get; set; }
        public int AType2 { get; set; }
        public string? ATypeName2 { get; set; }
        public int SubCount { get; set; }
        public int SubID { get; set; }
        public string? SubName { get; set; }
        public int SubFlags { get; set; }
        public int SubType { get; set; }
        public string? SubTypeName { get; set; }
        public int SubID2 { get; set; }
        public string? SubName2 { get; set; }
        public int SubFlags2 { get; set; }
        public int SubType2 { get; set; }
        public string? SubTypeName2 { get; set; }
        public int TypeID { get; set; }
        public string TypeName { get; set; }
        public string? Other { get; set; }
        public int HasComment { get; set; }

        [XmlIgnore]
        public DateTime? Date { get; set; }

        [NotMapped]
        [XmlElement("Date")]
        public string? DateString
        {
            get { return Date.HasValue ? Date.Value.ToString("yyyy-MM-dd HH:mm:ss") : null; }
            set { Date = value.ParseAniDbDateTime(); }
        }

        [XmlIgnore]
        public DateTime? Update { get; set; }

        [NotMapped]
        [XmlElement("Update")]
        public string? UpdateString
        {
            get { return Update.HasValue ? Update.Value.ToString("yyyy-MM-dd HH:mm:ss") : null; }
            set { Update = value.ParseAniDbDateTime(); }
        }

        public string? Storage { get; set; }
        public string? Source { get; set; }

        [XmlIgnore]
        public DateTime? ListDate { get; set; }

        [NotMapped]
        [XmlElement("ListDate")]
        public string? ListDateString
        {
            get { return ListDate.HasValue ? ListDate.Value.ToString("yyyy-MM-dd HH:mm:ss") : null; }
            set { ListDate = value.ParseAniDbDateTime(); }
        }

        [XmlIgnore]
        public DateTime? ViewDate { get; set; }

        [NotMapped]
        [XmlElement("ViewDate")]
        public string? ViewDateString
        {
            get { return ViewDate.HasValue ? ViewDate.Value.ToString("yyyy-MM-dd HH:mm:ss") : null; }
            set { ViewDate = value.ParseAniDbDateTime(); }
        }

        public int State { get; set; }
        public int StateCRCOK { get; set; }
        public int StateCRCFailed { get; set; }
        public int StateCRCUnverified { get; set; }
        public string VersionName { get; set; }
        public int MyWatched { get; set; }
        public int MyState { get; set; }
        public string MyStateString { get; set; }
        public string MyStateIcon { get; set; }
        public int MyFileState { get; set; }
        public string? MyFileStateString { get; set; }
        public string? MyFileStateIcon { get; set; }

        public override string ToString()
        {
            return FID.ToString();
        }
    }
}
