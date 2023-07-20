//Сделайте из слова «Шишка», слово «Пышка».

/*using System;

class Program
{
    static void Main()
    {
        String cone = "Шишка";
        String donut = String.Concat((char)(cone[0] - 9), (char)(cone[2] + 3), cone.Substring(2));
        Console.WriteLine(donut);
        Console.ReadKey();
    }
}*/

//В консоли вводится текст, определите количество слов. Каждое слово отделено друг от друга пробелом.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст: ");
        string input = Console.ReadLine();
        input = input.Trim();
        string[] words = input.Split(' ');
        Console.WriteLine("Количество слов: " + words.Length);
        Console.ReadKey();
    }
}*/

//Вводятся три фамилии, выведите самую длинную.

/*using System;

class Program
{
   static void Main()
    {
        Console.WriteLine("Введите три фамилии: ");
        string surname1 = Console.ReadLine();
        string surname2 = Console.ReadLine();
        string surname3 = Console.ReadLine();
        int lenght1 = surname1.Length;
        int lenght2 = surname2.Length;
        int lenght3 = surname3.Length;
        int maxLenght = Math.Max(Math.Max(lenght1, lenght2), lenght3);
        if(lenght1 == lenght2 && lenght2 == lenght3)
        {
            Console.WriteLine("Все фамилии одинаковы по длинне");
        }
        else
        {
            int maxLength = Math.Max(Math.Max(lenght1, lenght2), lenght3);

            if(lenght1 == maxLength)
            {
                Console.WriteLine("Самая длинная фамилия: " + surname1);
            }
            else if (lenght2 == maxLength)
            {
                Console.WriteLine("Самая длинная фамилия: " + surname2);
            }
            else
            {
                Console.WriteLine("Самая длинная фамилия: " + surname3);
            }
        }
        Console.ReadKey();
    }
}*/

/*using System;
using System.Globalization;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите текст:");
        string inputText = Console.ReadLine();

        string normalizedText = NormalizeText(inputText);

        Console.WriteLine("Нормализованный текст:");
        Console.WriteLine(normalizedText);

        Console.ReadLine();
    }

    static string NormalizeText(string text)
    {
        StringBuilder normalizedText = new StringBuilder();

        string[] sentences = text.Split(new char[] { '.', '!', '?' });

        for (int i = 0; i < sentences.Length; i++)
        {
            string sentence = sentences[i].Trim();

            if (!string.IsNullOrEmpty(sentence))
            {
                sentence = char.ToUpper(sentence[0]) + sentence.Substring(1).ToLower();

                normalizedText.Append(sentence);

                if (i < sentences.Length - 1)
                {
                    char punctuation = text[text.IndexOf(sentences[i]) + sentences[i].Length];
                    normalizedText.Append(punctuation);
                }

                if (i < sentences.Length - 1)
                {
                    normalizedText.Append(" ");
                }
            }
        }
        return normalizedText.ToString();
    }
}*/

/*using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите текст:");
        string inputText = Console.ReadLine();

        string normalizedText = NormalizeText(inputText);

        Console.WriteLine("Нормализованный текст:");
        Console.WriteLine(normalizedText);

        Console.ReadLine();
    }

    static string NormalizeText(string text)
    {
        // Разделяем текст на слова
        string[] words = text.Split(' ');

        // Обработка каждого слова
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i].Trim();

            if (!string.IsNullOrEmpty(word))
            {
                // Приводим первый символ слова к верхнему регистру, остальные к нижнему
                word = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(word.ToLower());

                // Возвращаем слово в массив слов
                words[i] = word;
            }
        }

        // Собираем слова обратно в текст
        string normalizedText = string.Join(" ", words);

        return normalizedText;
    }
}*/

/*using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите текст:");
        string inputText = Console.ReadLine();

        string alternatingText = AlternateCase(inputText);

        Console.WriteLine("Текст с чередующимися регистрами:");
        Console.WriteLine(alternatingText);

        Console.ReadLine();
    }

    static string AlternateCase(string text)
    {
        StringBuilder result = new StringBuilder();
        bool upperCase = true;

        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];

            if (char.IsLetter(c))
            {
                if (upperCase)
                {
                    result.Append(char.ToUpper(c));
                }
                else
                {
                    result.Append(char.ToLower(c));
                }

                upperCase = !upperCase;
            }
            else
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }
}*/

