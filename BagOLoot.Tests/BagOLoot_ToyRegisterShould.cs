using System;
using System.Collections.Generic;
using Xunit;

namespace BagOLoot.Tests
{
    public class ToyRegisterShould
    {
        private readonly ToyRegister _register;
        private readonly ChildRegister _book;

        public ToyRegisterShould()
        {
            _register = new ToyRegister();
            _book = new ChildRegister();
        }

        [Fact]
        public void AddToy()
        {
            // Create a child
            Child kid = _book.AddChild("Terell");

            // Add a toy for the child
            Toy toy = _register.Add("Silly Putty", kid);
            Assert.True(toy != null);
        }

        [Fact]
        public void RevokeToyFromChild()
        {
            Child kid = _book.AddChild("Terell");
            Toy toy = _register.Add("Silly Putty", kid);
            _register.RevokeToy(kid, toy);
            List<Toy> toysForTerell = _register.GetToysForChild(kid);

            Assert.DoesNotContain(toy, toysForTerell);

        }

        // [Fact]
        // public void ListChildren()
        // {
        //     Child child1 = _book.AddChild("Fred");
        //     Child child2 = _book.AddChild("Greg");
        //     Toy toy1 = _register.Add("Ball", child1);
        //     Toy toy2 = _register.Add("Top", child2);
        //     Toy toy3 = _register.Add("Truck", child1);

        //     //Assert.Count(); 
        // }

        [Fact]
        public void ListAllofChildsToys()
        {
            Child child1 = _book.AddChild("Fred");
            Child child2 = _book.AddChild("Greg");
            Toy toy1 = _register.Add("Ball", child1);
            Toy toy2 = _register.Add("Truck", child1);
            Toy toy3 = _register.Add("Top", child2);

            List<Toy> toysForKiddo = _register.GetToysForChild(child1);

            Assert.Contains("Ball", "Truck");
            // Assert.Count(); 
        }

    }
}
