﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJET_PPE2._1_KARATE
{
    public partial class acceuil : Form
    {
        public acceuil()
        {
            InitializeComponent();
        }

        //Bouton ajouter
        private void Button1_Click(object sender, EventArgs e)
        {
            Frm_GestionEntraineur_AJ frm = new Frm_GestionEntraineur_AJ();
            frm.Show();

        }

        //Bouton modifier
        private void button4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("La modification est temporairement désactiver");
            Frm_GestionMembre_M frm = new Frm_GestionMembre_M();
            frm.Show();
        }


        //Bouton consultation des licences
        private void button2_Click(object sender, EventArgs e)
        {
            Frm_GestionMembre_CS frm = new Frm_GestionMembre_CS();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acceuil_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            
        }

        private void aJOUTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_GestionEntraineur_AJ aj = new Frm_GestionEntraineur_AJ();
            aj.ShowDialog();
        }

        private void mODIFIERSUPPRIMERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_GestionMembre_M ms = new Frm_GestionMembre_M();
            ms.ShowDialog();
        }

        private void cONSULTERLESLICENCESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_GestionMembre_CS cs = new Frm_GestionMembre_CS();
            cs.ShowDialog();
        }

        private void fERMERAPPLICATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