/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите текст:");
        string inputText = Console.ReadLine();

        string alternatingWordsText = AlternateCaseForWords(inputText);

        Console.WriteLine("Текст с чередующимися регистрами для слов:");
        Console.WriteLine(alternatingWordsText);

        Console.ReadLine();
    }

    static string AlternateCaseForWords(string text)
    {
        string[] words = text.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (i % 2 == 0)
            {
                words[i] = words[i].ToLower();
            }
            else
            {
                words[i] = words[i].ToUpper();
            }
        }

        return string.Join(" ", words);
    }
}*/

//СИНОНИМ -> АНТОНИМ

/*using System;

class Program
{
    static void Main()
    {
        string cone = "Синоним";
        string donut = String.Concat((char)(cone[0] - 17), (char)(cone[1] + 5), "т" , cone.Substring(3));
        Console.WriteLine(donut);
        Console.ReadKey();
    }
}*/

//Пользователь вводит строку. Определить, является ли строка палиндромом. Без учёта регистра.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку");
        string inputString = Console.ReadLine();
        string cleanedString = inputString.Replace(" ", " ").ToLower();
        char[] charArray = cleanedString.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);
        bool isPalindrome = cleanedString == reversedString;
        if (isPalindrome)
        {
            Console.WriteLine("Введенная строка является палиндромом");
        }
        else
        {
            Console.WriteLine("Введенная строка не является палиндромом");
        }
        Console.ReadKey();
    }
}*/

//Пользователь вводит строку. Вывести количество символов -*+/_@

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string inputString = Console.ReadLine();

        int countDash = CountOccurrences(inputString, '-');
        int countAsterisk = CountOccurrences(inputString, '*');
        int countPlus = CountOccurrences(inputString, '+');
        int countSlash = CountOccurrences(inputString, '/');
        int countUnderscore = CountOccurrences(inputString, '_');
        int countAt = CountOccurrences(inputString, '@');

        Console.WriteLine("Количество символов '-': " + countDash);
        Console.WriteLine("Количество символов '*':" + countAsterisk);
        Console.WriteLine("Количество символов '+':" + countPlus);
        Console.WriteLine("Количество символов '/'" + countSlash);
        Console.WriteLine("Количество символов '_': " + countUnderscore);
        Console.WriteLine("Количество символов '@': " + countAt);

        Console.ReadKey();
    }

    static int CountOccurrences(string input, char character)
    {
        int count = 0;
        foreach (char c in input)
        {
            if (c == character)
            {
                count++;
            }
        }
        return count;
    }
}*/

/*using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string inputString = Console.ReadLine();

        int oneLetter = OneLetter(inputString);

        Console.WriteLine("Количество слов, начинающихся с одной буквы: " + oneLetter);
        Console.ReadKey();
    }

    static int OneLetter(string input)
    {
        string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        int count = words.Count(word => word.Length > 0 && char.IsLetter(word[0]));
        return count;
    }
}*/

/*using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку: ");
        string inputString = Console.ReadLine();
        int lastLetter = LastLetter(inputString);
        Console.WriteLine("Количество слов,заканчивающихся на одну букву: " + lastLetter);
        Console.ReadKey();
    }
    static int LastLetter(string input)
    {
        string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        int count = words.Count(word => word.Length > 0 && char.IsLetter(word[0]));
        return count;
    }
}*/

/*using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку: ");
        string inputString = Console.ReadLine();
        int countDigits = CountDigits(inputString);
        Console.WriteLine("Кол-во цифр в одной строке: " +  countDigits);
        Console.ReadKey();
    }
    static int CountDigits(string input)
    {
        int count = input.Count(char.IsDigit);
        return count;
    }
}*/

/*using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку: ");
        string inputString = Console.ReadLine();
        int upLetter = UpLetter(inputString);
        Console.WriteLine("Количество заглавных букв: " +  upLetter);
        Console.ReadKey();
    }
    static int UpLetter(string input)
    {
        int count = input.Count(char.IsUpper);
        return count;
    }
}*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string inputString = Console.ReadLine();

        int countUppercaseLetters = 0;
        for (int i = 0; i < inputString.Length; i++)
        {
            char currentChar = inputString[i];
            if (currentChar >= 'А' && currentChar <= 'Я')
            {
                countUppercaseLetters++;
            }
        }

        Console.WriteLine("Количество заглавных букв в строке: " + countUppercaseLetters);
        Console.ReadKey();
    }
}
