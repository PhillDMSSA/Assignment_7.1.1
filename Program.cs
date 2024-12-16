namespace Assignment_7._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] grades = { 96, 100, 75, 71, 65, 85, 82, 79 };

            Console.WriteLine($"Grades: {String.Join(" ", grades)} ");

            SelectionSort(grades);

            Console.WriteLine("\nSorted Scores (Ascending Order):");
            DisplayArray(grades);
        }
        static void SelectionSort(int[] nums)
        {
           
            for(int i = 0; i < nums.Length - 1; i++)
            {
                int minIndex = i;
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] <  nums[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = nums[minIndex];
                nums[minIndex] = nums[i];
                nums[i] = temp;
            }
        }
        static void DisplayArray(int[] array)
        {
            foreach(int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
