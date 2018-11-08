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
        public int Age { get; set; }

        public int MyProperty { get; set; }

        //Constructeur par défaut
        public Personne() : this("Default", 0) { }

        public Personne(string nom, int age)
        {
            this.Nom = nom;
            this.Age = age;
        }

        public override string ToString()
        {
            return String.Format("Nom={0}, Age={1}", Nom, Age);
        }
    }

}
