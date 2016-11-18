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
    public partial class Neue_Serie : Form
    {
        public Neue_Serie()
        {
            InitializeComponent();

            combGenre.DataSource = Helper.GetGenre();
            combGenre.DisplayMember = "bezeichnung";
            combGenre.ValueMember = "id";

            combStreamingService.DataSource = Helper.GetStreamService();
            combStreamingService.DisplayMember = "name";
            combStreamingService.ValueMember = "id";

            combProducer.DataSource = Helper.GetProducer();
            combProducer.DisplayMember = "surname, lastname";
            combProducer.ValueMember = "name";
            
            

            combActor.DataSource = Helper.GetActor();
            combActor.DisplayMember = "surname, lastname";
            combActor.DisplayMember = "name";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listbGenre.Items.Add(combGenre.Text);
            listbActor.Items.Add(combActor.Text);
            listbStreamService.Items.Add(combStreamingService.Text);
            listbProducer.Items.Add(combProducer.Text);

        }

        private void insert_Click(object sender, EventArgs e)
        {
            string name = txtbName.Text;
            string insertGenre = listbGenre.Items[0].ToString();
            string insertActor = listbGenre.Items[0].ToString();
            string insertProducer = listbGenre.Items[0].ToString();
            string insertStrem = listbGenre.Items[0].ToString();

            Helper.InsertSeriesGenreStream(insertGenre, "bezeichnung",name);
            Helper.InsertSeriesGenreStream(insertStrem, "name", name);
            Helper.InsertSeriesActorProducer(insertActor, name);
            Helper.InsertSeriesActorProducer(insertProducer, name);





        }
    }
}
