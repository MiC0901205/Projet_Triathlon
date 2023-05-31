using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Triathlon
{
    public class Triathlete
    {
        private DateTime dateNaissance;
        private int numLicence, cp;
        private string nom, adresse, prenom, ville;

        public Triathlete(int unNumLicence, int unCp, string unNom, string unPrenom, string uneAdresse, string uneVille, DateTime uneDateNaissance)
        {
            this.NumLicence = unNumLicence;
            this.Cp = unCp;
            this.Nom = unNom;
            this.Prenom = unPrenom;
            this.Adresse = uneAdresse;
            this.Ville = uneVille;
            this.DateNaissance = uneDateNaissance;
        }

        public Triathlete(int unCp, string unNom, string unPrenom, string uneAdresse, string uneVille, DateTime uneDateNaissance)
        {
            this.Cp = unCp;
            this.Nom = unNom;
            this.Prenom = unPrenom;
            this.Adresse = uneAdresse;
            this.Ville = uneVille;
            this.DateNaissance = uneDateNaissance;
        }

        public int NumLicence { get => numLicence; set => numLicence = value; }
        public int Cp { get => cp; set => cp = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Ville { get => ville; set => ville = value; }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }

        public override string ToString()
        {
            return "[" + this.NumLicence + "] " + this.Nom + " " + this.Prenom;
        }
    }

    public class Triathlon
    {
        private int codeTypeT, numTriath;
        private string lieu, nom;
        private DateTime dateCompet;
        private TypeTriathlon unTypeTriathlon;

        public Triathlon(int unNumTriath, string unNom, string unLieu, DateTime uneDateCompet, int unCodeTypeT)
        {
            this.NumTriath = unNumTriath;
            this.Nom = unNom;
            this.Lieu = unLieu;
            this.DateCompet = uneDateCompet;
            this.CodeTypeT = unCodeTypeT;
        }

        public int NumTriath { get => numTriath; set => numTriath = value; }
        public int CodeTypeT { get => codeTypeT; set => codeTypeT = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Lieu { get => lieu; set => lieu = value; }
        public DateTime DateCompet { get => dateCompet; set => dateCompet = value; }
        public TypeTriathlon UnTypeTriathlon { get => unTypeTriathlon; set => unTypeTriathlon = value; }

        public override string ToString()
        {
            return this.NumTriath + ". " + this.Nom;
        }
    }

    public class Inscription
    {
        private int numLicence, numDossard, numTriath;
        private DateTime dateInscription;
        private double tempsNatation, tempsCourse, tempsCyclisme, tempsTotal;
        private string nom, prenom;

        public Inscription(int unNumTriath, int unNumDossard, int unNumLicence, DateTime uneDateInscription, double unTempsNatation, double unTempsCourse, double unTempsCyclisme)
        {
            this.NumTriath = unNumTriath;
            this.NumDossard = unNumDossard;
            this.NumLicence = unNumLicence;
            this.DateInscription = uneDateInscription;
            this.TempsNatation = unTempsNatation;
            this.TempsCourse = unTempsCourse;
            this.TempsCyclisme = unTempsCyclisme;
        }

        public Inscription(int unNumTriath, int unNumDossard, int unNumLicence, string unNom, string unPrenom, double unTempsNatation, double unTempsCourse, double unTempsCyclisme, double tempsTotal)
        {
            this.NumTriath = unNumTriath;
            this.NumDossard = unNumDossard;
            this.NumLicence = unNumLicence;
            this.Nom = unNom;
            this.Prenom = unPrenom;
            this.TempsNatation = unTempsNatation;
            this.TempsCourse = unTempsCourse;
            this.TempsCyclisme = unTempsCyclisme;
            this.TempsTotal = tempsTotal;
        }

        public Inscription(int unNumTriath, int unNumDossard, int unNumLicence, DateTime uneDateInscription, double unTempsNatation, double unTempsCourse, double unTempsCyclisme, string unNom, string unPrenom)
        {
            this.NumTriath = unNumTriath;
            this.NumDossard = unNumDossard;
            this.NumLicence = unNumLicence;
            this.DateInscription = uneDateInscription;
            this.TempsNatation = unTempsNatation;
            this.TempsCourse = unTempsCourse;
            this.TempsCyclisme = unTempsCyclisme;
            this.Nom = unNom;
            this.Prenom = unPrenom;
        }

        public int NumTriath { get => numTriath; set => numTriath = value; }
        public int NumDossard { get => numDossard; set => numDossard = value; }
        public int NumLicence { get => numLicence; set => numLicence = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime DateInscription { get => dateInscription; set => dateInscription = value; }
        public double TempsNatation { get => tempsNatation; set => tempsNatation = value; }
        public double TempsCourse { get => tempsCourse; set => tempsCourse = value; }
        public double TempsCyclisme { get => tempsCyclisme; set => tempsCyclisme = value; }
        public double TempsTotal { get => tempsTotal; set => tempsTotal = value; }

        public override string ToString()
        {
            return this.NumTriath + "." + this.NumDossard + " " + this.Nom + " " + this.Prenom;
        }
    }

    public class Controler
    {
        private int codeDop, numTriath, numDossard;
        private double mesureEtablie;

        public Controler(int unNumTriath, int unNumDossard, int unCodeDop, double uneMesureEtablie)
        {
            this.NumTriath = unNumTriath;
            this.NumDossard = unNumDossard;
            this.CodeDop = unCodeDop;
            this.MesureEtablie = uneMesureEtablie;
        }

        public int NumTriath { get => numTriath; set => numTriath = value; }
        public int NumDossard { get => numDossard; set => numDossard = value; }
        public int CodeDop { get => codeDop; set => codeDop = value; }
        public double MesureEtablie { get => mesureEtablie; set => mesureEtablie = value; }

        public override string ToString()
        {
            return "[" + this.NumTriath + "." + this.NumDossard + "] " + this.CodeDop;
        }
    }

    public class ProdDopant
    {
        private int codeDop;
        private string libelle;
        private double tauxMax;

        public int CodeDop { get => codeDop; set => codeDop = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public double TauxMax { get => tauxMax; set => tauxMax = value; }

        public ProdDopant(int unCodeDop, string unLibelle, double unTauxMax)
        {
            this.codeDop = unCodeDop;
            this.Libelle = unLibelle;
            this.TauxMax = unTauxMax;
        }

        public ProdDopant(string unLibelle, double unTauxMax)
        {
            this.Libelle = unLibelle;
            this.TauxMax = unTauxMax;
        }


        public override string ToString()
        {
            return this.codeDop + ". " + this.Libelle;
        }
    }

    public class TypeTriathlon
    {
        private int codeTypeT, distanceCourse, distanceCyclisme, distanceNatation;
        private string nom, designation;

        public TypeTriathlon(int unCodeTypeT, string uneDesignation, string unNom, int uneDistanceCyclisme, int uneDistanceNatation, int uneDistanceCourse)
        {
            this.CodeTypeT = unCodeTypeT;
            this.Designation = uneDesignation;
            this.Nom = unNom;
            this.DistanceCyclisme = uneDistanceCyclisme;
            this.DistanceNatation = uneDistanceNatation;
            this.DistanceCourse = uneDistanceCourse;
        }

        public int CodeTypeT { get => codeTypeT; set => codeTypeT = value; }
        public int DistanceCyclisme { get => distanceCyclisme; set => distanceCyclisme = value; }
        public int DistanceNatation { get => distanceNatation; set => distanceNatation = value; }
        public int DistanceCourse { get => distanceCourse; set => distanceCourse = value; }
        public string Designation { get => designation; set => designation = value; }
        public string Nom { get => nom; set => nom = value; }

        public override string ToString()
        {
            return this.CodeTypeT + ". " + this.Nom + " [" + this.Designation + "]";
        }
    }
}
