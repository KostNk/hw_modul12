using System;
using System.Diagnostics.Metrics;

namespace Program1
{
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
    }

    public class Program
    {
        static void Main()
        {
            // Задание 12.1.5
            User[] users = new User[5];

            // заполняем массив пользователей
            users[0] = new User();
            users[0].Login = "User 0";
            users[0].Name = "Comrade 0";
            users[0].IsPremium = true;

            users[1] = new User();
            users[1].Login = "User 1";
            users[1].Name = "Comrade 1";
            users[1].IsPremium = true;

            users[2] = new User();
            users[2].Login = "User 2";
            users[2].Name = "Comrade 2";
            users[2].IsPremium = false;

            users[3] = new User();
            users[3].Login = "User 3";
            users[3].Name = "Comrade 3";
            users[3].IsPremium = true;

            users[4] = new User();
            users[4].Login = "User 4";
            users[4].Name = "Comrade 4";
            users[4].IsPremium = true;

            // Кто с премиум подпиской - тому просто приветствие, а кто без премиум подписки - тому реклама
            for (int i=0; i<5; i++)
            {
                Console.WriteLine("Hello, {0}", users[i].Name);
                if (!users[i].IsPremium)
                {
                    ShowAds();
                }
            }
            Console.ReadKey();

        }
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}