using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Training2.Data
{
    public class Cars
    {
       
        public string Hersteller { get; set; }
       public virtual Type[] Type { get; set; }
    }
    public class Type
    {
        public Type(string _Name)
        {
            Name = _Name;
        }
        public string Name { get; set; }

    }
}
