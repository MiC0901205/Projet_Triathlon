using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Triathlon
{
    public class Triathlete
    {
        public int NumLicence, NumDossard, Cp;
        public string Nom, Prenom, Adresse, Ville;
        public DateTime DateNaissance;
        public float TempsNatation, TempsCourse, TempsCyclisme, TempsTotal;

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

        public Triathlete(int unNumLicence, int unNumDossard, string unNom, string unPrenom, float unTempsCourse, float unTempsCyclisme, float unTempsNatation, float unTempsTotal)
        {
            this.NumLicence = unNumLicence;
            this.NumDossard = unNumDossard;
            this.Nom = unNom;
            this.Prenom = unPrenom;
            this.TempsCourse = unTempsCourse;
            this.TempsCyclisme = unTempsCyclisme;
            this.TempsNatation = unTempsNatation;
            this.TempsTotal = unTempsTotal;
        }

        public override string ToString()
        {
            return "[" + this.NumLicence + "] " + this.Nom + " " + this.Prenom;
        }
    }

    public class Triathlon
    {
        public int NumTriath, CodeTypeT;
        public string Nom, Lieu;
        public DateTime DateCompet;

        public Triathlon(int unNumTriath, string unNom, string unLieu, DateTime uneDateCompet, int unCodeTypeT)
        {
            this.NumTriath = unNumTriath;
            this.Nom = unNom;
            this.Lieu = unLieu;
            this.DateCompet = uneDateCompet;
            this.CodeTypeT = unCodeTypeT;
        }

        public override string ToString()
        {
            return this.NumTriath + ". " + this.Nom;
        }
    }

    public class Inscription
    {
        public int NumTriath, NumDossard, NumLicence;
        public DateTime DateInscription;
        public float TempsNatation, TempsCourse, TempsCyclisme;

        public Inscription(int unNumTriath, int unNumDossard, int unNumLicence, DateTime uneDateInscription, float unTempsNatation, float unTempsCourse, float unTempsCyclisme)
        {
            this.NumTriath = unNumTriath;
            this.NumDossard = unNumDossard;
            this.NumLicence = unNumLicence;
            this.DateInscription = uneDateInscription;
            this.TempsNatation = unTempsNatation;
            this.TempsCourse = unTempsCourse;
            this.TempsCyclisme = unTempsCyclisme;
        }

        public override string ToString()
        {
            return this.NumTriath + "." + this.NumDossard;
        }
    }

    public class Controler
    {
        public int NumTriath, NumDossard, CodeDop;
        public float MesureEtablie;

        public Controler(int unNumTriath, int unNumDossard, int unCodeDop, float uneMesureEtablie)
        {
            this.NumTriath = unNumTriath;
            this.NumDossard = unNumDossard;
            this.CodeDop = unCodeDop;
            this.MesureEtablie = uneMesureEtablie;
        }

        public override string ToString()
        {
            return "[" + this.NumTriath + "." + this.NumDossard + "] " + this.CodeDop;
        }
    }

    public class ProdDopant
    {
        public int CodDop;
        public string Libelle;
        public float TauxMax;

        public ProdDopant(int unCodeDop,string unLibelle, float unTauxMax)
        {
            this.CodDop = unCodeDop;
            this.Libelle = unLibelle;
            this.TauxMax = unTauxMax;
        }

        public override string ToString()
        {
            return this.CodDop + ". " + this.Libelle;
        }
    }

    public class TypeTriathlon
    {
        public int CodeTypeT, DistanceCyclisme, DistanceNatation, DistanceCourse;
        public string Designation, Nom;

        public TypeTriathlon(int unCodeTypeT, string uneDesignation, string unNom, int uneDistanceCyclisme, int uneDistanceNatation, int uneDistanceCourse)
        {
            this.CodeTypeT = unCodeTypeT;
            this.Designation = uneDesignation;
            this.Nom = unNom;
            this.DistanceCyclisme = uneDistanceCyclisme;
            this.DistanceNatation = uneDistanceNatation;
            this.DistanceCourse = uneDistanceCourse;
        }

        public override string ToString()
        {
            return this.CodeTypeT + ". " + this.Nom + " [" + this.Designation + "]";
        }
    }
}
