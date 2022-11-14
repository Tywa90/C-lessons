using System.Globalization;

/* 1.Среднее арифмитеческое двух чисел
 * 2. Ввести три числа и вывести результат умножения этих чисел
 * 3. Простой Конвертер валют(вывести несколько валют)
 */
//-------- исполнение из видео:
//HW 1.1 Среднее арифмитеческое двух чисел

double firstVal, secondVal;
Console.WriteLine("Введите число 1");
firstVal = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
secondVal = double.Parse(Console.ReadLine());
double result = (firstVal + secondVal)/2;
Console.WriteLine("Среднее арифмитеческое двух чисел = " + result);

//HW 1.2 Ввести три числа и вывести результат умножения этих чисел

double firstValue, secondValue, thirdValue;

Console.WriteLine("Введите число 1");
firstValue = double.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2");
secondValue = double.Parse(Console.ReadLine());

Console.WriteLine("Введите число 3");
thirdValue = double.Parse(Console.ReadLine());

double someResult1 = firstValue + secondValue + thirdValue;
double someResult2 = firstValue * secondValue * thirdValue;
Console.WriteLine("Сумма чисел = " + someResult1);
Console.WriteLine("Умножение чисел = " + someResult2);

//HW 1.3 Простой Конвертер валют(вывести несколько валют)
double UsdToEuro = 0.9;
double UsdToUAH = 41.20;
double USD;

Console.WriteLine("Введите сумму в USD");
USD = double.Parse(Console.ReadLine());

Console.WriteLine(USD + " USD в EUR = " + USD * UsdToEuro);
Console.WriteLine(USD + " USD в UAH = " + USD * UsdToUAH);
