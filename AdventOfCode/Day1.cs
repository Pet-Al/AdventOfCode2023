using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day1
    {
        public static void Star1()
        {
            bool firstHit = false;
            bool secondHit = false;
            int number1 = 0;
            int number2 = -1;
            int number3 = 0;
            int numbersTotal = 0;
            List<int> numbers = new List<int>();

            using (StreamReader sr = new StreamReader("input.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    int n; bool isNumeric = int.TryParse(line.ToString(), out n);

                    for (int i = 0; i < line.Length; i++)
                    {
                        isNumeric = int.TryParse(line[i].ToString(), out n);

                        if (isNumeric is true && firstHit is false)
                        {
                            firstHit = true;
                            number1 = n;
                        }
                        else if (isNumeric is true && firstHit is true)
                        {
                            number2 = n;
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
            }
            Console.WriteLine(numbersTotal);
        }
        public static void Star2()
        {
            int rowValue = 0;
            int numbersTotal = 0;
            bool found = false;
            bool found2 = false;
            List<int[]> numbers = new List<int[]>();
            List<int[]> words = new List<int[]>();
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
                                index = i;
                            }
                        }
                        for (int i = 0; i < words.Count(); i++)
                        {
                            if (words[i].Contains(lowestIndex))
                            {
                                index2 = i;
                            }
                        }
                        rowValue = words[index2][0] * 10 + words[index][0];
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
                                if (words[i].Contains(highestIndex2))
                                {
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
                                if (words[i].Contains(lowestIndex2))
                                {
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
                            low = real;
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

    }
}
