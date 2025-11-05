namespace LittleCompany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapa en lista för att lagra anställda
            List<Personal> employees = new List<Personal>();

            Console.WriteLine("Det här är en personalregistering.");

            // Loop för att registrera fler än en anställd
            while (true)
            {
                Console.WriteLine("\nAnge namn på den anställda: ");
                string name = Console.ReadLine();

                Console.WriteLine("Ange lön på den anställda: ");
                int salary = Convert.ToInt32(Console.ReadLine());

                // Skapar en personalobjekt och lägger till i listan
                Personal personal = new Personal(name, salary);
                employees.Add(personal);

                Console.WriteLine("Du har registrerat en anställd med namn: " + personal.name + " och lön: " + personal.salary);

                Console.WriteLine("Vill du registrera en till anställd? (j/n)");
                char answer = Convert.ToChar(Console.ReadLine());

                // Avsluta loopen om användaren inte vill registrera fler anställda
                if (answer != 'j')
                {
                    break; 
                }
            }

            // Visa alla registrerade anställda
            Console.WriteLine("\nAlla registrerade anställda:");
            foreach (Personal emp in employees)
            {
                Console.WriteLine("Anställd: " + emp.name + ", Lön: " + emp.salary);
            }
        }

        public class Personal(string name, int salary)
        {
            public string name = name;
            public int salary = salary;
        }
    }
}
