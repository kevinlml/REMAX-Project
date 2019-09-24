using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Remax_Project.Business
{
    static class clsGlobal
    {
        public static OleDbConnection myCon;
        public static OleDbDataAdapter adpHouses;
        public static DataSet mySet;
    }
}
