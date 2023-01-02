using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnidbExportParser.Model
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int CategoryParentID { get; set; }
        public int CategoryHentai { get; set; }
    }
}
