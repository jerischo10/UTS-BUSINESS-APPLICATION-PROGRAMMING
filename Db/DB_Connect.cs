using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db
{
    public class DB_Connect
    {
        public string db_connect()
        {
            //return "Server = localhost; Initial catalog = pos_restoran; " +
            //"Integrated Security = SSPI; MultipleActiveResultSets = True";
            return "Server = localhost; Data Source = localhost; Database = pos_restoran; " +
            "Integrated Security = SSPI; MultipleActiveResultSets = True";
        }
    }
}