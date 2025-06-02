using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kependudukan.config
{
    abstract class Service_cls
    {
        // deklarasi abstract method untuk menangani INSERT, UPDATE, DELETE
        public abstract int ekskusiBukanQuery(string query);

        // deklarasi abstract method untuk menangani SELECT
        public abstract DataTable ekskusiQuery(string query);
    }
}
