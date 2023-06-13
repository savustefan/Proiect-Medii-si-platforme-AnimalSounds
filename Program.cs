using System.Xml.Linq;

namespace AnimalSounds
{
    class Program
    {
        class Porc : Animal
        {
            public override void AnimalSounds()
            {
                Console.WriteLine($"{Name} makes: {Sound}.");
            }
        }

        class Caine : Animal
        {
            public override void AnimalSounds()
            {
                Console.WriteLine($"{Name} makes: {Sound}");
            }
        }

        class Pisica : Animal
        {
            public override void AnimalSounds()
            {
                Console.WriteLine($"{Name} makes: {Sound}.");
            }
        }

        class Lup : Animal
        {
            public override void AnimalSounds()
            {
                Console.WriteLine($"{Name} makes: {Sound}!");
            }
        }

        static void Main(string[] args)
        {
            Animal caine = new Caine { Name = "Câine", Sound = "woof, woof" };
            Animal porc = new Porc { Name = "Porc", Sound = "oink, oink" };
            Animal lup = new Lup { Name = "Lup", Sound = "WOOOOOF" };
            Animal pisica = new Pisica { Name = "Pisică", Sound = "miau" };

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
