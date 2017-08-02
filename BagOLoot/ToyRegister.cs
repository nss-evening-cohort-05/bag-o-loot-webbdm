using System.Collections.Generic;
using System.Linq;

namespace BagOLoot
{
    public class ToyRegister
    {
        private List<Toy> _toys = new List<Toy>();

        public Toy Add(string toy, Child child)
        {
            // Create new toy instance
            Toy newToy = new Toy()
            {
                name = toy,
                child = child
            };

            // Add to private collection
            _toys.Add(newToy);

            return newToy;
        }

        public void RevokeToy(Child kid, Toy toy)
        {
            // var toyToTake = from toy1 in _toys
            //            where toy1.child.name == kid.name
            //            select toy1;


            //toyToTake.ToList();

            _toys.Remove(toy);

        }

        public List<Toy> GetToysForChild(Child kid)
        {

            var selectedToy = from toy in _toys
                              where toy.child.name == kid.name
                              select toy;

            var toyList = selectedToy.ToList();

            return toyList;

        }
    }
}
