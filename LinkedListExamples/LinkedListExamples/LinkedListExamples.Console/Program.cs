
using LinkedListExamples.Core;
using System.ComponentModel.Design;


var list = new SinglyLinkedList<string>();
var opc = string.Empty;


do
{
    opc = Menu();
    switch (opc)
    {
        case "0":
            Console.WriteLine("Exiting...");
            break;
        case "1":
            Console.Write("Enter the value to insert at the beginning: ");
            var valueAtBeginning = Console.ReadLine()!;
            list.InsertAtBeginning(valueAtBeginning);
            Console.WriteLine($"Inserted {valueAtBeginning} at the beginning.");
            break;
        case "2":
            Console.Write("Enter the value to insert at the end: ");
            var valueAtEnd = Console.ReadLine()!;
            list.InsertAtEnd(valueAtEnd);
            Console.WriteLine($"Inserted {valueAtEnd} at the end.");
            break;
        case "3":
            Console.WriteLine("Current List:");
            list.PrintList();
            Console.WriteLine();
            break;
        default:
            Console.WriteLine();
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }

}while (opc != "0");

string Menu()
{
    Console.WriteLine();
    Console.WriteLine("1. Insert at Beginning");
    Console.WriteLine("2. Insert at End");
    Console.WriteLine("3. Print List");
    Console.WriteLine("0. Exit");
    Console.Write("Enter your option: ");
    return Console.ReadLine()!;
}


