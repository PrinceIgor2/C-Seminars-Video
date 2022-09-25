

//     9 Напишите программу, которая выводит случайное число из отрезка [10, 99]
//  и показывает наибольшую цифру числа. 
// 78 -> 8
//  12-> 2
//   85 -> 8

// int GetRandomNumberFromRange(int minBorder, int maxBorder)
// {
// int result = new int();
// result = new Random().Next(minBorder, maxBorder+1);
// return result;
// }

// int maxDigitFronNumber(int number)
// {
// int maxNumber = 0;
// while(number > 0){
// int currentDigit = number % 10;
// if(maxNumber < currentDigit) {
//     maxNumber = currentDigit;
//     }
// number = number / 10;
// }
// return maxNumber;
// }


// int getMaxDigitFromMunberOfTwoDigits (int number){

// int MaxDigit = number % 10;
// int secondDigit = number / 10;
// if(MaxDigit < secondDigit) {
//     MaxDigit = secondDigit;
// }
// return MaxDigit;
// }
// int randomNumber = GetRandomNumberFromRange(10, 99);
// Console.WriteLine($" Случайное значение {randomNumber}");
// int maxDigit = getMaxDigitFromMunberOfTwoDigits(randomNumber);
// Console.WriteLine($" Максимальная цифра случайного значения {maxDigit}");



//  Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98
// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное число {number}");
// {
// int MaxDigit = 0;

// while(number > 0){
// int currentDigit = number % 10;
// if(MaxDigit < currentDigit) {
//     MaxDigit = currentDigit;
//     }
// number = number / 10;
// }
// return MaxDigit;
// }

// int firstDigit = number / 100;
// int thirdDigit = number % 10;


// Console.WriteLine($"{firstDigit} {thirdDigit}");





// 3 Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления. 
// 34, 5 -> не кратно, // остаток 4 16, // 4 -> кратно

// int firstnumber = new Random().Next(1,100);
// int secondnumber = new Random().Next(1,100);

// void ReturnOstatok(int firstnumber, int secondnumber){
//     if(firstnumber % secondnumber == 0){
//         Console.WriteLine($"Второе число {secondnumber} кратно первому числу {firstnumber}");
//             }
//     else
//     Console.WriteLine($"Второе число {secondnumber} не кратно первому числу {firstnumber}, остаток {firstnumber % secondnumber}");}
// Console.WriteLine($"Первое число {firstnumber}"); 
// Console.WriteLine($"Второе число {secondnumber}"); 
// ReturnOstatok(firstnumber, secondnumber); 



// //  Напишите программу, которая выводит случайное трёхзначное число и 
// удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98

// int number = new Random().Next(100,1000);

// int DeleteSecondDigit(int number){

// int firstnumber = number / 100;
// int thirdnumber = number % 10;
// return (firstnumber*10 + thirdnumber);
// }
// Console.WriteLine(number);
// int result = DeleteSecondDigit(number);
// Console.WriteLine(result);


// 4 Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да

// int number = new Random().Next(100,1000);

// string Kratno(int number){
//     string Kratno = " ";
//     if(number % 7 == 0 && number % 23 == 0){
//         Console.WriteLine("Да");
//     }
//     else
//     Console.WriteLine("Нет");
//     return Kratno;
// }
// Console.WriteLine(number);
// string result = Kratno(number);
// Console.WriteLine(result);




// 5  Напишите программу, которая принимает на вход два числа и проверяет,
//  является ли одно число квадратом другого. 
//  5, 25 -> да 
//  - 4, 16 -> да
//   25, 5 -> да
//   8,9 -> нет


Console.WriteLine("Введите первое число ");
int usernumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int usernumberB = Convert.ToInt32(Console.ReadLine());
if(usernumberB == Math.Pow(usernumberA,2)){
    Console.WriteLine("Да");
}
else{
Console.WriteLine("Нет");
}