using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnimalSounds
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Sound { get; set; }

        public virtual void AnimalSounds()
        {
            Console.WriteLine($"{Name} emits a sound");
        }
    }
}
