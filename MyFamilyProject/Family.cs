using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFamilyProject
{
    public class Family
    {
        public string Fun { get; set; }
        public string Struggles { get; set; }
        public string Fights { get; set; }
        public string TouchingMoments { get; set; }

        public Family(string fun, string struggles, string fights, string touchingMoments)
        {
            Fun = fun;
            Struggles = struggles;
            Fights = fights;
            TouchingMoments = touchingMoments;
        }
    }
}
