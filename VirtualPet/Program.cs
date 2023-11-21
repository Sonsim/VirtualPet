namespace VirtualPet
{
    public class Program
    {
        static Pet CurrentPet;
        static List<Pet> _pets = new List<Pet>
            {
                new Pet("Calo", 6),
                new Pet("Easy", 3),
                new Pet ("Atlas", 5),
            };

        static void Main()
        {

            SelectPet();
        }

        static void SelectPet()
        {
           
            Console.WriteLine("Which pet do you want to select?");
            for (int i = 0; i < _pets.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] : {_pets[i].Name}");
            }

            int ans = Convert.ToInt32(Console.ReadLine());
            CurrentPet = _pets[ans - 1];

            ShowPet();
        }
        static void ShowPet()
        {
            CurrentPet.getInformation();
            Console.WriteLine("Hva vil du gjøre?");
            Console.WriteLine($"[0] - Ta vare på annet dyr");
            Console.WriteLine($"[1] - Gi mat til {CurrentPet.Name}");
            Console.WriteLine($"[2] - Leke med {CurrentPet.Name}");
            Console.WriteLine($"[3] - Gå ut med {CurrentPet.Name}");
            Console.WriteLine("----------------------------------");
            int ans = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch  (ans)
            {
                case 0:
                    CurrentPet = null;
                    SelectPet();
                    return;
                case 1:
                    CurrentPet.Feed();
                    ShowPet();
                    return;
                case 2:
                    CurrentPet.PlayWith();
                    ShowPet();
                    return;
                case 3:
                    CurrentPet.GoToilet();
                    ShowPet();
                    return;
                default:
                    CurrentPet.Idle();
                    ShowPet();
                    return;
            }
        }
    }
}