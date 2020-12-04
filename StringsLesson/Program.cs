using System;
using System.Text;

namespace StringsLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // тип[] имя = new тип[количество]
            // имя [индекс] = значение;
            //Console.WritLine(имя[значение]);

            // int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            //for(int i = 0; i< numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(numbers);
            //}

            //// рванный массив
            //int[][] bigArray = new int[2][];
            //bigArray[0] = new int[10];
            //bigArray[1] = new int[5];

            //// двумерный массив
            //int[,] anotherArray = new int[2, 4];

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //int[] temporaryNumber = new int[10];

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //Array.Resize(ref numbers, numbers.Length + 1);          

            //String name = "Anuar";
            //string anotherName = "Anuar";
            //// string anotherString = new string(new char[] { 'a', 'b', 'c' });
            ////name.Trim();
            //if (name.Contains("o"))
            //{
            //    // TODO
            //}
            //var leng = name.Substring(1);

            //var data = "Привет, меня зовут Вася.  ";
            //var splittedArray = data.Split(" ");

            //var result = data + " " + name;

            Console.WriteLine("Пожалуйста, представьтесь:");
            var name = Console.ReadLine();
            Console.WriteLine("Здравствуйте, " + name + "! Добро Пожаловать!");
            var resultText = string.Format("Здравствуйте, {0}! Добро Пожаловать!",name);
            // Интерполяция строк
            var interpolatedText = $"Здравствуйте, {name}! Добро Пожаловать!";

            // Строитель строк, используется при создании больших текстов (более 10 объеденений)
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("Здравствуйте, ");
            stringBuilder.Append(name);
            stringBuilder.Append("! Добро пожаловать!");
            var resultString = stringBuilder.ToString();

            string path=@"C:\Program Files\Common";


            //string city = "Nur-Sultan";
            //city = city.Replace("N", "X");
            //Console.WriteLine(city);

            Console.ReadLine();


        }
    }
}
