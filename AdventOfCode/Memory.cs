using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Memory
    {//base, inherit, abstract, interface, internal, private, protected, public, sealed, static, virtual, volatile, extern, override, new, partial, ref, out, in, params, readonly, unsafe, as, is, sizeof, typeof, checked, unchecked, default, delegate, event, explicit, implicit, namespace, operator, this, throw, try, catch, finally, fixed, from, group, into, join, let, orderby, select, where, yield, add, remove, get, set, value, alias, ascending, descending, dynamic, from, get, global, group, into, join, let, orderby, partial, select, set, value, var, where, yield, async, await, when, where,  
        public static void ShowAll()
        {
            StreamReader sr = new StreamReader("input.txt");
            string line = sr.ReadLine();
            var input = File.ReadAllText("input.txt");
            Console.WriteLine(input);
            Console.ReadKey();
        }
        public static void Star1GPT()
        {
            int numbersTotal = 0;
            List<int> numbers = new List<int>();

            using (StreamReader sr = new StreamReader("input.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    int number1 = 0;
                    int number2 = 0;

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (char.IsDigit(line[i]))
                        {
                            if (number1 == 0)
                            {
                                number1 = line[i] - '0';
                            }
                            number2 = line[i] - '0'; // Always update number2 to the last digit
                        }
                    }

                    int number3 = number1 * 10 + number2;
                    Console.WriteLine(number3);
                    numbers.Add(number3);
                }
            }

            numbersTotal = numbers.Sum();
            Console.WriteLine(numbersTotal);
        }

        public static void Star1cpy()
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
        public static void Star2()
        {
            //second bool is to check if the first number is already set // NOT NEEDED
            bool firstHit = false;
            bool secondHit = false;
            string number1 = "none";
            string number2 = "none";
            int number3 = 0;
            int numbersTotal = 0;
            List<int> numbers = new List<int>();
            string[] numbersString = { "one", "two", "three", "four",
                "five", "six", "seven", "eight", "nine" };
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
                            //number1 = n;
                            //Console.WriteLine(number1);

                        }
                        else if (isNumeric is true && firstHit is true)
                        {
                            //number2 = n;
                            //Console.WriteLine(number2);
                        }
                        else if (isNumeric is false) ;
                    }
                    if (number2 == "none")
                    {
                        secondHit = false;
                        number2 = number1;
                        foreach (string i in numbersString)
                        {
                            if (number1 == i)
                            {
                                number1 = i;
                            }
                        }
                    }
                    number3 = int.Parse(number1 + number2);
                    Console.WriteLine(number3);
                    numbers.Add(number3);
                    firstHit = false;
                    secondHit = false;
                    number2 = "none";
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                numbersTotal += numbers[i];
                //Console.WriteLine(numbers[i]);
            }
            Console.WriteLine(numbersTotal);
        }

        public static void Star1()
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
        public static void Star2()
        {
            int rowValue = 0;
            int numbersTotal = 0;
            bool found = false;
            bool found2 = false;

            //Data, Index
            List<int[]> numbers = new List<int[]>();
            List<int[]> words = new List<int[]>();
            //--------------------

            Dictionary<string, int> numbersString = new Dictionary<string, int>();
            numbersString.Add("one", 1);
            numbersString.Add("two", 2);
            numbersString.Add("three", 3);
            numbersString.Add("four", 4);
            numbersString.Add("five", 5);
            numbersString.Add("six", 6);
            numbersString.Add("seven", 7);
            numbersString.Add("eight", 8);
            numbersString.Add("nine", 9);

            string[] numbersStringArray = { "one", "two", "three", "four",
                "five", "six", "seven", "eight", "nine" };

            using (StreamReader sr = new StreamReader("input.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    int n; bool isNumeric = int.TryParse(line.ToString(), out n);
                    int index3 = -1;

                    for (int i = 0; numbersStringArray.Length > i; i++)
                    {
                        do
                        {
                            index3 = line.IndexOf(numbersStringArray[i], index3 + 1);
                            if (index3 != -1)
                            {
                                Console.WriteLine($"Substring '{numbersStringArray[i]}' found at index {index3}");
                                numbersString.TryGetValue(numbersStringArray[i], out int result);
                                words.Add(new int[2] { result, index3 });
                                found = true;
                            }
                        } while (index3 != -1);
                    }

                    for (int i = 0; i < line.Length; i++)
                    {
                        isNumeric = int.TryParse(line[i].ToString(), out n);

                        if (isNumeric is true)
                        {
                            Console.WriteLine($"Number '{n}' found at index {i}");
                            numbers.Add(new int[2] { n, i });
                            found2 = true;
                        }
                    }

                    if (found2 is true && found is false)
                    {
                        int highestIndex = numbers.Max(arr => arr[1]);
                        int lowestIndex = numbers.Min(arr => arr[1]);
                        rowValue = int.Parse(line[lowestIndex].ToString()) * 10 + int.Parse(line[highestIndex].ToString());
                    }
                    if (found2 is false && found is true)
                    {
                        int highestIndex = words.Max(arr => arr[1]);
                        int lowestIndex = words.Min(arr => arr[1]);
                        int index = 0;
                        int index2 = 0;

                        for (int i = 0; i < words.Count(); i++)
                        {
                            if (words[i].Contains(highestIndex))
                            {
                                // Find the other element in the same array
                                //int otherElement = words[i].First(element => element != highestIndex2);
                                index = i;
                            }
                        }
                        // Iterate through each array in the list
                        for (int i = 0; i < words.Count(); i++)
                        {
                            // Check if the known value is present in the array
                            if (words[i].Contains(lowestIndex))
                            {
                                // Find the other element in the same array
                                //int otherElement2 = words[i].First(element => element != lowestIndex2);
                                index2 = i;
                            }
                        }
                        //Console.WriteLine(words[index][0]);
                        //Console.WriteLine(words[index2][0]);
                        rowValue = words[index2][0] * 10 + words[index][0]; //swapped index and index2
                        //rowValue = words[index][lowestIndex] * 10 + words[index2][highestIndex];
                        //words.Sort((x, y) => x[1].CompareTo(y[1]));
                        //Will get lowest values but not from the lowest index
                        //int highestValue2 = words[?][highest index];
                        //int lowestValue2 = words.Min(arr => arr[0]);

                        //rowValue = int.Parse(line[lowestValue2].ToString()) * 10 + int.Parse(line[highestValue2].ToString());
                    }
                    if (found is true && found2 is true)
                    {
                        int highestIndex2 = words.Max(arr => arr[1]);
                        int lowestIndex2 = words.Min(arr => arr[1]);
                        int highestIndex = numbers.Max(arr => arr[1]);
                        int lowestIndex = numbers.Min(arr => arr[1]);
                        int high = 0;
                        int low = 0;

                        if (highestIndex > highestIndex2)
                        {
                            high = int.Parse(line[highestIndex].ToString());
                            Console.WriteLine($"number high {high}");
                        }
                        else
                        {
                            List<int> index = new List<int>();
                            int real2 = 0;
                            for (int i = 0; i < words.Count(); i++)
                            {
                                if (words[i].Contains(highestIndex2)) //LATEST CHANGE
                                {
                                    // Find the other element in the same array
                                    //int otherElement = words[i].First(element => element != highestIndex2);
                                    index.Add(i);
                                }
                            }
                            for (int i = 0; i < index.Count; i++)
                            {
                                if (words[index[i]][1] == highestIndex2)
                                {
                                    real2 = words[index[i]][0];
                                }
                            }
                            high = real2;
                            Console.WriteLine($"word high {high}");
                        }
                        if (lowestIndex2 > lowestIndex)
                        {
                            low = int.Parse(line[lowestIndex].ToString());
                            Console.WriteLine($"number low {low}");
                        }
                        else
                        {
                            List<int> index2 = new List<int>();
                            int real = 0;
                            for (int i = 0; i < words.Count(); i++)
                            {
                                Console.WriteLine(words[i][0]);
                                Console.WriteLine(words[i][1]);
                                if (words[i].Contains(lowestIndex2)) //WHY NOT 2??????????????
                                {
                                    // Find the other element in the same array
                                    //int otherElement = words[i].First(element => element != highestIndex2);
                                    index2.Add(i);
                                }
                            }
                            for (int i = 0; i < index2.Count; i++)
                            {
                                if (words[index2[i]][1] == lowestIndex2)
                                {
                                    real = words[index2[i]][0];
                                }
                            }
                            low = real; //lowestIndex??????????
                            Console.WriteLine($"word low {low}");
                        }
                        rowValue = low * 10 + high;
                    }
                    if (found is false & found2 is false)
                    {
                        ;
                    }

                    Console.WriteLine(rowValue);
                    numbersTotal += rowValue;

                    //RESET EVERY LOOP
                    words = new List<int[]>();
                    numbers = new List<int[]>();
                    found = false;
                    found2 = false;
                    rowValue = 0;
                    Console.WriteLine("Next");
                }
            }
            Console.WriteLine(numbersTotal);
        }

        public static void Star2GPT()
        {
            int numbersTotal = 0;
            List<int> numbers = new List<int>();

            using (StreamReader sr = new StreamReader("input.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    int number1 = 0;
                    int number2 = 0;

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (char.IsDigit(line[i]))
                        {
                            if (number1 == 0)
                            {
                                number1 = line[i] - '0';
                            }
                            number2 = line[i] - '0'; // Always update number2 to the last digit
                        }
                        else if (char.IsLetter(line[i]))
                        {
                            int spelledDigit = SpellToDigit(line.Substring(i));
                            if (number1 == 0)
                            {
                                number1 = spelledDigit;
                            }
                            number2 = spelledDigit;
                            i += spelledDigit.ToString().Length - 1; // Skip the spelled-out digits
                        }
                    }

                    int number3 = number1 * 10 + number2;
                    Console.WriteLine(number3);
                    numbers.Add(number3);
                }
            }

            numbersTotal = numbers.Sum();
            Console.WriteLine(numbersTotal);
        }

        public static int SpellToDigit(string spelledDigit)
        {
            switch (spelledDigit.ToLower())
            {
                case "one": return 1;
                case "two": return 2;
                case "three": return 3;
                case "four": return 4;
                case "five": return 5;
                case "six": return 6;
                case "seven": return 7;
                case "eight": return 8;
                case "nine": return 9;
                default: throw new ArgumentException("Invalid spelled digit: " + spelledDigit);
            }
        }
    }
}
