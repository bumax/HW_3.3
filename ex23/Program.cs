Console.Write("Введите число N: ");
var N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
    System.Console.WriteLine("Куб числа {0} равен {1}", i, Math.Pow(i, 3));
