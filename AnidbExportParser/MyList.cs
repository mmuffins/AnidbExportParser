using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using AnidbExportParser.Model;

namespace AnidbExportParser
{
    public class MyList
    {
        public my_anime_list AnidbData { get; set; }
        public MyListDbContextFactory DBFactory { get; set; }


        public async Task ParseAnidbXml(string path)
        {
            if (!System.IO.File.Exists(path))
            {
                throw new FileNotFoundException(path);
            }

            var serializer = new XmlSerializer(typeof(my_anime_list));
            serializer.UnknownNode += new XmlNodeEventHandler(serializer_UnknownNode);
            serializer.UnknownAttribute += new XmlAttributeEventHandler(serializer_UnknownAttribute);

            await Task.Run(() =>
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    try
                    {
                        AnidbData = (my_anime_list)serializer.Deserialize(reader);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        reader.Close();
                    }
                }
            });
        }


        public async Task ExportData(string path)
        {
            DBFactory = new MyListDbContextFactory(path);
            DBFactory.MigrateDB();

            using var context = DBFactory.GetContext();
            await context.Database.EnsureCreatedAsync();

            await context.AnimeCategory.AddRangeAsync(AnidbData.AnimeCategory);
            await context.Award.AddRangeAsync(AnidbData.Award);
            await context.AwardType.AddRangeAsync(AnidbData.AwardType);
            await context.Category.AddRangeAsync(AnidbData.Category);
            await context.Company.AddRangeAsync(AnidbData.Companies);
            await context.EpisodeTitle.AddRangeAsync(AnidbData.EpisodeTitle);
            await context.File.AddRangeAsync(AnidbData.File);
            await context.Title.AddRangeAsync(AnidbData.Titles);
            await context.UserInfo.AddRangeAsync(AnidbData.UserInfo);

            await context.SaveChangesAsync();
        }


        private static void serializer_UnknownAttribute(object sender, XmlAttributeEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private static void serializer_UnknownNode(object sender, XmlNodeEventArgs e)
        {
            //throw new System.NotImplementedException();
        }

    }
}
