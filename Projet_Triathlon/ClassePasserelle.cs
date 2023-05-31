using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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

            SqlCommand reqGetLesInscriptions = new SqlCommand("SELECT numTriath, numDossard, dateInscription, tempsNatation, tempsCourse, tempsCyclisme, I.numLicence, nom, prenom FROM Inscription I LEFT JOIN Triathlete T ON T.numLicence = I.numLicence;", connexionBaseTriathlon);

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
                    string nom = readerLesInscriptions[7].ToString();
                    string prenom = readerLesInscriptions[8].ToString();

                    lesInscriptions.Add(new Inscription(numTriath, numDossard, numLicence, dateI, tempsNat, tempsCou, tempsCycl, nom, prenom));
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

                    lesControles.Add(new Controler(numTriath, numDoss, codeDop, mesureE));
                }
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }

            return lesControles;
        }

        /// <summary>
        /// Retourne le classement du triathlon passé en paramètre
        /// </summary>
        /// <param name="unTriath">Objet type triathlon</param>
        /// <returns>Collection d'inscription</returns>
        public static List<Inscription> GetClassement(Triathlon unTriath)
        {
            List<Inscription> lesTriathletes = new List<Inscription>();

            SqlCommand reqGetLeClassement = new SqlCommand("EXEC GetClassementByTriathlon @numT;", connexionBaseTriathlon);
            reqGetLeClassement.Parameters.AddWithValue("@numT", unTriath.NumTriath);

            try
            {
                connexionBaseTriathlon.Open();
                SqlDataReader readerLesTriathletes = reqGetLeClassement.ExecuteReader();

                while (readerLesTriathletes.Read())
                {
                    int numLicence = (int)readerLesTriathletes[0];
                    int numTriath = (int)readerLesTriathletes[1];
                    int numDossard = (int)readerLesTriathletes[2];
                    string nom = readerLesTriathletes[3].ToString();
                    string prenom = readerLesTriathletes[4].ToString();
                    double tempsCourse = (double)readerLesTriathletes[5];
                    double tempsCyclisme = (double)readerLesTriathletes[6];
                    double tempsNatation = (double)readerLesTriathletes[7];
                    double tempsTotal = (double)readerLesTriathletes[8];

                    lesTriathletes.Add(new Inscription(numTriath, numDossard, numLicence, nom, prenom, tempsNatation, tempsCourse, tempsCyclisme, tempsTotal));
                }
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }
            return lesTriathletes;
        }

        /// <summary>
        /// Retourne tous les triathlons présent dans la base de données pour le type triatlon passé en paramètre
        /// </summary>
        /// <param name="typeTriathlon">Objet type triathlon</param>
        /// <returns>Collection de triathlons</returns>
        public static List<Triathlon> GetLesTriathlonsByType(TypeTriathlon typeTriathlon)
        {
            List<Triathlon> lesTriathlons = new List<Triathlon>();

            SqlCommand reqGetLesTriathlonsByType = new SqlCommand("SELECT numTriath, nom, lieu, dateCompet, codeTypeT FROM Triathlon WHERE CodeTypeT = @num;", connexionBaseTriathlon);

            reqGetLesTriathlonsByType.Parameters.AddWithValue("@num", typeTriathlon.CodeTypeT);

            try
            {
                connexionBaseTriathlon.Open();
                SqlDataReader readerLesTriathlons = reqGetLesTriathlonsByType.ExecuteReader();

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
        /// Retourne tous les controles présent dans la base de données pour l'inscription passé en paramètre
        /// </summary>
        /// <param name="uneInscription">Objet inscription</param>
        /// <returns>Collection de controle</returns>
        public static List<Controler> GetLesControlesByInscription(Inscription uneInscription)
        {
            List<Controler> lesControles = new List<Controler>();

            SqlCommand reqGetLesControlesByInscription = new SqlCommand("SELECT codeDop, numTriath, numDossard, mesureEtablie FROM Controler WHERE numTriath = @numT and numDossard = @numD;", connexionBaseTriathlon);

            reqGetLesControlesByInscription.Parameters.AddWithValue("@numT", uneInscription.NumTriath);
            reqGetLesControlesByInscription.Parameters.AddWithValue("@numD", uneInscription.NumDossard);

            try
            {
                connexionBaseTriathlon.Open();
                SqlDataReader readerLesControles = reqGetLesControlesByInscription.ExecuteReader();

                while (readerLesControles.Read())
                {
                    int codeDop = (int)readerLesControles[0];
                    int numTriath = (int)readerLesControles[1];
                    int numDoss = (int)readerLesControles[2];
                    double mesureE = (double)readerLesControles[3];

                    lesControles.Add(new Controler(numTriath, numDoss, codeDop, mesureE));
                }
            }
            finally
            {
                connexionBaseTriathlon.Close();
            }

            return lesControles;
        }

        /// <summary>
        /// Retourne toutes les inscriptions présente dans la base de données pour le triathlon passé en paramètre
        /// </summary>
        /// <param name="unTriathlon">Objet triathlon</param>
        /// <returns>Collection d'inscriptions</returns>
        public static List<Inscription> GetLesInscriptionsByTriathlon(Triathlon unTriathlon)
        {
            List<Inscription> lesInscriptions = new List<Inscription>();

            SqlCommand reqGetLesInscriptionsByTriathlon = new SqlCommand("SELECT numTriath, numDossard, dateInscription, tempsNatation, tempsCourse, tempsCyclisme, numLicence FROM Inscription WHERE numTriath = @num;", connexionBaseTriathlon);

            reqGetLesInscriptionsByTriathlon.Parameters.AddWithValue("@num", unTriathlon.NumTriath);

            try
            {
                connexionBaseTriathlon.Open();
                SqlDataReader readerLesInscriptions = reqGetLesInscriptionsByTriathlon.ExecuteReader();

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
        /// Ajoute un nouveau produit dopant dans la base de données avec les valeurs passées en paramètre
        /// </summary>
        /// <param name="prodAAjouter">Objet produit dopant à ajouter</param>
        public static void AjouterProduitDop(ProdDopant prodAAjouter)
        {
            SqlCommand reqAjouterProduitDop = new SqlCommand("INSERT INTO ProdDopant (libelle, tauxMax) VALUES (@libelle, @tauxMax);", connexionBaseTriathlon);

            reqAjouterProduitDop.Parameters.AddWithValue("@libelle", prodAAjouter.Libelle);
            reqAjouterProduitDop.Parameters.AddWithValue("@tauxMax", prodAAjouter.TauxMax);
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
        /// <param name="typeTriathlonAAjouter">Objet type triathlon à ajouter</param>
        public static void AjouterTypeTriathlon(TypeTriathlon typeTriathlonAAjouter)
        {
            SqlCommand reqAjouterTypeTriathlon = new SqlCommand("INSERT INTO TypeTriathlon (designation, nom, distanceCyclisme, distanceNatation, distanceCourse) VALUES (@designation, @nom, @dCy, @dN, @dCo);", connexionBaseTriathlon);

            reqAjouterTypeTriathlon.Parameters.AddWithValue("@designation", typeTriathlonAAjouter.Designation);
            reqAjouterTypeTriathlon.Parameters.AddWithValue("@nom", typeTriathlonAAjouter.Nom);
            reqAjouterTypeTriathlon.Parameters.AddWithValue("@dCy", typeTriathlonAAjouter.DistanceCyclisme);
            reqAjouterTypeTriathlon.Parameters.AddWithValue("@dN", typeTriathlonAAjouter.DistanceNatation);
            reqAjouterTypeTriathlon.Parameters.AddWithValue("@dCo", typeTriathlonAAjouter.DistanceCourse);

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
        /// <param name="triathleteAAjouter">Objet triathlete à ajouter</param>
        public static void AjouterTriathlete(Triathlete triathleteAAjouter)
        {
            SqlCommand reqAjouterTriathlete = new SqlCommand("INSERT INTO Triathlete (nom, prenom, adresse, cp, ville, dateNaissance) VALUES (@nom, @prenom, @adresse, @cp, @ville, @dateN);", connexionBaseTriathlon);

            reqAjouterTriathlete.Parameters.AddWithValue("@nom", triathleteAAjouter.Nom);
            reqAjouterTriathlete.Parameters.AddWithValue("@prenom", triathleteAAjouter.Prenom);
            reqAjouterTriathlete.Parameters.AddWithValue("@adresse", triathleteAAjouter.Adresse);
            reqAjouterTriathlete.Parameters.AddWithValue("@cp", triathleteAAjouter.Cp);
            reqAjouterTriathlete.Parameters.AddWithValue("@ville", triathleteAAjouter.Ville);
            reqAjouterTriathlete.Parameters.AddWithValue("@dateN", triathleteAAjouter.DateNaissance);

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
        /// <param name="inscriptionAAjouter">Objet inscription à ajouter</param>
        public static void AjouterInscription(Inscription inscriptionAAjouter)
        {
            SqlCommand reqAjouterInscription = new SqlCommand("INSERT INTO Inscription (numTriath, numLicence, dateInscription) VALUES (@numT, @numL, @dateI);", connexionBaseTriathlon);

            reqAjouterInscription.Parameters.AddWithValue("@numT", inscriptionAAjouter.NumTriath);
            reqAjouterInscription.Parameters.AddWithValue("@numL", inscriptionAAjouter.NumLicence);
            reqAjouterInscription.Parameters.AddWithValue("@dateI", inscriptionAAjouter.DateInscription);

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
        /// <param name="triathlonAAjouter">param>
        public static void AjouterTriathlon(Triathlon triathlonAAjouter)
        {
            SqlCommand reqAjouterTriathlon = new SqlCommand("INSERT INTO Triathlon (nom, lieu, dateCompet, codeTypeT) VALUES (@nom, @lieu, @dateC, @codeType);", connexionBaseTriathlon);

            reqAjouterTriathlon.Parameters.AddWithValue("@nom", triathlonAAjouter.Nom);
            reqAjouterTriathlon.Parameters.AddWithValue("@lieu", triathlonAAjouter.Lieu);
            reqAjouterTriathlon.Parameters.AddWithValue("@dateC", triathlonAAjouter.DateCompet);
            reqAjouterTriathlon.Parameters.AddWithValue("@codeType", triathlonAAjouter.CodeTypeT);

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
        /// <param name="controleAAjouter">Objet controle à ajouter</param>
        public static void AjouterControle(Controler controleAAjouter)
        {
            SqlCommand reqAjouterControle = new SqlCommand("INSERT INTO Controler (codeDop, numTriath, numDossard, mesureEtablie) VALUES (@codeD, @numT, @numD, @mesureE);", connexionBaseTriathlon);

            reqAjouterControle.Parameters.AddWithValue("@codeD", controleAAjouter.CodeDop);
            reqAjouterControle.Parameters.AddWithValue("@numT", controleAAjouter.NumTriath);
            reqAjouterControle.Parameters.AddWithValue("@numD", controleAAjouter.NumDossard);
            reqAjouterControle.Parameters.AddWithValue("@mesureE", controleAAjouter.MesureEtablie);

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
        /// <param name="prodAModifier">Objet produit dopant à modifier</param>
        public static void ModifierProduitsDop(ProdDopant prodAModifier)
        {
            SqlCommand reqModifierProduitsDop = new SqlCommand("UPDATE ProdDopant Set libelle = @libelle, tauxMax = @tauxMax WHERE codeDop = @code;", connexionBaseTriathlon);

            reqModifierProduitsDop.Parameters.AddWithValue("@libelle", prodAModifier.Libelle);
            reqModifierProduitsDop.Parameters.AddWithValue("@tauxMax", prodAModifier.TauxMax);
            reqModifierProduitsDop.Parameters.AddWithValue("@code", prodAModifier.CodeDop);
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
        /// <param name="typeTriathlonAModifier">Objet type triathlon à modifier</param>
        public static void ModifierTypeTriathlon(TypeTriathlon typeTriathlonAModifier)
        {
            SqlCommand reqModifierTypeTriathlon = new SqlCommand("UPDATE TypeTriathlon Set designation = @desi, nom = @nom, distanceCyclisme = @dCy, distanceNatation = @dN, distanceCourse = @dCo WHERE codeTypeT = @code;", connexionBaseTriathlon);

            reqModifierTypeTriathlon.Parameters.AddWithValue("@desi", typeTriathlonAModifier.Designation);
            reqModifierTypeTriathlon.Parameters.AddWithValue("@nom", typeTriathlonAModifier.Nom);
            reqModifierTypeTriathlon.Parameters.AddWithValue("@dCy", typeTriathlonAModifier.DistanceCyclisme);
            reqModifierTypeTriathlon.Parameters.AddWithValue("@dN", typeTriathlonAModifier.DistanceNatation);
            reqModifierTypeTriathlon.Parameters.AddWithValue("@dCo", typeTriathlonAModifier.DistanceCourse);
            reqModifierTypeTriathlon.Parameters.AddWithValue("@code", typeTriathlonAModifier.CodeTypeT);
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
        /// <param name="triathleteAModifier">Objet triathlete à modifier</param>
        public static void ModifierTriathlete(Triathlete triathleteAModifier)
        {
            SqlCommand reqModifierTriathlete = new SqlCommand("UPDATE Triathlete Set nom = @nom, prenom = @prenom, adresse = @adresse, cp = @cp, ville = @ville, dateNaissance = @dateN WHERE numLicence = @num;", connexionBaseTriathlon);

            reqModifierTriathlete.Parameters.AddWithValue("@nom", triathleteAModifier.Nom);
            reqModifierTriathlete.Parameters.AddWithValue("@prenom", triathleteAModifier.Prenom);
            reqModifierTriathlete.Parameters.AddWithValue("@adresse", triathleteAModifier.Adresse);
            reqModifierTriathlete.Parameters.AddWithValue("@cp", triathleteAModifier.Cp);
            reqModifierTriathlete.Parameters.AddWithValue("@ville", triathleteAModifier.Ville);
            reqModifierTriathlete.Parameters.AddWithValue("@dateN", triathleteAModifier.DateNaissance);
            reqModifierTriathlete.Parameters.AddWithValue("@num", triathleteAModifier.NumLicence);
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
        /// <param name="triathlonAModifier">Objet triathlon à modifier</param>
        public static void ModifierTriathlon(Triathlon triathlonAModifier)
        {
            SqlCommand reqModifierTriathlon = new SqlCommand("UPDATE Triathlon Set nom = @nom, lieu = @lieu, dateCompet = @dateC, codeTypeT = @codeType WHERE numTriath = @num;", connexionBaseTriathlon);

            reqModifierTriathlon.Parameters.AddWithValue("@nom", triathlonAModifier.Nom);
            reqModifierTriathlon.Parameters.AddWithValue("@lieu", triathlonAModifier.Lieu);
            reqModifierTriathlon.Parameters.AddWithValue("@dateC", triathlonAModifier.DateCompet);
            reqModifierTriathlon.Parameters.AddWithValue("@codeType", triathlonAModifier.UnTypeTriathlon.CodeTypeT);
            reqModifierTriathlon.Parameters.AddWithValue("@num", triathlonAModifier.NumTriath);
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
        /// <param name="inscriptionAModifier">Objet inscription à modifier</param>
        public static void ModifierTemps(Inscription inscriptionAModifier)
        {
            SqlCommand reqModifierTemps = new SqlCommand("UPDATE Inscription Set tempsNatation = @tN, tempsCourse = @tCo, tempsCyclisme = @tCy WHERE numTriath = @numT and numDossard = @numD;", connexionBaseTriathlon);

            reqModifierTemps.Parameters.AddWithValue("@tN", inscriptionAModifier.TempsNatation);
            reqModifierTemps.Parameters.AddWithValue("@tCo", inscriptionAModifier.TempsCourse);
            reqModifierTemps.Parameters.AddWithValue("@tCy", inscriptionAModifier.TempsCyclisme);
            reqModifierTemps.Parameters.AddWithValue("@numD", inscriptionAModifier.NumDossard);
            reqModifierTemps.Parameters.AddWithValue("@numT", inscriptionAModifier.NumTriath);
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
        /// <param name="controleAModifier">Objet controle à modifier</param>
        public static void ModifierControle(Controler controleAModifier)
        {
            SqlCommand reqModifierControle = new SqlCommand("UPDATE Controler Set mesureEtablie = @mesureE WHERE numTriath = @numT and numDossard = @numD and codeDop = @codeD;", connexionBaseTriathlon);

            reqModifierControle.Parameters.AddWithValue("@mesureE", controleAModifier.MesureEtablie);
            reqModifierControle.Parameters.AddWithValue("@codeD", controleAModifier.CodeDop);
            reqModifierControle.Parameters.AddWithValue("@numD", controleAModifier.NumDossard);
            reqModifierControle.Parameters.AddWithValue("@numT", controleAModifier.NumTriath);
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
        /// <param name="prodASupprimer">Objet produit dopant à supprimer</param>
        public static void SupprimerProduitDop(ProdDopant prodASupprimer)
        {
            SqlCommand reqSupprimerControle = new SqlCommand("DELETE FROM Controler WHERE codeDop = @codeD", connexionBaseTriathlon);
            reqSupprimerControle.Parameters.AddWithValue("@codeD", prodASupprimer.CodeDop);
            SqlCommand reqSupprimerProduitDop = new SqlCommand("DELETE FROM ProdDopant WHERE codeDop = @codeD", connexionBaseTriathlon);
            reqSupprimerProduitDop.Parameters.AddWithValue("@codeD", prodASupprimer.CodeDop);

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
        /// <param name="triathlonASupprimer">Objet triathlon à supprimer</param>
        public static void SupprimerTriathlon(Triathlon triathlonASupprimer)
        {
            SqlCommand reqSupprimerControle = new SqlCommand("DELETE FROM Controler WHERE numTriath = @numTriath", connexionBaseTriathlon);
            reqSupprimerControle.Parameters.AddWithValue("@numTriath", triathlonASupprimer.NumTriath);
            SqlCommand reqSupprimerInscription = new SqlCommand("DELETE FROM Inscription WHERE numTriath = @numTriath", connexionBaseTriathlon);
            reqSupprimerInscription.Parameters.AddWithValue("@numTriath", triathlonASupprimer.NumTriath);
            SqlCommand reqSupprimerTriathlon = new SqlCommand("DELETE FROM Triathlon WHERE numTriath = @numTriath", connexionBaseTriathlon);
            reqSupprimerTriathlon.Parameters.AddWithValue("@numTriath", triathlonASupprimer.NumTriath);

            try
            {
                connexionBaseTriathlon.Open();
                reqSupprimerControle.ExecuteNonQuery();
                reqSupprimerInscription.ExecuteNonQuery();
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
        /// <param name="typeTriathlonASupprimer">Objet type triathlon à supprimer</param>
        public static void SupprimerTypeTriathlon(TypeTriathlon typeTriathlonASupprimer)///marche pas
        {
            SqlCommand reqSupprimerControle = new SqlCommand("DELETE C FROM Controler AS C JOIN Triathlon T ON T.numTriath = C.numTriath WHERE codeTypeT = @codeT", connexionBaseTriathlon);
            reqSupprimerControle.Parameters.AddWithValue("@codeT", typeTriathlonASupprimer.CodeTypeT);
            SqlCommand reqSupprimerInscription = new SqlCommand("DELETE I FROM Inscription AS I JOIN Triathlon T ON T.numTriath = I.numTriath WHERE codeTypeT = @codeT", connexionBaseTriathlon);
            reqSupprimerInscription.Parameters.AddWithValue("@codeT", typeTriathlonASupprimer.CodeTypeT);
            SqlCommand reqSupprimerTriathlon = new SqlCommand("DELETE FROM Triathlon WHERE codeTypeT = @codeT", connexionBaseTriathlon);
            reqSupprimerTriathlon.Parameters.AddWithValue("@codeT", typeTriathlonASupprimer.CodeTypeT);
            SqlCommand reqSupprimerTypeTriathlon = new SqlCommand("DELETE FROM TypeTriathlon WHERE codeTypeT = @codeT", connexionBaseTriathlon);
            reqSupprimerTypeTriathlon.Parameters.AddWithValue("@codeT", typeTriathlonASupprimer.CodeTypeT);

            try
            {
                connexionBaseTriathlon.Open();
                reqSupprimerControle.ExecuteNonQuery();
                reqSupprimerInscription.ExecuteNonQuery();
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
        /// <param name="triathleteASupprimer">Objet triathlete à supprimer</param>
        public static void SupprimerTriathlete(Triathlete triathleteASupprimer)
        {
            SqlCommand reqSupprimerInscription = new SqlCommand("DELETE FROM Inscription WHERE numLicence = @numL", connexionBaseTriathlon);
            reqSupprimerInscription.Parameters.AddWithValue("@numL", triathleteASupprimer.NumLicence);
            SqlCommand reqSupprimerTriathlete = new SqlCommand("DELETE FROM Triathlete WHERE numLicence = @numL", connexionBaseTriathlon);
            reqSupprimerTriathlete.Parameters.AddWithValue("@numL", triathleteASupprimer.NumLicence);

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
        /// <param name="controleASupprimer">Objet controle à supprimer</param>
        public static void SupprimerControle(Controler controleASupprimer)
        {
            SqlCommand reqSupprimerControle = new SqlCommand("DELETE FROM Controle WHERE codeDop = @codeD and numTriath = @numT and numDossard = @numD", connexionBaseTriathlon);
            reqSupprimerControle.Parameters.AddWithValue("@codeD", controleASupprimer.CodeDop);
            reqSupprimerControle.Parameters.AddWithValue("@numT", controleASupprimer.NumTriath);
            reqSupprimerControle.Parameters.AddWithValue("@numD", controleASupprimer.NumDossard);

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
        /// <param name="inscriptionASupprimer">Objet inscription à supprimer</param>
        public static void SupprimerInscription(Inscription inscriptionASupprimer)
        {
            SqlCommand reqSupprimerControle = new SqlCommand("DELETE FROM Controler WHERE numTriath = @numT and numDossard = @numD", connexionBaseTriathlon);
            reqSupprimerControle.Parameters.AddWithValue("@numT", inscriptionASupprimer.NumTriath);
            reqSupprimerControle.Parameters.AddWithValue("@numD", inscriptionASupprimer.NumDossard);
            SqlCommand reqSupprimerInscription = new SqlCommand("DELETE FROM Inscription WHERE numTriath = @numT and numDossard = @numD", connexionBaseTriathlon);
            reqSupprimerInscription.Parameters.AddWithValue("@numT", inscriptionASupprimer.NumTriath);
            reqSupprimerInscription.Parameters.AddWithValue("@numD", inscriptionASupprimer.NumDossard);

            try
            {
                connexionBaseTriathlon.Open();
                reqSupprimerControle.ExecuteNonQuery();
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
        /// <param name="inscriptionASupprimer">Objet inscription à supprimer</param>
        public static void SupprimerTemps(Inscription inscriptionASupprimer)
        {
            SqlCommand reqSupprimerTemps = new SqlCommand("UPDATE Inscription Set tempsNatation = 0, tempsCourse = 0, tempsCyclisme = 0 WHERE numTriath = @numT and numDossard = @numD;", connexionBaseTriathlon);

            reqSupprimerTemps.Parameters.AddWithValue("@numD", inscriptionASupprimer.NumDossard);
            reqSupprimerTemps.Parameters.AddWithValue("@numT", inscriptionASupprimer.NumTriath);
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
