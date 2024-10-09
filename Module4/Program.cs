using System;

class MainClass
{
    public static void Main(string[] args)
    {
        //string[] favcolors = new string[3];

        //for (int i = 0; i < favcolors.Length; i++)
        //{
        //    Console.WriteLine("Введите любимый цвет номер {0}", i + 1);
        //    favcolors[i] = Console.ReadLine();
        //}

        //foreach (var color in favcolors)
        //{
        //    switch (color)
        //    {
        //        case "red":
        //            Console.BackgroundColor = ConsoleColor.Red;
        //            Console.ForegroundColor = ConsoleColor.Black;

        //            Console.WriteLine("Your color is red!");
        //            break;

        //        case "green":
        //            Console.BackgroundColor = ConsoleColor.Green;
        //            Console.ForegroundColor = ConsoleColor.Black;

        //            Console.WriteLine("Your color is green!");
        //            break;

        //        case "cyan":
        //            Console.BackgroundColor = ConsoleColor.Cyan;
        //            Console.ForegroundColor = ConsoleColor.Black;

        //            Console.WriteLine("Your color is cyan!");
        //            break;
        //        default:
        //            Console.BackgroundColor = ConsoleColor.Yellow;
        //            Console.ForegroundColor = ConsoleColor.Black;

        //            Console.WriteLine("Your color is yellow!");
        //            break;
        //    }

        //}


        (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;

        for (int k = 0; k < 3; k++)
        {

            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");

            User.LastName = Console.ReadLine();

            Console.WriteLine("Введите логин");

            User.Login = Console.ReadLine();

            User.LoginLength = User.Login.Length;

            Console.WriteLine("Есть ли у вас животные? Да или Нет");

            var result = Console.ReadLine();

            if (result == "Да")
            {
                User.HasPet = true;
            }
            else
            {
                User.HasPet = false;
            }

            Console.WriteLine("Введите возраст пользователя");

            User.Age = double.Parse(Console.ReadLine());

            User.favcolors = new string[3];
            Console.WriteLine("Введите три любимых цвета пользователя");

            for (int i = 0; i < User.favcolors.Length; i++)
            {
                User.favcolors[i] = Console.ReadLine();
            }
        }



    }
}