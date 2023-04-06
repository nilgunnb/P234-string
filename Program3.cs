// TASK 3:

int[] Numbers = { 1, 2, 5, 3, 7, 4, 10, 3 };

int LargestNum = Numbers[0];

for ( int i = 0; i < Numbers.Length; i++ )
{
    if (Numbers[i] > LargestNum )
    { 
        LargestNum = Numbers[i];
    }
}
Console.WriteLine( LargestNum );