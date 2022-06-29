using System;

namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста, введите количества выбираемых карт");
            string chooseNumbers = Console.ReadLine();
            if(int.TryParse(chooseNumbers, out int numberOfCards))
            {
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
            }
            Console.ReadLine();
        }
    }
}
