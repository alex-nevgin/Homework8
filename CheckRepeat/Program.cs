using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace CheckRepeat
{
	class Program
	{
		static void Main(string[] args)
		{
			// Первый элемент добавляется в HashSet<T> без проверки, т.к. HashSet изначально пустой.
			int num = Input();
			HashSet<int> set = new HashSet<int>();
			AddToHashset(num, set);
			Output(set);

			// Второй и последующие элементы итеративно вводятся и проверяются на наличие в HashSet<T>.
			while (true)
			{
				num = Input();
				bool isContains = CheckInput(num, set);
				if (isContains == false)
				{ 
					AddToHashset(num, set);
					Output(set);
				}
				else
				{
					Console.WriteLine("Число не было добавлено");
					Output(set);
				}
			}
		} 
		
		/// <summary>
		/// Handles user input
		/// </summary>
		/// <returns>The element to add to HashSet</returns>
		static int Input()
		{
			Console.WriteLine("Введите число: ");
			bool isInt = int.TryParse(Console.ReadLine(), out int num);
			if (isInt == false)
			{
				Console.WriteLine("Ошибка: ввод не является числом.");
			}
			
			return num;
		}

		/// <summary>
		/// Adds a user-specified number to the specified HashSet collection
		/// </summary>
		/// <param name="num">A number to add</param>
		/// <param name="set">A collection to add the number to </param>
		/// <returns>A set with added number</returns>
		static HashSet<int> AddToHashset(int num, HashSet<int> set)
		{
			if (num == 0)
			{
				set.Add(num);
				set.Remove(num);
			}
			set.Add(num);
			return set;
		}

		/// <summary>
		/// Checks whether user-provided element is contained in the set or not
		/// </summary>
		/// <param name="num">The element to check</param>
		/// <param name="set">The collection to check</param>
		/// <returns>
		/// true, if element is contained in the HashSet; false if not.
		/// </returns>
		static bool CheckInput(int num, HashSet<int> set)
		{
			bool isContains = set.Contains(num);
			
			return isContains;
		}

		/// <summary>
		/// Outputs a specified HashSet collection into a console
		/// </summary>
		/// <param name="set"></param>
		static void Output(HashSet<int> set)
		{
			Console.Write("Коллекция: ");
			foreach (var e in set)
			{
				Console.Write($"{e} ");
			}
			Console.WriteLine();
				
		}
		
	}
}