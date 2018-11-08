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

        //Constructeur par défaut
        public Personne() : this("Default","Jacques", 0, "Routier") { }

        public Personne(string nom,string prenom, int age,string qualite)
         {
            this.Prenom = prenom ;
            this.Nom = nom;
            this.Age = age;
        }

        public override string ToString()
        {
            return String.Format("Prénom={0},Nom={1}, Age={2}, Qualité={3}", Prenom, Nom, Age, Qualite);
        }
    }

}
