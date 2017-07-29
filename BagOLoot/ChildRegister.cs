using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;

namespace BagOLoot
{
    public class ChildRegister
    {
        private List<Child> _children = new List<Child>();
        public int AddChild (string child) 
        {
            _children.Add(
                new Child()
                {
                    id = id,
                    name = child,
                    delivered = false
                }
            );

            return id;
        }

        public List<Child> GetChildren () => _children;

        public Child GetChild (int id) =>  _children.SingleOrDefault(kid => kid.id == id);
        
    }
}
