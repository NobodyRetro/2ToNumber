/* Write a C# program that prompts the user to enter a positive integer and then displays all even numbers from 2 to that integer (inclusive). 
The program should use a for loop to iterate through the numbers and display only the even ones.
To complete this assignment, you'll need to take user input for a positive integer, use a for loop to iterate from 2 to the entered integer, 
and display only the even numbers within that range.
Remember to handle cases where the user enters a non-positive integer and display the even numbers found during the loop iteration. */

Console.WriteLine("Please enter a positive number.");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 2 ; number >= i ; i += 2)
{
    Console.WriteLine(i);
}

Console.WriteLine("Press any key to exit.");
Console.ReadKey();