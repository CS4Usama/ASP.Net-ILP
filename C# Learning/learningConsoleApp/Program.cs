using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
//using learningConsoleApp.Exercise;

namespace learningConsoleApp
{
    class Person
    {
        private string name;
        private int age;
        
        // Private Anonymous Backing Fields:>
        //public string Name { get; set; }
        //public int Age { get; set; }

        public string Name
        {
            get => name;
            set => name = !string.IsNullOrEmpty(value) ? value : "Invalid Name!";
        }
        public int Age
        {
            get => age;
            set => age = value >= 0 && value <= 150 ? value : -1;
        }
        public Person (string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"Name: {name} \t Age: {age} \t ";
        }
        public override bool Equals(object obj)
        {
            if (obj is Person)
            {
                Person person = obj as Person;
                return Name.Equals(person.Name) && Age == person.Age;
            }
            return false;
        }
    }


    internal class Program
    {
        /*struct Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        };*/

        static void Main(string[] args)
        {
            Exercise exrc = new Exercise();
            //exrc.Table();
            //exrc.FizzBuzz();
            //exrc.ReverseStr();
            //exrc.PasswordChecker();
            //exrc.TriangleValidation();
            //exrc.EvenOddSplit();
            //Exercise.ArrayOfMultiples();
            //exrc.IntArrSum();
            //exrc.ExceptionHandling();



            /*Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Your Age: ");
            var age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nYour name is " + name + " and your age is " + age);*/


            /*double pnt = -10D / 3D;
            Console.WriteLine(pnt);*/

            /*Console.WriteLine(string.Format("${00:0.00}", pnt));
            Console.WriteLine(pnt.ToString("C"));
            Console.WriteLine(pnt.ToString("C0"));
            Console.WriteLine(pnt.ToString("C1"));
            Console.WriteLine(pnt.ToString("C2"));

            Console.WriteLine(pnt.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(pnt.ToString("C", CultureInfo.CreateSpecificCulture("ur-pKr")));*/

            /*string num = Console.ReadLine();
            bool suc = int.TryParse(num, out int result);
            Console.WriteLine(result);
            Console.WriteLine(suc);*/

            /*string name = "Usama";
            int age = 23;
            Console.WriteLine("My name is " + name + " and my age is " + age);   //Simple String Display
            Console.WriteLine("My name is {0} and my age is {1}", name, age);   //String Formatting
            Console.WriteLine($"My name is {name} and my age is {age}");   //String Interpolation

            string[] names = { "Usama ", "Ali ", "Hamza" };
            Console.WriteLine(string.Concat(names));

            string str = "hello";
            char[] chars = { 'h', 'e', 'l', 'l', 'o' };
            object str2 = new string(chars);
            //System.Threading.Thread.Sleep(1000);
            if(str.Equals(str2))
            {
                Console.WriteLine("EQUAL");
            }

            string newStr = null;
            if(newStr == "")
            {
                Console.WriteLine("here...");
            }*/


            /*int[] nums = new int[5];
            for(int i = 0; i<nums.Length; i++)
            {
                Console.Write("Enter A Number: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write($"{nums[i]} ");
            //}
            foreach (int num in nums)
            {
                Console.Write($"{num} ");
            }*/


            /*string test = "Usama";
            string newtst = test.Replace('a', '*');
            Console.WriteLine(newtst);
            int[] arr = new int[] { 1, 3, 3, 5, 0, 4, 8, 1 };
            Array.Sort(arr);
            foreach(int i in arr)
            {
                Console.Write(i);
            }

            Array.Clear(arr, 5, 3);
            foreach (int i in arr)
            {
                Console.Write(i);
            }*/


            /*List<int> list = new List<int>();
            for(int i = 0; i < 3; i++)
            {
                Console.Write("Enter Number: ");
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }*/


            /*Dictionary<int, string> dict = new Dictionary<int, string>
            {
                { 1, "Usama" },
                { 2, "Ali" },
                { 3, "Hamza" }
            };
            for(int i = 0; i < dict.Count; i++)
            {
                KeyValuePair<int, string> pair = dict.ElementAt(i);
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }
            Console.WriteLine();
            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }
            if(dict.TryGetValue(1, out var value))
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("Not Found!");
            }
            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }

            Console.WriteLine(dict.ContainsKey(1));*/


            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Person person = new Person(name, age);
            Person test = new Person("Aba", 25);
            Console.WriteLine($"Name is {name} and Age is {age}");
            Console.WriteLine(person);

            if (person.Equals(test))
            //if (person == test)
                {
                Console.WriteLine("Objects are Same!");
            }
            else
            {
                Console.WriteLine("Objects are Different!");
            }





            Console.Title = "C# Learning from FreeCodeCamp.org";

            Console.ReadLine();
        }
    }
}
