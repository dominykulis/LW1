using System;

using System.IO;
internal class TextFieldParser
{
    static void Main(string[] args)
    {
        using(var reader = new StreamReader(@".\data.csv"))
        {
            int i=0;
            List<string> age = new List<string>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                    
                if (i>0)
                {
                    age.Add(values[2]);
                }
                i++;
            }

            for(int f=1900; f < 2023; f++)
            {
                int matches = 0;

                foreach(string date in age)
                {
                    int date_int = Convert.ToInt32(date);

                    if(date_int == f)
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