using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_InheritanceAssignment
{
    class Patient : Person
    {
        public new void WhatAmI()
        {
            Console.WriteLine("I am a patient!");
        }
    }
}
