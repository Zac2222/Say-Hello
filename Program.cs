//Peer Reivew: Saul Suazo
//Comments: Code looks good and works man!


bool runAgain = true;

while (runAgain == true)
{
    string choice = "";
    string name;
    Console.WriteLine("What is your name?");
    name = Console.ReadLine();
    Console.WriteLine($"Hello, {name}!");
    Console.WriteLine("run again? (y / n)");

    while(choice != "yes" & choice != "y" & choice != "no" & choice != "n")
    {
        choice = Console.ReadLine().ToLower();
    }
    
    if(choice == "y" || choice == "yes")
    {
        runAgain = true;
    }
    else if(choice == "n" || choice == "no")
    {
        runAgain = false;
        Console.WriteLine("Now exiting");
    }
}
