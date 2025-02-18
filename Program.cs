using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;

namespace dz_karamov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable book = new Hashtable();
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Добавить новый контакт");
                Console.WriteLine("2 - Удалить контакт");
                Console.WriteLine("3 - Найти фамилию по номеру телефона");
                Console.WriteLine("4 - Найти номер телефона по фамилии");
                Console.Write("Выберите действие: ");
                int selected = Convert.ToInt16(Console.ReadLine());
                if (selected == 1)
                {
                    Console.Clear();
                    Console.Write("Введите фамилию контакта: ");
                    string name = Console.ReadLine();
                    Console.Write("Введите номер телефона: ");
                    string telephone = Console.ReadLine();
                    book.Add(name, telephone);
                    Console.WriteLine("Контакт добавлен");
                }
                else if (selected == 2)
                {
                    Console.Clear();
                    Console.Write("Введите фамилию контакта для удаления: ");
                    string name = Console.ReadLine();
                    book.Remove(name);
                    Console.WriteLine("Контакт удалён");
                }
                else if (selected == 3)
                {
                    Console.Clear();
                    Console.Write("Введите номер телефона: ");
                    string telephone = Console.ReadLine();
                    object[] keys = new object[book.Count];
                    book.Keys.CopyTo(keys, 0);
                    if (book.ContainsValue(telephone))
                    {
                        for (int i = 0; i < keys.Length; i++)
                        {
                            if (Convert.ToString(book[keys[i]]) == telephone)
                            {
                                Console.WriteLine($"Фамилия: {keys[i]} Номер: {telephone}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Контакт не найден");
                    }
                }
                else if (selected == 4)
                {
                    Console.Clear();
                    Console.Write("Введите фамилию: ");
                    string name = Console.ReadLine();
                    if (book.ContainsKey(name))
                    {
                        Console.WriteLine($"Фамилия: {name} Номер: {book[name]}");
                    }
                    else
                    {
                        Console.WriteLine("Контакт не найден");
                    }
                }
                Console.ReadLine();
            } while (true);
        }
    }
}
