namespace ListCalculations
{
    public class Program
    {
        // Get the sum of the 4 smallest values in a user-submitted list
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of numbers, separated by a comma:");
            var input = Console.ReadLine();

            string[] splitInput = input.Split(',');

            List<int> nums = new List<int>();

            foreach (var item in splitInput)
            {
                nums.Add(Convert.ToInt32(item));
            }

            nums.Sort();

            var smallNums = nums.GetRange(0, 4);

            Console.WriteLine(smallNums.Sum());
        }
    }
}
