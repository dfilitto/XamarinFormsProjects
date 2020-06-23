using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaNoite.UWP
{
    public class FileAccessHelper
    {
        public static string GetLocalFilePath(string filename)
        {
            string path = global::Windows.Storage.ApplicationData.Current.LocalFolder.Path;
            return System.IO.Path.Combine(path, filename);
        }
    }
}
