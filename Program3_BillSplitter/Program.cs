int billAmount = 250;
int numberOfPeople = 4;

int share = billAmount / numberOfPeople;
int remainder = billAmount % numberOfPeople;
double exactShare = (double)billAmount / numberOfPeople;

Console.WriteLine("=== Bill Splitter ===");
Console.WriteLine($"Total Bill: PHP {billAmount}");
Console.WriteLine($"Number of People: {numberOfPeople}");
Console.WriteLine($"Whole Number Share: PHP {share}");
Console.WriteLine($"Remainder: PHP {remainder}");
Console.WriteLine($"Exact Share: PHP {exactShare:F2}");
