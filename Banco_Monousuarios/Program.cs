using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Monousuarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] Incomes = new int[1000];
            int [] Outcomes = new int[1000];
            int count = 0;
            int count2 = 0;
            int money = 0;
           
            while (true)
            {
                Console.WriteLine("Choose an option");
                Console.WriteLine("1.Money Income");
                Console.WriteLine("2.Money Outcome");
                Console.WriteLine("3.List All Movements");
                Console.WriteLine("4.List Incomes");
                Console.WriteLine("5.List Outcomes");
                Console.WriteLine("6.Show current money");
                Console.WriteLine("7.Exit");

                int x = int.Parse(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        Console.WriteLine("How much do you want to income");
                        int add = int.Parse(Console.ReadLine());
                        money += add;
                        Incomes[count] = add;
                        Console.WriteLine("You incomed "+ add);
                        count++;
                        break;

                    case 2:
                        Console.WriteLine("How much do you want to outcome");
                        int dif = int.Parse(Console.ReadLine());
                        if (money < dif) 
                        {
                            throw new Exception("You dont have that ammount of money");
                        }
                        money -= dif;
                        if(money < 0) 
                        { 
                            money = 0;
                        }
                        Outcomes[count2] = dif;
                        Console.WriteLine("You Outcomed " + dif);
                        count2++;
                        break;
                     
                    case 3:
                        for (int i = 0; i < count2; i++) 
                        { 
                            Console.WriteLine("Money Outcomed " + Outcomes[i]);
                        }
                        for (int i = 0; i < count; i++) 
                        { 
                            Console.WriteLine("Money Incomed " + Incomes[i]);
                        }
                        break;

                    case 4:
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine("Money Incomed " + Incomes[i]);
                        }
                        break;

                    case 5:
                        for (int i = 0; i < count2; i++)
                        {
                            Console.WriteLine("Money Outcomed " + Outcomes[i]);
                        }
                        break;

                    case 6:
                        Console.WriteLine("Current Money " + money);
                        break;

                    case 7:
                        return;

                    default:
                        break;
                }
            }
        }
    }
}
