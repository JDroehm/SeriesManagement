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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadSeries_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Hinzufügen frmSeries = new Hinzufügen();
            frmSeries.Show();
        }

        private void seriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridTable.DataSource = Helper.GetSeries();
        }

        private void actorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridTable.DataSource = Helper.GetActor();
        }
        private void producerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridTable.DataSource = Helper.GetProducer();
        }

        private void streamingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridTable.DataSource = Helper.GetStreamingService();
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridTable.DataSource = Helper.GetGenreSeries();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete frmSeries = new Delete();
            frmSeries.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Neue_Serie frmSeries = new Neue_Serie();
            frmSeries.Show();
        }
    }
}
