using System;
public class Average
{
	public static void Main()
	{
		double totalGrades = 0, grade, counter = 0, averageGrades;
		string end;

		Console.Write("Insert a mark: ");
		end=Console.ReadLine();

		while(end != "end")
		{
			grade=Convert.ToDouble(end);
			counter++;
			totalGrades += grade;
			Console.Write("Insert a mark: ");
			end = Console.ReadLine();
		}
		if (counter != 0) 
		{
			averageGrades = totalGrades / counter;
			Console.WriteLine("The average is {0}.", averageGrades);
		}
	}
}
