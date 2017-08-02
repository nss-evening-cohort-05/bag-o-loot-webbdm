using System;

namespace BagOLoot
{
    public class Toy
    {
        public string name { get; set; }
        public Child child { get; set; }

        public static implicit operator Toy(string v)
        {
            throw new NotImplementedException();
        }
    }
}
