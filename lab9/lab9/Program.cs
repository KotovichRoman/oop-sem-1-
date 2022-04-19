using System;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Game hero = new Game("Knight",10);
            Game monster = new Game("Monster", 4);
            
            hero.Notify += DisplayMessage;
            monster.Notify += DisplayMessage;
            
            hero.Attack(2);
            hero.Heal(1);

            monster.Attack(3);
            monster.Heal(1);

            string str = "123,32.3  3  3";
            Func<string, string> strFunc;
            
            Console.WriteLine($"Исходная строка: {str}");
            strFunc = UserString.DeletePunctuationMark;
            Console.WriteLine($"Без знаков препинания: {str = strFunc(str)}");
            strFunc = UserString.AddSymbols;
            Console.WriteLine($"Добавление символов: {str = strFunc(str)}");
            strFunc = UserString.ToUpper;
            Console.WriteLine($"С заглавными буквами: {str = strFunc(str)}");
            strFunc = UserString.ToLower;
            Console.WriteLine($"Со строчными буквами: {str = strFunc(str)}");
            strFunc = UserString.DeleteExtraSpace;
            Console.WriteLine($"Без лишних пробелов: {str = strFunc(str)}");

        }
        
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}