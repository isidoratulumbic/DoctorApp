using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMSKT3.Model
{
    public class Examination
    {
        public string name { get; set; }
        public string jmbg { get; set; }

        public Examination(string name, string jmbg)
        {
            this.name = name;
            this.jmbg = jmbg;
        }

    }
}
