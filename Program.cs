using SelfValue;

try
{
    Console.WriteLine($"Enter the count for the necessery work: ");
    int n = int.Parse(Console.ReadLine());
    var necesseryWorkData = new List<PaymentPerHour>(); 
    StreamWriter writer = new("NecesseryWork.txt"); 
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Enter data for necessery work - (Code Type Payment Hours)");
        string[] command = Console.ReadLine().Split(" ");

        WorkData workData = new PaymentPerHour(int.Parse(command[0]), command[1], double.Parse(command[2]), int.Parse(command[3])); 

        necesseryWorkData.Add((PaymentPerHour)workData);

    }
    necesseryWorkData.Sort(); 
    necesseryWorkData.ForEach(x => x.Print()); 

    Console.Write("Enter code: ");
    int code = int.Parse(Console.ReadLine()); 

    //PaymentPerHour searchingByCode = necesseryWorkData.FirstOrDefault(x => code == x.Code);
    //Console.WriteLine(searchingByCode);
    var highestMoneyAvailable = necesseryWorkData.Select(x => x.Payment).Max();
    Console.WriteLine($"Biggest payment for the work: {highestMoneyAvailable}");
}
catch (ArgumentNullException exeption)
{
    Console.WriteLine(exeption.Message);
}

