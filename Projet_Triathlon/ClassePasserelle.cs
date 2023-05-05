using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Web;

namespace Projet_Triathlon
{
    public static class ClassePasserelle
    {
        private static SqlConnection connexionBaseTriathlon = new SqlConnection("Data Source=LAPTOP-AT6B1DPN; Initial Catalog=TriathlonDB; user Id=EntityTriathlon; password=21Sl@mM€rm0z23");

        /// <summary>
        /// Retourne tous les types de triathlon présent dans la base de données
        /// </summary>
        /// <returns>Collection de types de triathlon</returns>
        public static List<TypeTriathlon> GetLesTypesTriathlon()
        {
            List<TypeTriathlon> lesTypesTriathlon = new List<TypeTriathlon>();

            SqlCommand reqGetLesTypesTriathlon = new SqlCommand("SELECT codeTypeT, designation, nom, distanceCyclisme, distanceNatation, distanceCourse FROM TypeTriathlon;", connexionBaseTriathlon);

            try
            {
                connexionBaseTriathlon.Open();
                SqlDataReader readerLesTypesTriathlon = reqGetLesTypesTriathlon.ExecuteReader();
                while (readerLesTypesTriathlon.Read())
                {
                    int codeType = (int)readerLesTypesTriathlon[0];
                    string designation = readerLesTypesTriathlon[1].ToString();
                    string nom = readerLesTypesTriathlon[2].ToString();
                    int distanceCyclisme = (int)readerLesTypesTriathlon[3];
                    int distanceNatation = (int)readerLesTypesTriathlon[4];
                    int distanceCourse = (int)readerLesTypesTriathlon[5];

                    lesTypesTriathlon.Add(new TypeTriathlon(codeType, designation, nom, distanceCyclisme, distanceNatation, distanceCourse));
                }
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }

            return lesTypesTriathlon;
        }

        /// <summary>
        /// Retourne tous les produits dopants présent dans la base de données
        /// </summary>
        /// <returns>Collection de produits dopants</returns>
        public static List<ProdDopant> GetLesProduitsDop()
        {
            List<ProdDopant> lesProduitsDop = new List<ProdDopant>();

            SqlCommand reqGetLesProduitsDop = new SqlCommand("SELECT codeDop, libelle, tauxMax FROM ProdDopant;", connexionBaseTriathlon);

            try
            {
                connexionBaseTriathlon.Open();
                SqlDataReader readerLesProduitsDop = reqGetLesProduitsDop.ExecuteReader();
                while (readerLesProduitsDop.Read())
                {
                    int codeDop = (int)readerLesProduitsDop[0];
                    string libelle = readerLesProduitsDop[1].ToString();
                    double tauxMax = (double)readerLesProduitsDop[2];

                    lesProduitsDop.Add(new ProdDopant(codeDop, libelle, tauxMax));
                }
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }

            return lesProduitsDop;
        }

        /// <summary>
        /// Retourne tous les triathletes présent dans la base de données
        /// </summary>
        /// <returns>Collection de triathletes</returns>
        public static List<Triathlete> GetLesTriathletes()
        {
            List<Triathlete> lesTriathletes = new List<Triathlete>();

            SqlCommand reqGetLesTriathletes = new SqlCommand("SELECT numLicence, nom, prenom, adresse, cp, ville, dateNaissance FROM Triathlete;", connexionBaseTriathlon);

            try
            {
                connexionBaseTriathlon.Open();
                SqlDataReader readerLesTriathletes = reqGetLesTriathletes.ExecuteReader();

                while (readerLesTriathletes.Read())
                {
                    int numLicence = (int)readerLesTriathletes[0];
                    string nom = readerLesTriathletes[1].ToString();
                    string prenom = readerLesTriathletes[2].ToString();
                    string adresse = readerLesTriathletes[3].ToString();
                    int cp = (int)readerLesTriathletes[4];
                    string ville = readerLesTriathletes[5].ToString();
                    DateTime dateN = (DateTime)readerLesTriathletes[6];

                    lesTriathletes.Add(new Triathlete(numLicence, cp, nom, prenom, adresse, ville, dateN));
                }
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }

            return lesTriathletes;
        }

