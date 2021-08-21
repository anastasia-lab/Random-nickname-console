using System;
using System.Linq;
using Random_nick.DataBased;

namespace Random_nick
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBaseCharactersDataContext _dataBased = new DataBaseCharactersDataContext();
            Random rnd = new Random();

            Console.Write("Здравствуйте :) \n");
            Console.Write("Данная программа может подобрать для Вас никнейм.\n");
            Console.Write("Для продолжения выберите один из вариантов: ");
            Console.Write("1 - сгенирировать никнейм; 2 - выход\n");
            Console.Write("Ваш выбор: ");

            try
            {
                var result = Convert.ToInt32(Console.ReadLine());

                if (result == 1)
                {
                    var _firstName = _dataBased.FirstNameCharacter.Select(f => f.firstname).ToList();
                    var _lastName = _dataBased.LastNameCharacteer.Select(l => l.lastname).ToList();

                    string _firstWord = "";
                    string _lastWord = "";

                    for (int i = 0; i < 1; i++)
                    {
                        var _word = rnd.Next(0, _firstName.Count);
                        _firstWord += _firstName[_word];
                    }

                    for (int i = 0; i < 1; i++)
                    {
                        var word = rnd.Next(0, _lastName.Count);
                        _lastWord += _lastName[word];

                    }

                    Console.Write("\nНикнейм: ");
                    Console.WriteLine(_firstWord + "__" + _lastWord);
                }

                if (result == 2)
                {
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            Console.ReadKey();
        }
    }
}
