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
                  
        }
    }
}
