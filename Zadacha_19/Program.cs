Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
int firstNumber = number / 10000;
int secondNumber = number / 1000;
int secondNumberTwo = secondNumber % 10;
int fourthNumber = number / 10;
int fourthNumberFour = fourthNumber % 10;
int fifthNumber = number % 10;
if (firstNumber == fifthNumber && secondNumberTwo == fourthNumberFour)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}