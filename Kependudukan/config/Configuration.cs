using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kependudukan.config
{
    class Configuration
    {
        public static string[] readConfig(string nameFile)
        {
            TextReader baca=new StreamReader(nameFile);
            string file=baca.ReadToEnd();
            string[] data = new string[5];

            int i = 0;
            while (file != null) 
            {
                data[i++] = file;
                file = baca.ReadToEnd();
            }

            return data;
        }
    }
}
