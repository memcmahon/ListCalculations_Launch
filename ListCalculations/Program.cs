namespace ListCalculations
{
    public class Program
    {
        // Get the sum of the 4 smallest values in a user-submitted list
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of numbers, separated by a comma:");
            var input = Console.ReadLine();

            string[] splitInput = SplitOnComma(input);

            var nums = ParseStringArrayToIntList(splitInput);

            var smallNums = GetSmallestNums(nums, 4);

            Console.WriteLine(SumNumbers(smallNums));
        }

        //turn input into array of strings.
        static string[] SplitOnComma(string input)
        {
            return input.Split(',');
        }

        // convert each string in input to an integer, store as a list
        static List<int> ParseStringArrayToIntList(string[] stringNumbers)
        {
            List<int> nums = new List<int>();

            foreach (var item in stringNumbers)
            {
                nums.Add(Convert.ToInt32(item));
            }

            return nums;
        }

        // retrieve smallest numbers from list
        static List<int> GetSmallestNums(List<int> allNums, int count)
        {
            allNums.Sort();

            return allNums.GetRange(0, count);
        }

        // sum small numbers
        static int SumNumbers(List<int> nums)
        {
            return nums.Sum();
        }
    }
}

// Outputting and Getting information

//3,15,21,-5,82,7,5

