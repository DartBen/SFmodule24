using AdoNetConsole;
using AdoNetLib;
using Microsoft.Data.SqlClient;
using System.Data;

internal class Program
{
    static Manager manager;
    private static void Main(string[] args)
    {

        var manager = new Manager();

        manager.Connect();


        //manager.ShowData();

        //////Console.WriteLine("Введите логин для удаления:");
        //////var deleteCount= manager.DeleteUserByLogin(Console.ReadLine());
        //////Console.WriteLine(deleteCount);

        ////Console.WriteLine("Введите логин для добавления:");

        ////var login = Console.ReadLine();

        ////Console.WriteLine("Введите имя для добавления:");
        ////var name = Console.ReadLine();
        ////manager.AddUser(login, name);


        //Console.WriteLine("Введите логин для замены имены :");

        //var login = Console.ReadLine();

        //Console.WriteLine("Введите новое имя:");
        //var name = Console.ReadLine();
        //manager.UpdateUserByLogin(login, name);

        //Console.WriteLine("изменённая таблица");
        //manager.ShowData();

        Console.WriteLine("Список команд для работы консоли:");
        Console.WriteLine(Commands.stop + ": прекращение работы");
        Console.WriteLine(Commands.add + ": добавление данных");
        Console.WriteLine(Commands.delete + ": удаление данных");
        Console.WriteLine(Commands.update + ": обновление данных");
        Console.WriteLine(Commands.show + ": просмотр данных");

        string command;
        do
        {
            Console.WriteLine("Введите команду:");
            command = Console.ReadLine();
            Console.WriteLine();
            switch (command)
            {
                case
                nameof(Commands.add):
                    {
                        Add();
                        break;
                    }

                case
                nameof(Commands.delete):
                    {
                        Delete();
                        break;
                    }
                case
                nameof(Commands.update):
                    {
                        Update();
                        break;
                    }
                case
                nameof(Commands.show):
                    {
                        manager.ShowData();
                        break;
                    }

            }


        }
        while (command != nameof(Commands.stop));



        manager.Disconnect();

        Console.ReadKey();
    }

    static void Update()
    {
        Console.WriteLine("Введите логин для обновления:");

        var login = Console.ReadLine();

        Console.WriteLine("Введите имя для обновления:");
        var name = Console.ReadLine();

        var count = manager.UpdateUserByLogin(login, name);

        Console.WriteLine("Строк обновлено" + count);

        manager.ShowData();
    }

    static void Add()
    {
        Console.WriteLine("Введите логин для добавления:");

        var login = Console.ReadLine();

        Console.WriteLine("Введите имя для добавления:");
        var name = Console.ReadLine();

        manager.AddUser(login, name);

        manager.ShowData();
    }

    static void Delete()
    {
        Console.WriteLine("Введите логин для удаления:");

        var count = manager.DeleteUserByLogin(Console.ReadLine());

        Console.WriteLine("Количество удаленных строк " + count);

        manager.ShowData();
    }
}
