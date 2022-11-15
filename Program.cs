// Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.

// int randomNum = new Random().Next(100, 1000); // рандомное число
// Console.WriteLine(randomNum);
// // 238 пример
// // 28
// int num = (randomNum / 100) * 10 + randomNum % 10;
// Console.WriteLine(num);


// Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если число 2 не кратно числу 1, 
//то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно


// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 % num2 == 0)
// {
// Console.WriteLine("кратно");
// }
// else
// {
//     Console.WriteLine($"остаток {num1 % num2}");
// }


//Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 
//7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да

// Console.WriteLine("number = ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 7 == 0 && num % 23 == 0)
// {
// Console.WriteLine("кратно");
// }
// else
// {
//     Console.WriteLine($"не кратно");
// }



// Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет


// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 * num1 == num2 || num2 * num2 == num1)
// {
// Console.WriteLine("является квадратом");
// }
// else
// {
// Console.WriteLine("не является квадратом");
// }


//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("введите число ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0 )
{
Console.WriteLine("чётное");
}
else
{
Console.WriteLine($"нечётное");
}