using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    //everybody can use this (global variable)
    public static class GlobalConfig
    {
        //list because we have more than one data source to pull from
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool TextFiles)
        {
            if (database)
            {
                // TODO - Set up SQL connector properly;
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }

            if (TextFiles)
            {
                // TODO - Set up text connection properly
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}
