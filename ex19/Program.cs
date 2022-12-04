Console.Write("Введите пятизначное число: ");
var number = Convert.ToInt32(Console.ReadLine());

// Проверка на 5-ти значность числа:
if (number > 10000 && number < 99999)
{
    int[] digits = new int[5];

    // раскладываем число по разрядам
    for (int i = 0; i < 5; i++)
    {
        digits[i] = number % 10;
        number /= 10;
    }
    if (digits[4] == digits[0] && digits[3] == digits[1])
        System.Console.WriteLine("да");
    else
        System.Console.WriteLine("нет");
}
else
    System.Console.WriteLine("Число не пятизначное!");