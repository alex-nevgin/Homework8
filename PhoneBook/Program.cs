using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PhoneBook
{
	static class Program
	{
		/// <summary>
		/// Adds specified phone number (key) and name (value) to the dictionary d.
		/// </summary>
		/// <param name="d">The dictionary to add elements to.</param>
		/// <param name="data">Tuple containing key and value to add.</param>
		/// <returns>The dictionary with added element</returns>
		static Dictionary<string,string> Add(Dictionary<string,string> d, (string,string) data)
		{
			string p = data.Item1;
			string n = data.Item2;
			
			d.Add(p, n);
			return d;
		}

		/// <summary>
		/// Handles user input
		/// </summary>
		/// <returns>The tuple representing key-value pair to add to dictionary</returns>
		static (string,string) Input()
		{
			Console.WriteLine("Введите номер: ");
			string p = Console.ReadLine();
			Console.WriteLine("Введите имя: ");
			string n = Console.ReadLine();

			(string, string) data = (p, n);
			return data;
		}
		
		/// <summary>
		/// Searches for entries of specified key in the dictionary.
		/// </summary>
		/// <param name="d">The dictionary to search in.</param>
		/// <param name="p">The key to search entries of</param>
		/// <returns>if exists, a string representing the key-value pair with specified key; otherwise null.</returns>
		static string Search(Dictionary<string,string> d, string p)
		{
			bool isContainsKey = d.ContainsKey(p);
			if (isContainsKey)
			{
				string res = new KeyValuePair<string, string>(p, d[p]).ToString();
				return res;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// Outputs a dictionary into the console.
		/// </summary>
		/// <param name="d">The dictionary to display.</param>
		static void Output(Dictionary<string, string> d)
		{
			foreach (var e in d)
			{
				Console.WriteLine($"{e} ");
			}
		}
		
		static void Main(string[] args)
		{
			// Вариант с пустым словарём.
			// Dictionary<string, string> phoneBook = new Dictionary<string, string>();
			
			// Тестовый словарь.
			Dictionary<string, string> phoneBook = new Dictionary<string, string>()
			{
				{"1235454", "Alex"},
				{"6546565", "Tony"},
				{"5677788", "Alex"},
				{"8766865", "Alice"},
				{"8908706", "Bob"},
				{"9004499", "Rand"}
			};
			while (true)
			{
				Console.WriteLine("Для добавления номера в книгу нажмите 1; для поиска номера нажмите 2; "+
				                  "для отображения книги нажмите 3. Для выхода нажмите q.");
				string ev = Console.ReadLine();
				switch (ev)
				{
					case "1":
						(string, string) data = Input();
						Add(phoneBook, data);
						break;
					case "2":
						Console.WriteLine("Введите номер для поиска: ");
						string p = Console.ReadLine();
						string res = Search(phoneBook, p);
						if (res == null) Console.WriteLine("Номер не найден.");
						else Console.WriteLine($"Результат поиска: {res}");
						break;
					case "3":
						Output(phoneBook);
						break;
					case "q":
						Environment.Exit(0);
						break;
					default:
						Console.WriteLine("Действия не предусмотрено.");
						break;
				}
			}
		}
	}
}