using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab1
{
    public class customer
    {
        public string Name { get; set; }
        public string phoneNumber { get; set; }

        public customer(string name, string phonenumber)
        {
            Name = name;
            phoneNumber = phonenumber;
        }
    }
}