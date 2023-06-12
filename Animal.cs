using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnimalSounds
{
    public class Animal
    {
        public string animal { get; set; }
        public string sound { get; set; }

        public virtual void AnimalSounds()
        {
            Console.WriteLine($"{animal} emits a sound");
        }
    }
}
