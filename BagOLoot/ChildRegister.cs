using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;

namespace BagOLoot
{
    public class ChildRegister
    {
        private List<Child> _children = new List<Child>();
        public Child AddChild (string child) 
        {
            var child = new Child()
                {
                    name = child,
                    delivered = false
                };
            _children.Add(child);

            return child;
        }

        public List<Child> GetChildren () => _children;

        public Child GetChild (int id) =>  _children.SingleOrDefault(kid => kid.id == id);
        
    }
}
