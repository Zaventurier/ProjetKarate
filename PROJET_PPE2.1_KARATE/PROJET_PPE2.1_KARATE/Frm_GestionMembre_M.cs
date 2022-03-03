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

        private void Frm_GestionMembre_M_Load(object sender, EventArgs e)
        {
            Grid_Membre.Rows.Clear();
            MySqlConnection conn = connexion.ConnectionBD();
            conn.Open();
            string sql2 = "SELECT * FROM membre";
            MySqlCommand cmd = new MySqlCommand(sql2, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string NUM_LICENCE = reader["NUM_LICENCE"].ToString();
                string NUM_CLUB = reader["NUM_CLUB"].ToString();
                string NOM_MEMBRE = reader["NOM_MEMBRE"].ToString();
                string PRENOM_MEMBRE = reader["PRENOM_MEMBRE"].ToString();
                string DATE_NAISSANCE = reader["DATE_NAISSANCE"].ToString();
                string ADR_RUE_MEMBRE = reader["ADR_RUE_MEMBRE"].ToString();
                string CODE_POST_MEMBRE = reader["CODE_POST_MEMBRE"].ToString();
                string ADR_VILLE_MEMBRE = reader["ADR_VILLE_MEMBRE"].ToString();
                Grid_Membre.Rows.Add(NUM_LICENCE, NUM_CLUB, NOM_MEMBRE, PRENOM_MEMBRE, DATE_NAISSANCE, ADR_RUE_MEMBRE, CODE_POST_MEMBRE, ADR_VILLE_MEMBRE);
            }
            conn.Close();



            dataGridView1.Rows.Clear();
            MySqlConnection conn3 = connexion.ConnectionBD();
            conn3.Open();
            string sql3 = "SELECT NUM_CLUB, NOM_CLUB, ADR_VILLE_CLUB from club";
            MySqlCommand cmd2 = new MySqlCommand(sql3, conn3);
            MySqlDataReader reader1 = cmd2.ExecuteReader();
            while (reader1.Read())
            {
                string NUM_CLUB = reader1["NUM_CLUB"].ToString();
                string NOM_CLUB = reader1["NOM_CLUB"].ToString();
                string VILLE_CLUB = reader1["ADR_VILLE_CLUB"].ToString();
                dataGridView1.Rows.Add(NUM_CLUB, NOM_CLUB, VILLE_CLUB);
            }
            conn3.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ces lignes de codes permettent 
            int ligne = e.RowIndex;
            Txt_NumLiscence.Text = Grid_Membre.Rows[ligne].Cells[0].Value.ToString();
            Txt_NumClub.Text = Grid_Membre.Rows[ligne].Cells[1].Value.ToString(); 
            Txt_Nom.Text = Grid_Membre.Rows[ligne].Cells[2].Value.ToString(); 
            Txt_Prenom.Text = Grid_Membre.Rows[ligne].Cells[3].Value.ToString(); 
            Txt_DateNaissance.Text = Grid_Membre.Rows[ligne].Cells[4].Value.ToString();
            Txt_Adresse.Text = Grid_Membre.Rows[ligne].Cells[5].Value.ToString(); 
            Txt_CodePostal.Text = Grid_Membre.Rows[ligne].Cells[6].Value.ToString(); 
            Txt_Ville.Text = Grid_Membre.Rows[ligne].Cells[7].Value.ToString();

            //MessageBox.Show("TEST", Grid_Membre.Rows[1].Cells[1].Value.ToString());
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {

        }

        //Bouton modifier
        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn2 = connexion.ConnectionBD();
            conn2.Open();
            string req2 = "UPDATE membre SET NUM_CLUB = @NumClub, NOM_MEMBRE = @NomMembre, PRENOM_MEMBRE = @PrenomMembre, DATE_NAISSANCE = @DateNaissance, ADR_RUE_MEMBRE = @AdresseMembre, CODE_POST_MEMBRE = @CodePostal, ADR_VILLE_MEMBRE = @VilleMembre where NUM_LICENCE = @NumLicence ";
            MySqlCommand cmd = new MySqlCommand(req2, conn2);
            cmd.Parameters.AddWithValue("@NumLicence", Txt_NumLiscence.Text);
            cmd.Parameters.AddWithValue("@NumClub", Txt_NumClub.Text);
            cmd.Parameters.AddWithValue("@NomMembre", Txt_Nom.Text);
            cmd.Parameters.AddWithValue("@PrenomMembre", Txt_Prenom.Text);
            cmd.Parameters.AddWithValue("@DateNaissance", Txt_DateNaissance.Text);
            cmd.Parameters.AddWithValue("@AdresseMembre", Txt_Adresse.Text);
            cmd.Parameters.AddWithValue("@CodePostal", Txt_CodePostal.Text);
            cmd.Parameters.AddWithValue("@VilleMembre", Txt_Ville.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Modification effectué avec succés !", "Modification");
            Txt_NumLiscence.Text = "";
            Txt_NumClub.Text = "";
            Txt_Nom.Text = "";
            Txt_Prenom.Text = "";
            Txt_DateNaissance.Text = "";
            Txt_Adresse.Text = "";
            Txt_CodePostal.Text = "";
            Txt_Ville.Text = "";
            conn2.Close();


            Grid_Membre.Rows.Clear();
            MySqlConnection conn = connexion.ConnectionBD();
            conn.Open();
            string sql2 = "SELECT * FROM membre";
            MySqlCommand cmd1 = new MySqlCommand(sql2, conn);
            MySqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                string NUM_LICENCE = reader["NUM_LICENCE"].ToString();
                string NUM_CLUB = reader["NUM_CLUB"].ToString();
                string NOM_MEMBRE = reader["NOM_MEMBRE"].ToString();
                string PRENOM_MEMBRE = reader["PRENOM_MEMBRE"].ToString();
                string DATE_NAISSANCE = reader["DATE_NAISSANCE"].ToString();
                string ADR_RUE_MEMBRE = reader["ADR_RUE_MEMBRE"].ToString();
                string CODE_POST_MEMBRE = reader["CODE_POST_MEMBRE"].ToString();
                string ADR_VILLE_MEMBRE = reader["ADR_VILLE_MEMBRE"].ToString();
                Grid_Membre.Rows.Add(NUM_LICENCE, NUM_CLUB, NOM_MEMBRE, PRENOM_MEMBRE, DATE_NAISSANCE, ADR_RUE_MEMBRE, CODE_POST_MEMBRE, ADR_VILLE_MEMBRE);
            }
            conn.Close();

        }

        //Bouton supprimer
        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn3 = connexion.ConnectionBD();
            conn3.Open();
            string req4 = "Select * from inscription where NUM_LICENCE = @NumLicence";
            MySqlCommand cmd = new MySqlCommand(req4, conn3);
            cmd.Parameters.AddWithValue("@NumLicence", Txt_NumLiscence.Text);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()== true)
            {
                MessageBox.Show("Erreur : membre déjà inscrit !", "Erreur suppression");
                return;
            }
            conn3.Close();
            conn3.Open();
            string req3 = "Delete from membre where NUM_LICENCE = @NumLicence";
            MySqlCommand cmd1 = new MySqlCommand(req3, conn3);
            cmd1.Parameters.AddWithValue("@NumLicence", Txt_NumLiscence.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("La suppresion à été effectué avec succés !", "Suppresion");
            Txt_NumLiscence.Text = "";
            Txt_NumClub.Text = "";
            Txt_Nom.Text = "";
            Txt_Prenom.Text = "";
            Txt_DateNaissance.Text = "";
            Txt_Adresse.Text = "";
            Txt_CodePostal.Text = "";
            Txt_Ville.Text = "";
            conn3.Close();

            Grid_Membre.Rows.Clear();
            MySqlConnection conn = connexion.ConnectionBD();
            conn.Open();
            string sql2 = "SELECT * FROM membre";
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
            MySqlDataReader reader1 = cmd2.ExecuteReader();
            while (reader1.Read())
            {
                string NUM_LICENCE = reader1["NUM_LICENCE"].ToString();
                string NUM_CLUB = reader1["NUM_CLUB"].ToString();
                string NOM_MEMBRE = reader1["NOM_MEMBRE"].ToString();
                string PRENOM_MEMBRE = reader1["PRENOM_MEMBRE"].ToString();
                string DATE_NAISSANCE = reader1["DATE_NAISSANCE"].ToString();
                string ADR_RUE_MEMBRE = reader1["ADR_RUE_MEMBRE"].ToString();
                string CODE_POST_MEMBRE = reader1["CODE_POST_MEMBRE"].ToString();
                string ADR_VILLE_MEMBRE = reader1["ADR_VILLE_MEMBRE"].ToString();
                Grid_Membre.Rows.Add(NUM_LICENCE, NUM_CLUB, NOM_MEMBRE, PRENOM_MEMBRE, DATE_NAISSANCE, ADR_RUE_MEMBRE, CODE_POST_MEMBRE, ADR_VILLE_MEMBRE);
            }
            conn.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int ligne = e.RowIndex;
            Txt_NumClub.Text = dataGridView1.Rows[ligne].Cells[0].Value.ToString();
        }
    }
    }
