using System;
using System.Collections.Generic;
using System.Globalization;

namespace Homework8
{
	class Program
	{
		/// <summary>
		/// Creates and fills a List of 100 randomly generated integers
		/// </summary>
		/// <returns>A list of 100 random integers </returns>
		static List<int> CreateAndFill()
		{
			List<int> nums = new List<int>();
			Random r = new Random();

			for (int i = 0; i < 100; i++)
			{
				nums.Add(r.Next(100));
			}
			return nums;
		}

		/// <summary>
		/// Removes elements (within specified range of values) from the list
		/// </summary>
		/// <param name="nums">List to delete elements from</param>
		/// <returns>A list with elements within specified range of values removed </returns>
		static List<int> RemoveElements(List<int> nums)
		{
			for (int i = 99; i >= 0; i--)
			{
				if (nums[i] > 25 && nums[i] < 50)
				{
					nums.Remove(nums[i]);
				}
				
			}
			return nums;
		}
		
		/// <summary>
		/// Displays the list into the console
		/// </summary>
		/// <param name="nums">A list to display</param>
		static void Output(List<int> nums)
		{
			for (int i = 0; i < nums.Count; i++)
			{
				Console.Write(nums[i] + " ");
			}
		} 

		static void Main(string[] args)
		{
			List<int> ints = CreateAndFill();
			Console.WriteLine("Коллекция до изменений: ");
			Output(ints);

			Console.WriteLine();

			ints = RemoveElements(ints);
			Console.WriteLine("Коллекция после изменения: ");
			Output(ints);

		}
		
	}
}