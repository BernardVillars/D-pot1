using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGit
{

    public class Personne
    {

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public string Qualite { get; set; }
        public string Adresse { get; set; }

        //Constructeur par défaut
        public Personne() : this("Dupont","Jacques", 30, "Routier","12 rue") { }

        public Personne(string nom,string prenom, int age,string qualite,string adresse)
         {
            this.Prenom = prenom ;
            this.Nom = nom;
            this.Age = age;
            this.Qualite=qualite;
            this.Adresse=adresse;
        }

        public override string ToString()
        {
            return String.Format("Prénom= {0}\nNom= {1}\nAge= {2}\nQualité= {3}\nAdresse= {4}", Prenom, Nom, Age, Qualite, Adresse);
        }
    }

}
