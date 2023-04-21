// Type of Loops
// For, While, Do...While, For each

//for(int i = 10; i >= 1; i--)
//{
//    Console.WriteLine(i);
//}

//int i = 1;
//while (i <= 10)
//{
//    i++;
//    Console.WriteLine(i);
//}

//int i = 11;
//do
//{
//    Console.WriteLine(i);
//    i++;
//} while (i <= 10);

// Q1.
// Write a program to accept a 5 digit number and calculate the sum of all digits
// 34981

// Q2.
//Write a program that prints out a table to show the temperature in degree Celcius and the
//equivalent temperature in degrees Fahrenheit using Iterative statements in C#.
//Your program must compute the temperature in Fahrenheit by using an appropriate formula for
//converting the temperature from Celsius to Fahrenheit.
// This table will contain 10 rows
//Sr.No Temperature(Celsius)           Temperature(Fahrenheit)
//     1          0                               32
//     2         10                               50
//     3         20                               68
//     4         30                               86
//     5         40                              104
//     6         50                              122
//     7         60                              140
//     8         70                              158
//     9         80                              176
//    10         90                              194

// Q3.
//Write a program that prints out the temperature in degrees Celcius and the equivalent temperature
//in degrees Fahrenheit.

//Your program must compute the temperature in Fahrenheit by using an appropriate formula for
//converting the temperature from degree Celcius to Fahrenheit.

//The program will accept the temperature in degrees Celcius from the user and display its
//corresponding temperature in Fahrenheit.

//Once done, it should ask the user whether he wants to continue or not.The user can respond by
//typing ‘y’ or ‘n’.

//Enter the temperature in Degree Celsius:
//0 < PASSED AS AN INPUT>
//Temperature(Celsius)= 0.00           Temperature(Fahrenheit) = 32.00
//Do you wish to continue(y/n)?
//y<PASSED AS AN INPUT>
//Enter the temperature in Degree Celsius:
//10 <PASSED AS AN INPUT>
//Temperature(Celsius)= 10.00           Temperature(Fahrenheit)= 50.00
//Do you wish to continue(y/n)?
//n<PASSED AS AN INPUT>

for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}