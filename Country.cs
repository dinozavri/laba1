using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_1
{
    class Country
    {
        public string Name{get; set;}
        public string Form_of_government{ get; set;}
        public float Area { get; set;}
        public Country ()
        {
            Name = "Беларусь";
            Form_of_government = "Республика";
            Area= 208000;
        }
    }
}
