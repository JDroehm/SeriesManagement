using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace progrmmierschnittstelle
{
    class Actor
    {

        public static int Anzahl { get; set; }
        public static int AcrtorMin = 15;
        public static int ActorMax = 30;
        public string Surname { get; set; }
        public string Lastname { get; set; }



        /// <summary>
        /// Daten werden von anderen speicher orten zugewiesen
        /// </summary>
        /// <param name="surname">vorname</param>
        /// <param name="lastname">nachname</param>
        public Actor(string surname, string lastname)
        {
            Surname = surname;
            Lastname = lastname;
        }




        /// <summary>
        /// acor wird in eine daten tabelle eingefügt
        /// </summary>
        /// <returns></returns>
         public static DataTable GetActors()
        {
            var dt = new DataTable();

            using (var con = new MySqlConnection(Helper.Connection))
            {
                con.Open();
                var cmd = new MySqlCommand("SELECT * FROM actor", con);
                var sa = new MySqlDataAdapter(cmd);
                sa.Fill(dt);
            }

            return dt;
        }



        /// <summary>
        /// acort wird in eine liste eingefügt
        /// </summary>
        /// <returns></returns>
        public static List<Actor> GetActorList()
        {
            var actorList = new List<Actor>();

            using (var con = new MySqlConnection(Helper.Connection))
            {
                con.Open();
                var cmd = new MySqlCommand("SELECT * FROM DbSeries.actor", con);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var a = new Actor(reader[1].ToString(), reader[2].ToString());
                        actorList.Add(a);
                        reader.NextResult();
                    }   
                }
            }
            return actorList;


        }






        /// <summary>
        /// anzahl an schauchpieler wird gezählt
        /// </summary>
        /// <returns></returns>
        public static int CountActor()
        {
            int count = 1;
            using (var connection = new MySqlConnection(Helper.Connection))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT COUNT(id) FROM actor", connection);
                count = int.Parse(command.ExecuteScalar().ToString());
            }
            return count;
        }
    } 
}

