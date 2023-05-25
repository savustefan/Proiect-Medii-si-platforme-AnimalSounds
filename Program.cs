namespace AnimalSounds
{
    class Porc : Animal
    {
        public override void SunetAnimal()
        {
            Console.WriteLine("Porc makes: oink,oink.");
        }
    }

    class Caine : Animal
    {
        public override void SunetAnimal()
        {
            Console.WriteLine("Câine makes: woof, woof");
        }
    }


    class Pisica : Animal
    {
        public override void SunetAnimal()
        {
            Console.WriteLine("Pisică makes: miau.");
        }
    }


    class Lup : Animal
    {
        public override void SunetAnimal()
        {
            Console.WriteLine("Delfin makes: WOOOOOF!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal caine = new Caine();
            Animal porc = new Porc();
            Animal lup = new Lup();
            Animal pisica = new Pisica();

            List<Animal> animale = new List<Animal>();
            animale.Add(caine);
            animale.Add(porc);
            animale.Add(lup);
            animale.Add(pisica);


            foreach (Animal animal in animale)
            {
                animal.SunetAnimal();
            }
        }
    }
}