        /// <summary>
        /// Retourne toutes les inscriptions présente dans la base de données
        /// </summary>
        /// <returns>Collection d'inscription</returns>
        public static List<Inscription> GetLesInscriptions()
        {
            List<Inscription> lesInscriptions = new List<Inscription>();

            SqlCommand reqGetLesInscriptions = new SqlCommand("SELECT numTriath, numDossard, dateInscription, tempsNatation, tempsCourse, tempsCyclisme, numLicence FROM Inscription;", connexionBaseTriathlon);

            try
            {
                connexionBaseTriathlon.Open();
                SqlDataReader readerLesInscriptions = reqGetLesInscriptions.ExecuteReader();

                while (readerLesInscriptions.Read())
                {
                    int numTriath = (int)readerLesInscriptions[0];
                    int numDossard = (int)readerLesInscriptions[1];
                    DateTime dateI = (DateTime)readerLesInscriptions[2];
                    double tempsNat = (double)readerLesInscriptions[3];
                    double tempsCou = (double)readerLesInscriptions[4];
                    double tempsCycl = (double)readerLesInscriptions[5];
                    int numLicence = (int)readerLesInscriptions[6];

                    lesInscriptions.Add(new Inscription(numTriath, numDossard, numLicence, dateI, tempsNat, tempsCou, tempsCycl));
                }
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }

            return lesInscriptions;
        }

        /// <summary>
        /// Retourne tous les triathlons présent dans la base de données
        /// </summary>
        /// <returns>Collection de triathlons</returns>
        public static List<Triathlon> GetLesTriathlons()
        {
            List<Triathlon> lesTriathlons = new List<Triathlon>();

            SqlCommand reqGetLesTriathlons = new SqlCommand("SELECT numTriath, nom, lieu, dateCompet, codeTypeT FROM Triathlon;", connexionBaseTriathlon);

            try
            {
                connexionBaseTriathlon.Open();
                SqlDataReader readerLesTriathlons = reqGetLesTriathlons.ExecuteReader();

                while (readerLesTriathlons.Read())
                {
                    int numTriath = (int)readerLesTriathlons[0];
                    string nom = readerLesTriathlons[1].ToString();
                    string lieu = readerLesTriathlons[2].ToString();
                    DateTime dateC = (DateTime)readerLesTriathlons[3];
                    int codeTypeT = (int)readerLesTriathlons[4];

                    lesTriathlons.Add(new Triathlon(numTriath, nom, lieu, dateC, codeTypeT));
                }
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }

            return lesTriathlons;
        }

        /// <summary>
        /// Retourne tous les contrôles présent dans la base de données
        /// </summary>
        /// <returns>Collection de controles</returns>
        public static List<Controler> GetLesControles()
        {
            List<Controler> lesControles = new List<Controler>();

            SqlCommand reqGetLesControles = new SqlCommand("SELECT codeDop, numTriath, numDossard, mesureEtablie FROM Controler;", connexionBaseTriathlon);

            try
            {
                connexionBaseTriathlon.Open();
                SqlDataReader readerLesControles = reqGetLesControles.ExecuteReader();

                while (readerLesControles.Read())
                {
                    int codeDop = (int)readerLesControles[0];
                    int numTriath = (int)readerLesControles[1];
                    int numDoss = (int)readerLesControles[2];
                    double mesureE = (double)readerLesControles[3];

                    lesControles.Add(new Controler(codeDop, numTriath, numDoss, mesureE));
                }
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }

            return lesControles;
        }

        /// à tester
        /// <summary>
        /// Retourne le classement du triathlon passé en paramètre
        /// </summary>
        /// <param name="numTriath">Identifiant du triathlon pour lequel on souhaite obtenir le classement des triathletes</param>
        /// <returns>Collection de triathletes</returns>
        public static List<Triathlete> GetClassementTriathlete(int numTriath)
        {
            List<Triathlete> lesTriathletes = new List<Triathlete>();
            
            SqlCommand reqGetLeClassement = new SqlCommand("EXEC GetClassementByTriathlon @numT;", connexionBaseTriathlon);
            reqGetLeClassement.Parameters.AddWithValue("@numT", numTriath);

            try
            {
                connexionBaseTriathlon.Open();
                SqlDataReader readerLesTriathletes = reqGetLeClassement.ExecuteReader();

                while (readerLesTriathletes.Read())
                {
                    int numLicence = (int)readerLesTriathletes[0];
                    int numDossard = (int)readerLesTriathletes[1];
                    string nom = readerLesTriathletes[2].ToString();
                    string prenom = readerLesTriathletes[3].ToString();
                    double tempsCourse = (double)readerLesTriathletes[4];
                    double tempsCyclisme = (double)readerLesTriathletes[5];
                    double tempsNatation = (double)readerLesTriathletes[6];
                    double tempsTotal = (double)readerLesTriathletes[7];

                    lesTriathletes.Add(new Triathlete(numLicence, numDossard, nom, prenom, tempsCourse, tempsCyclisme, tempsNatation, tempsTotal));
                }
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }
            return lesTriathletes;
        }

