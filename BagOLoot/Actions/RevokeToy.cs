using System;
using System.Collections.Generic;


namespace BagOLoot.Actions
{
    public class RevokeToy
    {
        public static void DoAction(ToyRegister bag, ChildRegister book)
        {
            Console.Clear();
            Console.WriteLine("Choose child to take toy from");

            var children = book.GetChildren().ToArray();
            foreach (Child child in children)
            {
                Console.WriteLine($"{Array.IndexOf(children, child) + 1}. {child.name}");
            }

            Console.Write("> ");
            string childName = Console.ReadLine();
            Child kid = book.GetChild(children[int.Parse(childName) - 1].name);
            //Console.WriteLine(kid);

            var kidsToyList = bag.GetToysForChild(kid).ToArray();

            Console.WriteLine("Choose the toy to take");
            foreach (Toy toy in kidsToyList)
            {
                Console.WriteLine($"{Array.IndexOf(kidsToyList, toy) + 1}. {toy.name}");
            }

            Console.Write("> ");
            var toyChoice = Console.ReadLine();
            var chosenToy = kidsToyList[int.Parse(toyChoice) - 1];

            bag.RevokeToy(kid, chosenToy);
        }
    }
}