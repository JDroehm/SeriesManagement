using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerienVerwaltung
{
    public partial class Hinzufügen : Form
    {
        
        public Hinzufügen()
        {
            InitializeComponent();
        }
        
        //private void Hinzufügen_Load(object sender, EventArgs e)
        //{

        //}

        //private void acceptSeries_Click(object sender, EventArgs e)
        //{
        //    using (var con = new MySqlConnection(Helper.Connection))
        //    {
        //        con.Open();
        //        var cmd = new MySqlCommand("INSERT INTO series (name) VALUES (@seriesName)", con);
        //        cmd.Parameters.AddWithValue("@seriesName", txtbSeriesName.Text);
        //        cmd.ExecuteNonQuery();
        //    }
        //}

        //private void acceptGenre_Click(object sender, EventArgs e)
        //{
        //    using (var con = new MySqlConnection(Helper.Connection))
        //    {
        //        con.Open();
        //        var cmd = new MySqlCommand("INSERT INTO genre (bezeichnung) VALUES (@genreName)", con);
        //        cmd.Parameters.AddWithValue("@genreName", txtbGenreName.Text);
        //        cmd.ExecuteNonQuery();
        //    }
        //}

        //private void acceptStream_Click(object sender, EventArgs e)
        //{
        //    using (var con = new MySqlConnection(Helper.Connection))
        //    {
        //        con.Open();
        //        var cmd = new MySqlCommand("INSERT INTO streamingService (name) VALUES (@streamName)", con);
        //        cmd.Parameters.AddWithValue("@streamName", txtbStreamingName.Text);
        //        cmd.ExecuteNonQuery();
        //    }
        //}

        //private void acceptProducer_Click(object sender, EventArgs e)
        //{
        //    using (var con = new MySqlConnection(Helper.Connection))
        //    {
        //        con.Open();
        //        var cmd = new MySqlCommand("INSERT INTO producer (surname, lastname, birthday) VALUES (@surname, @lastname, @birthday)", con);
        //        cmd.Parameters.AddWithValue("@surname", txtbProducerName.Text);
        //        cmd.Parameters.AddWithValue("@lastname", txtbProducerLastname.Text);
        //        cmd.Parameters.AddWithValue("@birthday", dateProducer.Value);
        //        cmd.ExecuteNonQuery();
        //    }
        //}

        //private void einfügenActor_Click(object sender, EventArgs e)
        //{
        //    using (var con = new MySqlConnection(Helper.Connection))
        //    {
        //        con.Open();
        //        var cmd = new MySqlCommand("INSERT INTO actor (surname, lastname, birthday) VALUES (@surname, @lastname, @birthday)", con);
        //        cmd.Parameters.AddWithValue("@surname", txtbActorName.Text);
        //        cmd.Parameters.AddWithValue("@lastname", txtbActorLastname.Text);
        //        cmd.Parameters.AddWithValue("@birthday", dateActor.Value);
        //        cmd.ExecuteNonQuery();
        //    }
        //}

        //private void combstreamingDienst_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    combstreamingDienst.Items.Add("");
        //}

        //private void groupBox1_Enter(object sender, EventArgs e)
        //{

        //}
    }
}
