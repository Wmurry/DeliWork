main();

void main()
{
    List<string> Full_Order = new List<string>();
    do
    {
        Full_Order.Add(set_order().ToString());
    } while (new_order() == true);
    display_order(Full_Order);
    Console.ReadKey();
}

(string name, double value) set_order()
{
    return (meat_or_cheese(), number());
}

bool new_order()
{
    Console.WriteLine("Anything else Y for true");
    string userName = Console.ReadLine();
    if ((userName == "Y") || (userName == "y"))
    {
        return true;
    }
    return false;
}

double number()
{
    while (true)
    {
        Console.WriteLine("How much in lbs?");
        string userName = Console.ReadLine();
        if (Double.TryParse(userName, out double result))
        {
            return result;
        }
        else { Console.WriteLine("Order must be a numerical value."); }
    }
}

string meat_or_cheese()
{
    while (true)
    {
        Console.WriteLine("Which meat or cheese do you want?");
        string userName = Console.ReadLine();
        if (userName != "")
        {
            return userName;
        }
        else { Console.WriteLine("Order cant be empty."); }
    }
}

void display_order(List<string> list)
{
    foreach (var i in list)
    {
        Console.WriteLine($"{i}");
    }
}

