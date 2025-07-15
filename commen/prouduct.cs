using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commen
{
    public class Prouduct
    { 
        public int Id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public override string  ToString() 
        {
            return $"Id : {Id} \nName : {name} \nprice : {price}"; 
        }
         


    }
}
