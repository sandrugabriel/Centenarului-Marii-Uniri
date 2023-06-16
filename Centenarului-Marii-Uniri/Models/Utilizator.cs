using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centenarului_Marii_Uniri.Models
{
    internal class Utilizator
    {

        private int id;
        private string name;
        private string parola;
        private string email;

        public Utilizator()
        {

        }

        public Utilizator(int id, string name, string parola, string email)
        {
            this.id = id;
            this.name = name;
            this.parola = parola;
            this.email = email;
        }

        public Utilizator(string text) {

            string[] prop = text.Split('*');

            this.id = int.Parse(prop[0]);
            this.name = prop[1];
            this.parola = prop[2];
            this.email = prop[3];

        }

        public int getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public string getParola()
        {
            return parola;
        }

        public string getEmail()
        {
            return email;
        }

        public void setParola(string parola)
        {
            this.parola = parola;
        }

        public string toSave()
        {

            return id.ToString() + "*" + name + "*" + parola + "*" + email;
        }

    }
}
