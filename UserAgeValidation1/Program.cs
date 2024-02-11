// See https://aka.ms/new-console-template for more information

//rakendus kysib kasutajal tema vanuse
//kui kasutaja vanus on vaiksem kui 13 siis konsoolis kuvatakse:
//"You are too young to use Instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to Instagram"

using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if (isAgeNumber)
{
    if (userAgeNum >=13)
    {
        Console.WriteLine("Welcome to Instagram.");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram");
    }
}
else
{
    Console.WriteLine("Could not read your age.");
}




