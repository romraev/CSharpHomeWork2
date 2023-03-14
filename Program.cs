// Подготовил Раевский Р.Ю.
// Task 10.

// int MidDigit(int num)
// {
//     if (num < 100 || num > 999)
//     {
//         int result = -1;
//         return result;
//     }
//     else
//     {
//         int result = (num / 10) % 10;
//         return result;
//     }

// }

// Console.Write("Hello, friend. Enter your number: ");
// int Number = Convert.ToInt32(Console.ReadLine());

// if (MidDigit(Number) < 0) Console.WriteLine("Your number has less than 3 digits");
// else Console.WriteLine("The middle digit is: " + MidDigit(Number));

// Task 13.

// int ThirdDigit(int num)
// {
//     if (num < 100)
//     {
//         int result = -1;
//         return result;
//     }
//     else
//     {
//         while (num > 999)
//         {
//              num = num / 10;
//         }
//         int result = num % 10;
//         return result;
//     }

// }

// Console.Write("Hello, friend. Enter your number: ");
// int Number = Convert.ToInt32(Console.ReadLine());

// if (ThirdDigit(Number) < 0) Console.WriteLine("Your number has less than 3 digits");
// else Console.WriteLine("The third digit is: " + ThirdDigit(Number));

// Task 15

// bool Wknd(int num)
// {
//     if (num == 6 || num == 7) return true;
//     else return false;
// }

// Console.Write("Hello, friend. Enter your day's number: ");
// int Number = Convert.ToInt32(Console.ReadLine());

// if (Number > 7) Console.WriteLine("There is no such day");
// else Console.WriteLine("It's time to have a drink! - " + Wknd(Number) + " statement");