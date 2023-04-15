String name = "Kamil";
bool male = true;
var age = 30;
string result1 = "Mężczyzna poniżej 30lat";
string result2 = "Kamil, lat 30";
string result3 = "Niepełnoletnia Kobieta";


if (age < 30 && male == true)
{
    Console.WriteLine( result1 );
}
if (age == 30 && male == true && name == "Kamil" )
{
    Console.WriteLine( result2 );
}
if (age < 18 && male == true)
{
    Console.WriteLine( result3 );
}
