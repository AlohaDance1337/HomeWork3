Console.WriteLine("Введите координаты точки А:");
String stringValue1 = Console.ReadLine();   
String stringValue2 = Console.ReadLine();
String stringValue3 = Console.ReadLine();
int x1 = Convert.ToInt32(stringValue1);
int y1 = Convert.ToInt32(stringValue2);
int z1 = Convert.ToInt32(stringValue3);

Console.WriteLine("Введите координаты точки B:");
String stringValue4 = Console.ReadLine();   
String stringValue5 = Console.ReadLine();
String stringValue6 = Console.ReadLine();
int x2 = Convert.ToInt32(stringValue4);
int y2 = Convert.ToInt32(stringValue5);
int z2 = Convert.ToInt32(stringValue6);

double Length(int x1, int y1, int z1 ,int x2, int y2, int z2)
{
    double l = Math.Pow((Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2)*1), 0.5);
    Console.Write($"Полученное значение длинны {l}");
    return;
}

Length(x1, y1 , z1, x2, y2, z2);
