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