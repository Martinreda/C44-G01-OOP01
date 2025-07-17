using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01.UD_datatypes
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
       // public string Gender { get; set; }
       public Gender Gender { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Gender: {Gender}";
        }


    }
}
