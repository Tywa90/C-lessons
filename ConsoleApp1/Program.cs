// See https://aka.ms/new-console-template for more information
using System.Globalization;

//Console.WriteLine("Hello, World!");

//----------------------------------
//      C# Course SimpleCode
//      https://www.youtube.com/watch?v=KyFWqbRfWIA&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N
//----------------------------------

//string data;
//data = Console.ReadLine();
//Console.WriteLine("Hello " + data);

//                      Конвертация строк:
//string str = "5";
//int a = Convert.ToInt32(str);
////Console.WriteLine(a);

//// Форматирование разделителя в дробных числах
//string str2 = "1.9";
//NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
//{
//    NumberDecimalSeparator = ".",
//};
//double a2 = Convert.ToDouble(str2, numberFormatInfo);

//              Конвертация строк: parse / tryparse

//string str3 = "5";
//int a = int.Parse(str3);
//double d = double.Parse(str3);
//Console.WriteLine($"a(int) = {a}" + "\td(double)= " + d);

//string str4 = "3.2";
//NumberFormatInfo nfi = new NumberFormatInfo()
//{
//    NumberDecimalSeparator = ".",
//};
//double d2 = double.Parse(str4, nfi);
//Console.WriteLine(d2);

//      Конвертация строк: Верификация данных
//string str = "9jfghj";
//int a;
//bool resultTryparse = int.TryParse(str, out a);
//if (resultTryparse)
//{
//    Console.WriteLine("Good convert with TryParse. int = " + a);
//}
//else
//{
//    Console.WriteLine("Error with TryParse convertation");
//}

// ДЗ-1 Видео 8
/* 
 * 1. Среднее арифмитеческое двух чисел
 * 2. Ввести три числа и вывести результат умножения этих чисел
 * 3. Простой Конвертер валют(вывести несколько валют)
 */
//HW 1.1 Среднее арифмитеческое двух чисел
//Console.WriteLine("1. Среднее арифмитическое двух чисел");
//Console.WriteLine("Введите последовательно два числа");
//string firstNum = Console.ReadLine();
//double a;
//bool resFirstNum = double.TryParse(firstNum, out a);

//string secondNum = Console.ReadLine();
//double b;
//bool resSecondNum = double.TryParse(secondNum, out b);
//double resultAVG = (a + b) / 2;
//Console.WriteLine($"Среднее арифметическое чисел {a} и {b} = {resultAVG}");
//Console.WriteLine();

//HW 1.2 Ввести три числа и вывести результат умножения этих чисел
//Console.WriteLine("Введите три числа для их перемножения");
//string input1 = Console.ReadLine();
//string input2 = Console.ReadLine();
//string input3 = Console.ReadLine();

//NumberFormatInfo nfi = new NumberFormatInfo()
//{
//    NumberDecimalSeparator = ".",
//};

//double num1 = double.Parse(input1, nfi);
//double num2 = double.Parse(input2, nfi);
//double num3 = double.Parse(input3, nfi);

//double resultMn = num1 * num2 * num3;
//Console.WriteLine($"Резльтат умножения {input1} * {input2} * {input3} = {resultMn}");
//Console.WriteLine();

//HW 1.3 Простой Конвертер валют(вывести несколько валют)
double usDollarBuy = 41.00;
double ukFuntBuy = 62.00;
double euEuroBuy = 42.50;
double plZlotyBuy = 8.50;

double usDollarSell = 40.00;
double ukFuntSell = 60.00;
double euEuroSell = 41.50;
double plZlotySell = 8.00;

Console.WriteLine("\t\tКурс банка на сегодня:");
Console.WriteLine($"USD\t{usDollarSell}\t{usDollarBuy}");
Console.WriteLine($"FUNT\t{ukFuntSell}\t{ukFuntBuy}");
Console.WriteLine($"EUR\t{euEuroSell}\t{euEuroBuy}");
Console.WriteLine($"ZLT\t{plZlotySell}\t{plZlotyBuy}");
Console.WriteLine("Конвертер валют. Введите сумму для обмена");
string inputSum = Console.ReadLine();
NumberFormatInfo nfi = new NumberFormatInfo()
{
    NumberDecimalSeparator = "."
};
double inputSumConvert = Convert.ToDouble(inputSum, nfi);

double usDollarBuyCalc = inputSumConvert / 41.00;
double ukFuntBuyCalc = inputSumConvert / 62.00;
double euEuroBuyCalc = inputSumConvert / 42.50;
double plZlotyBuyCalc = inputSumConvert / 8.50;

double usDollarSellCalc = inputSumConvert * 40.00;
double ukFuntSellCalc = inputSumConvert * 60.00;
double euEuroSellCalc = inputSumConvert * 41.50;
double plZlotySellCalc = inputSumConvert * 8.00;

Console.WriteLine("Вы получите: ");
Console.WriteLine($"USD\t{usDollarBuyCalc}");
Console.WriteLine($"FUNT\t{ukFuntBuyCalc}");
Console.WriteLine($"EUR\t{euEuroBuyCalc}");
Console.WriteLine($"ZLT\t{plZlotyBuyCalc}");

