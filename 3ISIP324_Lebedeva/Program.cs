using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ISIP324_Lebedeva
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            List<Product> products = new List<Products>();
 int nextId = 1;
 string[] categories = { "Продукты", "Электроника", "Одежда" };
 while (true);
    {
     Console.WriteLine("\n===== УЧЕТ ТОВАРОВ В МАГАЗИНЕ =====");
     Console.WriteLine("1. Добавить товар");
     Console.WriteLine("2. Удалить товар");
     Console.WriteLine("3. Заказать поставку товра");
     Console.WriteLine("4. Продать товар");
     Console.WriteLine("5. Поиск товаров");
     Console.WriteLine("6.Показать все товары");
     Console.WriteLine("0. Выход");
     Console.Write("Выберите пункт");
     string choice = Console.ReadLine();
        if (choice == "1")
        {
    Console.Write("Введите название: ");
    string name = Console.ReadLine();
    Console.Write("Введите цену: ");
    double price = double.Parse(Console.ReadLine());
    Console.Write("Введите количество: ");
    int count = int.Parse(Console.ReadLine());
    Console.WriteLine("Выберите категорию:");
                Console.WriteLine("1. Продукты");
    Console.WriteLine("2. Электроника");
    Console.WriteLine("3. Одежда");
    Console.Write("Ваш выбор: ");
    string vibor = Console.ReadLine();
    Product p = new Product();
    p.Code = "1" + nextId.ToString("D3");
    nextId++;
    p.Name = name;
    p.Price = price;
    p.Count = count;
    p.InStock = count > 0;
    switch (vibor)
    {
        case "1": p.Category = "Продукты"; break;
        case "2": p.Category = "Электроника"; break;
        case "3": p.Category = "Одежда"; break;
        default:
            Console.WriteLine("Неверная категория!");
            nextId--;
            continue;
    }
    products.Add(p);
    Console.WriteLine($"Товар добавлен! Код: {p.Code}");
}
else if (choice == "2")
{
    Console.Write("Введите код товара для удаления: ");
    string code = Console.ReadLine();
    Product found = null;
    foreach (Product p in products)
    {
        if (p.Code == code)
        {
            found = p;
            break;
        }
    }
    if (found == null)
    {
        Console.WriteLine("Товар не найден!");
        continue;
    }
    products.Remove(found);
    Console.WriteLine("Товар удалён!");
}
else if (choice == "3")
{
    Console.Write("Введите код товара: ");
    string code = Console.ReadLine();
    Product found = null;
    foreach (Product p in products)
    {
        if (p.Code == code)
        {
            found = p;
            break;
        }
    }
    if (found == null)
    {
        Console.WriteLine("Товар не найден!");
        continue;
    }
    Console.Write("Сколько единиц поставить: ");
    int add = int.Parse(Console.ReadLine());
    found.Count += add;
    found.InStock = found.Count > 0;
    Console.WriteLine($"Поставка выполнена. Теперь на складе: {found.Count}");
}
else if (choice == "4")
{
    Console.Write("Введите код товара: ");
    string code = Console.ReadLine();
    Product found = null;
    foreach (Product p in products)
    {
        if (p.Code == code)
        {
            found = p;
            break;
        }
    }
    if (found == null)
                  
        }
    }
}
