// Подготовил Раевский Р.Ю.
// Task 10.

int MidNumber(int num)
{
    if (num < 100 || num > 999)
    {
        int result = -1;
        return result;
    }
    else
    {
        int result = (num / 10) % 10;
        return result;
    }

}

Console.Write("Hello, friend. Enter your number: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (MidNumber(Number) < 0) Console.WriteLine("Your number has less than 3 digits");
else Console.WriteLine("The middle number is: " + MidNumber(Number));