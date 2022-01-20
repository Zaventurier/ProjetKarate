using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PROJET_PPE2._1_KARATE
{
    public partial class Frm_GestionMembre_M : Form
    {
        public Frm_GestionMembre_M()
        {
            InitializeComponent();
        }

        private void Txt_Recherche_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cmd_Recherche_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = connexion.ConnectionBD();
            conn.Open();
            string req = "";
            MySqlCommand cmd = new MySqlCommand(req, conn);
            conn.Close();
        }
    }
}
