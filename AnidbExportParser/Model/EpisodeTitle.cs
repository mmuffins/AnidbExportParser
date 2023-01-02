﻿using System.Xml.Serialization;

namespace AnidbExportParser.Model
{
    [XmlRoot(ElementName = "episode_title")]
    public class EpisodeTitle
    {
        public int AnimeID { get; set; }
        public int EpID { get; set; }
        public string Name { get; set; }
        public int LanguageID { get; set; }
        public string LanguageName { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}