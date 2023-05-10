using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCS
{
    public class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public Person(string name, int id)
        {
            this.Name = name;
            this.Id = id;
            this.Date = DateTime.Now;
        }
    }
}
