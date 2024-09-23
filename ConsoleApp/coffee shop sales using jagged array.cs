Console.WriteLine("\t\t\t\tCoffee Shop");
Console.WriteLine("\t\t\t\t**************");
int[][] sales = new int[4][];
int total = 0;

for (int i = 0; i < 4; i++) {
    sales[i] = new int[5];
    Console.WriteLine($"Enter the Week {i+1}");
    Console.WriteLine("Enter the sales of coffee:");
    sales[i][0] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the sales of Tea:");
    sales[i][1] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the sales of dessert:");
    sales[i][2] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the sales of juice:");
    sales[i][3] = Convert.ToInt32(Console.ReadLine());
    sales[i][4] = sales[i][0] + sales[i][1] + sales[i][2] + sales[i][3];
    total += sales[i][4];
}
Console.WriteLine();

for (int i = 0; i < sales.Length; i++) {
    Console.WriteLine($"Sales of week {i+1}");
    Console.WriteLine("*************************");
    Console.WriteLine($"Coffee sales: {sales[i][0]}");
    Console.WriteLine($"Tea sales: {sales[i][1]}");
    Console.WriteLine($"Dessert sales: {sales[i][2]}");
    Console.WriteLine($"juice sales: {sales[i][3]}");
    Console.WriteLine($"Total sales of week {i}: {sales[i][4]}",i+1);
    Console.WriteLine();
    
}
Console.WriteLine($"Total sales of month {total}");