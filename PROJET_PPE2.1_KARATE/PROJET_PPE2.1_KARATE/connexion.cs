namespace PROJET_PPE2._1_KARATE
{
    class connexion
    {
        public static MySqlConnection ConnectionBD()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=localhost; DATABASE=karaté; UID=root; PASSWORD=root";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
    }
}
