using AdoNetLib;
using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        var connector = new MainConnector();

        var result = connector.ConnectAsync();

        if (result.Result)
        {
            Console.WriteLine("Подключено успешно!");
        }
        else
        {
            Console.WriteLine("Ошибка подключения!");
        }

        Console.ReadKey();



        //var data = new DataTable();

        //if (result.Result)
        //{
        //    Console.WriteLine("Подключено успешно!");

        //    var db = new DbExecutor(connector);

        //    var tablename = "NetworkUser";

        //    Console.WriteLine("Получаем данные таблицы " + tablename);

        //    data = db.SelectAll(tablename);

        //    Console.WriteLine("Отключаем БД!");
        //    connector.DisconnectAsync();

        //}
        //else
        //{
        //    Console.WriteLine("Ошибка подключения!");
        //}
    }
}