﻿string[] forbiddenWords = { "Ты ", "все", "сможешь" };
string sentence = "";
while (true)
{
    Console.Write("Введите слово (для завершения введите 'конец'): ");
    string word = Console.ReadLine();
for (int i = 0; i < forbiddenWords.Length; i++)
    {
        if (word == forbiddenWords[i])
        {
            word = "(скрыто)";
            break;
        }
    }
    if (word == "конец")
    {
        break;
    }
    sentence += word + " ";
}
Console.WriteLine("Сформированное предложение: " + sentence);