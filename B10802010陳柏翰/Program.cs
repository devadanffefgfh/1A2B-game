using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10802010陳柏翰
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4];
            
            
            
            
           
            Console.WriteLine("1A2B數字遊戲");
            
            Random rand = new Random();
            numbers[0] = rand.Next(0,10);
           
            numbers[1] = rand.Next(0, 10);
            while(numbers[0] == numbers[1])
            {
                numbers[1] = rand.Next(0, 10);
            }
            
            numbers[2] = rand.Next(0, 10);
            while (numbers[0] == numbers[2] || numbers[1] == numbers[2])
            {
                numbers[2] = rand.Next(0, 10);
            }
            
            numbers[3] = rand.Next(0, 10);
            while (numbers[0] == numbers[3] || numbers[1] == numbers[3] || numbers[2] == numbers[3])
            {
                numbers[3] = rand.Next(0, 10);
            }

            foreach (int i in numbers)
            {
                Console.Write($"{i} ");
            }
            
            
            bool play = true;
            int b = 0;
            int a = 0;
            while(play==true)
            {
                Console.Write("請輸入4個數字:");
                string player_numbers = Console.ReadLine();



                if (player_numbers.Contains(numbers[0].ToString())==true&& Int32.Parse(player_numbers[0].ToString()) != numbers[0])
                {
                    b++;
                    
                }
                if (player_numbers.Contains(numbers[1].ToString()) == true && Int32.Parse(player_numbers[1].ToString()) != numbers[1])
                {
                    b++;
                }
                if (player_numbers.Contains(numbers[2].ToString()) == true && Int32.Parse(player_numbers[2].ToString()) != numbers[2])
                {
                    b++;
                }
                if (player_numbers.Contains(numbers[3].ToString()) == true && Int32.Parse(player_numbers[3].ToString()) != numbers[3])
                {
                    b++;
                }

                if (player_numbers.Contains(numbers[0].ToString()) == true && Int32.Parse(player_numbers[0].ToString()) == numbers[0])
                {
                    a++;

                }
                if (player_numbers.Contains(numbers[1].ToString()) == true && Int32.Parse(player_numbers[1].ToString()) == numbers[1])
                {
                    a++;
                }
                if (player_numbers.Contains(numbers[2].ToString()) == true && Int32.Parse(player_numbers[2].ToString()) == numbers[2])
                {
                    a++;
                }
                if (player_numbers.Contains(numbers[3].ToString()) == true && Int32.Parse(player_numbers[3].ToString()) == numbers[3])
                {
                    a++;
                }
                Console.WriteLine($"{a}A{b}B");
                if (a==4&&b==0)
                {
                    Console.WriteLine($"你猜對了，遊戲結束");
                    play = false;
                }
                a = 0;
                b = 0;
            }            
            Console.ReadKey();
        }
    }
}
