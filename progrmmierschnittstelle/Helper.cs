using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace progrmmierschnittstelle
{
    public class Helper
    {
        /// <summary>
        /// Verbindung zum internet für den Webservice
        /// </summary>
        public static string Connection = ConfigurationManager.ConnectionStrings["dbSeries"].ConnectionString;


        /// <summary>
        /// Has Tabellen werden durch eine zufallszahl generiert und als dictionary zurück gegeben.
        /// </summary>
        /// <param name="dtSeries">Datatable mit serieninhalten aus Datenbank</param>
        /// <param name="min">Mimimal anzahl der Wiederholungen</param>
        /// <param name="max">Maximal anzahl der wiederholungen</param>
        /// <param name="list">Liste wird verwendet damit wert nicht merfach vorkommt</param>
        /// <returns></returns>
        public static Dictionary<int, int[]> GenerateIdForHasTable(DataTable dtSeries, int min, int max, List<int> list)
        {
            int numberOfSeries = dtSeries.Rows.Count;
            var dictionary = new Dictionary<int, int[]>();

            Random random = new Random();
           
            foreach (DataRow item in Series.SeriesFromDb.Rows)
            {

                var templist = list.ToList();

              

                Dictionary<int, int> überprüfen = new Dictionary<int, int>();
                var seriesId = int.Parse(item["id"].ToString());
                int repetition = random.Next(min, max);
                var elements = new int[repetition];
                
                for (int x = 0; x < repetition; x++)
                {
                    int insertIndex = random.Next(1, templist.Count -1);
                    elements[x] = templist[insertIndex];

                  templist.RemoveAt(insertIndex);
                }

                dictionary[seriesId] = elements;

            }
            return dictionary;
        }




        /// <summary>
        /// Der schauspieler wird in die Tabelle cast eingefügt (name, nachanme)
        /// </summary>
        public static void Insert()
        {
            try
            {
                using (var con = new MySqlConnection(Helper.Connection))
                {
                    con.Open();
                    Series item = new Series();
                    var cast = item.cast;
                    var title = item.title;
                    var cmd = new MySqlCommand();
                    cmd.Connection = con;
                    for (int i = 0; i < title.Length; i++)
                    {
                        for (int j = 0; j < cast.Length; j++)
                        {
                            string cast1 = cast[j];
                            string[] surLastname = cast1.Split(' ');
                            cmd.Parameters.AddWithValue("@name", surLastname[0]);
                            cmd.Parameters.AddWithValue("@nachname", Series.SerienInformation);
                            cmd.CommandText = "INSERT INTO actor (surname, lastname) VALUES (@name, @nachname)";

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }



        /// <summary>
        /// in dieser Methode werden serien und actor in die tabellen eingefügt.
        /// </summary>
        /// <param name="delete">ein bool wert wird übergeben und wenn er true ist werden actor, series und series has actor gelöscht</param>
        public static void InsertSeriesAndActor(bool delete)
        {

            using (var con = new MySqlConnection(Helper.Connection))
            {
                con.Open();
                var cmd = new MySqlCommand();
                cmd.Connection = con;

                if (delete == true)
                {
                    cmd.CommandText = "DELETE FROM actor";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "DELETE FROM series";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "DELETE FROM seriesHasActor";
                    cmd.ExecuteNonQuery();
                }

                foreach (var item in Series.SerienInformation)
                {
                    cmd.CommandText = "INSERT INTO series (name) VALUES (@title)";
                    cmd.Parameters.AddWithValue("@title", item.title);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();


                    cmd.CommandText = "SELECT LAST_INSERT_ID()";
                    int lastID = int.Parse(cmd.ExecuteScalar().ToString());


                    string[] namen = item.cast;
                    for (int i = 0; i < namen.Length; i++)
                    {
                        string[] vorNachname = namen[i].Split(' ');

                        cmd.CommandText = "SELECT LAST_INSERT_ID()";
                        int lastIDActo = int.Parse(cmd.ExecuteScalar().ToString());

                        cmd.CommandText = "INSERT INTO actor (surname, lastname) VALUES (@name, @nachname)";
                        cmd.Parameters.AddWithValue("@name", vorNachname[0]);
                        cmd.Parameters.AddWithValue("@nachname", vorNachname[1]);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();




                        cmd.CommandText = "INSERT INTO seriesHasActor (seriesId, actorId) Values (@seriesID, @actorID)";
                        cmd.Parameters.AddWithValue("@seriesID", lastID);
                        cmd.Parameters.AddWithValue("@actorID", lastIDActo);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                    }

                }


            }
        }



        /// <summary>
        /// (Kleine übung) ich sollte ein mehrdimensionales array ausgeben.
        /// </summary>
        /// <param name="SeriesHasGenre">mehrdimensionales array das augegeben wird.</param>
        /// <returns></returns>
        public static int mehrdiArrayAusgeben(int[][] SeriesHasGenre)
        {
            for (int i = 0; i < SeriesHasGenre.Length; i++)
            {
                for (int j = 0; j < SeriesHasGenre[i].Length; j++)
                {
                    int spaltenzahl = SeriesHasGenre[i][j];
                    Console.Write("{0}, ", spaltenzahl);
                }
                Console.WriteLine("");
            }
            return 0;
        }


        /// <summary>
        /// Daten werden in die Has Tabellen eingefügt und übergeben.
        /// </summary>
        /// <param name="dic">Dictionary</param>
        /// <param name="tablename">tabellen name wo die daten aus dem dictionary eingefügt werden.</param>
        /// <param name="column">spalten name1</param>
        /// <param name="column2">spalten name2</param>
        public static void InsertHasTable(Dictionary<int, int[]> dic, string tablename, string column, string column2)
        {
            
            foreach (var hasId in dic.Keys)
            {
                
                foreach (var hasId2 in dic[hasId])
                {
                    
                    using (var con = new MySqlConnection(Helper.Connection))
                    {
                        con.Open();
                        var cmd = new MySqlCommand();
                        cmd.Connection = con;

                        
                        cmd.CommandText = string.Format("INSERT INTO {0} ({1}, {2}) VALUES (@hasId, @hasId2)", tablename, column, column2);
                        cmd.Parameters.AddWithValue("@hasId", hasId);
                        cmd.Parameters.AddWithValue("@hasid2", hasId2);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                }
            }
        }
    }
}
