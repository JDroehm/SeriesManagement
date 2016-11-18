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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(Helper.Connection))
            {
                con.Open();
                var cmd = new MySqlCommand(string.Format("DELETE FROM {0} WHERE id = {1}", txtbTableName.Text, txtbID.Text), con);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
