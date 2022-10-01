using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PhoneBook
{
	static class Program
	{
		
		/// <summary>
		/// Adds a provided phone number into a dictionary
		/// </summary>
		/// <returns>A dictionary with a user-specified phone added in</returns>
		static Dictionary<string, string> Add()
		{
			Dictionary<string, string> phoneBook = new Dictionary<string, string>();
			while (true)
			{
				Console.WriteLine("Введите номер телефона: ");
				string phone = Console.ReadLine();
				Console.WriteLine("Введите имя: ");
				string name = Console.ReadLine();
				phoneBook.Add(phone, name);
				Console.WriteLine("Вводим далее? (y или Д - да, n или Н - нет)");
				ConsoleKey key = Console.ReadKey().Key;
				switch (key)
				{
					case ConsoleKey.N:
						Console.WriteLine();
						Menu();
						return phoneBook;
					case ConsoleKey.Y:
						Console.WriteLine();
						Add();
						break;
					default:
						Console.WriteLine("Действия не предусмотрено");
						break;
				}
			}
		}

		/// <summary>
		/// Displays a menu into the console
		/// </summary>
		static void Menu()
		{
			Console.WriteLine("Укажите действие (1 - Ввод данных и добавление в телефонную книгу, 2 - поиск по номеру, 0 - выход): ");
			string action = Console.ReadLine();
			switch (action)
			{
				case "1":
					Add();
					break;
				case "2":
					Dictionary<string, string> phoneBook = Add();
					Search(phoneBook);
					break;
				case "0": 
					
					break;
				default:
					Console.WriteLine("Действия не предусмотрено");
					break;
			}
		}

		/// <summary>
		/// Searches for a specified number (key) in a dictionary
		/// </summary>
		/// <param name="phoneBook">A list to search in</param>
		static void Search(Dictionary<string,string> phoneBook)
		{
			Console.WriteLine("Введите номер телефона для поиска: ");
			string phone = Console.ReadLine();
			string name;

			bool ifContainsKey = phoneBook.ContainsKey(phone);

			if (ifContainsKey)
			{
				Console.WriteLine(phoneBook[phone]);
			}
			else
			{
				Console.WriteLine("Номера нет в книге");
			}

		}

		static void Main(string[] args)
		{
			while (true)
			{
				Menu();
				break;
			}
		}
	}
}