        /// à voir si besoin
        /// <summary>
        /// Retourne tous les triathletes présent dans la base de données pour le triathlon passé en paramètre
        /// </summary>
        /// <param name="numTriath">Identifiant du triathlon pour lequel on souhaite obtenir les triathletes</param>
        /// <returns>Collection de triathletes</returns>
        public static List<Triathlete> GetLesTriathletesByTriathlon(int numTriath)
        {
            List<Triathlete> lesTriathletes = new List<Triathlete>();

            SqlCommand reqGetLesTriathletesByTriath = new SqlCommand("SELECT T.numLicence, nom, prenom, adresse, cp, ville, dateNaissance FROM Triathlete T Join Inscription I on I.numLicence = T.numLicence WHERE numTriath = @num;", connexionBaseTriathlon);

            reqGetLesTriathletesByTriath.Parameters.AddWithValue("@num", numTriath);

            try
            {
                connexionBaseTriathlon.Open();
                SqlDataReader readerLesTriathletes = reqGetLesTriathletesByTriath.ExecuteReader();

                while (readerLesTriathletes.Read())
                {
                    int numLicence = (int)readerLesTriathletes[0];
                    string nom = readerLesTriathletes[1].ToString();
                    string prenom = readerLesTriathletes[2].ToString();
                    string adresse = readerLesTriathletes[3].ToString();
                    int cp = (int)readerLesTriathletes[4];
                    string ville = readerLesTriathletes[5].ToString();
                    DateTime dateN = (DateTime)readerLesTriathletes[6];

                    lesTriathletes.Add(new Triathlete(numLicence, cp, nom, prenom, adresse, ville, dateN));
                }
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }

            return lesTriathletes;
        }

        /// <summary>
        /// Ajoute un nouveau produit dopant dans la base de données avec les valeurs passées en paramètre
        /// </summary>
        /// <param name="libelle">libelle du nouveau produit dopant</param>
        /// <param name="tauxMax">taux max du nouveau produit dopant</param>
        public static void AjouterProduitDop(string libelle, double tauxMax)
        {
            SqlCommand reqAjouterProduitDop = new SqlCommand("INSERT INTO ProdDopant (libelle, tauxMax) VALUES (@libelle, @tauxMax);", connexionBaseTriathlon);

            reqAjouterProduitDop.Parameters.AddWithValue("@libelle", libelle);
            reqAjouterProduitDop.Parameters.AddWithValue("@tauxMax", tauxMax);
            try
            {
                connexionBaseTriathlon.Open();
                reqAjouterProduitDop.ExecuteNonQuery();
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }
        }

        /// <summary>
        /// Ajoute un nouveau type de triathlon dans la base de données avec les valeurs passées en paramètre
        /// </summary>
        /// <param name="designation">designation du nouveau type de triathlon</param>
        /// <param name="nom">nom du nouveau type de triathlon</param>
        /// <param name="distanceCyclisme">distance cyclisme du nouveau type de triathlon</param>
        /// <param name="distanceNatation">distance natation du nouveau type de triathlon</param>
        /// <param name="distanceCourse">distance course du nouveau type de triathlon</param>
        public static void AjouterTypeTriathlon(string designation, string nom, int distanceCyclisme, int distanceNatation, int distanceCourse)
        {
            SqlCommand reqAjouterTypeTriathlon = new SqlCommand("INSERT INTO TypeTriathlon (designation, nom, distanceCyclisme, distanceNatation, distanceCourse) VALUES (@designation, @nom, @dCy, @dN, @dCo);", connexionBaseTriathlon);

            reqAjouterTypeTriathlon.Parameters.AddWithValue("@designation", designation);
            reqAjouterTypeTriathlon.Parameters.AddWithValue("@nom", nom);
            reqAjouterTypeTriathlon.Parameters.AddWithValue("@idCy", distanceCyclisme);
            reqAjouterTypeTriathlon.Parameters.AddWithValue("@idN", distanceNatation);
            reqAjouterTypeTriathlon.Parameters.AddWithValue("@idCo", distanceCourse);

            try
            {
                connexionBaseTriathlon.Open();
                reqAjouterTypeTriathlon.ExecuteNonQuery();
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }
        }

