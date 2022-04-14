bool realNum = false;
int userIn = 0;
string yes = "yes";
string y = "y";
string no = "no";
string n = "n";
string userAns;


Console.WriteLine("Hello, User, would you like to tell me your first name?");
string userName = Console.ReadLine();
Console.WriteLine();
begin:
Console.WriteLine("Okay, " + userName + ", please enter a number between 1 and 100. (Whole numbers only, plesase.)");
string userInput = Console.ReadLine();
realNum = int.TryParse(userInput, out userIn);

if (realNum == false)
{
    Console.WriteLine("Hm, try a NUMBER!");
    Console.WriteLine();
    goto begin;
}
else if (userIn < 1 || userIn > 100)
{
    Console.WriteLine("Umm... try again.");
    Console.WriteLine();
    goto begin;
}
else if (userIn % 2 != 0 && userIn < 60)
{
    Console.WriteLine(userName + ", " + userInput + " is odd and it's less than 60. Wanna go again?");
    userAns = Console.ReadLine().ToLower();
    userAns.Trim();
    userAns = userAns.Trim();
    Console.WriteLine();

    if (userAns == yes || userAns == y)
    {
        goto begin;
    }
    else
    {
        Console.WriteLine("So long.");
    }
}
else if (userIn % 2 == 0 && userIn > 1 && userIn < 25)
{
    Console.WriteLine(userName + ", " + userInput + " is even and it's less than 25. Any more?");
    userAns = Console.ReadLine().ToLower();
    userAns.Trim();
    userAns = userAns.Trim();
    Console.WriteLine();

    if (userAns == yes || userAns == y)
    {
        goto begin;
    }
    else
    {
        Console.WriteLine("So long.");
    }
}
else if (userIn % 2 == 0 && userIn > 25 && userIn < 61)
{
    Console.WriteLine(userName + ", " + userInput + " is even and it's between 26 and 60 (inclusive). Got another?");
    userAns = Console.ReadLine().ToLower();
    userAns.Trim();
    userAns = userAns.Trim();
    Console.WriteLine();

    if (userAns == yes || userAns == y)
    {
        goto begin;
    }
    else
    {
        Console.WriteLine("So long.");
    }
}
else if (userIn % 2 == 0 && userIn > 61)
{
    Console.WriteLine(userName + ", " + userInput + " is even and it's greater than 60. One more?");
    userAns = Console.ReadLine().ToLower();
    userAns.Trim();
    userAns = userAns.Trim();
    Console.WriteLine();

    if (userAns == yes || userAns == y)
    {
        goto begin;
    }
    else
    {
        Console.WriteLine("So long.");
    }
}
else
{
    Console.WriteLine(userName + ", " + userInput + " is odd and it's greater than 60. Will that be all?");
    userAns = Console.ReadLine().ToLower();
    userAns.Trim();
    userAns = userAns.Trim();
    Console.WriteLine();

    if (userAns == no || userAns == n)
    {
        goto begin;
    }
    else
    {
        Console.WriteLine("So long.");
    }
}

Console.ReadLine();
