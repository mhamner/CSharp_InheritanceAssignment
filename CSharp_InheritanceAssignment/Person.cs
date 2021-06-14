using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_InheritanceAssignment
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public void WhatAmI()
        {
            Console.WriteLine("I am a person!");
        }
    }
}