        /// <summary>
        /// Ajoute un nouveau triathlete dans la base de données avec les valeurs passées en paramètre
        /// </summary>
        /// <param name="nom">nom du nouveau triathlete</param>
        /// <param name="prenom">prenom du nouveau triathlete</param>
        /// <param name="adresse">adresse du nouveau triathlete</param>
        /// <param name="cp">code postale du nouveau triathlete</param>
        /// <param name="ville">ville du nouveau triathlete</param>
        /// <param name="dateNaissance">date de naissance du nouveau triathlete</param>
        public static void AjouterTriathlete(string nom, string prenom, string adresse, int cp, string ville, DateTime dateNaissance)
        {
            SqlCommand reqAjouterTriathlete = new SqlCommand("INSERT INTO Triathlete (nom, prenom, adresse, cp, ville, dateNaissance) VALUES (@nom, @prenom, @adresse, @cp, @ville, @dateN);", connexionBaseTriathlon);

            reqAjouterTriathlete.Parameters.AddWithValue("@nom", nom);
            reqAjouterTriathlete.Parameters.AddWithValue("@prenom", prenom);
            reqAjouterTriathlete.Parameters.AddWithValue("@adresse", adresse);
            reqAjouterTriathlete.Parameters.AddWithValue("@cp", cp);
            reqAjouterTriathlete.Parameters.AddWithValue("@ville", ville);
            reqAjouterTriathlete.Parameters.AddWithValue("@dateN", dateNaissance);

            try
            {
                connexionBaseTriathlon.Open();
                reqAjouterTriathlete.ExecuteNonQuery();
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }
        }

        /// <summary>
        /// Ajoute une nouvelle inscription dans la base de données avec les valeurs passées en paramètre
        /// </summary>
        /// <param name="numTriath">num triathlon de la nouvelle inscription</param>
        /// <param name="numLicence">num licence de la nouvelle inscription</param>
        /// <param name="dateInscription">date inscription de la nouvelle inscription</param>
        public static void AjouterInscription(int numTriath, int numLicence, DateTime dateInscription)
        {
            SqlCommand reqAjouterInscription = new SqlCommand("INSERT INTO Inscription (numTriath, numLicence, dateInscription) VALUES (@numT, @numL, @dateI);", connexionBaseTriathlon);

            reqAjouterInscription.Parameters.AddWithValue("@numT", numTriath);
            reqAjouterInscription.Parameters.AddWithValue("@numL", numLicence);
            reqAjouterInscription.Parameters.AddWithValue("@dateI", dateInscription);

            try
            {
                connexionBaseTriathlon.Open();
                reqAjouterInscription.ExecuteNonQuery();
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }
        }

        /// <summary>
        /// Ajoute un nouveau triathlon dans la base de données avec les valeurs passées en paramètre
        /// </summary>
        /// <param name="nom">nom triathlon du nouveau triathlon</param>
        /// <param name="lieu">lieu du nouveau triathlon</param>
        /// <param name="dateCompet">date competition du nouveau triathlon</param>
        /// <param name="codeTypeT">code du type de triathlon du nouveau triathlon</param>
        public static void AjouterTriathlon(string nom, string lieu, DateTime dateCompet, int codeTypeT)
        {
            SqlCommand reqAjouterTriathlon = new SqlCommand("INSERT INTO Triathlon (nom, lieu, dateCompet, codeTypeT) VALUES (@nom, @lieu, @dateC, @codeType);", connexionBaseTriathlon);

            reqAjouterTriathlon.Parameters.AddWithValue("@nom", nom);
            reqAjouterTriathlon.Parameters.AddWithValue("@lieu", lieu);
            reqAjouterTriathlon.Parameters.AddWithValue("@dateC", dateCompet);
            reqAjouterTriathlon.Parameters.AddWithValue("@codeType", codeTypeT);

            try
            {
                connexionBaseTriathlon.Open();
                reqAjouterTriathlon.ExecuteNonQuery();
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }
        }

