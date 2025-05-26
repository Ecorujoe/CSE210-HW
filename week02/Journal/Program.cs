using System;

class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();
        //working in journal

        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {



            // choices from the vidieo
            Console.WriteLine("\nChoose between option 1-5.");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.WriteLine("What would you like to do? ");

            string choices = Console.ReadLine();
            switch (choices)
            {
                  case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt})");
                    Console.WriteLine("Record thought (type 'END' to finish):");
                    string entryText = "";
                    string line;
                    while ((line = Console.ReadLine()) != "END")
                    {
                        entryText += line + Environment.NewLine;
                    }
                    Entry newEntry = new Entry(DateTime.Now.ToString("yyyy-MM-dd"), prompt, entryText);
                    
                    journal.AddEntry(newEntry);

                    Console.WriteLine("Added");
                    break;
                    
                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    journal.LoadFromFile();
                    break;

                case "4":
                    journal.SaveToFile();
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Thank you for sharing your thoughts. Goodbye");
                    break;

                default:
                    Console.WriteLine("Please select an option");
                    break;
            }
        }
    }
}