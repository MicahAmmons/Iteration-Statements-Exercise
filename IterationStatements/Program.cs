using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below

        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Gimme1000ThruNeg1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine($"{i}");

            }
        }

        // oppsite of above 1000 -> -1000
        public static void GimmeNeg1000To1000()
        {
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine($"{i}");

            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool AreTheyTheySameOrNah(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Num3Thru99By3()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine($"{i}");
            }
        }

        //Write a method to check whether a given number is even or odd
        public static string IsThisEvenOrOdd(int num1)
        {
            int leftOver = num1 % 2;
            if (leftOver == 0)
            {
                return "even";
            }
            return "odd";
        }

        //Write a method to check whether a given number is positive or negative
        public static string IsThisPosOrNeg(int num)
        {
            return (num < 0) ? "negative" : "positive";
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        public static string OfVotingAge()
        {
            Console.WriteLine("So you wanna vote, ay?  Alright then, why don't you tell me how old you are?");
            string input = Console.ReadLine(); //I can't figure out how to make the parsing work for this.  I can make it work as is without parsing, but will leave here for
            if (int.TryParse(input, out int num)) // when we go over it in  class to fix
            {
                if (num >= 18)
                {
                    return "You are MOORREEE than welcomed to vote";
                }
                else
                {
                    return "Try again when you're older, pipsqueak";
                }
            }
            else { return "ERROR"; }
        }
    
    

        //Hint: Use Parse or the safer TryParse() for an extra challenge
    //Parse()
    //TryParse()

    //Heatin Up Section:
    //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static string IsItInTheRange(int num1)
        {
           if ((num1 >= -10) && (num1 <= 10))
            {
            return "It is within the range";
            }
        else
           {
            return "NOOOPPPEEE";
           }
        }



    //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultTable(int num)
        {

           for (int i = 1; i <= 12; i++)
            {
                int answer = num * i;
                Console.WriteLine($"{num} * {i} = {answer}");
            }
          
        }


    //Call the methods to test them in the Main method below
    static void Main(string[] args)
        {
            //Gimme1000ThruNeg1000();
            //GimmeNeg1000To1000();
            //Console.WriteLine(AreTheyTheySameOrNah(1, 2));
            //Num3Thru99By3();
            //Console.WriteLine(IsThisEvenOrOdd(6));
            //Console.WriteLine(IsThisEvenOrOdd(7));
            //Console.WriteLine(IsThisPosOrNeg(-1));
            //Console.WriteLine(IsThisPosOrNeg(1));
            OfVotingAge();
            //Console.WriteLine(IsItInTheRange(9));
            //Console.WriteLine(IsItInTheRange(22));
            //MultTable(2);
        }
    }
}
