using ConsoleApp7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data;

namespace ConsoleApp7.Animals
{
    public class Elephant : Animal
    {
        public Elephant(string name, int age, string biom, int sound, string foodtype, int mass, double area)
        {
            Name = name;
            Age = age;
            Biom = biom;
            Sound = sound;
            Foodtype = foodtype;
            Mass = mass;
            Area = area;
            _massLuseCoef = 0.1d;
            _type = "Elephant";
        }
        public void Eat(int foodMass)
        {
            Mass += foodMass / 2; Console.WriteLine($"{Name}: Nam-Nam");
        }
        public void DoAuf()
        {
            Console.WriteLine($"{Name}: Auf_Auf");
        }
        public void Run(int distance)
        {
            Mass -= (int)(distance * _massLuseCoef);
        }
    }
    public class Pinguin : Animal
    {
        public Pinguin(string name, int age, string biom, int sound, string foodtype, int mass, double area)
        {
            Name = name;
            Age = age;
            Biom = biom;
            Sound = sound;
            Foodtype = foodtype;
            Mass = mass;
            Area = area;
            _massLuseCoef = 0.1d;
            _type = "Pinguin";
        }
        public void Eat(int foodMass)
        {
            Mass += foodMass / 2; Console.WriteLine($"{Name}: Nam-Nam");
        }
        public void DoXru()
        {
            Console.WriteLine($"{Name}: Xru-Xru");
        }
        public void Run(int distance)
        {
            Mass -= (int)(distance * _massLuseCoef);
        }
    }

    public class Tiger : Animal
    {
        public Tiger(string name, int age, string biom, int sound, string foodtype, int mass, double area)
        {
            Name = name;
            Age = age;
            Biom = biom;
            Sound = sound;
            Foodtype = foodtype;
            Mass = mass;
            Area = area;
            _massLuseCoef = 0.1d;
            _type = "Tiger";
        }
        public void Eat(int foodMass)
        {
            Mass += foodMass / 2; Console.WriteLine($"{Name}: Nam-Nam");
        }
        public void DoRrr()
        {
            Console.WriteLine($"{Name}: Rrr-Rrr");
        }
        public void Run(int distance)
        {
            Mass -= (int)(distance * massLuseCoef);
        }
    }
}
