﻿using System;
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
    public partial class Frm_GestionMembre_CS : Form
    {
        public Frm_GestionMembre_CS()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Grid_Membre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ligne = e.RowIndex;
            lbl_NumLiscence.Text = Grid_Membre.Rows[ligne].Cells[0].Value.ToString();
            lbl_NumClub.Text = Grid_Membre.Rows[ligne].Cells[1].Value.ToString();
            lbl_NomMembre.Text = Grid_Membre.Rows[ligne].Cells[2].Value.ToString();
            lbl_PrenomMembre.Text = Grid_Membre.Rows[ligne].Cells[3].Value.ToString();
            lbl_DateNaissance.Text = Grid_Membre.Rows[ligne].Cells[4].Value.ToString();
            lbl_AdresseMembre.Text = Grid_Membre.Rows[ligne].Cells[5].Value.ToString();
            lbl_CodePostal.Text = Grid_Membre.Rows[ligne].Cells[6].Value.ToString();
            lbl_VilleMembre.Text = Grid_Membre.Rows[ligne].Cells[7].Value.ToString();
        }

        private void lbl_NumLiscence_Click(object sender, EventArgs e)
        {

        }

        private void lbl_NomMembre_Click(object sender, EventArgs e)
        {

        }

        private void lbl_PrenomMembre_Click(object sender, EventArgs e)
        {

        }

        private void lbl_DateNaissance_Click(object sender, EventArgs e)
        {

        }

        private void lbl_AdresseMembre_Click(object sender, EventArgs e)
        {

        }

        private void lbl_CodePostal_Click(object sender, EventArgs e)
        {

        }

        private void lbl_VilleMembre_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {

        }

        private void Frm_GestionMembre_CS_Load(object sender, EventArgs e)
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
        }
    }
}
