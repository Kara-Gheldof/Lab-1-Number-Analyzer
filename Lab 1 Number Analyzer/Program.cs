// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, what is your name?");
string UserName = Console.ReadLine();

Console.WriteLine("Good day " + UserName + ", please enter an integer between 1 and 100.");
string integer = Console.ReadLine();
int Number1 = Convert.ToInt32(Console.ReadLine());

if (Number1 > 1 && Number1 < 100) ;

{

    if (Number1 < 60 && Number1 % 2 != 0) ;
    { Console.WriteLine(Number1 + " is odd and less than 60."); }

    if (Number1 % 2 == 0 && Number1 >= 2 && Number1 <= 24) ;
    { Console.WriteLine(Number1 + " is even and less than 25"); }

    if (Number1 % 2 == 0 && Number1 >= 26 && Number1 >= 60) ;
    { Console.WriteLine(Number1 + " is even and between 26 and 60 inclusive."); }

    if (Number1 % 2 == 0 && Number1 > 60) ;
    { Console.WriteLine(Number1 + " is even and greater than 60"); }

    if (Number1 % 2 != 0 && Number1 > 60) ;
    { Console.WriteLine(Number1 + " is odd and greater than 60"); }

}
Console.WriteLine("Thank you " + UserName + " and have a good night!");