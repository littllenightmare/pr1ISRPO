using System;
Console.WriteLine("Введите матрицу (числа в строке писать через запятую, при переходе на новую строку поставить точку с запятой, пробелы между числами не ставить)");
string s = Console.ReadLine();
try
{
    for (int i = 0; i < s.Length; i++)
    {
        double ch = Char.GetNumericValue(s, i);
        if (s[i] == ',')
        {

        }
        if (s[i] == ';')
        {

        }
    }
}
catch (Exception)
{
    Console.WriteLine("Ну я же говорила, как написать матрицу");
}