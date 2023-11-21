namespace VirtualPet
{
    public class Pet
    {

        public readonly string Name;
        public readonly int Age;
        private int _fun;
        private int _hunger;
        private int _toilet;

        public Pet(string name, int age, int Fun = 10, int Hunger = 10, int Toilet = 10)
        {
            Name = name;
            Age = age;
            _fun = Fun;
            _hunger = Hunger;
            _toilet = Toilet;
        }

        public void getInformation()
        {
            Console.WriteLine(""+Name);
            Console.WriteLine($"Alder: {Age}");
            Console.WriteLine($"{getProgress("Hunger", _hunger)}");
            Console.WriteLine("   " + getProgress("Fun", _fun));
            Console.WriteLine($"{getProgress("Toilet", _toilet)}");
        }

        private string getProgress(string Type, int current)
        {
            int _blank = 10 - current;
            string _string = "";

            _string = $"{Type}: [";
            for (int i = 0; i < current; i++)
            {
                _string += "■";
            }
            for (int i = 0; i < _blank; i++)
            {
                _string += " ";
            }
            _string += "]";

            return _string;
        }

        public void PlayWith()
        {
            _fun+= 5;
            _hunger--;
            _toilet--;
            fixStatus();
            Console.WriteLine($"{Name} har det gøy!");
        }

        public void Feed()
        {
            _fun--;
            _hunger += 5;
            _toilet--;
            fixStatus();
            Console.WriteLine($"{Name} liker maten og føler seg mettere");
        }

        public void GoToilet()
        {
            _fun--;
            _hunger--;
            _toilet += 5;
            fixStatus();
            Console.WriteLine("*PLUMP*");
        }

        public void Idle()
        {
            _fun--;
            _hunger--;
            _toilet--;
            fixStatus();
        }

        private void fixStatus()
        {
            if (_fun <= 3)
                Console.WriteLine("jeg kjeeeeeeeeeeeeeder meggg....");
            if (_hunger <= 3)
                Console.WriteLine("jeg døøøøøøøøøøør....");
            if (_toilet == 0)
                Console.WriteLine("jeg bæsja i senga....");

            if (_fun < 0)
                _fun = 0;
            if (_hunger < 0)
                _fun = 0;
            if (_toilet < 0)
                _toilet = 0;

            if (_fun > 10)
                _fun = 10;
            if (_hunger > 10)
                _hunger = 10;
            if (_toilet > 10)
                _toilet = 10;
        }

    }
}
