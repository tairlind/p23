using p23;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

class Program
{
    static void Main()
    {

        Singleton cache = Singleton.GetInstance();

        cache.RegisterEntityType("Человек");
        cache.RegisterEntityType("Животное");
        cache.AddEntity("Человек", new NewClass());
        cache.AddEntity("Животное", new { Name = "Барашек", Age = 2, Color = "белый" });

        bool exists = cache.CheckEntityExistence("Человек", new Human { Name = "Человек", Age = 25 });
        exists = cache.CheckEntityExistence("Животное", new { Name = "Барашек", Age = 2, Color = "белый" });
        Console.WriteLine($"Объект существует в кэше: {exists}");

        foreach (var person in cache.cache)
        {
            Console.WriteLine($"key: {person.Key}  value: {person.Value}");

        }
        Console.WriteLine("Нажмите любую клавишу для выхода.");
        Console.ReadKey();
    }

}

internal class NewClass
{
    public object Name { get; }

    public NewClass()
    {
        Name = "sdsds";
    }
}
//("Человек",  { Name = "Человек", Age = 25 }, { Name = "Человек1", Age = 29 });
//("Животное", { Name = "Барашек", Age = 2, Color = "белый" }) entityType