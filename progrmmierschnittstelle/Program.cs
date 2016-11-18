using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MySql.Data.MySqlClient;
using System.Data;

namespace progrmmierschnittstelle
{
    class Program
    {
        static void Main(string[] args)
        {


            #region comment

            //var count = Actor.GetActorCount();
            //Actor.GetActors();
            //Actor.GetActorList();
            //Actor.Insert();
            //Actor.Anzahl = Helper.CountActor();
            //Producer.Anzahl = Helper.CountProducer();
            //Genres.Anzahl = Helper.CountGenre();
            //StreamingService.Anzahl = Helper.CountStreamingService();
            //Console.WriteLine("Möchten sie 1 = Die has-tabellen füllen?, 2 Die serien tabelle füllen oder 0 beenden");
            //int übergabe = int.Parse(Console.ReadLine());


            //Series.SerienInformationAbrufen(dic);
            //switch (übergabe)
            //{
            //    case 1:
            //        Series.SeriesHasProducer = Helper.GenerateId(Producer.ProducerMax, Producer.ProducerMin, Producer.Anzahl);
            //        Series.SeriesHasStreamingService = Helper.GenerateId(StreamingService.StreamingServiceMin, 1, StreamingService.Anzahl);
            //        Series.SeriesHasActor = Helper.GenerateId(Actor.ActorMax, Actor.AcrtorMin, Actor.Anzahl);
            //        Series.SeriesHasGenre = Helper.GenerateId(Genres.GenreMax, Genres.GenreMin, Genres.Anzahl);
            //        break;
            //    case 2:
            //        break;
            //    case 0:
            //        break;
            //}
            //Helper.Insert();

            //Helper.mehrdiArrayAusgeben(Series.SeriesHasGenre);

            //Series.InsertSeries(dic);
            //Series.InsertInformation();
            //Helper.Insert();
            //Series serie1 = new Series();

            //int zahl = 1;
            //foreach(var item in programmierschnittstelle.Fahrzeug.liste)
            //{
            //    Console.WriteLine("Fahrzeug {0} :{1}, {2}, {3}, {4}", zahl, item.Farbe, item.GefahreneKilometer, item.Kennzeichen, item.PS);
            //    zahl++;
            //}

            #endregion

            //var dic = Series.SerienLinkId();
            //Series.SerienInformationAbrufen(dic);

            //Helper.InsertSeriesAndActor(true);

            Series.SeriesFromDb = Series.GetSeries();

            var listGenre = Genres.GetGenre();
            var listProducer = Producer.GetProducer();
            var listStreamingService = StreamingService.GetStreamingservice();


            var dicProducer = Helper.GenerateIdForHasTable(Series.SeriesFromDb, 1, 3, listProducer);
            var dicGenre = Helper.GenerateIdForHasTable(Series.SeriesFromDb, 1, 3, listGenre);
            var dicStreamingService = Helper.GenerateIdForHasTable(Series.SeriesFromDb, 1, 3, listStreamingService);


            Helper.InsertHasTable(dicGenre, "seriesHasGenre", "seriesId", "genreId");
            Helper.InsertHasTable(dicProducer, "seriesHasProducer", "seriesId", "producerId");
            Helper.InsertHasTable(dicStreamingService, "seriesHasStreamService", "seriesId", "streamId");



            //int anzahlSerien = Series.CountSeries();
            //int numberOfSeries = Series.SeriesFromDb.Rows.Count;






































            //Series.SeriesHasGenre = Helper.GenerateIdHasTable(numberOfSeries, 1, 3);
            //Series.SeriesHasProducer = Helper.GenerateIdHasTable(numberOfSeries, 1, 1);
            //Series.SeriesHasStreamingService = Helper.GenerateIdHasTable(numberOfSeries, 1, 3);


            //Helper.ArrayEinfügen(Series.SeriesHasGenre);
            //Helper.ArrayEinfügen(Series.SeriesHasProducer);
            //Helper.ArrayEinfügen(Series.SeriesHasStreamingService);
























            Console.ReadKey();

            
            
            







            








        }
    }
}
