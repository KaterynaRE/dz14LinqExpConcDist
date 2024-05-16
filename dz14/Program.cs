using cl;
using clComp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz14
{
	internal class Program
	{
		static int DigitSum(int num)
		{
			int sum = 0;
			while (num > 0)
			{
				sum += num % 10;
				num /= 10;
			}
			return sum;
		}
		static void Main(string[] args)
		{

			//			Завдання 1:
			//Для масиву цілих чисел реалізуйте користувацьке сортування.
			//Сортування має працювати за сумою цифр числа(за зростанням та зменшенням).
			//Наприклад, якщо сортування проводиться за зменшенням, потрібно повернути числа з максимальною сумою
			//в порядку зменшення суми. Наприклад, якщо масив містить 121, 75, 81,
			//після сортування за зменшенням ми отримаємо 75, 81, 121.
			//Такий результат, тому що 7 + 5 = 12, 8 + 1 = 9, 1 + 2 + 1 = 4.

			//int[] arr = { 121, 75, 81 };

			//Console.WriteLine("Select a sort method: 1 - ascending, 2 - descending");
			//int choiceUser = int.Parse(Console.ReadLine());
			//if (choiceUser == 1)
			//{
			//	int[] arrAsc = arr.OrderBy(x => DigitSum(x)).ToArray();
			//	PrintList(arrAsc.ToList());
			//}
			//else if (choiceUser == 2)
			//{
			//	int[] arrDesc = arr.OrderByDescending(x => DigitSum(x)).ToArray();
			//	PrintList(arrDesc.ToList());
			//}


			//			Завдання 2:
			//Для двох масивів країн реалізуйте такі запити:
			//+ Отримати різницю двох масивів(елементи першого масиву, яких немає у другому). 
			//+ Отримати перетин масивів(спільні елементи для обох масивів).
			//+ Отримати об'єднання масивів (елементи обох масивів без дублікатів).
			//+ Отримати вміст першого масиву без повторень.

			//string[] countries1 = { "Ukraine", "USA", "Poland", "Germany", "Egipt", "Germany", "USA" };
			//Console.Write("\nArray 1: ");
			//PrintList(countries1.ToList());

			//string[] countries2 = { "Poland", "Ukraine", "USA", "Egipt" };
			//Console.Write("\nArray 2: ");
			//PrintList(countries2.ToList());

			//List<string> cExp = countries1.Except(countries2).ToList();
			//Console.Write("\nExept: ");
			//PrintList(cExp.ToList());

			//List<string> cInters = countries1.Intersect(countries2).ToList();
			//Console.Write("\nIntersect: ");
			//PrintList(cInters.ToList());

			//List<string> cUnion = countries1.Union(countries2).ToList();
			//Console.Write("\nConcat: ");
			//PrintList(cUnion.ToList());

			//List<string> cDist = countries1.Distinct().ToList();
			//Console.Write("\nDist array 1: ");
			//PrintList(cDist.ToList());


			//			Завдання 3:
			//Створіть користувацький тип «Пристрій», який зберігатиме так інформацію:
			//+ назва пристрою;
			//+ виробник пристрою;
			//+ вартість.
			//Для двох масивів пристроїв реалізуйте операції:
			//+ різниця масивів;
			//+ перетин масивів;
			//+ об'єднання масивів.
			//Критерій для проведення операцій — виробник пристрою

			ClDevice device1 = new ClDevice("Smartphone", "Samsung", 2500);
			ClDevice device2 = new ClDevice("Laptop", "HP", 5000);
			ClDevice device3 = new ClDevice("Tablet", "Apple", 3000);
			ClDevice device4 = new ClDevice("Smartwatch", "Xiaomi", 1500);
			ClDevice device5 = new ClDevice("Camera", "Canon", 4000);
			ClDevice device6 = new ClDevice("Headphones", "Samsung", 1000);

			ClDevice[] clDevices1 = { device1, device2, device3, device4, device5 };
			Console.WriteLine("\nArray device1: ");
			PrintList(clDevices1.ToList());

			ClDevice[] clDevices2 = { device1, device2, device3, device5, device6 };
			Console.WriteLine("\nArray device2: ");
			PrintList(clDevices1.ToList());

			ClDeviceManufacturerComparer comparer = new ClDeviceManufacturerComparer();

			var deviceExp = clDevices1.Except(clDevices2, comparer).ToList();
			Console.WriteLine("\nExept arrays device: \n");
			PrintList(deviceExp.ToList());

			var deviceInter = clDevices1.Intersect(clDevices2, comparer).ToList();
			Console.WriteLine("\nIntersect arrays device: \n");
			PrintList(deviceInter.ToList());

			var deviceConcat = clDevices1.Concat(clDevices2).ToList();
			Console.WriteLine("\nConcat arrays device: \n");
			PrintList(deviceConcat.ToList());

			var deviceUnion = clDevices1.Union(clDevices2, comparer).ToList();
			Console.WriteLine("\nUnion arrays device: \n");
			PrintList(deviceUnion.ToList());

		}

		private static void PrintList<T>(List<T> list, string separator = " ")
		{
			foreach (T item in list)
			{
				Console.Write(item + separator);
			}
			Console.WriteLine();
		}
	}
}
