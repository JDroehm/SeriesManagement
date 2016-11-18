using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace progrmmierschnittstelle
{
    class Producer
    {
        public static int Anzahl { get; set; }
        public static int ProducerMin = 1;
        public static int ProducerMax = 3;

        /// <summary>
        /// Producer werden in einen Daten Tabelle eingefügt
        /// </summary>
        /// <returns></returns>
        public static List<int> GetProducer()
        {
            var dt = new DataTable();

            using (var con = new MySqlConnection(Helper.Connection))
            {
                con.Open();
                var cmd = new MySqlCommand("SELECT id FROM producer", con);
                var sa = new MySqlDataAdapter(cmd);
                sa.Fill(dt);
            }

            List<int> list = (from row in dt.AsEnumerable() select Convert.ToInt32(row["id"])).ToList();

            return list;
        }


        /// <summary>
        /// Producer wird gezählt
        /// </summary>
        /// <returns></returns>
        public static int CountProducer()
        {
            int count = 1;
            using (var connection = new MySqlConnection(Helper.Connection))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT COUNT(id) FROM producer", connection);
                count = int.Parse(command.ExecuteScalar().ToString());
            }
            return count;
        }
    }
}
