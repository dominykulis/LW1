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
                age.Add(values[2]);

                //Console.WriteLine(values[2]);
                i++;
            }

            //Console.WriteLine(i);
            Console.WriteLine(age[0]);

            for(int g = 0; g < i ; g++)
            {
                int matches=0;
                for(int f = g+1; f < i ; f++)
                {
                    if(age[g] == age[f])
                    {
                        matches++;
                    }
                }
            Console.WriteLine($"There are {matches} ammout of people that were born in {age[g]}");
            }
        }
    }
}