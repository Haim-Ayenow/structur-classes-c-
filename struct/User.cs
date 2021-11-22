using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Struct
{
    public class User:IComparable
{
        public string name;
        public int year;
        public string Email;

        public User() { }
        

        public User(string name, int year, string Email)
        {
            this.name = name;
            this.year = year; 
            this.Email = Email; 
        }
        protected virtual string print()
        {
           return ($"name:{this.name},year:{this.year},Email:{this.Email}");
        }
        public int CompareTo(object obj)
        {
            User u = (User)obj;
            if (this.year > u.year) return -1;
            if (this.year < u.year) return 1;
            return 0;
        }
    }
}
