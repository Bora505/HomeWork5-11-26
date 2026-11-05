namespace HomeWork5_11_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 zad 
            List<string> nums = Console.ReadLine().Split(" ").ToList();
            //2 zad
            List<int> list = new List<int>();
            foreach (string str in nums)
            {
                int num = int.Parse(str);
                list.Add(num);
            }
            //3 zad
            foreach (int number in list) 
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            //4 zad
            Console.WriteLine($"{list.Count}");
            //5 zad
            List<int> newNums = new List<int>();
            foreach (int num in list)
            {
                if (num >= 0 && num % 2 == 0 && !newNums.Contains(num))
                {
                    newNums.Add(num);
                }
            }
            //6 zad
            Console.WriteLine($"{string.Join(", ",newNums)}");
            //7 zad
            Console.WriteLine($"{newNums.Count}");
            int sum = 0;
            foreach (int item in newNums)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
