using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name");

            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name");

            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter your age");

            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your birth month(number value only!)");

            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your favorite ROYGBIV color.If you dont know one,type\"help\" and a list of colors will appear");

            string word = "Help";
            word.ToLower();

            if (word == "help")
            {
                Console.WriteLine("Red, Orange , Yellow , Green , Blue , Indigo , Violet");
            }
            string color = Console.ReadLine();
            color.ToLower();

            Console.WriteLine("Please enter the number of brothers and/or sisters you have");

            int noS = int.Parse(Console.ReadLine());

            string retire;
            if (userAge % 2 == 0)
            {
                retire = "You will retire in 15 years";
            }
            else
            {
                retire = "You will retire in 300 years";
            }
            string vacation;
            if (noS == 0)

                vacation = "You will be in Hawaii";

            else if (noS == 1)

                vacation = "You will be in Panama";

            else if (noS == 2)

                vacation = "You will be in Florida";

            else if (noS == 3)

                vacation = "You will be in Ontario";

            else if (noS > 3)

                vacation = "You will be in Brazil";
            else if (noS < 0)

                vacation = "You will be in Gary Indiana";

            string transportation;

            if (color == "red")

                transportation = "You will drive a LamBo";

            else if (color == "orange")

                transportation = "You will drive a Ferrari";

            else if (color == "yellow")

                transportation = "You will fly a Boeing 747";

            else if (color == "green")

                transportation = "You will pilot a Yacht";

            else if (color == "blue")

                transportation = "You will pilot a Segway";

            else if (color == "indigo")

                transportation = "You will push a Hoopty";

            else if (color == "violet") ;

            transportation = "You will own a Rocket Bike";

            double money;
            if (birthMonth <= 4 && birthMonth >= 1)

                money = 2500.00;

            else if (birthMonth >= 5 && birthMonth <= 8)

                money = 50000.00;

            else if (birthMonth >= 9 && birthMonth <= 12)

                money = 1000000.00;

            else

                money = 0.00;


            Console.WriteLine(firstName + lastName);
            Console.WriteLine();
            Console.WriteLine(retire);
            Console.WriteLine();
            Console.WriteLine(money);
            Console.WriteLine();
            Console.WriteLine(transportation);






        }
    }
}

