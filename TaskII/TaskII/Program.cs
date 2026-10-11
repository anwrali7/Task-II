namespace TaskII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            string c;

            do
            {
                Console.WriteLine();
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("F - Find a number in the list");
                Console.WriteLine("C - Clear the list");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                c = Console.ReadLine();



                switch (c)
                {
                    // Print numbers
                    case "P":
                    case "p":
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("[] - the list is empty");
                        }
                        else
                        {
                            Console.Write("[ ");
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                            Console.WriteLine("]");
                        }
                        break;

                    // Add a number
                    case "A":
                    case "a":
                        Console.Write("Enter an integer to add: ");
                        int addedNum = Convert.ToInt32(Console.ReadLine());
                        numbers.Add(addedNum);
                        Console.WriteLine($"{addedNum} added");
                        break;

                    // Display mean of the numbers
                    case "M":
                    case "m":
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to calculate the mean - no data");
                        }
                        else
                        {
                            double sum = 0;
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                sum = sum + numbers[i];
                            }
                            double mean = sum / numbers.Count;
                            Console.WriteLine("The mean is " + mean);
                        }
                        break;

                    // Display the smallest number
                    case "S":
                    case "s":
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
                        }
                        else
                        {
                            int smallest = numbers[0];
                            for (int i = 1; i < numbers.Count; i++)
                            {
                                if (numbers[i] < smallest)
                                {
                                    smallest = numbers[i];
                                }
                            }
                            Console.WriteLine("The smallest number is " + smallest);
                        }
                        break;

                    // Display the largest number
                    case "L":
                    case "l":
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the largest number - list is empty");
                        }
                        else
                        {
                            int largest = numbers[0];
                            for (int i = 1; i < numbers.Count; i++)
                            {
                                if (numbers[i] > largest)
                                {
                                    largest = numbers[i];
                                }
                            }
                            Console.WriteLine("The largest number is " + largest);
                        }
                        break;

                    // Find a number in the list
                    case "F":
                    case "f":
                        Console.Write("Enter the number to find: ");
                        int findNum = Convert.ToInt32(Console.ReadLine());
                        if (numbers.Contains(findNum))
                        {
                            Console.WriteLine($"{findNum} is in the list");
                        }
                        else
                        {
                            Console.WriteLine($"{findNum} is not in the list");
                        }
                        break;

                    // Clear the list
                    case "C":
                    case "c":
                        numbers.Clear();
                        Console.WriteLine("List cleared");
                        break;

                    // Quit
                    case "Q":
                    case "q":
                        Console.WriteLine("Goodbye!");
                        break;

                    // Invalid choice
                    default:
                        Console.WriteLine("Unknown selection, please try again");
                        break;
                }
            } while (c != "Q" && c != "q");
        }
    }
}
