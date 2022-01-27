using System;
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


        //Bouton consultation des données
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La consultation des liscences n'est pas disponible");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acceuil_Load(object sender, EventArgs e)
        {

        }
    }
}
