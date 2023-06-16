using Centenarului_Marii_Uniri.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centenarului_Marii_Uniri.Controllers
{
    internal class ControllerUtilizatori
    {

        private List<Utilizator> utilizatori;

        public ControllerUtilizatori()
        {

            utilizatori = new List<Utilizator>();
            load();

        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/utilizatori.txt";

            StreamReader streamReader = new StreamReader(path);

            string text;

            while((text = streamReader.ReadLine()) != null)
            {

                Utilizator utilizator = new Utilizator(text);
                utilizatori.Add(utilizator);

            }

            streamReader.Close();
        }

        public List<Utilizator> getUtilizatori()
        {
            return utilizatori;
        }

        public bool verificare(string email, string parola)
        {

            for(int i=0;i<utilizatori.Count;i++)
            {

                if (utilizatori[i].getEmail().Equals(email) && utilizatori[i].getParola().Equals(parola)) {

                    return true;
                
                }

            }

            return false;
        }

        public Utilizator UtilizatorByEmailParola(string email, string parola)
        {

            for (int i = 0; i < utilizatori.Count; i++)
            {

                if (utilizatori[i].getEmail().Equals(email) && utilizatori[i].getParola().Equals(parola))
                {

                    return utilizatori[i];

                }

            }

            return null;

        }

        public string toFisier()
        {

            string text = "";

            for (int i = 0; i < utilizatori.Count; i++)
            {
                text += utilizatori[i].toSave() + "\n";
            }

            return text;
        }

        public void update()
        {

            String path = Application.StartupPath + @"/data/utilizatori.txt";
            StreamWriter streamWriter = new StreamWriter(path);

            streamWriter.Write(this.toFisier());

            streamWriter.Close();

        }

        public void setParolabyEmail(string email, string parola)
        {

            for(int i=0;i<utilizatori.Count;i++)
            {
                if (utilizatori[i].getEmail().Equals(email))
                {
                    utilizatori[i].setParola(parola);
                    break;
                }
            }

        }

        public bool verificareEmail(string email)
        {

            for (int i = 0; i < utilizatori.Count; i++)
            {

                if (utilizatori[i].getEmail().Equals(email))
                {

                    return true;

                }

            }

            return false;
        }


    }
}
