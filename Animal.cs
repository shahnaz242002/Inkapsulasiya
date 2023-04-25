using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public abstract class Animal
   
    {

        public string Name { get; protected set; }
        public int Age { get; protected set; }
        public string Biom { get; protected set; }
        public int Sound { get; protected set; }
        public string Foodtype { get; protected set; }
        public int Mass { get; protected set; }
        public double Area { get; protected set; }
        protected double _massLuseCoef { get; set; }
        protected string _type;
    
    }
}
