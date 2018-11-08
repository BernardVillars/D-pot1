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

        //Constructeur par défaut
        public Personne() : this("Default","Jacques", 0) { }

        public Personne(string nom,string prenom, int age)
         {
            this.Prenom = prenom ;
            this.Nom = nom;
            this.Age = age;
        }

        public override string ToString()
        {
            return String.Format("Nom={0}, Age={1}", Nom, Age);
        }
    }

}
