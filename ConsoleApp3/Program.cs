using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine($@"Дана строка из символов '(' и ')'.Определить, является ли она корректным скобочным выражением.
            Определить максимальную глубину вложенности скобок.
Пример “(()(()))” -строка корректная и максимум глубины равняется 3.
Пример не верных строк: '(()', '())', ')(', '(()))(()' Для перебора строки по символам можно использовать цикл foreach, к примеру будет так foreach (var symbol in text) " +
"Или цикл for (int i = 0; i < text.Length; i++) и дальше обращаться к каждому символу внутри цикла как text[i]" +
"Цикл нужен для перебора всех символов в строке");
        Console.WriteLine();
        Console.WriteLine("Введите скобочки!)))");
        var str = Console.ReadLine();
        var length = str.Length;
        var num = 0;
        var counter = 0;
        var list = new List<int>();
        if (length == 0)
        {
            Console.WriteLine("Вы ввели не скобочки!)");
            return;
        }
        for (var i = 0; i < length; i++)
        {
            if (str[i] == '(')
                num++;
            else if (str[i] == ')')
            {
                if (i != length - 1 && str[i + 1] != '(')
                    counter++;
                num--;
            }
            if (num == 0)
            {
                list.Add(counter);
                counter = 0;
            }
        }
        if (num == 0)
            Console.WriteLine("Kорректным скобочным выражением: " + list[list.Count - 1] + 1);
        else Console.WriteLine("Строка не является корректным скобочным выражением");
    }
}