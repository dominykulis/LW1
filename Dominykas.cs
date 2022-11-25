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
            
            // reading file until the end storing the date value into a list and counting the number of dates
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                    
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
                    Console.WriteLine($"There are {matches} people that were born in {f}");
                }

            }

        }
    }
}