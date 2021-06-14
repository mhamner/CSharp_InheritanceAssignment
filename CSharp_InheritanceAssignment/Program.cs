using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_InheritanceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demos doing inheritance in different ways, both with the new keyword and the virtual / override methods
            Person person = new Person();
            person.WhatAmI();

            Patient patient = new Patient();
            patient.WhatAmI();

            //Will display "I am a person!" because it will use the method from the base class when using New
            Person patient1 = new Patient();
            patient1.WhatAmI();

            Building building = new Building();
            building.WhatAmI();

            Hospital hospital = new Hospital();
            hospital.WhatAmI();

            //Will display "I am a hospital!" because it will use the method from the derived class when using Override
            Building hospital1 = new Hospital();
            hospital1.WhatAmI();                

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
