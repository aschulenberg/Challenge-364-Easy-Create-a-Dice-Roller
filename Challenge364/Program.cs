using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge364
{
    class Program
    {


        static void Main(string[] args)
        {
            int number_of_dice;
            int number_of_sides;

            string number_of_dice_error = "The number of dice must be between 1-100(XXX)";
            string number_of_sides_error = "The number of sides a dice can have is between 2-100(YYY)";
            string format_error = "Invalid Dice Format XXXdYYY";

            while (true)
            {
                Console.Write("Enter Your dice: ");
                string dice = Console.ReadLine();
                string[] temp = dice.Split('d');
                Console.WriteLine('\n');

                try
                {
                    number_of_dice = Int32.Parse(temp[0]);
                    number_of_sides = Int32.Parse(temp[1]);


                    if (number_of_dice <= 100 && number_of_dice >= 1)
                    {
                        if (number_of_sides <= 100 && number_of_sides >= 2)
                        {
                            int total = 0;
                            List<int> single_roll = new List<int>();
                            single_roll.Clear();
                            string output = "";
                            Random rnd = new Random();
                            for (int i = 0; i < number_of_dice; i++)
                            {
                                single_roll.Add(rnd.Next(1, number_of_sides + 1));
                                output += " " + single_roll.Last().ToString();
                                total += single_roll.Last();

                            }

                            Console.Write(total + ":" + output);
                            Console.WriteLine('\n');

                        }
                        else
                        {
                            Console.WriteLine(number_of_sides_error);
                        }
                    }
                    else
                    {
                        Console.WriteLine(number_of_dice_error);
                    }
                }catch
                {
                    Console.WriteLine(format_error);
                }



            }


        }
    }
}
