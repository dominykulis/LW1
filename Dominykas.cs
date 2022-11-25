using System;

using System.IO;
internal class TextFieldParser
{
    static void Main(string[] args)
    {
        using(var reader = new StreamReader(@".\data.csv"))
        {
            int amount_people=0;
            List<string> age = new List<string>();

            int num_males=0;
            int num_females=0;
            
            // reading file until the end storing the date value into a list and counting the number of dates
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                    
                var gender = values[3].Split('"');
                

                if(gender[1].StartsWith('M'))
                {
                    num_females++;
                }
                if(gender[1].StartsWith('V'))
                {
                    num_males++;
                }


                if (amount_people>0)
                {
                    age.Add(values[2]);
                }
                amount_people++;
            }

            // testing each date from 1900 to 2023 to find matches of a certain year
            for(int test_date=1900; test_date < 2023; test_date++)
            {
                int matches = 0;

                foreach(string date in age)
                {
                    int date_int = Convert.ToInt32(date);

                    if(date_int == test_date)
                    {
                        matches++;
                    }
                }

                if(matches > 0)
                {
                    Console.WriteLine($"There are {matches} people that were born in {test_date}");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"There are {num_males} males and {num_females} females in this list");
        }
    }
}