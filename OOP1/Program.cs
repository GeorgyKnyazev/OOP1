 using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Иван" , "Иванов", 45);

            player1.ShowPlayerData();

            Console.ReadKey();
        }

        class Player
        {
            public string Name;
            public string Surname;
            public int Age;

            public Player(string name, string surname, int age)
            {
                Name = name;
                Surname = surname;
                Age = age;
            }

            public void ShowPlayerData()
            {
                Console.WriteLine("Имя " + Name);
                Console.WriteLine("Фамилия " + Surname);
                Console.WriteLine("Возвраст " + Age);
            }
        }
    }
}
