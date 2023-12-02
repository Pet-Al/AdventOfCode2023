using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{//base, inherit, abstract, interface, internal, private, protected, public, sealed, static, virtual, volatile, extern, override, new, partial, ref, out, in, params, readonly, unsafe, as, is, sizeof, typeof, checked, unchecked, default, delegate, event, explicit, implicit, namespace, operator, this, throw, try, catch, finally, fixed, from, group, into, join, let, orderby, select, where, yield, add, remove, get, set, value, alias, ascending, descending, dynamic, from, get, global, group, into, join, let, orderby, partial, select, set, value, var, where, yield, async, await, when, where,  
    internal class Day1
    {
        public static void ShowAll()
        {
            StreamReader sr = new StreamReader("input.txt");
            string line = sr.ReadLine();
            var input = File.ReadAllText("input.txt");
            Console.WriteLine(input);
            Console.ReadKey();
        }
        public static void Run1()
        {
            //second bool is to check if the first number is already set // NOT NEEDED
            bool firstHit = false;
            bool secondHit = false;
            int number1 = 0;
            int number2 = -1;
            int number3 = 0;
            int numbersTotal = 0;
            List<int> numbers = new List<int>();
            //int index = 1; NOT NEEDED

            using (StreamReader sr = new StreamReader("input.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    int n; bool isNumeric = int.TryParse(line.ToString(), out n);
                    //Console.WriteLine(isNumeric);
                    for (int i = 0; i < line.Length; i++)
                    {
                        isNumeric = int.TryParse(line[i].ToString(), out n);
                        //Console.WriteLine(isNumeric);
                        if (isNumeric is true && firstHit is false)
                        {
                            firstHit = true;
                            number1 = n;
                            //Console.WriteLine(number1);

                        }
                        else if (isNumeric is true && firstHit is true)
                        {
                            number2 = n;
                            //Console.WriteLine(number2);
                        }
                        else if (isNumeric is false) ;
                    }
                    if (number2 == -1)
                    {
                        secondHit = false;
                        number2 = number1;
                    }
                    number3 = int.Parse(number1.ToString() + number2.ToString());
                    Console.WriteLine(number3);
                    numbers.Add(number3);
                    firstHit = false;
                    secondHit = false;
                    number2 = -1;
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                numbersTotal += numbers[i];
                //Console.WriteLine(numbers[i]);
            }
            Console.WriteLine(numbersTotal);
        }
        public static void Run2()
        {
            //second bool is to check if the first number is already set // NOT NEEDED
            bool firstHit = false;
            bool secondHit = false;
            int number1 = 0;
            int number2 = -1;
            int number3 = 0;
            int numbersTotal = 0;
            List<int> numbers = new List<int>();
            //int index = 1; NOT NEEDED

            using (StreamReader sr = new StreamReader("input.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    int n; bool isNumeric = int.TryParse(line.ToString(), out n);
                    //Console.WriteLine(isNumeric);
                    for (int i = 0; i < line.Length; i++)
                    {
                        isNumeric = int.TryParse(line[i].ToString(), out n);
                        //Console.WriteLine(isNumeric);
                        if (isNumeric is true && firstHit is false)
                        {
                            firstHit = true;
                            number1 = n;
                            //Console.WriteLine(number1);

                        }
                        else if (isNumeric is true && firstHit is true)
                        {
                            number2 = n;
                            //Console.WriteLine(number2);
                        }
                        else if (isNumeric is false) ;
                    }
                    if (number2 == -1)
                    {
                        secondHit = false;
                        number2 = number1;
                    }
                    number3 = int.Parse(number1.ToString() + number2.ToString());
                    Console.WriteLine(number3);
                    numbers.Add(number3);
                    firstHit = false;
                    secondHit = false;
                    number2 = -1;
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                numbersTotal += numbers[i];
                //Console.WriteLine(numbers[i]);
            }
            Console.WriteLine(numbersTotal);
        }
    }
}
