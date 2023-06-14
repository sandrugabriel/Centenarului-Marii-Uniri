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


    }
}
