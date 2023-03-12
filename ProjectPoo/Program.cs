using ProjectPoo;

Console.WriteLine("Primer Poo!");
try
{
	Console.WriteLine(new Date(2021, 9, 29));
	Console.WriteLine(new Date(2022, 5, 13));
	Console.WriteLine(new Date(2024, 2, 29));
}
catch (Exception error)
{
	Console.WriteLine(error.Message);
	
}