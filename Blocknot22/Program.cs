namespace Blocknot22
{
    class Program
    {
        static void Main(string[] args)
        {
            Blocknot blocknot = new Blocknot();
            blocknot.LoadFromFile();

            do
            {
                Helper.ShowMenu();

                int choice;
                while (true)
                {
                    Console.Write("select item -> ");

                    if (Int32.TryParse(Console.ReadLine(), out choice) &&
                        Enum.IsDefined<MenuItems>((MenuItems)choice))
                        break;


                    Console.WriteLine("Illegal symbol");
                }

                MenuItems selectedItem = (MenuItems)choice;
                bool isExit = false;

                switch (selectedItem)
                {
                    case MenuItems.AddRecord:
                        Console.Write("name = ");
                        string name = Console.ReadLine();

                        Console.Write("phone = ");
                        string phone = Console.ReadLine();

                        Record record = new Record(name, phone);
                        blocknot.Add(record);

                        break;

                    case MenuItems.Find:
                        string nameToFind = Console.ReadLine();
                        IEnumerable<Record> record1 = blocknot.Find(nameToFind);

                        foreach (Record item in record1)
                        {
                            Console.WriteLine(item);
                        }

                        break;

                    case MenuItems.Remove:
                        break;

                    case MenuItems.ShowAll:
                        blocknot.ShowAllConsole();
                        break;

                    case MenuItems.Save:
                        blocknot.SaveToFile();
                        break;

                    case MenuItems.Exit:
                        isExit = true;
                        break;

                    default:
                        break;
                }

                Console.WriteLine();

                if(isExit)
                {
                    Console.WriteLine("Saving and exiting...");
                    blocknot.SaveToFile();
                    break;
                }

            } while (true);
        }
    }
}