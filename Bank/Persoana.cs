using System;

namespace OOP
{
    public class Persoana
    {
        public Persoana() {}

        public Persoana(string name, DateTime dataNasterii)
        {
            Name = name;
            DataNasterii = dataNasterii;
        }

        public string Name { get; set; }
        public DateTime DataNasterii { get; set; }


    }
}