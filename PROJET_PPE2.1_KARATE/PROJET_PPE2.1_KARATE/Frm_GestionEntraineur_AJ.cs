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
    public partial class Frm_GestionEntraineur_AJ : Form
    {
        public Frm_GestionEntraineur_AJ()
        {
            InitializeComponent();
        }

        private void Cmd_Fermer_Click(object sender, EventArgs e)
        {
            //Environment.Exit(0);
            this.Close();
            acceuil frm = new acceuil();
            frm.Show();
        }
        //Zone de texte 
        private void Txt_Nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Prenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_DateNaissance_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_VilleNaissance_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cmd_Ajouter_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = connexion.ConnectionBD();
            conn.Open();
            string req = "INSERT INTO membre (NUM_LICENCE, NUM_CLUB, NOM_MEMBRE, PRENOM_MEMBRE, DATE_NAISSANCE, ADR_RUE_MEMBRE, CODE_POST_MEMBRE, ADR_VILLE_MEMBRE) VALUES (@TxtNumLicence, @TxtNumClub, @TxtNom, @TxtPrenom, @TxtDateNaissance, @TxtRueMembre, @TxtCodePostal, @TxtVilleNaissance)";
            MySqlCommand cmd = new MySqlCommand(req, conn);
            cmd.Parameters.AddWithValue("@TxtNumLicence", Txt_NumLicence.Text);
            cmd.Parameters.AddWithValue("@TxtNumClub", Txt_NumClub.Text);
            cmd.Parameters.AddWithValue("@TxtNom", Txt_Nom.Text);
            cmd.Parameters.AddWithValue("@TxtPrenom", Txt_Prenom.Text);
            cmd.Parameters.AddWithValue("@TxtDateNaissance", Txt_DateNaissance.Text);
            cmd.Parameters.AddWithValue("@TxtRueMembre", Txt_Adresse.Text);
            cmd.Parameters.AddWithValue("@TxtCodePostal", Txt_CodePostal.Text);
            cmd.Parameters.AddWithValue("@TxtVilleNaissance", Txt_VilleNaissance.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Membre ajouté avec succés", "Membre ajouté");
            Txt_NumLicence.Text = "";
            Txt_NumClub.Text = "";
            Txt_Nom.Text = "";
            Txt_Prenom.Text = "";
            Txt_DateNaissance.Text = "";
            Txt_Adresse.Text = "";
            Txt_CodePostal.Text = "";
            Txt_VilleNaissance.Text = "";
            Txt_VilleNaissance.Text = "";
            conn.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_GestionEntraineur_AJ_Load(object sender, EventArgs e)
        {
            Grid_Membre.Rows.Clear();
            MySqlConnection conn = connexion.ConnectionBD();
            conn.Open();
            string sql2 = "SELECT NUM_CLUB, NOM_CLUB from club";
            MySqlCommand cmd = new MySqlCommand(sql2, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string NUM_CLUB = reader["NUM_CLUB"].ToString();
                string NOM_CLUB = reader["NOM_CLUB"].ToString();
                Grid_Membre.Rows.Add(NUM_CLUB, NOM_CLUB);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ligne = e.RowIndex;
            Txt_NumClub.Text = Grid_Membre.Rows[ligne].Cells[0].Value.ToString();
        }
    }
}
