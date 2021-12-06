using System;

namespace övning_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1;
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Navigate by typing a number from the list below:");
                Console.WriteLine("\n");
                Console.WriteLine("1: Check if age discount is applicable");
                Console.WriteLine("2: Repeat ten times");
                Console.WriteLine("3: The third word");
                Console.WriteLine("4: Add tickets and calculate sum");
                Console.WriteLine("0: Quit");
                input = int.Parse(Console.ReadLine());
                
                switch (input)
                {
                    case 1:
                        int age;
                        Console.WriteLine("Type age");
                        

                        try
                        {
                            age = int.Parse(Console.ReadLine());

                            if (age < 20)
                            {
                                Console.WriteLine("Discount for youth: 80 kr");
                            }
                            if(age > 64)
                            {
                                Console.WriteLine("Discount for elders: 90 kr");
                            }
                            else
                            {
                                Console.WriteLine("No discount, standard price: 120 kr");
                            }
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine("Wrong input");
                        }

                        break;
                    case 2:
                        Console.WriteLine("Type a sentence");
                        var sentence = Console.ReadLine();
                        int number = 1;
                        for (int i = 0; i < 11;  i++)
                        {
                            
                            Console.Write(number + "." + sentence + " ");
                            number++;
                        }

                        break;
                    case 3:
                        Console.WriteLine("Type a sentence consisting of at least three words");
                        var phrase = Console.ReadLine();
                        string[] words = phrase.Split(" ");
                        Console.WriteLine("The third word is: " + words[2]);

                        break;

                    case 4:
                        Console.WriteLine("How many tickets?");
                        int arraysize = int.Parse(Console.ReadLine());

                        int[] tickets = new int[arraysize];

                   
                        int sum = 0;
                        for (int i = arraysize; i > 0; i--)                      
                        {
                            Console.WriteLine("Age?");
                           int age_ticket = int.Parse(Console.ReadLine());
                            
                            if (age_ticket < 20)
                            {
                                sum += 80; 
                                
                            }
                            else if (age_ticket > 64)
                            {
                                sum += 90;
                            }
                            else
                            {
                                sum += 120;
                            }
                        }

                        Console.WriteLine("The total sum is: " + sum);

                       
                        break;
                    case 0:
                        
                        break;

                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }

            } while (input != 0);

        }

       


    }
}