        /// <summary>
        /// Ajoute un nouveau controle dans la base de données avec les valeurs passées en paramètre
        /// </summary>
        /// <param name="codeDop">code produit dopant du nouveau controle</param>
        /// <param name="numTriath">num triathlon du nouveau controle</param>
        /// <param name="numDossard">num dossard du nouveau controle</param>
        /// <param name="mesureEtablie">mesure etablie du nouveau controle</param>
        public static void AjouterControle(int codeDop, int numTriath, int numDossard, string mesureEtablie)
        {
            SqlCommand reqAjouterControle = new SqlCommand("INSERT INTO Controler (codeDop, numTriath, numDossard, mesureEtablie) VALUES (@codeD, @numT, @numD, @mesureE);", connexionBaseTriathlon);

            reqAjouterControle.Parameters.AddWithValue("@codeD", codeDop);
            reqAjouterControle.Parameters.AddWithValue("@numT", numTriath);
            reqAjouterControle.Parameters.AddWithValue("@numD", numDossard);
            reqAjouterControle.Parameters.AddWithValue("@mesureE", mesureEtablie);

            try
            {
                connexionBaseTriathlon.Open();
                reqAjouterControle.ExecuteNonQuery();
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }
        }


        /// A FAIRE
        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        public static void AjouterTemps()
        {

        }



        /// <summary>
        /// Modifie dans la base de données le produit dopant correspondant à l'identifiant avec les valeurs passées en paramètre
        /// </summary>
        /// <param name="codeDop">code du produit dopant à modifier</param>
        /// <param name="libelle">nouveau libelle du produit dopant</param>
        /// <param name="tauxMax">nouveau taux max du produit dopant</param>
        public static void ModifierProduitsDop(int codeDop, string libelle, double tauxMax)
        {
            SqlCommand reqModifierProduitsDop = new SqlCommand("UPDATE ProdDopant Set libelle = @libelle, tauxMax = @tauxMax WHERE codeDop = @code;", connexionBaseTriathlon);

            reqModifierProduitsDop.Parameters.AddWithValue("@libelle", libelle);
            reqModifierProduitsDop.Parameters.AddWithValue("@tauxMax", tauxMax);
            reqModifierProduitsDop.Parameters.AddWithValue("@code", codeDop);
            try
            {
                connexionBaseTriathlon.Open();
                reqModifierProduitsDop.ExecuteNonQuery();
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }
        }

        /// <summary>
        /// Modifie dans la base de données le type de triathlon correspondant à l'identifiant avec les valeurs passées en paramètre
        /// </summary>
        /// <param name="codeType">code du type de triathlon à modifier</param>
        /// <param name="designation">nouvelle designation du type de triathlon</param>
        /// <param name="nom">nouveau nom du type de triathlon</param>
        /// <param name="distanceCyclisme">nouvelle distance cyclisme du type de triathlon</param>
        /// <param name="distanceNatation">nouvelle distance natation du type de triathlon</param>
        /// <param name="DistanceCourse">nouvelle distance course du type de triathlon</param>
        public static void ModifierTypeTriathlon(int codeType, string designation, string nom, int distanceCyclisme, int distanceNatation, int DistanceCourse)
        {
            SqlCommand reqModifierTypeTriathlon = new SqlCommand("UPDATE TypeTriathlon Set designation = @desi, nom = @nom, distanceCyclisme = @dCy, distanceNatation = @dN, distanceCourse = @dCo WHERE codeTypeT = @code;", connexionBaseTriathlon);

            reqModifierTypeTriathlon.Parameters.AddWithValue("@desi", designation);
            reqModifierTypeTriathlon.Parameters.AddWithValue("@nom", nom);
            reqModifierTypeTriathlon.Parameters.AddWithValue("@dCy", distanceCyclisme);
            reqModifierTypeTriathlon.Parameters.AddWithValue("@dN", distanceNatation);
            reqModifierTypeTriathlon.Parameters.AddWithValue("@dCo", DistanceCourse);
            reqModifierTypeTriathlon.Parameters.AddWithValue("@code", codeType);
            try
            {
                connexionBaseTriathlon.Open();
                reqModifierTypeTriathlon.ExecuteNonQuery();
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }
        }

