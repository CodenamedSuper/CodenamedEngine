using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodenamedEngine
{
    public class Uis
    {

        public static List<Ui> uis = new List<Ui>();

        public Uis()
        {
            uis.Add(new Button(0, "button"));
        }
    }
}
