using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        private string firstname;
        public int Id { get; set; }
        public string Firstname { 
            get 
            {
                return "Mrs." + firstname;
            }
            set 
            {
                firstname = value;
            }
                
          }
        public string Lastname { get; set; }
        public string City { get; set; }
    }
}
