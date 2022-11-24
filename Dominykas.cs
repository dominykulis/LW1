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
                age.Add(values[4]);
                i++;

            }
                   foreach(string date in age)
{
    int matches=0;
    for(int f=0; f < i ; f++)
    {
        if(date == age[f])
        {
            matches++;
        }
    }
    Console.WriteLine($"There are {matches} ammout of people that were born in {date}");
}



        }
            


    }
       


}
  



            