        /// <summary>
        /// Modifie dans la base de données le triathlete correspondant à l'identifiant avec les valeurs passées en paramètre
        /// </summary>
        /// <param name="numLicence">num licence du triathlete à modifier</param>
        /// <param name="nom">nouveau nom du triathlete</param>
        /// <param name="prenom">nouveau prenom du triathlete</param>
        /// <param name="adresse">nouvelle adresse du triathlete</param>
        /// <param name="cp">nouveau code postale du triathlete</param>
        /// <param name="ville">nouvelle ville du triathlete</param>
        /// <param name="dateNaissance">nouvelle date de naissance du triathlete</param>
        public static void ModifierTriathlete(int numLicence, string nom, string prenom, string adresse, int cp, string ville, DateTime dateNaissance)
        {
            SqlCommand reqModifierTriathlete = new SqlCommand("UPDATE Triathlete Set nom = @nom, prenom = @prenom, adresse = @adresse, cp = @cp, ville = @ville, dateNaissance = @dateN WHERE numLicence = @num;", connexionBaseTriathlon);

            reqModifierTriathlete.Parameters.AddWithValue("@nom", nom);
            reqModifierTriathlete.Parameters.AddWithValue("@prenom", prenom);
            reqModifierTriathlete.Parameters.AddWithValue("@adresse", adresse);
            reqModifierTriathlete.Parameters.AddWithValue("@cp", cp);
            reqModifierTriathlete.Parameters.AddWithValue("@ville", ville);
            reqModifierTriathlete.Parameters.AddWithValue("@dateN", dateNaissance);
            reqModifierTriathlete.Parameters.AddWithValue("@num", numLicence);
            try
            {
                connexionBaseTriathlon.Open();
                reqModifierTriathlete.ExecuteNonQuery();
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }
        }

        /// <summary>
        /// Modifie dans la base de données le triathlon correspondant à l'identifiant avec les valeurs passées en paramètre
        /// </summary>
        /// <param name="numTriath">num du triathlon à modifier</param>
        /// <param name="nom">nouveau nom du triathlon</param>
        /// <param name="lieu">nouveau lieu du triathlon</param>
        /// <param name="dateCompet">nouvelle date de competition du triathlon</param>
        /// <param name="codeType">nouveau code type de triathlon du triathlon</param>
        public static void ModifierTriathlon(int numTriath, string nom, string lieu, DateTime dateCompet, int codeType)
        {
            SqlCommand reqModifierTriathlon = new SqlCommand("UPDATE Triathlon Set nom = @nom, lieu = @lieu, dateCompet = @dateC, codeTypeT = @codeType WHERE numTriath = @num;", connexionBaseTriathlon);

            reqModifierTriathlon.Parameters.AddWithValue("@nom", nom);
            reqModifierTriathlon.Parameters.AddWithValue("@lieu", lieu);
            reqModifierTriathlon.Parameters.AddWithValue("@dateC", dateCompet);
            reqModifierTriathlon.Parameters.AddWithValue("@codeType", codeType);
            reqModifierTriathlon.Parameters.AddWithValue("@num", numTriath);
            try
            {
                connexionBaseTriathlon.Open();
                reqModifierTriathlon.ExecuteNonQuery();
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }
        }

        /// <summary>
        /// Modifie dans la base de données le temps d'un triathlète correspondant à l'identifiant avec les valeurs passées en paramètre
        /// </summary>
        /// <param name="numTriath">num du triathlon de l'inscription à modifier</param>
        /// <param name="numDossard">num du dossard de l'inscription à modifier</param>
        /// <param name="tempsNatation">nouveau temps natation du triathlete inscrit</param>
        /// <param name="tempsCourse">nouveau temps course du triathlete inscrit</param>
        /// <param name="tempsCyclisme">nouveau temps cyclisme du triathlete inscrit</param>
        public static void ModifierTemps(int numTriath, int numDossard, double tempsNatation, double tempsCourse, double tempsCyclisme)
        {
            SqlCommand reqModifierTemps = new SqlCommand("UPDATE Inscription Set tempsNatation = @tN, tempsCourse = @tCo, tempsCyclisme = @tCy WHERE numTriath = @numT and numDossard = @numD;", connexionBaseTriathlon);

            reqModifierTemps.Parameters.AddWithValue("@tN", tempsNatation);
            reqModifierTemps.Parameters.AddWithValue("@tCo", tempsCourse);
            reqModifierTemps.Parameters.AddWithValue("@tCy", tempsCyclisme);
            reqModifierTemps.Parameters.AddWithValue("@numD", numDossard);
            reqModifierTemps.Parameters.AddWithValue("@numT", numTriath);
            try
            {
                connexionBaseTriathlon.Open();
                reqModifierTemps.ExecuteNonQuery();
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }
        }

