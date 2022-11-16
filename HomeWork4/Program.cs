
Console.WriteLine("Программа подсчета чётных/нечетных чисел из введеного диапозона чисел");
int countChetnoe = 0;
int countNechetnoe = 0;

Console.WriteLine("Введите певое число отсчета:");
int minNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число конца диапозона: ");
int maxNumber = int.Parse(Console.ReadLine());

while (minNumber <= maxNumber)
{
    if (minNumber%2 == 0)
    {
        countChetnoe++;
    }
    else
    {
        countNechetnoe++;
    }
    minNumber++;
}

Console.WriteLine("Количество четных чисел:" + countChetnoe);
Console.WriteLine("Количество нечетных чисел:" + countNechetnoe);




