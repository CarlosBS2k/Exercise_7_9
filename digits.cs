using System;

class digits
{
    static void Main()
    {
        int oneDigitCounter = 0, twoDigitCounter = 0, threeDigitCounter = 0, nDigitCounter = 0;
        Console.Write("Insert a number: ");
        string end = Console.ReadLine();
        int input = Convert.ToInt32(end);
        while(end != "end")
        {
                if(input != 0)
                    if(input/10 == 0)
                        oneDigitCounter ++;  
                else 
                    if (input/100 == 0)
	                    twoDigitCounter ++; 
                    else 
                        if (input/1000 == 0)
                            threeDigitCounter ++;  
                        else
                            nDigitCounter++;  
            end = Console.ReadLine();
            input = Convert.ToInt32(end);
            Console.WriteLine("one: {0} two: {1} three: {2} more: {3}",
                               oneDigitCounter, twoDigitCounter, threeDigitCounter, nDigitCounter); 
        }
    }