        /// <summary>
        /// Modifie dans la base de données le controle correspondant à l'identifiant avec les valeurs passées en paramètre
        /// </summary>
        /// <param name="codeDop">code produit dopant du controle à modifier</param>
        /// <param name="numTriath">num du triathlon du controle à modifier</param>
        /// <param name="numDossard">num du dossard du controle à modifier</param>
        /// <param name="mesureEtablie">nouvelle mesure etablie du controle</param>
        public static void ModifierControle(int codeDop, int numTriath, int numDossard, double mesureEtablie)
        {
            SqlCommand reqModifierControle = new SqlCommand("UPDATE Controler Set mesureEtablie = @mesureE WHERE numTriath = @numT and numDossard = @numD and codeDop = @codeD;", connexionBaseTriathlon);

            reqModifierControle.Parameters.AddWithValue("@mesureE", mesureEtablie);
            reqModifierControle.Parameters.AddWithValue("@codeD", codeDop);
            reqModifierControle.Parameters.AddWithValue("@numD", numDossard);
            reqModifierControle.Parameters.AddWithValue("@numT", numTriath);
            try
            {
                connexionBaseTriathlon.Open();
                reqModifierControle.ExecuteNonQuery();
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }
        }




        /// <summary>
        /// Supprime dans la base de données le produit dopant avec le code passé en paramètre ainsi que ses controles
        /// </summary>
        /// <param name="codeDop">code du produit dopant à supprimer</param>
        public static void SupprimerProduitDop(int codeDop)
        {
            SqlCommand reqSupprimerControle = new SqlCommand("DELETE FROM Controler WHERE codeDop = @codeD", connexionBaseTriathlon);
            reqSupprimerControle.Parameters.AddWithValue("@codeD", codeDop);
            SqlCommand reqSupprimerProduitDop = new SqlCommand("DELETE FROM ProdDopant WHERE codeDop = @codeD", connexionBaseTriathlon);
            reqSupprimerProduitDop.Parameters.AddWithValue("@codeD", codeDop);

            try
            {
                connexionBaseTriathlon.Open();
                reqSupprimerControle.ExecuteNonQuery();
                reqSupprimerProduitDop.ExecuteNonQuery();
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }
        }

        /// <summary>
        /// Supprime dans la base de données le triathlon avec le num passé en paramètre
        /// </summary>
        /// <param name="numTriath">num du triathlon à supprimer</param>
        public static void SupprimerTriathlon(int numTriath)
        {
            SqlCommand reqSupprimerTriathlon = new SqlCommand("DELETE FROM Triathlon WHERE numTriath = @numTriath", connexionBaseTriathlon);
            reqSupprimerTriathlon.Parameters.AddWithValue("@numTriath", numTriath);

            try
            {
                connexionBaseTriathlon.Open();
                reqSupprimerTriathlon.ExecuteNonQuery();
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }
        }

        /// <summary>
        /// Supprime dans la base de données le type de triathlon avec le code passé en paramètre ainsi que ses triathlons
        /// </summary>
        /// <param name="codeType">code du type de triathlon à supprimer</param>
        public static void SupprimerTypeTriahtlon(int codeType)///marche pas
        {
            SqlCommand reqSupprimerTriathlon = new SqlCommand("DELETE FROM Triathlon WHERE codeTypeT = @codeT", connexionBaseTriathlon);
            reqSupprimerTriathlon.Parameters.AddWithValue("@codeT", codeType);
            SqlCommand reqSupprimerTypeTriathlon = new SqlCommand("DELETE FROM TypeTriathlon WHERE codeTypeT = @codeT", connexionBaseTriathlon);
            reqSupprimerTypeTriathlon.Parameters.AddWithValue("@codeT", codeType);

            try
            {
                connexionBaseTriathlon.Open();
                reqSupprimerTriathlon.ExecuteNonQuery();
                reqSupprimerTypeTriathlon.ExecuteNonQuery();
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }
        }

