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
        cache.AddEntity("Человек", new Human("Человек",25));
        cache.AddEntity("Животное", new Animal{ Name = "Барашек", Age = 2, Color = "белый" });
        cache.AddEntity("Животное", new Animal("Козёл", 29, "зелёный"));

        bool exists = cache.CheckEntityExistence("Человек", new Human { Name = "Человек", Age = 25 });
        Console.WriteLine($"Объект существует в кэше: {exists}");

        foreach (var type in cache.cache)
        {
            Console.WriteLine($"key: {type.Key}:");
            foreach(var entity in type.Value)
            {
                Console.WriteLine(entity);
            }
        }
        Console.WriteLine("Нажмите любую клавишу для выхода.");
        Console.ReadKey();
    }

}
//("Человек",  { Name = "Человек", Age = 25 }, { Name = "Человек1", Age = 29 });
//("Животное", { Name = "Барашек", Age = 2, Color = "белый" }) entityType