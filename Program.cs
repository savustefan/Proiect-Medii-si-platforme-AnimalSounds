using System.Xml.Linq;

namespace AnimalSounds
{
    class Program
    {
        class Porc : Animal
        {
            public override void AnimalSounds()
            {
                Console.WriteLine($"{animal} makes: {sound}.");
            }
        }

        class Caine : Animal
        {
            public override void AnimalSounds()
            {
                Console.WriteLine($"{animal} makes: {sound}");
            }
        }

        class Pisica : Animal
        {
            public override void AnimalSounds()
            {
                Console.WriteLine($"{animal} makes: {sound}.");
            }
        }

        class Lup : Animal
        {
            public override void AnimalSounds()
            {
                Console.WriteLine($"{animal} makes: {sound}!");
            }
        }

       
            static void Main(string[] args)
            {
                Animal caine = new Caine { animal = "Câine", sound = "woof, woof" };
                Animal porc = new Porc { animal = "Porc", sound = "oink, oink" };
                Animal lup = new Lup { animal = "Lup", sound = "WOOOOOF" };
                Animal pisica = new Pisica { animal = "Pisică", sound = "miau" };

                List<Animal> animale = new List<Animal>
            {
                caine,
                porc,
                lup,
                pisica
            };

                foreach (Animal animal in animale)
                {
                    animal.AnimalSounds();
                }

                Console.ReadLine();
            }
        }
 }
