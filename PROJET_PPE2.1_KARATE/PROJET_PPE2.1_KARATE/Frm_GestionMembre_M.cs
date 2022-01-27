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
            //Grid_Membre.Rows.Clear();
            MySqlConnection conn = connexion.ConnectionBD();
            conn.Open();
            //Requête à revoir
            string req = "SELECT * FROM membre where NOM_MEMBRE = @NomMembre AND PRENOM_MEMBRE = @PrenomMembre";
            MySqlCommand cmd = new MySqlCommand(req, conn);
            cmd.Parameters.AddWithValue("@NomMembre", Txt_RechercheNom.Text);
            cmd.Parameters.AddWithValue("@PrenomMembre", Txt_RecherchePrenom.Text);
            //Va mettre les valeurs de la requête dans chaque TexteBox












            //Numéro de la Liscence
            Txt_NumLiscence.Text = "NUM_LISCENCE";
            //Numéro du club
            Txt_NumClub.Text = "NUM_CLUB";
            //Nom du membre
            Txt_Nom.Text = "@NomMembre";
            //Prénom du membre
            Txt_Prenom.Text = "@PrenomMembre";
            //Prénom du membre
            Txt_DateNaissance.Text = "DATE_NAISSANCE";
            //Date naissance membre
            Txt_Adresse.Text = "ADR_RUE_MEMBRE";
            //Adresse membre
            Txt_CodePostal.Text = "CODE_POST_MEMBRE";
            //Code postal membre
            Txt_Ville.Text = "ADR_VILLE_MEMBRE";


            //MySqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //string idQuestion = reader["NOM_MEMBRE"].ToString();
            //string nomQuestion = reader["PRENOM_MEMBRE"].ToString();
            //Grid_Membre.Rows.Add(idQuestion, nomQuestion);
            //}
            conn.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Grid_Membre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Txt_NumLiscence_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_NumClub_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Prenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_DateNaissance_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Adresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_CodePostal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Ville_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
