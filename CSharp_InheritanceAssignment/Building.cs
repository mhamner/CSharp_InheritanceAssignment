using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_InheritanceAssignment
{
    public class Building
    {
        public string Address { get; set; }
        public string NumberOfFloors { get; set; }

        public virtual void WhatAmI()
        {
            Console.WriteLine("I am a buiding!");
        }
    }
}
