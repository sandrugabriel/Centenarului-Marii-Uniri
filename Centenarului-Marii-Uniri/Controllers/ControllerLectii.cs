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
    internal class ControllerLectii
    {

        private List<Lectie> lectii;

        public ControllerLectii()
        {

            lectii = new List<Lectie>();
            load();

        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/lectii.txt";

            StreamReader streamReader = new StreamReader(path);

            string t;

            while((t = streamReader.ReadLine()) != null)
            {

                Lectie lectie = new Lectie(t);
                lectii.Add(lectie);

            }

            streamReader.Close();
        }



    }
}
