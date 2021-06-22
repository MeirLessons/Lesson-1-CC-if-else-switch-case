using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_1_if_else__switch_case_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Check If Number Is Prime

            Console.WriteLine("Please Enter Number:");
            int number = int.Parse(Console.ReadLine());//11

            int divByNum = number;
            while (number % divByNum != 0)
            {
                divByNum++;
            }

            //After Loop
            if (divByNum == number)
            {
                Console.WriteLine("Is Prime");
            }
            else
            {
                Console.WriteLine("Try Another Number");
            }

            #endregion

            #region Etgar If-Else

            Console.WriteLine("Please Enter a Number:");
            int number1 = int.Parse(Console.ReadLine());

            int counter = 2;
            int result = 1;
            while (counter <= number1)
            {
                result *= counter;
                counter++;
            }
            Console.WriteLine(result);



            #endregion

            #region switch-case Light

            int currentStatus = 0;
            while (true)
            {
                Console.WriteLine("Please Enter The New Status:");
                int newStatus = int.Parse(Console.ReadLine());
                switch (newStatus)
                {
                    case -1:
                        switch (currentStatus)
                        {
                            case -1:
                                Console.WriteLine("The Light Already Broken");
                                break;
                            default:
                                Console.WriteLine("NOW, The Light IS Broken");
                                currentStatus = newStatus;
                                break;
                        }
                        break;
                    case 0:
                        if (currentStatus == -1)
                            Console.WriteLine("The Light IS Broken");
                        else
                        {
                            Console.WriteLine("NOW, The Light IS OFF");
                            currentStatus = newStatus;
                        }
                        break;
                    case 1:
                        if (currentStatus == -1)
                            Console.WriteLine("The Light IS Broken");
                        else
                        {
                            Console.WriteLine("NOW, The Light IS ON");
                            currentStatus = newStatus;
                        }
                        break;
                    default:
                        Console.WriteLine("NOW, The Light IS OK");
                        currentStatus = newStatus;
                        break;
                }

                if (newStatus == 10)
                    break;
            }

            #endregion
        }
    }
}
