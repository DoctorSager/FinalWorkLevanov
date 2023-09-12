internal class Program
{
   private static void Main(string[] args)
    {
        string[] inputArray = new string[4] {"12", "23", "hello", "res"};
        string[] outputArray = new string[inputArray.Length];
        int count = 0;
        
        SortArray(inputArray, outputArray);
        Print(outputArray);

        void SortArray(string[] firstArray, string[] secondArray)
            {
                for (int i = 0; i < firstArray.Length; i++)
                    {
                        if(firstArray[i].Length <= 3)
                            {
                                secondArray[count] = firstArray[i];
                                count++;
                            }
                    }
            }

        void Print(string[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
            }   
    }
}