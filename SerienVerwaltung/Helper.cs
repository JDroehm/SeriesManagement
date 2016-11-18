using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace SerienVerwaltung
{
    class Helper
    {
        public static string Connection = ConfigurationManager.ConnectionStrings["dbSeries"].ConnectionString;

        public static DataTable GetSeries()
        {
            DataTable dt = new DataTable();

            using (var con = new MySqlConnection(Helper.Connection))
            {
                con.Open();
                var cmd = new MySqlCommand("SELECT s.id, s.name, i.description, i.dateOfPuplication  FROM DbSeries.series AS s INNER JOIN information AS i ON s.id  = i.id", con);
                var sa = new MySqlDataAdapter(cmd);
                sa.Fill(dt);
            }
            return dt;
        }




        public static DataTable GetSeriesActor()
        {
            DataTable dt = new DataTable();

            using (var con = new MySqlConnection(Helper.Connection))
            {
                con.Open();
                var cmd = new MySqlCommand("SELECT a.surname, a.lastname FROM actor AS a INNER JOIN seriesHasActor AS sha ON a.id = sha.actorId INNER JOIN series AS s ON s.id = sha.seriesId", con);
                var sa = new MySqlDataAdapter(cmd);
                sa.Fill(dt);
            }
            return dt;
        }

        public static DataTable GetSeriesProducer()
        {
            DataTable dt = new DataTable();

            using (var con = new MySqlConnection(Helper.Connection))
            {
                con.Open();
                var cmd = new MySqlCommand("SELECT s.name, a.surname, a.lastname FROM producer AS a INNER JOIN seriesHasProducer AS sha ON a.id = sha.producerId INNER JOIN series AS s ON s.id = sha.seriesId", con);
                var sa = new MySqlDataAdapter(cmd);
                sa.Fill(dt);
            }
            return dt;
        }

        public static DataTable GetStreamingService()
        {
            DataTable dt = new DataTable();

            using (var con = new MySqlConnection(Helper.Connection))
            {
                con.Open();
                var cmd = new MySqlCommand("SELECT stream.name, s.name FROM streamingService AS stream INNER JOIN seriesHasStreamService AS shss ON stream.id = shss.streamId INNER JOIN series AS s ON shss.seriesId = s.id", con);
                var sa = new MySqlDataAdapter(cmd);
                sa.Fill(dt);
            }
            return dt;
        }


        public static DataTable GetGenreSeries()
        {
            DataTable dt = new DataTable();

            using (var con = new MySqlConnection(Helper.Connection))
            {
                con.Open();
                var cmd = new MySqlCommand("SELECT g.bezeichnung, s.name FROM genre AS g INNER JOIN seriesHasGenre AS sHG ON g.id = sHG.genreId INNER JOIN series AS s ON sHG.seriesId = s.id", con);
                var sa = new MySqlDataAdapter(cmd);
                sa.Fill(dt);
            }
            return dt;
        }


        public static DataTable GetGenre()
        {
            DataTable dt = new DataTable();

            using (var con = new MySqlConnection(Helper.Connection))
            {
                con.Open();
                var cmd = new MySqlCommand("SELECT id, bezeichnung FROM genre", con);
                var sa = new MySqlDataAdapter(cmd);
                sa.Fill(dt);
            }
            return dt;
        }



        public static DataTable GetActor()
        {
            DataTable dt = new DataTable();

            using (var con = new MySqlConnection(Helper.Connection))
            {
                con.Open();
                var cmd = new MySqlCommand("SELECT CONCAT_WS(',',lastname, surname) AS name FROM actor", con);
                var sa = new MySqlDataAdapter(cmd);
                sa.Fill(dt);
            }
            return dt;
        }


        public static DataTable GetStreamService()
        {
            DataTable dt = new DataTable();

            using (var con = new MySqlConnection(Helper.Connection))
            {
                con.Open();
                var cmd = new MySqlCommand("SELECT id, name FROM streamingService", con);
                var sa = new MySqlDataAdapter(cmd);
                sa.Fill(dt);
            }
            return dt;
        }


        public static DataTable GetProducer()
        {
            DataTable dt = new DataTable();

            using (var con = new MySqlConnection(Helper.Connection))
            {
                con.Open();
                var cmd = new MySqlCommand("SELECT concat_ws(',',lastname, surname) AS name FROM producer", con);
                var sa = new MySqlDataAdapter(cmd);
                sa.Fill(dt);
            }
            return dt;
        }

        public static void InsertSeriesGenreStream (string insertGenreStream, string insertName, string seriesName)
        {
            using (var con = new MySqlConnection(Helper.Connection))
            {
                con.Open();
                var cmd = new MySqlCommand("INSERT INTO @name (@insertName) VALUES (@value)", con);
                cmd.Parameters.AddWithValue("@insertName", insertName);
                cmd.Parameters.AddWithValue("@name", seriesName);
                cmd.Parameters.AddWithValue("@value", insertGenreStream);
                var sa = new MySqlDataAdapter(cmd);
                
            }
        }


        public static void InsertSeriesActorProducer(string eingabe, string seriesName)
        {
            char delimeter = ' ';
            string[] substring = eingabe.Split(delimeter);
            using (var con = new MySqlConnection(Helper.Connection))
            {
                con.Open();
                var cmd = new MySqlCommand("INSERT INTO @name (surname, lastname) VALUES (@surname, @lastname)", con);
                cmd.Parameters.AddWithValue("@name", seriesName);
                cmd.Parameters.AddWithValue("@surname", substring[1]);
                cmd.Parameters.AddWithValue("@lastname", substring[0]);
                var sa = new MySqlDataAdapter(cmd);

            }
        }

    }
}
