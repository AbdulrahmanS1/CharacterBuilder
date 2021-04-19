using System;

namespace CharacterBuilder
{
    class Program
    {
        class CharcterBuild
        {
            private string character;

            public CharcterBuild()
            {
           
                this.character = " ";

            }
            public CharcterBuild _CharLevel(string value)
            {
                this.character += " "+ value+" ";
                return this;
            }
            public CharcterBuild _Name(string value)
            {
                this.character += " "+ value+" ";
                return this;
            }
            public CharcterBuild _CharRace(string value)
            {
                //race= orc-human-elev-gnome-undead
                this.character += " "+ value+" ";
                return this;
            }
             public CharcterBuild _CharGender(string value)
            {
                //gender = male/ female
                this.character +=" "+ value+" ";
                return this;
            }
            public CharcterBuild setCharacter(string value)
            {
                this.character += " "+ value+" ";
                return this;
            }
          
            public string get()
            {
                return this.character ;
            }
        }
        static void Main(string[] args)
        {
            CharcterBuild hi = new CharcterBuild();
            string x  = hi._Name("Mai")._CharGender("Female")._CharRace("Elev")._CharLevel("Level 33 with an exp 99.99").get();
            Console.WriteLine(x);
             string z  = hi._Name("Lucio")._CharGender("Male")._CharRace("Gnome")._CharLevel("Level 35 with an exp 00.50").get();
            Console.WriteLine(z);
        }
    }
}
