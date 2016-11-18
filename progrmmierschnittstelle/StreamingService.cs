using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace progrmmierschnittstelle
{
    class StreamingService
    {
        public static int Anzahl { get; set; }
        public static int StreamingServiceMin = 1;

        public static int CountStreamingService()
        {
            int count = 1;
            using (var connection = new MySqlConnection(Helper.Connection))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT COUNT(id) FROM streamingService", connection);
                count = int.Parse(command.ExecuteScalar().ToString());
            }
            return count;
        }


        /// <summary>
        /// Anzahl der id's von der Datenbank.
        /// </summary>
        /// <returns></returns>
        public static List<int> GetStreamingservice()
        {
            var dt = new DataTable();

            using (var con = new MySqlConnection(Helper.Connection))
            {
                con.Open();
                var cmd = new MySqlCommand("SELECT id FROM streamingService", con);
                var sa = new MySqlDataAdapter(cmd);
                sa.Fill(dt);
            }

            List<int> list = (from row in dt.AsEnumerable() select Convert.ToInt32(row["id"])).ToList();

            return list;
        }

    }
}
