using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    //everybody can use this (global variable)
    public static class GlobalConfig
    {
        //list because we have more than one data source to pull from
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                // TODO - Set up SQL connector properly;
                SQLConnector sql = new SQLConnector();
                Connection = sql;
            }

            else if (db == DatabaseType.TextFile)
            {
                // TODO - Set up text connection properly
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string CnnString (string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
