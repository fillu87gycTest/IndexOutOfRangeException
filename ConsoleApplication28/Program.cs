using System;

class Program
{
	static void Main()
	{
		var num = new int[4];
		try
		{
			Console.WriteLine("begin");
			num[30] = 30;
			Console.WriteLine("this won't be displayed");
		}
		catch (IndexOutOfRangeException)
		{
			Console.WriteLine("Out of ref");
			//throw;
		}
		Console.WriteLine("After is generated");
	}
}