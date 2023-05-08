using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCS
{
    public class Person
    {
        public string Name { get; set;  }
        public Guid Id { get; set; }

        public Person(string name, Guid id)
        {
            this.Name = name;
            this.Id = id;
        }
    }
}
