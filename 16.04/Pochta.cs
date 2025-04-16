using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._04
{
    internal class Pochta
    {
        string nameOrganoz;

        public Pochta(string NameOrganoz_, string Street_, string Numberhome_)
        {
            nameOrganoz = NameOrganoz_;
            street = Street_;
            numberhome = Numberhome_;
        }
        public string NameOrganoz
        {
            get;
            set;
        }
        string street;
        public string Street
        {
            get;
            set;
        }
        string numberhome;
        public string Numberhome
        {
            get;
            set;
        }

    }
}
