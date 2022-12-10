// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;

class MainClass
{
    private static int ArrayChallenge(int num)
    {
        var numberString = num.ToString();
        var counter = 1;
        var result = "";
        var numberToCompareWith = numberString[0];

        for (var i = 1; i < numberString.Length; i++)
        {
            //compare char digit with number 
                if (numberToCompareWith ==numberString[i])
                {
                    counter++;
                }
                else
                {
                    result += counter;
                     result +=numberToCompareWith;
                    counter = 1;
                    numberToCompareWith = numberString[i];
                }
        }
        result += counter;
        result +=numberToCompareWith;

        return Convert.ToInt32(result);
    }

  

    static void Main()
    {
        

        

    
         Console.WriteLine(ArrayChallenge(1121));
    }
}