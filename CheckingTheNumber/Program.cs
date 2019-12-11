using System;


namespace CheckingTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            
            while (true)
            {
                
                try
                {
                    Console.Write("Please enter Number 1 = ");
                    int Number1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter number = {0}", Number1);

                    Console.Write("Please enter Number 2 = ");
                    int Number2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter number = {0}", Number2);

                    Console.Write("Please enter Number 3 = ");
                    int Number3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter number = {0}", Number3);

                    if (Number1 > Number2 && Number1 > Number3)
                    {

                        Console.WriteLine("The largest input number is");
                        Console.WriteLine(Number1);
                        Console.ReadLine();
                        if (Number1 % 2 == 0)
                        {
                            Console.WriteLine("the number is even");
                            Console.ReadLine();

                        }

                        else
                        {
                            Console.WriteLine("the number is`t even");
                            Console.ReadLine();
                        }
                    }

                    else if (Number2 > Number1 && Number2 > Number3)
                    {
                        Console.WriteLine("The largest input number is");
                        Console.WriteLine(Number2);
                        Console.ReadLine();
                        if (Number2 % 2 == 0)
                        {
                            Console.WriteLine("the number is even");
                            Console.ReadLine();
                        }

                        else
                        {
                            Console.WriteLine("the number is`t even");
                            Console.ReadLine();
                        }

                    }

                    else
                    {
                        Console.WriteLine("The largest input number is");
                        Console.WriteLine(Number3);
                        Console.ReadLine();

                        if (Number3 % 2 == 0)
                        {
                            Console.WriteLine("the number is even");
                            Console.ReadLine();
                        }

                        else
                        {
                            Console.WriteLine("the number is`t even");
                            Console.ReadLine();
                        }
                    }

                                   
                }

                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
        }
    }



}
    

