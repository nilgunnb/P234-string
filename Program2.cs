// TASK 2:

int[] Numbers = { 1, 2, 6, -5, -8, 9, -10, 13 };

int Negativeount = 0;

int PositiveCount = 0;

for (int i = 0; i < Numbers.Length; i++)
{
    if (Numbers[i] < 0)
    {
        Negativeount++;
    }
    else if (Numbers[i] > 0)
    {
        PositiveCount++;
    }
}

Console.WriteLine( Negativeount );


Console.WriteLine(PositiveCount);
