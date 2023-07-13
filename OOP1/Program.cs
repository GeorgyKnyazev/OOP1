 using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Иван" , "Иванов", 45);

            player1.ShowData();

            Console.ReadKey();
        }
    }

    class Player
    {
        private string _name;
        private string _surname;
        private int _age;

        public Player(string name, string surname, int age)
        {
            _name = name;
            _surname = surname;
            _age = age;
        }

        public void ShowData()
        {
            Console.WriteLine("Имя " + _name);
            Console.WriteLine("Фамилия " + _surname);
            Console.WriteLine("Возвраст " + _age);
        }
    }
}
