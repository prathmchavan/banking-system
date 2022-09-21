using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naman_and_nattu
{
    internal class Program
    {
        private class id1
        {
            int accno = 202201;
            int pass = 1234;
            int bal = 10000;

            static void withdrawal()
            {
                id1 myObj = new id1();
                Console.Write("Enter the amount you want to withdrawal :  ");
                Console.WriteLine("");

                int amt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");


                if (amt > 0 && amt != 0.1)
                {
                    if (amt > myObj.bal)
                    {
                        Console.WriteLine("you have don't have enogh money in your account");
                    }

                    else
                    {


                        Console.WriteLine("wait while we processe your transcation");
                        Console.WriteLine("");

                        int sleepTime = 10000;
                        Task.Delay(sleepTime).Wait();


                        Console.WriteLine("Please collect your cash");
                        Console.WriteLine("");

                        Console.WriteLine("transaction successfull");
                        Console.WriteLine("");

                        Console.WriteLine("summry of transaction :");
                        Console.WriteLine("");

                        Console.WriteLine("Amount withdrawal ->" + amt);

                        myObj.bal -= amt;
                        Console.WriteLine("Remaining Money in your account :" + myObj.bal);
                        Console.WriteLine("");


                    }
                }

                else
                {
                    Console.WriteLine("You entered invalid input :");
                }

            }

            static void deposite()
            {
                Console.Write("Entert the amount you want to deposit : ");
                // Console.WriteLine("");

                int dep = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (dep > 0)
                {
                    Console.WriteLine("wait while we process your transaction");
                    Console.WriteLine("");

                    int sleeptime = 5000;
                    Task.Delay(sleeptime).Wait();

                    Console.Write("Please place your cash in deposit pocket after placing cash in it press 'Y' for continue : ");


                    char y = Convert.ToChar(Console.ReadLine());
                    if (y == 'Y')
                    {
                        id1 myObj = new id1();

                        Console.WriteLine("");

                        Console.WriteLine("Wait while we process your transcation");
                        Console.WriteLine("");


                        int sleeptime1 = 5000;
                        Task.Delay(sleeptime1).Wait();

                        Console.WriteLine("your cash successfully deposited");
                        Console.WriteLine("");


                        Console.WriteLine("summry of transaction : ");
                        Console.WriteLine("");

                        Console.WriteLine("Amount deposited -> " + dep);

                        myObj.bal += dep;
                        Console.WriteLine("Balance in your account :" + myObj.bal);
                        Console.WriteLine("");




                    }
                    else
                    {
                        Console.WriteLine("You entered invalid input please collect your cash from deposit pocket and try again to deposit your money");

                    }






                }
                else
                {
                    Console.WriteLine("You entered invalid input ");

                }
            }







            static void Main(string[] args)
            {

                Console.WriteLine("welcome sir/mam,\n\n\t 1)lgin to your account \n\n\t 2)if you don't have account please create one");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        int A;





                        Console.WriteLine("\n\tplease enter your 6 digit Account number\n");
                        int acc = Convert.ToInt32(Console.ReadLine());
                        id1 myObj = new id1();


                        if (acc == myObj.accno)
                        {

                          
                            Console.WriteLine("\n\tplease enter your 4 digit pin \n");
                            int pin = Convert.ToInt32(Console.ReadLine());

                            if (pin == myObj.pass)
                            {
                                do
                                {



                                    Console.WriteLine("\n\tpress 1 for withdrawal :");
                                    Console.WriteLine("");

                                    Console.WriteLine("\n\tpress 2 for deposit : ");
                                    Console.WriteLine("");





                                    int a = Convert.ToInt32(Console.ReadLine());

                                    switch (a)
                                    {
                                        case 1:

                                            withdrawal();

                                            break;

                                        case 2:

                                            deposite();

                                            break;



                                    }
                                    Console.WriteLine("");
                                    Console.WriteLine("press 0 to run again the menu");
                                    A = Convert.ToInt32(Console.ReadLine());


                                } while (A == 0);
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("You have entered worng Pin \n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You have entered wrong Account no");
                        }

                        break;



                    case 2:



                        break;





                }
























            }
        }
    }
}
