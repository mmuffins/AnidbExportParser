using AnidbExportParser.Model;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnidbExportParser
{
    internal class MyListDb : IDisposable
    {
        private bool disposedValue;

        private LiteDatabase Db { get; set; }

        public ILiteCollection<Company> company { get; private set; }
        public ILiteCollection<Title> title{ get; private set; }

        public MyListDb(string path)
        {
            Db = CreateDb(path);
        }

        private LiteDatabase CreateDb(string path)
        {
            return new LiteDatabase(path);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Db.Dispose();
                }

                disposedValue = true;
            }
        }

        // ~MyListDb()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
