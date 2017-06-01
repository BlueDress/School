using System;
using System.Collections.Generic;
using System.Linq;

namespace Matrix_Operator
{
    public class MatrixOperator
    {
        public static void Main()
        {
            var rows = int.Parse(Console.ReadLine());

            var matrix = new List<string>();

            for (int i = 0; i < rows; i++)
            {
                matrix.Add(Console.ReadLine());
            }

            while (true)
            {
                var input = Console.ReadLine().Split();

                if (input[0].Equals("end"))
                {
                    break;
                }
                else
                {
                    switch (input[0])
                    {
                        case "remove":

                            switch (input[1])
                            {
                                case "positive":

                                    switch (input[2])
                                    {
                                        case "row":

                                            if (!matrix[int.Parse(input[3])].Equals(string.Empty))
                                            {
                                                var tempList1 = matrix[int.Parse(input[3])].Split().Select(int.Parse).ToList();
                                                tempList1.RemoveAll(x => x > 0);

                                                if (tempList1.Count > 0)
                                                {
                                                    matrix[int.Parse(input[3])] = string.Join(" ", tempList1);
                                                }
                                                else
                                                {
                                                    matrix[int.Parse(input[3])] = string.Empty;
                                                }
                                            }
                                            break;

                                        case "col":
                                            var column = int.Parse(input[3]);

                                            for (int i = 0; i < matrix.Count; i++)
                                            {
                                                if (!matrix[i].Equals(string.Empty))
                                                {
                                                    var tempList = matrix[i].Split().Select(int.Parse).ToList();

                                                    if (tempList.Count > column)
                                                    {
                                                        if (tempList[column] > 0)
                                                        {
                                                            tempList.RemoveAt(column);
                                                        }

                                                        if (tempList.Count > 0)
                                                        {
                                                            matrix[i] = string.Join(" ", tempList);
                                                        }
                                                        else
                                                        {
                                                            matrix[i] = string.Empty;
                                                        }
                                                    }
                                                }
                                            }
                                            break;
                                    }
                                    break;

                                case "negative":

                                    switch (input[2])
                                    {
                                        case "row":

                                            if (!matrix[int.Parse(input[3])].Equals(string.Empty))
                                            {
                                                var tempList1 = matrix[int.Parse(input[3])].Split().Select(int.Parse).ToList();
                                                tempList1.RemoveAll(x => x < 0);

                                                if (tempList1.Count > 0)
                                                {
                                                    matrix[int.Parse(input[3])] = string.Join(" ", tempList1);
                                                }
                                                else
                                                {
                                                    matrix[int.Parse(input[3])] = string.Empty;
                                                }
                                            }

                                            break;

                                        case "col":
                                            var column = int.Parse(input[3]);

                                            for (int i = 0; i < matrix.Count; i++)
                                            {
                                                if (!matrix[i].Equals(string.Empty))
                                                {
                                                    var tempList = matrix[i].Split().Select(int.Parse).ToList();

                                                    if (tempList.Count > column)
                                                    {
                                                        if (tempList[column] < 0)
                                                        {
                                                            tempList.RemoveAt(column);
                                                        }

                                                        if (tempList.Count > 0)
                                                        {
                                                            matrix[i] = string.Join(" ", tempList);
                                                        }
                                                        else
                                                        {
                                                            matrix[i] = string.Empty;
                                                        }
                                                    }
                                                }
                                            }
                                            break;
                                    }
                                    break;

                                case "odd":

                                    switch (input[2])
                                    {
                                        case "row":

                                            if (!matrix[int.Parse(input[3])].Equals(string.Empty))
                                            {
                                                var tempList1 = matrix[int.Parse(input[3])].Split().Select(int.Parse).ToList();
                                                tempList1.RemoveAll(x => x % 2 != 0);

                                                if (tempList1.Count > 0)
                                                {
                                                    matrix[int.Parse(input[3])] = string.Join(" ", tempList1);
                                                }
                                                else
                                                {
                                                    matrix[int.Parse(input[3])] = string.Empty;
                                                }
                                            }

                                            break;

                                        case "col":
                                            var column = int.Parse(input[3]);

                                            for (int i = 0; i < matrix.Count; i++)
                                            {
                                                if (!matrix[i].Equals(string.Empty))
                                                {
                                                    var tempList = matrix[i].Split().Select(int.Parse).ToList();

                                                    if (tempList.Count > column)
                                                    {
                                                        if (tempList[column] % 2 != 0)
                                                        {
                                                            tempList.RemoveAt(column);
                                                        }

                                                        if (tempList.Count > 0)
                                                        {
                                                            matrix[i] = string.Join(" ", tempList);
                                                        }
                                                        else
                                                        {
                                                            matrix[i] = string.Empty;
                                                        }
                                                    }
                                                }
                                            }
                                            break;
                                    }
                                    break;

                                case "even":

                                    switch (input[2])
                                    {
                                        case "row":

                                            if (!matrix[int.Parse(input[3])].Equals(string.Empty))
                                            {
                                                var tempList1 = matrix[int.Parse(input[3])].Split().Select(int.Parse).ToList();
                                                tempList1.RemoveAll(x => x % 2 == 0);

                                                if (tempList1.Count > 0)
                                                {
                                                    matrix[int.Parse(input[3])] = string.Join(" ", tempList1);
                                                }
                                                else
                                                {
                                                    matrix[int.Parse(input[3])] = string.Empty;
                                                }
                                            }

                                            break;

                                        case "col":
                                            var column = int.Parse(input[3]);

                                            for (int i = 0; i < matrix.Count; i++)
                                            {
                                                if (!matrix[i].Equals(string.Empty))
                                                {
                                                    var tempList = matrix[i].Split().Select(int.Parse).ToList();

                                                    if (tempList.Count > column)
                                                    {
                                                        if (tempList[column] % 2 == 0)
                                                        {
                                                            tempList.RemoveAt(column);
                                                        }

                                                        if (tempList.Count > 0)
                                                        {
                                                            matrix[i] = string.Join(" ", tempList);
                                                        }
                                                        else
                                                        {
                                                            matrix[i] = string.Empty;
                                                        }
                                                    }
                                                }
                                            }
                                            break;
                                    }
                                    break;
                            }
                            break;

                        case "swap":

                            var firstRow = matrix[int.Parse(input[1])];
                            var secondRow = matrix[int.Parse(input[2])];

                            matrix[int.Parse(input[2])] = firstRow;
                            matrix[int.Parse(input[1])] = secondRow;

                            break;

                        case "insert":

                            matrix[int.Parse(input[1])] = input[2] + " " + matrix[int.Parse(input[1])];

                            break;
                    }
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(row);
            }
        }
    }
}
