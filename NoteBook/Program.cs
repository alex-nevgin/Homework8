using System;
using System.IO;
using System.Xml.Serialization;

namespace NoteBook
{
	partial class Program
	{

		static Worker Input()
		{
			Console.WriteLine("Введите имя: ");
			string name = Console.ReadLine();
			Console.WriteLine("Введите улицу: ");
			string street = Console.ReadLine();
			Console.WriteLine("Введите номер дома: ");
			string house = Console.ReadLine();
			Console.WriteLine("Введите номер квартиры: ");
			string apt = Console.ReadLine();
			Console.WriteLine("Введите номер домашнего телефона: ");
			string fixNum = Console.ReadLine();
			Console.WriteLine("Введите номер мобильного телефона: ");
			string cellNum = Console.ReadLine();

			Worker w = new Worker(name, street, house, apt, fixNum, cellNum);
			return w;
		}

		static void SerializeWorker(Worker w, string p)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(Worker));
			Stream fs = new FileStream(p, FileMode.Create, FileAccess.Write);
			xmlSerializer.Serialize(fs, w);
			fs.Close();
		}
		
		static void Main(string[] args)
		{
			var w = new Worker("Alex Sohn", "Bond St.", "56", 
				"23", "1236545", "89076868");
			const string p = "_w.xml";
			SerializeWorker(w, p);
			
			
		}
	}
}