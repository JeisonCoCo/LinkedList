using LinkedList.Cor;
using System.ComponentModel.Design;

var list = new SinglyLinkedList<string>();


var option = string.Empty;
do
{
    Console.WriteLine("------------------------------------------------------------");
    option = Menu();
    switch (option)
    {
        case "0": 
            Console.Write("Bye.");
            break;
        case "1": 
            Console.Write("Enter the value: ");
            list.InsertAtBeginning(Console.ReadLine()!);
            break;
        case "2":
            Console.Write("Enter the value: ");
            list.InsertAtEnd(Console.ReadLine()!);
            break;
        case "3":
            Console.Write("Enter the value at Remove");
            list.RemoveList(Console.ReadLine()!);
            break;
        case "4":
            Console.Write("Enter the value at Reverse");
            list.ReverseList(Console.ReadLine()!);
            break;
        case "5": 
            list.PrintList();
            break;
        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}
while (option != "0");

string Menu()
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Insert at Beginning");
    Console.WriteLine("2. Insert at End");
    Console.WriteLine("3. Insert value to Delete");
    Console.WriteLine("4. Insert value to Remove");
    Console.WriteLine("5. Print list");
    Console.WriteLine("0. Exit");
    Console.Write("Choose an option:");
    
    return Console.ReadLine()!;
}
Console.WriteLine("");
Console.WriteLine("------------------------------------------------------------");