        /// <summary>
        /// Supprime dans la base de données le triathlete avec le num licence passé en paramètre ainsi que ses inscriptions
        /// </summary>
        /// <param name="numLicence">num licence du triathlete à supprimer</param>
        public static void SupprimerTriathlete(int numLicence)
        {
            SqlCommand reqSupprimerInscription = new SqlCommand("DELETE FROM Inscription WHERE numLicence = @numL", connexionBaseTriathlon);
            reqSupprimerInscription.Parameters.AddWithValue("@numL", numLicence);
            SqlCommand reqSupprimerTriathlete = new SqlCommand("DELETE FROM Triathlete WHERE numLicence = @numL", connexionBaseTriathlon);
            reqSupprimerTriathlete.Parameters.AddWithValue("@numL", numLicence);

            try
            {
                connexionBaseTriathlon.Open();
                reqSupprimerInscription.ExecuteNonQuery();
                reqSupprimerTriathlete.ExecuteNonQuery();
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }
        }

        /// <summary>
        /// Supprime dans la base de données le controle avec le code du produit dopant, du num triathlon et du num dossaes passé en paramètre
        /// </summary>
        /// <param name="codeDop">code du produit dopant du controle à supprimer</param>
        /// <param name="numTriath">num triathlon du controle à supprimer</param>
        /// <param name="numDossard">num dossard du controle à supprimer</param>
        public static void SupprimerControle(int codeDop, int numTriath, int numDossard)
        {
            SqlCommand reqSupprimerControle = new SqlCommand("DELETE FROM Controle WHERE codeDop = @codeD and numTriath = @numT and numDossard = @numD", connexionBaseTriathlon);
            reqSupprimerControle.Parameters.AddWithValue("@codeD", codeDop);
            reqSupprimerControle.Parameters.AddWithValue("@numT", numTriath);
            reqSupprimerControle.Parameters.AddWithValue("@numD", numDossard);

            try
            {
                connexionBaseTriathlon.Open();
                reqSupprimerControle.ExecuteNonQuery();
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }
        }

        /// <summary>
        /// Supprime dans la base de données l'inscription avec le num du triathlon et le num du dossard passé en paramètre
        /// </summary>
        /// <param name="numTriath">num triathlon de l'inscription à supprimer</param>
        /// <param name="numDossard">num dossard de l'inscription à supprimer</param>
        public static void SupprimerInscription(int numTriath, int numDossard)
        {
            SqlCommand reqSupprimerInscription = new SqlCommand("DELETE FROM Inscription WHERE numTriath = @numT and numDossard = @numD", connexionBaseTriathlon);
            reqSupprimerInscription.Parameters.AddWithValue("@numT", numTriath);
            reqSupprimerInscription.Parameters.AddWithValue("@numD", numDossard);

            try
            {
                connexionBaseTriathlon.Open();
                reqSupprimerInscription.ExecuteNonQuery();
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }
        }

        /// à tester
        /// <summary>
        /// Supprime dans la base de données le temps (en le mettant à 0) avec le num dossard et le num triathlon passé en paramètre
        /// </summary>
        /// <param name="numDossard">num dossard du temps à supprimer</param>
        /// <param name="numTriath">num triathlon du temps à supprimer</param>
        public static void SupprimerTemps(int numDossard, int numTriath)
        {
            SqlCommand reqSupprimerTemps = new SqlCommand("UPDATE Inscription Set tempsNatation = 0, tempsCourse = 0, tempsCyclisme = 0 WHERE numTriath = @numT and numDossard = @numD;", connexionBaseTriathlon);

            reqSupprimerTemps.Parameters.AddWithValue("@numD", numDossard);
            reqSupprimerTemps.Parameters.AddWithValue("@numT", numTriath);
            try
            {
                connexionBaseTriathlon.Open();
                reqSupprimerTemps.ExecuteNonQuery();
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }
        }
    }
}
