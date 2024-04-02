using System;
using System.Collections;

class Program
{
    static Stack jediCouncil = new Stack();
    static Queue padawanLine = new Queue();

    static void Main(string[] args)
    {
        InitializeJediCouncil();
        InitializePadawanLine();

        DisplayMenu();
    }

    static void DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("\n--- Jedi Training Program ---");
            Console.WriteLine("1. View Jedi Council");
            Console.WriteLine("2. View Padawan Line");
            Console.WriteLine("3. Add Padawan to Line");
            Console.WriteLine("4. Train Next Padawan");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ViewJediCouncil();
                    break;
                case "2":
                    ViewPadawanLine();
                    break;
                case "3":
                    AddPadawanToLine();
                    break;
                case "4":
                    TrainNextPadawan();
                    break;
                case "5":
                    Console.WriteLine("Exiting program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ViewJediCouncil()
    {
        Console.WriteLine("\nJedi Council:");
        PrintStack(jediCouncil);
    }

    static void ViewPadawanLine()
    {
        Console.WriteLine("\nPadawan Line:");
        PrintQueue(padawanLine);
    }

    static void AddPadawanToLine()
    {
        Console.Write("Enter the name of the Padawan: ");
        string padawanName = Console.ReadLine();
        padawanLine.Enqueue(padawanName);
        Console.WriteLine($"{padawanName} has been added to the Padawan line.");
    }

    static void TrainNextPadawan()
    {
        if (padawanLine.Count == 0)
        {
            Console.WriteLine("No Padawans in line for training.");
            return;
        }

        string padawan = (string)padawanLine.Dequeue();
        jediCouncil.Push(padawan);
        Console.WriteLine($"{padawan} has been trained and welcomed to the Jedi Council!");
    }

    static void InitializeJediCouncil()
    {
        jediCouncil.Push("Master Yoda");
        jediCouncil.Push("Obi-Wan Kenobi");
        jediCouncil.Push("Mace Windu");
    }

    static void InitializePadawanLine()
    {
        padawanLine.Enqueue("Anakin Skywalker");
        padawanLine.Enqueue("Ahsoka Tano");
        padawanLine.Enqueue("Ezra Bridger");
    }

    static void PrintStack(Stack stack)
    {
        foreach (var jedi in stack)
        {
            Console.WriteLine(jedi);
        }
    }

    static void PrintQueue(Queue queue)
    {
        foreach (var padawan in queue)
        {
            Console.WriteLine(padawan);
        }
    }
}
