int RowOfCubes(int n)
{
    int number = 0;
    for (int i = 1; i < n+1; i++)
        {
            number+=1;
           double row = Math.Pow(number, 3);
            Console.Write($"Значение элемента под номером {i}: {row} \t");
        }
    return 1;
}

Console.Write("Ввдеите колличество элементов: ");
String value = Console.ReadLine();
int strValue = Convert.ToInt32(value);

int A = RowOfCubes(strValue);
