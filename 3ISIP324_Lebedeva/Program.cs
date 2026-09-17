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
    {
                            Console.WriteLine("Товар не найден!");
                    continue;
                }
                Console.Write("Сколько единиц продать: ");
                int sell = int.Parse(Console.ReadLine());

                if (sell > found.Count)
                {
                    Console.WriteLine($"Недостаточно товара! На складе только {found.Count}");
                    continue;
                }
                found.Count -= sell;
                found.InStock = found.Count > 0;
                Console.WriteLine($"Продано. Осталось на складе: {found.Count}");
            }
            else if (choice == "5")
            {
                Console.WriteLine("Поиск по:");
                Console.WriteLine("1. Коду");
                Console.WriteLine("2. Названию");
                Console.WriteLine("3. Категории");
                Console.Write("Выберите: ");
                string searchChoice = Console.ReadLine();
                bool foundAny = false;
                if (searchChoice == "1")
                {
                    Console.Write("Введите код: ");
                    string code = Console.ReadLine();

                    foreach (Product p in products)
                    {
                        if (p.Code == code)
                        {
                            p.PrintInfo();
                            foundAny = true;
                        }
                    }
                }
                else if (searchChoice == "2")
                {
                    Console.Write("Введите название: ");
                    string name = Console.ReadLine();
                    foreach (Product p in products)
                    {
                        if (p.Name.ToLower().Contains(name.ToLower()))
                        {
                            p.PrintInfo();
                            foundAny = true;
                        }
                    }
                }
                else if (searchChoice == "3")
                {
                    Console.Write("Введите категорию: ");
                    string poisk = Console.ReadLine();
                    foreach (Product p in products)
                    {
                        if (p.Category.ToLower() == poisk.ToLower())
                        {
                            p.PrintInfo();
                            foundAny = true;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Неверный выбор!");
                    continue;
                }
                if (!foundAny)
                    Console.WriteLine("Ничего не найдено!");
            }
            else if (choice == "6")
            {
                if (products.Count == 0)
                {
                    Console.WriteLine("Список пуст.");
                    continue;
                }

                Console.WriteLine("\n--- Все товары ---");
                foreach (Product p in products)
                    p.PrintInfo();
            }
            else if (choice == "0")
            {
                return;
            }
            else
            {
                Console.WriteLine("Неверный выбор!");
            }
        }
    }
}
class Product
{
    public string Code;
    public string Name;
    public double Price;
    public int Count;
    public bool InStock;
    public string Category;
    public void PrintInfo()
    {
        Console.WriteLine("--------------------");
        Console.WriteLine($"Код: {Code}");
        Console.WriteLine($"Название: {Name}");
        Console.WriteLine($"Цена: {Price}");
        Console.WriteLine($"Количество: {Count}");
        Console.WriteLine($"В наличии: {(InStock ? "Да" : "Нет")}");
        Console.WriteLine($"Категория: {Category}");
        }
    }
}
