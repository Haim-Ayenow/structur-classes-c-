using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    public class Employee : User
    {
        public string role;
        public int sollare;

        public Employee(string name, int year, string Email, string role, int sollare) : base(name, year, Email)
        {
            this.role = role;
            this.sollare = sollare;
        }
        protected override string print()
        {
           
            return ($"{base.print()}role:{this.role},sollare:{this.sollare}");
        }
        public void print1()
        {
       
            Console.WriteLine(print());  
        }
    }


}
