using System;
using System.Collections.Generic;


namespace BagOLoot.Actions
{
    public class GetChildsList
    {
        public static void DoAction(ToyRegister bag, ChildRegister book)
        {
            Console.Clear();
            Console.WriteLine("Choose a child to see their toys");

            var children = book.GetChildren().ToArray();
            foreach (Child child in children)
            {
                Console.WriteLine($"{Array.IndexOf(children, child) + 1}. {child.name}");
            }

            Console.Write("> ");
            string childName = Console.ReadLine();
            Child kid = book.GetChild(children[int.Parse(childName) - 1].name);

            var toyList = bag.GetToysForChild(kid).ToArray();

            foreach (Toy toy in toyList)
            {
                Console.WriteLine($"{Array.IndexOf(toyList, toy) + 1}. {toy.name}");
            }
            

            // bag.RevokeToy(kid, chosenToy);
            Console.ReadLine();




            //bag.GetToysForChild(kid);
        }
    }
}