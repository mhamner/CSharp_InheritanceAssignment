using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_InheritanceAssignment
{
    public class Hospital : Building
    {
        public override void WhatAmI()
        {
            Console.WriteLine("I am a hospital!");
        }
    }
}
