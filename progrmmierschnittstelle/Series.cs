using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace progrmmierschnittstelle
{
    public class Series
    {
        /// <summary>
        /// Klassen eingenschaften 
        /// </summary>
        public static DataTable SeriesFromDb = new DataTable();
        public static List<Series> SerienInformation = new List<Series>();
        public static int[][] SeriesHasProducer = new int[Series.CountSeries()][] ;
        public static int[][] SeriesHasStreamingService = new int[Series.CountSeries()][];
        public static int[][] SeriesHasGenre = new int[Series.CountSeries()][];
        public string id { get; set; }
        public string type { get; set; }
        public string title { get; set; }
        public string year { get; set; }
        public string description { get; set; }
        public string certificate { get; set; }
        public string duration { get; set; }
        public string released { get; set; }
        public string[] cast { get; set; }
        public string[] genres { get; set; }
        public string[] directors { get; set; }
        public string[] writers { get; set; }
        public string image { get; set; }
        public string text { get; set; }
        public string rating { get; set; }

        /// <summary>
        /// konstruktor erzeugt ein objekt von Series.
        /// </summary>
        public Series()
        {

        }


        /// <summary>
        /// dictionary wird gespeichert und kann zurück gegeben werden.
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, string> SerienLinkId ()
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            int anzahldictionary = d.Count;
            d.Add("tt0944947", "Game of thrones");
            d.Add("tt0411008", "Lost");
            d.Add("tt0903747", "Breaking bad");
            d.Add("tt0460649", "How i met you mother");
            d.Add("tt0285403", "Scrubs");
            d.Add("tt0182576", "Family guy");
            return d;
        }
        

        /// <summary>
        /// Serieninformation werden vom Webservice abgerufen. Zudem werden Serienobjekte erstellt.
        /// </summary>
        /// <param name="dic">Dictionary>dictionary Mit serien namen und Links zum aburufen der daten</param>
        public static void SerienInformationAbrufen(Dictionary<string, string> dic)
        {
            Series series = new Series();
            foreach (var item in dic.Keys)
            {
                try
                {
                    WebClient client = new WebClient();
                    string data = client.DownloadString("http://imdb.wemakesites.net/api/" + item);

                    var jObject = JObject.Parse(data);

                    var token = jObject["data"];

                    series = JsonConvert.DeserializeObject<Series>(jObject["data"].ToString());
                    series.title = dic[item];
                    SerienInformation.Add(series);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }



        /// <summary>
        /// serien namen werden in series tabellen eingefügt.
        /// </summary>
        /// <param name="d"></param>
        public static void InsertSeries(Dictionary<string, string> d)
        {
            using (var con = new MySqlConnection(Helper.Connection))
            {
                con.Open();
                var cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO series (name) VALUES (@serienName)";
                foreach (var item in d.Keys)
                {
                    string wert = d[item];
                    cmd.Parameters.AddWithValue("@serienName", wert);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }

                con.Close();
            }
        }


        /// <summary>
        /// Information Tabelle wird gefüllt
        /// </summary>
        public static void InsertInformation()
        {
            try
            {
                using (var con = new MySqlConnection(Helper.Connection))
                {
                    con.Open();
                    var cmd = new MySqlCommand();
                    cmd.Connection = con;
                    foreach (Series serie in SerienInformation)
                    {
                        cmd.CommandText = "INSERT INTO information (description, dateOfPuplication) Values (@informationB, @informationR)";
                        cmd.Parameters.AddWithValue("@informationB", serie.description);
                        cmd.Parameters.AddWithValue("@informationR", serie.released);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    con.Close();
                }
                Console.WriteLine("Fertig.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        /// <summary>
        /// Zählt die anzahl der Serien
        /// </summary>
        /// <returns></returns>
        public static int CountSeries()
        {
            int count = 1;
            using (var connection = new MySqlConnection(Helper.Connection))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT COUNT(id) FROM series", connection);
                count = int.Parse(command.ExecuteScalar().ToString());
            }
            return count;
        }


        /// <summary>
        /// Datentabelle wird mit serien gefüllt.
        /// </summary>
        /// <returns></returns>
        public static DataTable GetSeries()
        {
            var dt = new DataTable();


            using (var con = new MySqlConnection(Helper.Connection))
            {
                con.Open();
                var cmd = new MySqlCommand("SELECT * FROM series", con);
                var sa = new MySqlDataAdapter(cmd);
                sa.Fill(dt);
            }

            return dt;
        }





    }
}
