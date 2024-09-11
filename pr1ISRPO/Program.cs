using pr1ISRPO;
using System;
try
{
    Console.WriteLine("Введите количество строк матрицы");
    Int32.TryParse(Console.ReadLine(), out int n);
    Console.WriteLine("Введите количество столбцов матрицы");
    Int32.TryParse(Console.ReadLine(), out int m);
    Console.WriteLine("Введите матрицу (числа в строке писать через пробел, при переходе на новую строку поставить запятую). Пример: 2 22,2 22");
    double[,] matr = new double[n,m];
    string s = Console.ReadLine();

    int o = 0, p = 0; string ch="";
    for (int i = 0; i < s.Length; i++)
    {
        if (i == 0)
        {
            if (s[i] == '-')
            {
                ch += s[i];
                continue;
            }
            else
            {
                ch = Convert.ToString(int.Parse(s[i].ToString()));
                continue;
            }
        }
        if (i == s.Length - 1)
        {
            ch += int.Parse(s[i].ToString());
            matr[p, o] = Convert.ToInt32(ch);
            continue;
        }
        if (Char.IsWhiteSpace(s[i]))
        {
            matr[p, o] = Convert.ToInt32(ch);
            ch = "";
            o++;
            continue;
        }
        if (Char.IsDigit(s, i))
        {
            ch += int.Parse(s[i].ToString());
            continue;
        }
        if (s[i] == ',')
        {
            matr[p, o] = Convert.ToInt32(ch);
            ch = "";
            p++;
            o = 0;
           continue;
        }
        if (s[i] == '-')
        {
            ch += s[i];
            continue;
        }
    }

    double[] mas = Class1.func(matr);
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write(mas[i] + " ");
    }
    Console.WriteLine($"Был получен ответ на задание. Первые {n} числа - результат умножения всех чисел в строках. Далее {m} чисел - среднее арифметическое всех чисел по столбцам." +
        $" Следующие {m} чисел - первые отрицательные числа в каждом столбце. 0 отображается в случае, если отрицательных чисел в столбце нет." +
        $" Последние {n} чисел - разница между максимальным и минимальным числом в каждой строке.");
    Console.ReadLine();
}

catch (Exception)
{
    Console.WriteLine("Ну я же говорила, как написать матрицу");
    Console.ReadLine();
}