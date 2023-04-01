using System.ComponentModel.Design;
//TASK 1:

int Points = 0;


if (Points < 51 && Points <= 0)
{
    Console.WriteLine("Kesildiniz");
}


else if (Points >= 51 && Points <= 60)
{
    Console.WriteLine("E");
}


else if (Points >= 61 && Points <= 70)
{
    Console.WriteLine("D");
}


else if (Points >= 71 && Points <= 80)
{
    Console.WriteLine("C");
}


else if (Points >= 81 && Points <= 90)
{
    Console.WriteLine("B");
}


else if ( Points >= 91 && Points <= 100)
{
    Console.WriteLine("A");
}


else if (Points < 0 || Points > 100)
{
    Console.WriteLine( "Points are not valid" );
}