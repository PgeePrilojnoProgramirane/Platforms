internal class Program
{
    private static void Main(string[] args)
    {
        int[]arr=Console.ReadLine().Split().Select(int.Parse).ToArray();
        Array.Sort(arr);
        bool flag = false;
        int count = 1;
        Console.WriteLine("List of platforms in the array : index - length of the platform:");
        for (int i = 0; i < arr.Length-1; i++)
        {
            if (arr[i] == arr[i+1])
            {
                count++;
                flag = true;
                if(i == arr.Length - 2)
                {
                    Console.WriteLine($"{i+2-count} - {count}");
                }
                         
            }
            else
            {
                if(count>1)
                {
                    Console.WriteLine($"{i + 1 - count} - {count}");
                }
                count = 1;
            }
        }
        Console.ReadLine();
    }
}