Console.Write("Введите через запятую 1 точку (x,y,z): ");
string[] dot1String = (Console.ReadLine()).Split(',');

Console.Write("Введите через запятую 2 точку (x,y,z): ");
string[] dot2String = (Console.ReadLine()).Split(',');

double d = Math.Sqrt(
    Math.Pow(Convert.ToInt32(dot2String[0]) - Convert.ToInt32(dot1String[0]), 2) +
    Math.Pow(Convert.ToInt32(dot2String[1]) - Convert.ToInt32(dot1String[1]), 2) +
    Math.Pow(Convert.ToInt32(dot2String[2]) - Convert.ToInt32(dot1String[2]), 2)
);

System.Console.WriteLine("Расстояние между точками: {0}", d.ToString("#.##") );